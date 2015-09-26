namespace ITechnologyNET.FindUnusedFiles
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.patternSearch = new System.Windows.Forms.TextBox();
            this.patternFind = new System.Windows.Forms.TextBox();
            this.lblInside = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.radioUsed = new System.Windows.Forms.RadioButton();
            this.radioUnused = new System.Windows.Forms.RadioButton();
            this.lblReport = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.registerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorShell = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorUpdate = new System.Windows.Forms.ToolStripSeparator();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblUsed = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.treeResult = new System.Windows.Forms.TreeView();
            this.lblUnused = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblParsed = new System.Windows.Forms.Label();
            this.lblToParse = new System.Windows.Forms.Label();
            this.lblToMatch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxImages = new System.Windows.Forms.CheckBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.tabPageTreeView = new System.Windows.Forms.TabPage();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.comboBoxAutoUpdate = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExcludeAdd = new System.Windows.Forms.Button();
            this.textBoxExclude = new System.Windows.Forms.TextBox();
            this.listBoxExclude = new System.Windows.Forms.ListBox();
            this.checkBoxExclude = new System.Windows.Forms.CheckBox();
            this.buttonFindAutoComplete = new System.Windows.Forms.Button();
            this.buttonSearchAutoComplete = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tabPageTreeView.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(708, 475);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "In this directory";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BrowseClick);
            // 
            // listResult
            // 
            this.listResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResult.FormattingEnabled = true;
            this.listResult.HorizontalScrollbar = true;
            this.listResult.ItemHeight = 15;
            this.listResult.Location = new System.Drawing.Point(3, 3);
            this.listResult.Margin = new System.Windows.Forms.Padding(0);
            this.listResult.Name = "listResult";
            this.listResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listResult.Size = new System.Drawing.Size(817, 332);
            this.listResult.Sorted = true;
            this.listResult.TabIndex = 1;
            // 
            // patternSearch
            // 
            this.patternSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patternSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.patternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternSearch.Location = new System.Drawing.Point(13, 478);
            this.patternSearch.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.patternSearch.Name = "patternSearch";
            this.patternSearch.Size = new System.Drawing.Size(643, 21);
            this.patternSearch.TabIndex = 2;
            // 
            // patternFind
            // 
            this.patternFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patternFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.patternFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternFind.Location = new System.Drawing.Point(14, 431);
            this.patternFind.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.patternFind.Name = "patternFind";
            this.patternFind.Size = new System.Drawing.Size(642, 21);
            this.patternFind.TabIndex = 3;
            // 
            // lblInside
            // 
            this.lblInside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInside.AutoSize = true;
            this.lblInside.Location = new System.Drawing.Point(10, 461);
            this.lblInside.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInside.Name = "lblInside";
            this.lblInside.Size = new System.Drawing.Size(98, 15);
            this.lblInside.TabIndex = 4;
            this.lblInside.Text = "Inside these files";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 414);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 15);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search for files";
            // 
            // radioUsed
            // 
            this.radioUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioUsed.AutoSize = true;
            this.radioUsed.Location = new System.Drawing.Point(712, 432);
            this.radioUsed.Margin = new System.Windows.Forms.Padding(2);
            this.radioUsed.Name = "radioUsed";
            this.radioUsed.Size = new System.Drawing.Size(52, 19);
            this.radioUsed.TabIndex = 6;
            this.radioUsed.Text = "used";
            this.radioUsed.UseVisualStyleBackColor = true;
            // 
            // radioUnused
            // 
            this.radioUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioUnused.AutoSize = true;
            this.radioUnused.Checked = true;
            this.radioUnused.Location = new System.Drawing.Point(768, 432);
            this.radioUnused.Margin = new System.Windows.Forms.Padding(2);
            this.radioUnused.Name = "radioUnused";
            this.radioUnused.Size = new System.Drawing.Size(66, 19);
            this.radioUnused.TabIndex = 7;
            this.radioUnused.TabStop = true;
            this.radioUnused.Text = "unused";
            this.radioUnused.UseVisualStyleBackColor = true;
            this.radioUnused.CheckedChanged += new System.EventHandler(this.RadioCheckedChanged);
            // 
            // lblReport
            // 
            this.lblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(709, 414);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(52, 15);
            this.lblReport.TabIndex = 9;
            this.lblReport.Text = "That are";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(864, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.toolStripSeparator1,
            this.registerShellToolStripMenuItem,
            this.toolStripSeparatorShell,
            this.aboutToolStripMenuItem,
            this.licenseToolStripMenuItem,
            this.toolStripSeparatorUpdate,
            this.checkUpdateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.manual;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.ShowShortcutKeys = false;
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.ManualToolStripMenuItemClick);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.changelog;
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.ShowShortcutKeys = false;
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.ChangelogToolStripMenuItemClick);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.website;
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.ShowShortcutKeys = false;
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // registerShellToolStripMenuItem
            // 
            this.registerShellToolStripMenuItem.Name = "registerShellToolStripMenuItem";
            this.registerShellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerShellToolStripMenuItem.Text = "Shell Extension";
            this.registerShellToolStripMenuItem.Click += new System.EventHandler(this.RegisterShellToolStripMenuItemClick);
            // 
            // toolStripSeparatorShell
            // 
            this.toolStripSeparatorShell.Name = "toolStripSeparatorShell";
            this.toolStripSeparatorShell.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShowShortcutKeys = false;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.license;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.ShowShortcutKeys = false;
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.LicenseToolStripMenuItemClick);
            // 
            // toolStripSeparatorUpdate
            // 
            this.toolStripSeparatorUpdate.Name = "toolStripSeparatorUpdate";
            this.toolStripSeparatorUpdate.Size = new System.Drawing.Size(149, 6);
            // 
            // checkUpdateToolStripMenuItem
            // 
            this.checkUpdateToolStripMenuItem.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.refresh;
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            this.checkUpdateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkUpdateToolStripMenuItem.Text = "Check Update";
            this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Enabled = false;
            this.lblUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsed.Location = new System.Drawing.Point(472, 29);
            this.lblUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(62, 13);
            this.lblUsed.TabIndex = 12;
            this.lblUsed.Text = "Used: 0000";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 65);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(716, 28);
            this.progressBar.TabIndex = 13;
            // 
            // panelProgress
            // 
            this.panelProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProgress.Controls.Add(this.buttonCancel);
            this.panelProgress.Controls.Add(this.label1);
            this.panelProgress.Controls.Add(this.lblCurrentFile);
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Location = new System.Drawing.Point(56, 141);
            this.panelProgress.Margin = new System.Windows.Forms.Padding(2);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(748, 114);
            this.panelProgress.TabIndex = 14;
            this.panelProgress.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(657, 17);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Parsing:";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(14, 46);
            this.lblCurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(36, 15);
            this.lblCurrentFile.TabIndex = 14;
            this.lblCurrentFile.Text = "... n/a";
            // 
            // treeResult
            // 
            this.treeResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeResult.Location = new System.Drawing.Point(3, 3);
            this.treeResult.Margin = new System.Windows.Forms.Padding(0);
            this.treeResult.Name = "treeResult";
            this.treeResult.ShowNodeToolTips = true;
            this.treeResult.Size = new System.Drawing.Size(817, 332);
            this.treeResult.TabIndex = 27;
            // 
            // lblUnused
            // 
            this.lblUnused.AutoSize = true;
            this.lblUnused.Enabled = false;
            this.lblUnused.Location = new System.Drawing.Point(554, 27);
            this.lblUnused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnused.Name = "lblUnused";
            this.lblUnused.Size = new System.Drawing.Size(84, 15);
            this.lblUnused.TabIndex = 16;
            this.lblUnused.Text = "Unused: 0000";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Enabled = false;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(11, 9);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(52, 13);
            this.lblPath.TabIndex = 17;
            this.lblPath.Text = "Path: n/a";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Enabled = false;
            this.lblFiles.Location = new System.Drawing.Point(11, 27);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(104, 15);
            this.lblFiles.TabIndex = 18;
            this.lblFiles.Text = "Total Files: 00000";
            // 
            // lblParsed
            // 
            this.lblParsed.AutoSize = true;
            this.lblParsed.Enabled = false;
            this.lblParsed.Location = new System.Drawing.Point(361, 27);
            this.lblParsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParsed.Name = "lblParsed";
            this.lblParsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblParsed.Size = new System.Drawing.Size(80, 15);
            this.lblParsed.TabIndex = 19;
            this.lblParsed.Text = "Parsed: 0000";
            // 
            // lblToParse
            // 
            this.lblToParse.AutoSize = true;
            this.lblToParse.Enabled = false;
            this.lblToParse.Location = new System.Drawing.Point(250, 27);
            this.lblToParse.Name = "lblToParse";
            this.lblToParse.Size = new System.Drawing.Size(90, 15);
            this.lblToParse.TabIndex = 20;
            this.lblToParse.Text = "To Parse: 0000";
            // 
            // lblToMatch
            // 
            this.lblToMatch.AutoSize = true;
            this.lblToMatch.Enabled = false;
            this.lblToMatch.Location = new System.Drawing.Point(136, 27);
            this.lblToMatch.Name = "lblToMatch";
            this.lblToMatch.Size = new System.Drawing.Size(92, 15);
            this.lblToMatch.TabIndex = 21;
            this.lblToMatch.Text = "To Match: 0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(120, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(234, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(346, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(446, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = ">>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(539, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "|";
            // 
            // checkBoxImages
            // 
            this.checkBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxImages.AutoSize = true;
            this.checkBoxImages.Checked = true;
            this.checkBoxImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImages.Location = new System.Drawing.Point(738, 26);
            this.checkBoxImages.Name = "checkBoxImages";
            this.checkBoxImages.Size = new System.Drawing.Size(107, 19);
            this.checkBoxImages.TabIndex = 28;
            this.checkBoxImages.Text = "Image Preview";
            this.checkBoxImages.UseVisualStyleBackColor = true;
            this.checkBoxImages.CheckedChanged += new System.EventHandler(this.checkBoxImages_CheckedChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageNormal);
            this.tabControlMain.Controls.Add(this.tabPageTreeView);
            this.tabControlMain.Controls.Add(this.tabPageOptions);
            this.tabControlMain.Location = new System.Drawing.Point(14, 45);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(831, 366);
            this.tabControlMain.TabIndex = 29;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.listResult);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 24);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(823, 338);
            this.tabPageNormal.TabIndex = 0;
            this.tabPageNormal.Text = "Flat View";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // tabPageTreeView
            // 
            this.tabPageTreeView.Controls.Add(this.treeResult);
            this.tabPageTreeView.Location = new System.Drawing.Point(4, 24);
            this.tabPageTreeView.Name = "tabPageTreeView";
            this.tabPageTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreeView.Size = new System.Drawing.Size(823, 338);
            this.tabPageTreeView.TabIndex = 1;
            this.tabPageTreeView.Text = "Tree View";
            this.tabPageTreeView.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.comboBoxAutoUpdate);
            this.tabPageOptions.Controls.Add(this.checkBoxAutoUpdateCheck);
            this.tabPageOptions.Controls.Add(this.label7);
            this.tabPageOptions.Controls.Add(this.buttonExcludeAdd);
            this.tabPageOptions.Controls.Add(this.textBoxExclude);
            this.tabPageOptions.Controls.Add(this.listBoxExclude);
            this.tabPageOptions.Controls.Add(this.checkBoxExclude);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 24);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(823, 338);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // comboBoxAutoUpdate
            // 
            this.comboBoxAutoUpdate.FormattingEnabled = true;
            this.comboBoxAutoUpdate.Location = new System.Drawing.Point(434, 39);
            this.comboBoxAutoUpdate.Name = "comboBoxAutoUpdate";
            this.comboBoxAutoUpdate.Size = new System.Drawing.Size(131, 23);
            this.comboBoxAutoUpdate.TabIndex = 8;
            this.comboBoxAutoUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoUpdate_SelectedIndexChanged);
            // 
            // checkBoxAutoUpdateCheck
            // 
            this.checkBoxAutoUpdateCheck.AutoSize = true;
            this.checkBoxAutoUpdateCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoUpdateCheck.Checked = true;
            this.checkBoxAutoUpdateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoUpdateCheck.Location = new System.Drawing.Point(431, 20);
            this.checkBoxAutoUpdateCheck.Name = "checkBoxAutoUpdateCheck";
            this.checkBoxAutoUpdateCheck.Size = new System.Drawing.Size(131, 19);
            this.checkBoxAutoUpdateCheck.TabIndex = 7;
            this.checkBoxAutoUpdateCheck.Text = "Auto-Update Check";
            this.checkBoxAutoUpdateCheck.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdateCheck.CheckedChanged += new System.EventHandler(this.checkBoxAutoUpdateCheck_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(416, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 329);
            this.label7.TabIndex = 6;
            // 
            // buttonExcludeAdd
            // 
            this.buttonExcludeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcludeAdd.Location = new System.Drawing.Point(322, 309);
            this.buttonExcludeAdd.Name = "buttonExcludeAdd";
            this.buttonExcludeAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonExcludeAdd.TabIndex = 3;
            this.buttonExcludeAdd.Text = "Add";
            this.buttonExcludeAdd.UseVisualStyleBackColor = true;
            this.buttonExcludeAdd.Click += new System.EventHandler(this.buttonExcludeAdd_Click);
            // 
            // textBoxExclude
            // 
            this.textBoxExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExclude.Location = new System.Drawing.Point(16, 311);
            this.textBoxExclude.Name = "textBoxExclude";
            this.textBoxExclude.Size = new System.Drawing.Size(300, 21);
            this.textBoxExclude.TabIndex = 2;
            // 
            // listBoxExclude
            // 
            this.listBoxExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxExclude.FormattingEnabled = true;
            this.listBoxExclude.ItemHeight = 15;
            this.listBoxExclude.Location = new System.Drawing.Point(16, 39);
            this.listBoxExclude.Name = "listBoxExclude";
            this.listBoxExclude.Size = new System.Drawing.Size(381, 259);
            this.listBoxExclude.Sorted = true;
            this.listBoxExclude.TabIndex = 1;
            // 
            // checkBoxExclude
            // 
            this.checkBoxExclude.AutoSize = true;
            this.checkBoxExclude.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxExclude.Location = new System.Drawing.Point(12, 20);
            this.checkBoxExclude.Name = "checkBoxExclude";
            this.checkBoxExclude.Size = new System.Drawing.Size(129, 19);
            this.checkBoxExclude.TabIndex = 5;
            this.checkBoxExclude.Text = "Exclusions Active ?";
            this.checkBoxExclude.UseVisualStyleBackColor = true;
            this.checkBoxExclude.CheckedChanged += new System.EventHandler(this.checkBoxExclude_CheckedChanged);
            // 
            // buttonFindAutoComplete
            // 
            this.buttonFindAutoComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindAutoComplete.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.down;
            this.buttonFindAutoComplete.Location = new System.Drawing.Point(656, 430);
            this.buttonFindAutoComplete.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonFindAutoComplete.Name = "buttonFindAutoComplete";
            this.buttonFindAutoComplete.Size = new System.Drawing.Size(23, 23);
            this.buttonFindAutoComplete.TabIndex = 30;
            this.buttonFindAutoComplete.UseVisualStyleBackColor = true;
            this.buttonFindAutoComplete.Click += new System.EventHandler(this.ButtonFindAutoCompleteClick);
            // 
            // buttonSearchAutoComplete
            // 
            this.buttonSearchAutoComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchAutoComplete.Image = global::ITechnologyNET.FindUnusedFiles.Properties.Resources.down;
            this.buttonSearchAutoComplete.Location = new System.Drawing.Point(656, 477);
            this.buttonSearchAutoComplete.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonSearchAutoComplete.Name = "buttonSearchAutoComplete";
            this.buttonSearchAutoComplete.Size = new System.Drawing.Size(23, 23);
            this.buttonSearchAutoComplete.TabIndex = 31;
            this.buttonSearchAutoComplete.UseVisualStyleBackColor = true;
            this.buttonSearchAutoComplete.Click += new System.EventHandler(this.ButtonSearchAutoComplete);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonSearchAutoComplete);
            this.Controls.Add(this.buttonFindAutoComplete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToMatch);
            this.Controls.Add(this.lblToParse);
            this.Controls.Add(this.lblParsed);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblUnused);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.radioUnused);
            this.Controls.Add(this.radioUsed);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblInside);
            this.Controls.Add(this.patternFind);
            this.Controls.Add(this.patternSearch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.checkBoxImages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1250, 750);
            this.MinimumSize = new System.Drawing.Size(880, 550);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I-Technology.NET: Find Unused Files";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageNormal.ResumeLayout(false);
            this.tabPageTreeView.ResumeLayout(false);
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.TextBox patternSearch;
        private System.Windows.Forms.TextBox patternFind;
        private System.Windows.Forms.Label lblInside;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton radioUsed;
        private System.Windows.Forms.RadioButton radioUnused;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnused;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblParsed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.Label lblToParse;
        private System.Windows.Forms.Label lblToMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorShell;
        private System.Windows.Forms.ToolStripMenuItem registerShellToolStripMenuItem;
        private System.Windows.Forms.TreeView treeResult;
        private System.Windows.Forms.CheckBox checkBoxImages;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TabPage tabPageTreeView;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFindAutoComplete;
        private System.Windows.Forms.Button buttonSearchAutoComplete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorUpdate;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.Button buttonExcludeAdd;
        private System.Windows.Forms.TextBox textBoxExclude;
        private System.Windows.Forms.ListBox listBoxExclude;
        private System.Windows.Forms.CheckBox checkBoxExclude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAutoUpdate;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdateCheck;
    }
}

