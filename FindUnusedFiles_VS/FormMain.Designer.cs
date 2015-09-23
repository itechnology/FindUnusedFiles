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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblUsed = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelProgress = new System.Windows.Forms.Panel();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.tabPageTreeView = new System.Windows.Forms.TabPage();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tabPageTreeView.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(652, 433);
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
            this.listResult.Size = new System.Drawing.Size(757, 290);
            this.listResult.TabIndex = 1;
            // 
            // patternSearch
            // 
            this.patternSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "\\.(htm|html|aspx|ascx|master|cshtml|js|css|less)$",
            "\\.(htm|html|php|js|css|less)$"});
            this.patternSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patternSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.patternSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternSearch.Location = new System.Drawing.Point(13, 436);
            this.patternSearch.Margin = new System.Windows.Forms.Padding(2);
            this.patternSearch.Name = "patternSearch";
            this.patternSearch.Size = new System.Drawing.Size(617, 21);
            this.patternSearch.TabIndex = 2;
            // 
            // patternFind
            // 
            this.patternFind.AutoCompleteCustomSource.AddRange(new string[] {
            "\\.(gif|png|jpg|jpeg|bmp|ico|svg)$",
            "\\.(js|css)$"});
            this.patternFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patternFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.patternFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternFind.Location = new System.Drawing.Point(14, 389);
            this.patternFind.Margin = new System.Windows.Forms.Padding(2);
            this.patternFind.Name = "patternFind";
            this.patternFind.Size = new System.Drawing.Size(616, 21);
            this.patternFind.TabIndex = 3;
            // 
            // lblInside
            // 
            this.lblInside.AutoSize = true;
            this.lblInside.Location = new System.Drawing.Point(10, 419);
            this.lblInside.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInside.Name = "lblInside";
            this.lblInside.Size = new System.Drawing.Size(98, 15);
            this.lblInside.TabIndex = 4;
            this.lblInside.Text = "Inside these files";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 372);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 15);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search for files";
            // 
            // radioUsed
            // 
            this.radioUsed.AutoSize = true;
            this.radioUsed.Location = new System.Drawing.Point(652, 390);
            this.radioUsed.Margin = new System.Windows.Forms.Padding(2);
            this.radioUsed.Name = "radioUsed";
            this.radioUsed.Size = new System.Drawing.Size(52, 19);
            this.radioUsed.TabIndex = 6;
            this.radioUsed.Text = "used";
            this.radioUsed.UseVisualStyleBackColor = true;
            // 
            // radioUnused
            // 
            this.radioUnused.AutoSize = true;
            this.radioUnused.Checked = true;
            this.radioUnused.Location = new System.Drawing.Point(708, 390);
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
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(649, 372);
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
            this.menuStrip.Size = new System.Drawing.Size(804, 24);
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
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.licenseToolStripMenuItem});
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
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
            this.panelProgress.Controls.Add(this.label1);
            this.panelProgress.Controls.Add(this.lblCurrentFile);
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Location = new System.Drawing.Point(26, 120);
            this.panelProgress.Margin = new System.Windows.Forms.Padding(2);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(748, 114);
            this.panelProgress.TabIndex = 14;
            this.panelProgress.Visible = false;
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
            this.treeResult.Size = new System.Drawing.Size(757, 290);
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
            this.checkBoxImages.AutoSize = true;
            this.checkBoxImages.Checked = true;
            this.checkBoxImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImages.Location = new System.Drawing.Point(678, 26);
            this.checkBoxImages.Name = "checkBoxImages";
            this.checkBoxImages.Size = new System.Drawing.Size(107, 19);
            this.checkBoxImages.TabIndex = 28;
            this.checkBoxImages.Text = "Image Preview";
            this.checkBoxImages.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNormal);
            this.tabControl1.Controls.Add(this.tabPageTreeView);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Location = new System.Drawing.Point(14, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 324);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.listResult);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 24);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(763, 296);
            this.tabPageNormal.TabIndex = 0;
            this.tabPageNormal.Text = "Normal";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // tabPageTreeView
            // 
            this.tabPageTreeView.Controls.Add(this.treeResult);
            this.tabPageTreeView.Location = new System.Drawing.Point(4, 24);
            this.tabPageTreeView.Name = "tabPageTreeView";
            this.tabPageTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreeView.Size = new System.Drawing.Size(763, 296);
            this.tabPageTreeView.TabIndex = 1;
            this.tabPageTreeView.Text = "TreeView";
            this.tabPageTreeView.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.label7);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 24);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(763, 296);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(238, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "For future stuff";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.tabControl1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I-Technology.NET: Find Unused Files";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem registerShellToolStripMenuItem;
        private System.Windows.Forms.TreeView treeResult;
        private System.Windows.Forms.CheckBox checkBoxImages;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TabPage tabPageTreeView;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Label label7;
    }
}

