using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.Win32;

namespace ITechnologyNET.FindUnusedFiles
{
    public partial class FormMain : Form
    {
        #region VSPackage Specific
        /// <summary>
        /// If set, then we are in VS environement
        /// </summary>
        IEnumerable<ProjectItem> ProjectItems { get; set; }
        DTE Dte { get; set; }

        public bool IsPackage { get; set; }
        #endregion

        #region Declarations
        string DirectoryPath { get; set; }
        List<string> AllFiles    { get; set; }
        //List<string> UsedFiles   { get; set; }
        List<string> UnUsedFiles { get; set; }
        ConcurrentDictionary<string, List<string>> UsedFiles { get; set; }
        PictureBox PictureBox { get; set; }


        const string PathLabel    = "Path: {0}";
        const string FilesLabel   = "Total Files: {0}";
        const string ToParseLabel = "To Parse: {0}";
        const string ToMatchLabel = "To Match: {0}";
        const string ParsedLabel  = "Parsed: {0}";
        const string UsedLabel    = "Used: {0}";
        const string UnusedLabel  = "Unused: {0}";

        static bool IsRegexPatternValid(string pattern)
        {
            try
            {
                var r = new Regex(pattern);
            }
            catch
            {
                return false;
            }

            return true;
        }
        #endregion

        #region Init

        /// <summary>
        /// Small helper to make sure args are never empty, null, or out of range
        /// </summary>
        /// <param name="args"></param>
        /// <param name="position"></param>
        /// <returns>string</returns>
        string GetArg(IList<string> args, int position)
        {
            if (args.Count > position)
            {
                if (!string.IsNullOrEmpty(args[position]))
                {
                    return args[position].Trim();
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Used when called upon from inisde VS package
        /// </summary>
        public FormMain(DTE dte, IEnumerable<ProjectItem> projectItems, string directoryPath)
        {
            InitializeComponent();

            Dte            = dte;
            ProjectItems   = projectItems;
            DirectoryPath  = directoryPath;
            IsPackage      = true;
            btnBrowse.Text = @"Search";

            // BUG: if cast to string missing, thinks we are dealing with a List<dynamic>
            AllFiles = ProjectItems.Select(c => (string)c.Properties.Item("FullPath").Value.ToString()).ToList();

            // dont show register shell extension
            registerShellToolStripMenuItem.Visible = false;
            toolStripSeparatorShell.Visible        = false;

            // dont show update check
            toolStripSeparatorUpdate.Visible     = false;
            checkUpdateToolStripMenuItem.Visible = false;

            InitializeFormElements();
            ProcessFiles();
        }

        /// <summary>
        /// Used when called upon from normal .exe program
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            registerShellToolStripMenuItem.Checked = Registry.ClassesRoot.OpenSubKey("Directory\\shell\\FindUnusedFiles") != null;

            InitializeFormElements();

            #region Command Line
            // Launch from command line for integration with external tools
            string[] args = Environment.GetCommandLineArgs();

            var path   = string.Empty;
            var find   = string.Empty;
            var inside = string.Empty;
            var report = string.Empty;
            var shell  = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    // path: -p "path"
                    case "-p":
                        path = Regex.Replace(GetArg(args, i + 1), "\"$", "");
                        break;

                    // find: -f "\.*"
                    case "-f":
                        find = GetArg(args, i + 1);
                        break;

                    // inside: -i "\.*"
                    case "-i":
                        inside = GetArg(args, i + 1);
                        break;

                    // report: -r 0|1
                    case "-r":
                        report = GetArg(args, i + 1);
                        break;

                    // shell: -s t
                    case "-s":
                        shell = GetArg(args, i + 1);
                        break;
                }
            }

            if (shell == "t")
            {
                RegisterShell();
                return;
            }

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            if (report == "1")
            {
                radioUsed.Checked = true;
            }

            if (!string.IsNullOrEmpty(find))
            {
                if (IsRegexPatternValid(find))
                {
                    patternFind.Text = find;
                }
            }

            if (!string.IsNullOrEmpty(inside))
            {
                if (IsRegexPatternValid(inside))
                {
                    patternSearch.Text = inside;
                }
            }

            // TODO: preset form choices depending on args passed
            // In case we pass a file path and not a directory path to the command line
            if (File.Exists(path))
            {
                GetPath(Path.GetDirectoryName(path));
            }
            else if (Directory.Exists(path))
            {
                GetPath(path);
            }
            #endregion
        }
        #endregion

        #region Form Actions
        // gets selected items from currently active result list
        List<string> GetSelectedItems()
        {
            if (tabControlMain.SelectedTab == tabPageNormal)
            {
                return listResult.SelectedItems
                                 .Cast<string>()
                                 .ToList();
            }

            if (tabControlMain.SelectedTab == tabPageTreeView)
            {
                return new List<string>() { treeResult.SelectedNode.Text };
            }

            return new List<string>();
        }

        string GetSelecteItemText()
        {
            if (tabControlMain.SelectedTab == tabPageNormal)
            {
                return listResult.SelectedItem.ToString();
            }

            if (tabControlMain.SelectedTab == tabPageTreeView)
            {
                return treeResult.SelectedNode.Text;
            }

            return null;
        }

        int GetSelectedItemCount()
        {
            if (tabControlMain.SelectedTab == tabPageNormal)
            {
                return listResult.SelectedItems.Count;
            }

            if (tabControlMain.SelectedTab == tabPageTreeView)
            {
                return treeResult.Nodes.Count > 0 ? 1 : 0;
            }

            return 0;
        }

        void Find(string pattern, vsFindTarget target)
        {
            if (Dte == null)
            {
                return;
            }

            Dte.Find.Target            = target;
            Dte.Find.PatternSyntax     = vsFindPatternSyntax.vsFindPatternSyntaxRegExpr;
            Dte.Find.Action            = vsFindAction.vsFindActionFindAll;
            Dte.Find.ResultsLocation   = vsFindResultsLocation.vsFindResults1;

            Dte.Find.FindWhat          = pattern;
            Dte.Find.MatchCase         = false;
            Dte.Find.MatchWholeWord    = false;
            Dte.Find.MatchInHiddenText = true;
            Dte.Find.SearchSubfolders  = true;
            Dte.Find.FilesOfType       = "*.*";

            Dte.ExecuteCommand("View.FindResults1");
            Dte.Find.Execute();
        }

        void InitializeFormElements()
        {
            listResult.DoubleClick += ListResultDoubleClick;
            treeResult.DoubleClick += ListResultDoubleClick;

            #region Restore Settings
            // Bind AutoComplete TextBoxes
            // http://stackoverflow.com/a/4267845
            SetAutoCompleteSource(patternFind, "Find");
            SetAutoCompleteSource(patternSearch, "Search");

            // Excluded Files ListBox
            listBoxExclude.Items.AddRange(Properties.Settings.Default.Exclude.Cast<object>().ToArray());

            // Excusion Active CheckBox
            checkBoxExclude.Checked = Properties.Settings.Default.ExcludeChecked;
            listBoxExclude.Enabled  = checkBoxExclude.Checked;

            // Image Preview CheckBox
            checkBoxImages.Checked = Properties.Settings.Default.ImagePreviewChecked;
            #endregion

            // The context menu
            #region Picture Preview
            PictureBox = new PictureBox(300, 300);

            // listResult
            listResult.SelectedIndexChanged += (s, o) =>
            {
                if ((checkBoxImages.Checked || ModifierKeys == Keys.Alt) && GetSelectedItemCount() == 1)
                {
                    PictureBox.Location = new Point(Right, Top);
                    PictureBox.DisplayImage(DirectoryPath + GetSelecteItemText());
                }
            };

            // treeResult
            treeResult.AfterSelect += (s, o) =>
            {
                if ((checkBoxImages.Checked || ModifierKeys == Keys.Alt))
                {
                    PictureBox.Location = new Point(Right, Top);
                    PictureBox.DisplayImage(DirectoryPath + GetSelecteItemText());
                }
            };
            #endregion

            var ctxMenu = new ContextMenuStrip();

            #region Launch External
            // Select ALL entry
            var mnuLaunch = new ToolStripMenuItem("Launch External")
            {
                Image = new Bitmap(Properties.Resources.@launch)
            };
            mnuLaunch.Click += LaunchExternal;
            ctxMenu.Items.Add(mnuLaunch);
            #endregion

            ctxMenu.Items.Add(new ToolStripSeparator());

            #region SelectAll
            // Select ALL entry
            var mnuSelect = new ToolStripMenuItem("Select All")
            {
                Image = new Bitmap(Properties.Resources.@select)
            };
            mnuSelect.Click += (sender, args) =>
            {
                for (int i = 0; i < listResult.Items.Count; i++)
                {
                    listResult.SetSelected(i, true);
                }
            };
            ctxMenu.Items.Add(mnuSelect);
            #endregion

            #region Invert Selection
            // Select ALL entry
            var mnuInvert = new ToolStripMenuItem("Select Other")
            {
                Image = new Bitmap(Properties.Resources.invert)
            };
            mnuInvert.Click += (sender, args) =>
            {
                for (int i = 0; i < listResult.Items.Count; i++)
                {
                    listResult.SetSelected(i, !listResult.SelectedIndices.Contains(i));
                }
            };
            ctxMenu.Items.Add(mnuInvert);
            #endregion

            #region treeViewResult Specific
            // Expand node
            var mnuExpandAll = new ToolStripMenuItem("Expand")
            {
                Image = new Bitmap(Properties.Resources.expand)
            };
            mnuExpandAll.Click += (s, o) =>
            {
                treeResult.SelectedNode.ExpandAll();
            };
            ctxMenu.Items.Add(mnuExpandAll);

            var mnuCollapseAll = new ToolStripMenuItem("Collapse")
            {
                Image = new Bitmap(Properties.Resources.collapse)
            };
            mnuCollapseAll.Click += (s, o) =>
            {
                treeResult.SelectedNode.Collapse(false);
            };
            ctxMenu.Items.Add(mnuCollapseAll);
            #endregion

            ctxMenu.Items.Add(new ToolStripSeparator());

            #region Export
            // Export entry
            var mnuExport = new ToolStripMenuItem("Export Selection")
            {
                Image = new Bitmap(Properties.Resources.save)
            };
            mnuExport.Click += ExportFiles;

            ctxMenu.Items.Add(mnuExport);
            #endregion

            #region Delete
            // Delete entry
            var mnuDelete = new ToolStripMenuItem("Delete Selection")
            {
                Image = new Bitmap(Properties.Resources.delete)
            };
            mnuDelete.Click += DeleteFiles;
            ctxMenu.Items.Add(mnuDelete);
            #endregion

            ctxMenu.Items.Add(new ToolStripSeparator());

            #region Explore
            // Explore entry
            var mnuExplore = new ToolStripMenuItem("Explore Here")
            {
                Image = new Bitmap(Properties.Resources.explore)
            };
            mnuExplore.Click += ExploreHere;

            ctxMenu.Items.Add(mnuExplore);
            #endregion

            #region Open Tests
            // Tests to hide context menu items
            ctxMenu.Opening += (s, o) =>
            {
                var selectedItemsCount = GetSelectedItemCount();

                mnuLaunch.Enabled      = (selectedItemsCount == 1);
                mnuSelect.Enabled      = (selectedItemsCount > 0);
                mnuSelect.Visible      = (tabControlMain.SelectedTab == tabPageNormal);
                mnuInvert.Enabled      = (selectedItemsCount > 0);
                mnuInvert.Visible      = (tabControlMain.SelectedTab == tabPageNormal);
                mnuExplore.Enabled     = (selectedItemsCount == 1);
                mnuCollapseAll.Enabled = (selectedItemsCount > 0);
                mnuCollapseAll.Visible = (tabControlMain.SelectedTab == tabPageTreeView);
                mnuExpandAll.Enabled   = (selectedItemsCount > 0);
                mnuExpandAll.Visible   = (tabControlMain.SelectedTab == tabPageTreeView);

                if (selectedItemsCount == 0)
                {
                    mnuExport.Enabled = false;
                    mnuDelete.Enabled = false;
                }
                else
                {
                    mnuExport.Enabled = true;
                    mnuDelete.Enabled = true;
                }
            };
            #endregion

            #region Package
            if (IsPackage)
            {
                // Main entry
                var mnuFind = new ToolStripMenuItem("Verify Selection")
                {
                    Image = new Bitmap(Properties.Resources.search)
                };

                ctxMenu.Opening += (s, o) =>
                {
                    if (GetSelectedItemCount() == 0)
                    {
                        mnuFind.Enabled = false;
                    }
                    else
                    {
                        mnuFind.Enabled = true;
                    }
                };

                // Search submenu: Project
                var mnuSearchProject = new ToolStripMenuItem("Exists In Project")
                {
                    Image = new Bitmap(Properties.Resources.project)
                };
                mnuSearchProject.Click += (s, o) =>
                {
                    var pattern  = string.Empty;
                    GetSelectedItems()
                        .ForEach(i =>
                    {
                            var name = Path.GetFileName(i);
                        if (!string.IsNullOrEmpty(name))
                        {
                            pattern += string.Format("{0}|", Regex.Escape(name));
                        }
                        });

                    Find(string.Format("({0})", pattern.Substring(0, pattern.Length - 1)), vsFindTarget.vsFindTargetCurrentProject);
                };

                // Search submenu: Solution
                var mnuSearchSolution = new ToolStripMenuItem("Exists In Solution")
                {
                    Image = new Bitmap(Properties.Resources.solution)
                };
                mnuSearchSolution.Click += (s, o) =>
                {
                    var pattern  = string.Empty;
                    GetSelectedItems()
                        .ForEach(i =>
                        {
                            var name = Path.GetFileName(i);
                            if (!string.IsNullOrEmpty(name))
                            {
                                pattern += string.Format("{0}|", Regex.Escape(name));
                            }
                        });

                    Find(string.Format("({0})", pattern.Substring(0, pattern.Length - 1)), vsFindTarget.vsFindTargetSolution);
                };

                // Add all items
                mnuFind.DropDownItems.Add(mnuSearchProject);
                mnuFind.DropDownItems.Add(mnuSearchSolution);

                ctxMenu.Items.Add(mnuFind);
            }
            #endregion

            listResult.ContextMenuStrip = ctxMenu;
            treeResult.ContextMenuStrip = ctxMenu;

            #region Find/Search TextBoxes
            var ctxTexboxMenu = new ContextMenuStrip();

            var mnuTextBoxDelete = new ToolStripMenuItem("Delete")
            {
                Image = new Bitmap(Properties.Resources.delete)
            };
            mnuTextBoxDelete.Click += (sender, args) =>
            {
                var mnuItem  = (ToolStripMenuItem)sender;
                var mnuStrip = (ContextMenuStrip)mnuItem.Owner;
                var txtBox   = (TextBox) mnuStrip.SourceControl;

                switch (txtBox.Name)
                {
                    case "patternSearch":
                        RemoveFromAutoCompleteSource(txtBox, "Search");
                        break;

                    case "patternFind":
                        RemoveFromAutoCompleteSource(txtBox, "Find");
                        break;
                }
            };
            ctxTexboxMenu.Items.Add(mnuTextBoxDelete);

            patternFind.ContextMenuStrip   = ctxTexboxMenu;
            patternSearch.ContextMenuStrip = ctxTexboxMenu;
            #endregion

            #region Options Panel
            var ctxExcludeMenu   = new ContextMenuStrip();
            var mnuExcludeDelete = new ToolStripMenuItem("Delete")
            {
                Image = new Bitmap(Properties.Resources.delete)
            };
            mnuExcludeDelete.Click += (sender, args) =>
            {
                var item = listBoxExclude.SelectedItem;
                if (item != null)
                {
                    Properties.Settings.Default.Exclude.Remove(item.ToString());
                    Properties.Settings.Default.Save();

                    listBoxExclude.Items.Remove(item);
                }
            };

            ctxExcludeMenu.Items.Add(mnuExcludeDelete);
            listBoxExclude.ContextMenuStrip = ctxExcludeMenu;
            #endregion
        }

        void BrowseClick(object sender, EventArgs e)
        {
            // in package mode, we replaced the directory button with a start button
            if (IsPackage)
            {
                ProcessFiles();
            }
            else
            {
                GetPath();
            }
        }

        void RadioCheckedChanged(object sender, EventArgs e)
        {
            ListFiles();
        }

        void ListFiles()
        {
            if (radioUnused.Checked)
            {
                BuildUnusedFilesFlat();
                BuildUnusedFilesTree();
            }
            else
            {
                BuildUsedFilesFlat();
                BuildUsedFilesTree();
            }
        }

        void BuildUnusedFilesFlat()
        {
            listResult.Items.Clear();

            lblUnused.Enabled = true;
            lblUsed.Enabled   = false;

            lblUsed.Text = string.Format(UsedLabel, UsedFiles == null ? "0000" : UsedFiles.Count.ToString("D4"));

            if (UnUsedFiles == null || UnUsedFiles.Count == 0)
            {
                lblUnused.Text = string.Format(UnusedLabel, 0);
                return;
            }

            lblUnused.Text = string.Format(UnusedLabel, UnUsedFiles.Count.ToString("D4"));

            UnUsedFiles
                .Where(c => !string.IsNullOrEmpty(c))
                .OrderBy(c => c)
                .ToList()
                .ForEach(i => listResult.Items.Add(i.Replace(DirectoryPath, string.Empty)));
        }

        void BuildUsedFilesFlat()
        {
            listResult.Items.Clear();

            lblUnused.Enabled = false;
            lblUsed.Enabled   = true;

            lblUnused.Text = string.Format(UnusedLabel, UnUsedFiles == null ? "0000" : UnUsedFiles.Count.ToString("D4"));

            if (UsedFiles == null || UsedFiles.Count == 0)
            {
                lblUsed.Text = string.Format(UsedLabel, 0);
                return;
            }

            lblUsed.Text = string.Format(UsedLabel, UsedFiles.Count.ToString("D4"));

            UsedFiles
                .Select(c => c.Key)
                .Where(c => !string.IsNullOrEmpty(c))
                .OrderBy(c => c)
                .ToList()
                .ForEach(i => listResult.Items.Add(i.Replace(DirectoryPath, string.Empty)));
        }

        void BuildUsedFilesTree()
        {
            treeResult.Nodes.Clear();

            lblUnused.Enabled = false;
            lblUsed.Enabled   = true;

            lblUnused.Text = string.Format(UnusedLabel, UnUsedFiles == null ? "0000" : UnUsedFiles.Count.ToString("D4"));

            if (UsedFiles == null || UsedFiles.Count == 0)
            {
                lblUsed.Text = string.Format(UsedLabel, 0);
                return;
            }

            lblUsed.Text = string.Format(UsedLabel, UsedFiles.Count.ToString("D4"));

            treeResult.BeginUpdate();

            var directoryNode = treeResult.Nodes.Add(DirectoryPath);
            var ordered = UsedFiles.OrderBy(parent => parent.Key).ThenBy(c => c.Value.OrderBy(d => d)).ToList();
            foreach (var item in ordered)
            {
                var parentNode = new TreeNode(item.Key.Replace(DirectoryPath, string.Empty));
                parentNode.ToolTipText = string.Format("Referenced in ({0}) file(s)", item.Value.Count);
                if (item.Value.Count > 0)
                {
                    foreach (var child in item.Value)
                    {
                        var childNode = new TreeNode(child.Replace(DirectoryPath, string.Empty));
                        parentNode.Nodes.Add(childNode);

                    }
                }

                directoryNode.Nodes.Add(parentNode);
                directoryNode.Expand();
            }

            treeResult.EndUpdate();
        }

        void BuildUnusedFilesTree()
        {
            treeResult.Nodes.Clear();

            lblUnused.Enabled = true;
            lblUsed.Enabled   = false;

            lblUsed.Text = string.Format(UsedLabel, UsedFiles == null ? "0000" : UsedFiles.Count.ToString("D4"));

            if (UnUsedFiles == null || UnUsedFiles.Count == 0)
            {
                lblUnused.Text = string.Format(UnusedLabel, 0);
                return;
            }

            lblUnused.Text = string.Format(UnusedLabel, UnUsedFiles.Count.ToString("D4"));

            treeResult.BeginUpdate();

            var directoryNode = treeResult.Nodes.Add(DirectoryPath);
            UnUsedFiles
                .Where(c => !string.IsNullOrEmpty(c))
                .OrderBy(c => c)
                .ToList()
                .ForEach(i =>
                {
                    var parentNode = new TreeNode(i.Replace(DirectoryPath, string.Empty));

                    directoryNode.Nodes.Add(parentNode);
                    directoryNode.Expand();
                });

            treeResult.EndUpdate();
        }

        void ViewInProjectExplorer(object sender, EventArgs e)
        {
            if (IsPackage)
            {
                if (GetSelecteItemText() != null)
                {
                    var fullPath = DirectoryPath + GetSelecteItemText();
                    var item     = ProjectItems.FirstOrDefault(c => c.Properties.Item("FullPath").Value.ToString() == fullPath);
                    if (item != null)
                    {
                        var w     = item.Open();
                        w.Visible = true;

                        // Not using constant here because EXE does not have right reference to DTE
                        Dte.Windows.Item("{3AE79031-E1BC-11D0-8F78-00A0C9110057}").Activate();
                        Dte.ExecuteCommand("SolutionExplorer.SyncWithActiveDocument");
                    }
                }
            }
        }

        void LaunchExternal(object sender, EventArgs e)
        {
            if (GetSelecteItemText() != null && GetSelectedItemCount() == 1)
            {
                var path = Path.GetFullPath(DirectoryPath + GetSelecteItemText());
                if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        void ExploreHere(object sender, EventArgs e)
        {
            if (GetSelecteItemText() != null && GetSelectedItemCount() == 1)
            {
                var path = Path.GetDirectoryName(DirectoryPath + GetSelecteItemText());
                if (path != null && Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
        }

        void ListResultDoubleClick(object sender, EventArgs e)
        {
            if (IsPackage)
            {
                ViewInProjectExplorer(sender, e);
            }
            else
            {
                ExploreHere(sender, e);
            }
        }

        void DeleteFiles(object sender, EventArgs eventArgs)
        {
            // TODO: Add alert to confirm deletion
            if (MessageBox.Show(@"Are you sure you want to delete this/these files ?", @"Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GetSelectedItems()
                    .ForEach(i =>
                    {
                        if (File.Exists(DirectoryPath + i))
                        {
                            var fullPath = DirectoryPath + i;

                            // treeview is a little more complicated, we need to search both keys/values, and remove at correct level
                            var key = UsedFiles.Where(c => c.Key == fullPath).Select(c => c.Key).FirstOrDefault();
                            if (key == null)
                            {
                                // check children, and return parent key
                                var parent = UsedFiles.FirstOrDefault(c => c.Value.Contains(fullPath));
                                if (parent.Key != null)
                                {
                                    UsedFiles[parent.Key].Remove(fullPath);
                                }
                            }
                            else
                            {
                                List<string> temp;
                                UsedFiles.TryRemove(key, out temp);
                            }

                            UnUsedFiles
                                .Remove(fullPath);

                            AllFiles
                                .Remove(fullPath);

                            // in package mode, let VS do the deleting
                            if (IsPackage)
                            {
                                var item = ProjectItems.FirstOrDefault(c => c.Properties.Item("FullPath").Value.ToString() == fullPath);
                                if (item != null)
                                {
                                    item.Delete();

                                    ProjectItems.ToList()
                                        .Remove(item);
                                }
                            }
                            else
                            {
                                File.Delete(fullPath);
                            }
                        }
                    });

                ListFiles();
            }
        }

        void ExportFiles(object sender, EventArgs eventArgs)
        {
            saveFileDialog.FileName = radioUnused.Checked ? "unused.txt" : "used.txt";

            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var s = new StreamWriter(saveFileDialog.FileName))
                {
                    GetSelectedItems().ForEach(i => s.WriteLine(DirectoryPath + i));
                }

                MessageBox.Show(string.Format("Result saved in: {0}", saveFileDialog.FileName), @"Done", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Main
        void GetPath(string path = null)
        {
            var result = DialogResult.Abort;
            if (string.IsNullOrEmpty(path))
            {
                folderBrowserDialog.SelectedPath = Properties.Settings.Default["Directory"].ToString();
                result                           = folderBrowserDialog.ShowDialog();
            }
            else
            {
                if (Directory.Exists(path))
                {
                    result = DialogResult.OK;
                }
            }

            if (result == DialogResult.OK)
            {
                DirectoryPath = path ?? folderBrowserDialog.SelectedPath;
                try
                {
                    AllFiles = Directory.GetFiles(DirectoryPath, "*.*", SearchOption.AllDirectories).ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                ProcessFiles();
            }
        }

        CancellationTokenSource _cancellationTokenSource;
        /// <summary>
        /// Cancels the ProcessFiles() loop
        /// </summary>
        void ButtonCancelClick(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();

                // In VS, just quit since we can't select a new directory anyways
                if (IsPackage)
                {
                    Dispose();
                }
                else
                {
                    // the problem is that even if the task is canceled, task.IsCompleted in ProcessFiles() will be called multiple times
                    // so just do all the clreaing and resetting here

                    UsedFiles.Clear();
                    UnUsedFiles.Clear();

                    lblParsed.Text        = string.Format(ParsedLabel, 0.ToString("D4"));
                    panelProgress.Visible = false;

                    this.EnabledControlAndChildren(true);
                }
            }
        }

        void ProcessFiles()
        {
            if (string.IsNullOrEmpty(DirectoryPath) || !Directory.Exists(DirectoryPath))
            {
                // show error message
                MessageBox.Show(@"Directory: Path is undefined or does not exist", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (IsPackage)
                {
                    Dispose();
                }

                return;
            }

            lblPath.Text = string.Format(PathLabel, DirectoryPath);

            if (AllFiles == null || AllFiles.Count == 0)
            {
                // show error message
                MessageBox.Show(@"No project files where found", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (IsPackage)
                {
                    Dispose();
                }

                return;
            }

            lblFiles.Text = string.Format(FilesLabel, AllFiles.Count.ToString("D5"));

            // reset result lists
            listResult.Items.Clear();
            treeResult.Nodes.Clear();

            lblUsed.Text            = string.Format(UsedLabel  , 0);
            lblUnused.Text          = string.Format(UnusedLabel, 0);
            patternFind.BackColor   = Color.White;
            patternSearch.BackColor = Color.White;

            if (!IsRegexPatternValid(patternFind.Text))
            {
                patternFind.BackColor = Color.FromArgb(251, 176, 176);
                return;
            }

            if (!IsRegexPatternValid(patternSearch.Text))
            {
                patternSearch.BackColor = Color.FromArgb(251, 176, 176);
                return;
            }

            // files to search within
            var searchIn = AllFiles.Where(c => Regex.IsMatch(c, patternSearch.Text, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)).ToList();

            #region Exclude files
            if (checkBoxExclude.Checked)
            {
                var excluded = listBoxExclude.Items.Cast<string>();
                // we remove here to not have to relaunch the program each time to take into account any changes made in the exclusion list
                searchIn = searchIn.Where(a => !excluded.Any(e => Regex.IsMatch(a, Regex.Escape(e), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))).ToList();
            }
            #endregion

            if (searchIn.Count == 0)
            {
                // nothing to search in
                MessageBox.Show(string.Format("No matching files found for:\r\n{0}", patternSearch.Text), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblToParse.Text = string.Format(ToParseLabel, searchIn.Count.ToString("D4"));

            // files to search for
            UnUsedFiles = AllFiles.Where(c => Regex.IsMatch(c, patternFind.Text, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)).ToList();

            #region Exclude files
            if (checkBoxExclude.Checked)
            {
                var excluded = listBoxExclude.Items.Cast<string>();
                // we remove here to not have to relaunch the program each time to take into account any changes made in the exclusion list
                UnUsedFiles = UnUsedFiles.Where(a => !excluded.Any(e => Regex.IsMatch(a, Regex.Escape(e), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))).ToList();
            }
            #endregion

            if (UnUsedFiles.Count == 0)
            {
                // nothing to search for
                MessageBox.Show(string.Format("No matching files found for:\r\n{0}", patternFind.Text), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #region Save current settings
            // no errors, so save settings

            // should do this on a right click or something, as to not bloat the list
            UpateAutoCompleteSource(patternFind  , "Find");
            UpateAutoCompleteSource(patternSearch, "Search");

            Properties.Settings.Default.Directory = DirectoryPath;
            Properties.Settings.Default.Save();
            #endregion

            lblToMatch.Text = string.Format(ToMatchLabel, UnUsedFiles.Count.ToString("D4"));

            // Disbale all controls on form except cancel button
            this.EnabledControlAndChildren(false);
            buttonCancel.EnableControlAndParents(true);

            progressBar.Value     = 0;
            progressBar.Minimum   = 0;
            progressBar.Maximum   = searchIn.Count;
            panelProgress.Visible = true;

            // placeholder for used files
            UsedFiles = new ConcurrentDictionary<string, List<string>>();

            // start searching async
            var ui = TaskScheduler.FromCurrentSynchronizationContext();
            _cancellationTokenSource = new CancellationTokenSource();

            Parallel.ForEach(searchIn, f => Task.Factory.StartNew(() =>
            {
                var fileName = Path.GetFileName(f);
                if (fileName != null && File.Exists(f))
                {
                    var content = File.ReadAllText(f);
                    UnUsedFiles.ForEach(i =>
                    {
                        var itemName = Path.GetFileName(i);
                        if (itemName != null)
                        {
                            // don't search for yourself in yourself (but use entire path)
                            if (!i.Equals(f, StringComparison.InvariantCultureIgnoreCase))
                            {
                                if (Regex.IsMatch(content, Regex.Escape(itemName),
                                    RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Multiline))
                                {
                                    if (UsedFiles.ContainsKey(i))
                                    {
                                        UsedFiles[i].Add(f);
                                    }
                                    else
                                    {
                                        UsedFiles.TryAdd(i, new List<string>() {f});
                                    }
                                }
                            }
                        }
                    });
                }
            }, _cancellationTokenSource.Token)
            .ContinueWith(task =>
            {
                if (task.IsCompleted)
                {
                    // operation was canceled
                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        return;
                    }

                    // update ui
                    progressBar.Value++;
                    lblCurrentFile.Text = f.Replace(DirectoryPath, string.Empty);
                    lblParsed.Text      = string.Format(ParsedLabel, progressBar.Value.ToString("D4"));

                    if (progressBar.Value == progressBar.Maximum)
                    {
                        UsedFiles
                            .ToList()
                            .ForEach(i =>
                            {
                                UnUsedFiles.Remove(i.Key);
                            });


                        panelProgress.Visible = false;
                        this.EnabledControlAndChildren(true);

                        ListFiles();
                    }
                }
            }, ui));
        }
        #endregion

        #region Menu Items
        void WebsiteStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.codeproject.com/Articles/555489/Find-Unused-Files-v");
        }

        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            Form about = new AboutBox();
            about.Show();
        }
        void ManualToolStripMenuItemClick(object sender, EventArgs e)
        {
            var help = new Help("manual");
            help.Show();
        }

        void ChangelogToolStripMenuItemClick(object sender, EventArgs e)
        {
            var help = new Help("changelog");
            help.Show();
        }

        void LicenseToolStripMenuItemClick(object sender, EventArgs e)
        {
            var help = new Help("license");
            help.Show();
        }

        void checkUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var req = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/itechnology/FindUnusedFiles/master/version.txt");

            req.BeginGetResponse(ar =>
            {
                try
                {
                    var resp = (HttpWebResponse) req.EndGetResponse(ar);
                    using (var stream = resp.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            using (var sr = new StreamReader(stream))
                            {
                                var result = sr.ReadToEnd();
                                var currentVersion = new Version(Application.ProductVersion);
                                var latestVersion = new Version(result);
                                if (latestVersion.CompareTo(currentVersion) > 0)
                                {
                                    var respMsg = MessageBox.Show(@"Would you like to go download it ?", @"Update Availiable", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (respMsg == DialogResult.Yes)
                                    {
                                        System.Diagnostics.Process.Start(
                                            "https://github.com/itechnology/FindUnusedFiles/tree/master/dist");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"You have the latest version.", @"Up to date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }, null);
        }
        #endregion

        bool IsElevatedProcess(string args = "")
        {
            var isAdmin  = false;
            var identity = WindowsIdentity.GetCurrent();
            if (identity != null)
            {
                var pricipal = new WindowsPrincipal(identity);

                isAdmin = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
                if (!isAdmin)
                {
                    var result = MessageBox.Show(@"This action requires admin rights, relaunch with appropriate rights ?", @"Admin Rights", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        var processInfo = new ProcessStartInfo
                        {
                            Verb      = "runas",
                            FileName  = Application.ExecutablePath,
                            Arguments = string.Format("{0} {1}", Environment.CommandLine, args)
                        };

                        try
                        {
                            System.Diagnostics.Process.Start(processInfo);
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            return isAdmin;
        }

        private void RegisterShellToolStripMenuItemClick(object sender, EventArgs e)
        {
            RegisterShell();
        }

        void RegisterShell()
        {
            if (IsPackage)
            {
                return;
            }

            if (IsElevatedProcess("-s t"))
            {
                var result = MessageBox.Show(string.Format("[{0}] shell extension?", registerShellToolStripMenuItem.Checked ? "UnRegister" : "Register"), @"Shell extension", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    if (registerShellToolStripMenuItem.Checked)
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree("Directory\\shell\\FindUnusedFiles", false);

                        registerShellToolStripMenuItem.Checked = false;
                        MessageBox.Show("Shell extension is now [UnRegistered]");
                        return;
                    }

                    var key = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\FindUnusedFiles");
                    if (key != null)
                    {
                        key.SetValue("", "Find Unused Files", RegistryValueKind.String);
                        key.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String);

                        var cmd = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\FindUnusedFiles\\command");
                        if (cmd != null)
                        {
                            cmd.SetValue("", string.Format("{0} -p \"%1\"", Application.ExecutablePath), RegistryValueKind.String);
                        }

                        registerShellToolStripMenuItem.Checked = true;
                        MessageBox.Show("Shell extension is now [Registered]");
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region AutoComplete (textboxes)
        /// <summary>
        /// Load autocomplete data into a textbox from user settings
        /// http://stackoverflow.com/a/4267845
        /// </summary>
        void SetAutoCompleteSource(TextBox textbox, string setting)
        {
            var settings               = Properties.Settings.Default;
            var patternCollection      = ((StringCollection)settings[setting]).Cast<string>().ToArray();
            var autoCompleteCollection = new AutoCompleteStringCollection();

            autoCompleteCollection.AddRange(patternCollection);

            textbox.AutoCompleteCustomSource = autoCompleteCollection;
            textbox.Text                     = patternCollection.FirstOrDefault();
        }

        /// <summary>
        /// Add current textbox.Text to user settings, it's loaded at next application launch
        /// </summary>
        void UpateAutoCompleteSource(TextBox textbox, string setting)
        {
            if (IsRegexPatternValid(textbox.Text))
            {
                if (!textbox.AutoCompleteCustomSource.Contains(textbox.Text))
                {
                    var settings          = Properties.Settings.Default;
                    var patternCollection = ((StringCollection) settings[setting]);

                    // add to top of list
                    patternCollection.Insert(0, textbox.Text);
                    settings.Save();

                    // refresh autocomplete list
                    SetAutoCompleteSource(textbox, setting);
                }
            }
        }

        void RemoveFromAutoCompleteSource(TextBox textbox, string setting)
        {
            if (IsRegexPatternValid(textbox.Text))
            {
                if (textbox.AutoCompleteCustomSource.Contains(textbox.Text))
                {
                    var settings          = Properties.Settings.Default;
                    var patternCollection = (StringCollection)settings[setting];

                    // add to top of list
                    patternCollection.Remove(textbox.Text);
                    textbox.AutoCompleteCustomSource.Remove(textbox.Text);
                    settings.Save();

                    textbox.Text = patternCollection.Cast<string>().FirstOrDefault();
                }
            }
        }

        void ButtonFindAutoCompleteClick(object sender, EventArgs e)
        {
            patternFind.Clear();
            patternFind.Focus();

            //http://stackoverflow.com/a/11460724
            SendKeys.Send(@"\");
        }

        void ButtonSearchAutoComplete(object sender, EventArgs e)
        {
            patternSearch.Clear();
            patternSearch.Focus();

            //http://stackoverflow.com/a/11460724
            SendKeys.Send(@"\");
        }
        #endregion

        #region Exclude
        void buttonExcludeAdd_Click(object sender, EventArgs e)
        {
            var item = textBoxExclude.Text;
            listBoxExclude.Items.Add(item);

            Properties.Settings.Default.Exclude.Add(item);
            Properties.Settings.Default.Save();
        }

        void checkBoxExclude_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExcludeChecked = checkBoxExclude.Checked;
            Properties.Settings.Default.Save();

            listBoxExclude.Enabled = checkBoxExclude.Checked;
        }
        #endregion

        private void checkBoxImages_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ImagePreviewChecked = checkBoxImages.Checked;
            Properties.Settings.Default.Save();

            if (!checkBoxImages.Checked && PictureBox != null)
            {
                PictureBox.Hide();
            }
        }
    }
}
