namespace BatchGuy.App
{
    partial class CreateX264BatchFileForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateX264BatchFileForm));
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.lblNumberOfFiles = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.tlpScreen = new System.Windows.Forms.TableLayoutPanel();
            this.chkIgnoreInternalSubtitles = new System.Windows.Forms.CheckBox();
            this.gbX264Template = new System.Windows.Forms.GroupBox();
            this.tlpX264Template = new System.Windows.Forms.TableLayoutPanel();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAviSynthFiles = new System.Windows.Forms.GroupBox();
            this.tlpAVSFiles = new System.Windows.Forms.TableLayoutPanel();
            this.lblDirectoryTypeCaption = new System.Windows.Forms.Label();
            this.lblDirectoryType = new System.Windows.Forms.Label();
            this.lblOutputAndLogFileCaption = new System.Windows.Forms.Label();
            this.txtX264EncodeOutputAndLogDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenX264LogFileOutputDialog = new System.Windows.Forms.Button();
            this.txtX264LogFileSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnOpenX264BatchFileOutputDialog = new System.Windows.Forms.Button();
            this.txtX264BatchFileOutputDirectory = new System.Windows.Forms.TextBox();
            this.chkSaveLogFileToDifferentDirectory = new System.Windows.Forms.CheckBox();
            this.bgwCreateX264BatchFile = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createX264BatchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMkvmergeBatchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMkvMergeWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviSynthFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEpisodeNumbersDropDownListItem = new System.Windows.Forms.BindingSource(this.components);
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            this.tlpScreen.SuspendLayout();
            this.gbX264Template.SuspendLayout();
            this.tlpX264Template.SuspendLayout();
            this.gbAviSynthFiles.SuspendLayout();
            this.tlpAVSFiles.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEpisodeNumbersDropDownListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowDrop = true;
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn,
            this.aviSynthFilePathDataGridViewTextBoxColumn,
            this.encodeNameDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.bsFiles;
            this.dgvFiles.Location = new System.Drawing.Point(2, 2);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(916, 240);
            this.dgvFiles.TabIndex = 4;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            this.dgvFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFiles_RowsRemoved);
            this.dgvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragDrop);
            this.dgvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragEnter);
            // 
            // lblNumberOfFiles
            // 
            this.lblNumberOfFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumberOfFiles.AutoSize = true;
            this.lblNumberOfFiles.Location = new System.Drawing.Point(3, 249);
            this.lblNumberOfFiles.Name = "lblNumberOfFiles";
            this.lblNumberOfFiles.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfFiles.TabIndex = 23;
            this.lblNumberOfFiles.Text = "Number of Files:";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // gbScreen
            // 
            this.gbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScreen.Controls.Add(this.tlpScreen);
            this.gbScreen.Location = new System.Drawing.Point(3, 3);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(938, 727);
            this.gbScreen.TabIndex = 31;
            this.gbScreen.TabStop = false;
            // 
            // tlpScreen
            // 
            this.tlpScreen.ColumnCount = 3;
            this.tlpScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.02938F));
            this.tlpScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.97063F));
            this.tlpScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpScreen.Controls.Add(this.lblDirectoryTypeCaption, 0, 0);
            this.tlpScreen.Controls.Add(this.chkIgnoreInternalSubtitles, 0, 4);
            this.tlpScreen.Controls.Add(this.gbX264Template, 0, 6);
            this.tlpScreen.Controls.Add(this.lblDirectoryType, 1, 0);
            this.tlpScreen.Controls.Add(this.gbAviSynthFiles, 0, 5);
            this.tlpScreen.Controls.Add(this.lblOutputAndLogFileCaption, 0, 1);
            this.tlpScreen.Controls.Add(this.txtX264EncodeOutputAndLogDirectory, 1, 1);
            this.tlpScreen.Controls.Add(this.label2, 0, 2);
            this.tlpScreen.Controls.Add(this.btnOpenX264LogFileOutputDialog, 2, 3);
            this.tlpScreen.Controls.Add(this.txtX264LogFileSaveDirectory, 1, 3);
            this.tlpScreen.Controls.Add(this.btnOpenX264BatchFileOutputDialog, 2, 2);
            this.tlpScreen.Controls.Add(this.txtX264BatchFileOutputDirectory, 1, 2);
            this.tlpScreen.Controls.Add(this.chkSaveLogFileToDifferentDirectory, 0, 3);
            this.tlpScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScreen.Location = new System.Drawing.Point(3, 16);
            this.tlpScreen.Name = "tlpScreen";
            this.tlpScreen.RowCount = 7;
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpScreen.Size = new System.Drawing.Size(932, 708);
            this.tlpScreen.TabIndex = 0;
            // 
            // chkIgnoreInternalSubtitles
            // 
            this.chkIgnoreInternalSubtitles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIgnoreInternalSubtitles.AutoSize = true;
            this.tlpScreen.SetColumnSpan(this.chkIgnoreInternalSubtitles, 3);
            this.chkIgnoreInternalSubtitles.Location = new System.Drawing.Point(3, 165);
            this.chkIgnoreInternalSubtitles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.chkIgnoreInternalSubtitles.Name = "chkIgnoreInternalSubtitles";
            this.chkIgnoreInternalSubtitles.Size = new System.Drawing.Size(311, 17);
            this.chkIgnoreInternalSubtitles.TabIndex = 3;
            this.chkIgnoreInternalSubtitles.Text = "Ignore internal subtitles when creating mkvmerge batch file? ";
            this.chkIgnoreInternalSubtitles.UseVisualStyleBackColor = true;
            this.chkIgnoreInternalSubtitles.CheckedChanged += new System.EventHandler(this.chkIgnoreInternalSubtitles_CheckedChanged);
            // 
            // gbX264Template
            // 
            this.gbX264Template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScreen.SetColumnSpan(this.gbX264Template, 3);
            this.gbX264Template.Controls.Add(this.tlpX264Template);
            this.gbX264Template.Location = new System.Drawing.Point(3, 492);
            this.gbX264Template.Name = "gbX264Template";
            this.gbX264Template.Size = new System.Drawing.Size(926, 213);
            this.gbX264Template.TabIndex = 30;
            this.gbX264Template.TabStop = false;
            this.gbX264Template.Text = "x264 Template";
            // 
            // tlpX264Template
            // 
            this.tlpX264Template.ColumnCount = 2;
            this.tlpX264Template.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.80349F));
            this.tlpX264Template.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19651F));
            this.tlpX264Template.Controls.Add(this.cbEncodeType, 1, 0);
            this.tlpX264Template.Controls.Add(this.label4, 0, 0);
            this.tlpX264Template.Controls.Add(this.txtX264Template, 0, 1);
            this.tlpX264Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpX264Template.Location = new System.Drawing.Point(3, 16);
            this.tlpX264Template.Name = "tlpX264Template";
            this.tlpX264Template.RowCount = 2;
            this.tlpX264Template.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpX264Template.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpX264Template.Size = new System.Drawing.Size(920, 194);
            this.tlpX264Template.TabIndex = 0;
            // 
            // txtX264Template
            // 
            this.txtX264Template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpX264Template.SetColumnSpan(this.txtX264Template, 2);
            this.txtX264Template.Location = new System.Drawing.Point(3, 30);
            this.txtX264Template.Multiline = true;
            this.txtX264Template.Name = "txtX264Template";
            this.txtX264Template.Size = new System.Drawing.Size(914, 161);
            this.txtX264Template.TabIndex = 6;
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.Items.AddRange(new object[] {
            "CRF",
            "2Pass"});
            this.cbEncodeType.Location = new System.Drawing.Point(769, 3);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(148, 21);
            this.cbEncodeType.TabIndex = 5;
            this.cbEncodeType.SelectedIndexChanged += new System.EventHandler(this.cbEncodeType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Encode Type:";
            // 
            // gbAviSynthFiles
            // 
            this.gbAviSynthFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScreen.SetColumnSpan(this.gbAviSynthFiles, 3);
            this.gbAviSynthFiles.Controls.Add(this.tlpAVSFiles);
            this.gbAviSynthFiles.Location = new System.Drawing.Point(3, 200);
            this.gbAviSynthFiles.Name = "gbAviSynthFiles";
            this.gbAviSynthFiles.Size = new System.Drawing.Size(926, 286);
            this.gbAviSynthFiles.TabIndex = 28;
            this.gbAviSynthFiles.TabStop = false;
            this.gbAviSynthFiles.Text = "Drag N Drop (.avs) files";
            // 
            // tlpAVSFiles
            // 
            this.tlpAVSFiles.ColumnCount = 1;
            this.tlpAVSFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAVSFiles.Controls.Add(this.dgvFiles, 0, 0);
            this.tlpAVSFiles.Controls.Add(this.lblNumberOfFiles, 0, 1);
            this.tlpAVSFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAVSFiles.Location = new System.Drawing.Point(3, 16);
            this.tlpAVSFiles.Name = "tlpAVSFiles";
            this.tlpAVSFiles.RowCount = 2;
            this.tlpAVSFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAVSFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAVSFiles.Size = new System.Drawing.Size(920, 267);
            this.tlpAVSFiles.TabIndex = 0;
            // 
            // lblDirectoryTypeCaption
            // 
            this.lblDirectoryTypeCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirectoryTypeCaption.AutoSize = true;
            this.lblDirectoryTypeCaption.Location = new System.Drawing.Point(3, 11);
            this.lblDirectoryTypeCaption.Name = "lblDirectoryTypeCaption";
            this.lblDirectoryTypeCaption.Size = new System.Drawing.Size(118, 13);
            this.lblDirectoryTypeCaption.TabIndex = 37;
            this.lblDirectoryTypeCaption.Text = "Directory Type Chosen:";
            // 
            // lblDirectoryType
            // 
            this.lblDirectoryType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirectoryType.AutoSize = true;
            this.lblDirectoryType.Location = new System.Drawing.Point(230, 11);
            this.lblDirectoryType.Name = "lblDirectoryType";
            this.lblDirectoryType.Size = new System.Drawing.Size(79, 13);
            this.lblDirectoryType.TabIndex = 38;
            this.lblDirectoryType.Text = "Directory Type:";
            // 
            // lblOutputAndLogFileCaption
            // 
            this.lblOutputAndLogFileCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutputAndLogFileCaption.AutoSize = true;
            this.lblOutputAndLogFileCaption.Location = new System.Drawing.Point(3, 47);
            this.lblOutputAndLogFileCaption.Name = "lblOutputAndLogFileCaption";
            this.lblOutputAndLogFileCaption.Size = new System.Drawing.Size(135, 13);
            this.lblOutputAndLogFileCaption.TabIndex = 40;
            this.lblOutputAndLogFileCaption.Text = "-output and (.log) Directory:";
            // 
            // txtX264EncodeOutputAndLogDirectory
            // 
            this.txtX264EncodeOutputAndLogDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtX264EncodeOutputAndLogDirectory.Location = new System.Drawing.Point(230, 45);
            this.txtX264EncodeOutputAndLogDirectory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtX264EncodeOutputAndLogDirectory.Name = "txtX264EncodeOutputAndLogDirectory";
            this.txtX264EncodeOutputAndLogDirectory.ReadOnly = true;
            this.txtX264EncodeOutputAndLogDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264EncodeOutputAndLogDirectory.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "x264 Batch File Save Directory*:";
            // 
            // btnOpenX264LogFileOutputDialog
            // 
            this.btnOpenX264LogFileOutputDialog.Enabled = false;
            this.btnOpenX264LogFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264LogFileOutputDialog.Location = new System.Drawing.Point(813, 117);
            this.btnOpenX264LogFileOutputDialog.Name = "btnOpenX264LogFileOutputDialog";
            this.btnOpenX264LogFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264LogFileOutputDialog.TabIndex = 2;
            this.btnOpenX264LogFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264LogFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264LogFileOutputDialog_Click);
            // 
            // txtX264LogFileSaveDirectory
            // 
            this.txtX264LogFileSaveDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtX264LogFileSaveDirectory.Enabled = false;
            this.txtX264LogFileSaveDirectory.Location = new System.Drawing.Point(230, 125);
            this.txtX264LogFileSaveDirectory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtX264LogFileSaveDirectory.Name = "txtX264LogFileSaveDirectory";
            this.txtX264LogFileSaveDirectory.ReadOnly = true;
            this.txtX264LogFileSaveDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264LogFileSaveDirectory.TabIndex = 34;
            // 
            // btnOpenX264BatchFileOutputDialog
            // 
            this.btnOpenX264BatchFileOutputDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenX264BatchFileOutputDialog.Location = new System.Drawing.Point(813, 76);
            this.btnOpenX264BatchFileOutputDialog.Name = "btnOpenX264BatchFileOutputDialog";
            this.btnOpenX264BatchFileOutputDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenX264BatchFileOutputDialog.TabIndex = 0;
            this.btnOpenX264BatchFileOutputDialog.UseVisualStyleBackColor = true;
            this.btnOpenX264BatchFileOutputDialog.Click += new System.EventHandler(this.btnOpenX264BatchFileOutputDialog_Click);
            // 
            // txtX264BatchFileOutputDirectory
            // 
            this.txtX264BatchFileOutputDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtX264BatchFileOutputDirectory.Location = new System.Drawing.Point(230, 85);
            this.txtX264BatchFileOutputDirectory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtX264BatchFileOutputDirectory.Name = "txtX264BatchFileOutputDirectory";
            this.txtX264BatchFileOutputDirectory.ReadOnly = true;
            this.txtX264BatchFileOutputDirectory.Size = new System.Drawing.Size(576, 20);
            this.txtX264BatchFileOutputDirectory.TabIndex = 25;
            // 
            // chkSaveLogFileToDifferentDirectory
            // 
            this.chkSaveLogFileToDifferentDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSaveLogFileToDifferentDirectory.AutoSize = true;
            this.chkSaveLogFileToDifferentDirectory.Location = new System.Drawing.Point(3, 124);
            this.chkSaveLogFileToDifferentDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.chkSaveLogFileToDifferentDirectory.Name = "chkSaveLogFileToDifferentDirectory";
            this.chkSaveLogFileToDifferentDirectory.Size = new System.Drawing.Size(195, 17);
            this.chkSaveLogFileToDifferentDirectory.TabIndex = 1;
            this.chkSaveLogFileToDifferentDirectory.Text = "Save (.log) file to different directory?";
            this.chkSaveLogFileToDifferentDirectory.UseVisualStyleBackColor = true;
            this.chkSaveLogFileToDifferentDirectory.CheckedChanged += new System.EventHandler(this.chkSaveLogFileToDifferentDirectory_CheckedChanged);
            // 
            // bgwCreateX264BatchFile
            // 
            this.bgwCreateX264BatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateX264BatchFile_DoWork);
            this.bgwCreateX264BatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateX264BatchFile_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 32;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveSettingsFileToolStripMenuItem
            // 
            this.saveSettingsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.createX264BatchFileToolStripMenuItem,
            this.createMkvmergeBatchFileToolStripMenuItem});
            this.saveSettingsFileToolStripMenuItem.Name = "saveSettingsFileToolStripMenuItem";
            this.saveSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.saveSettingsFileToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.loadToolStripMenuItem.Text = "Restore";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_New_file;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // createX264BatchFileToolStripMenuItem
            // 
            this.createX264BatchFileToolStripMenuItem.Enabled = false;
            this.createX264BatchFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createX264BatchFileToolStripMenuItem.Name = "createX264BatchFileToolStripMenuItem";
            this.createX264BatchFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.createX264BatchFileToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createX264BatchFileToolStripMenuItem.Text = "Create x264 Batch File";
            this.createX264BatchFileToolStripMenuItem.Click += new System.EventHandler(this.createX264BatchFileToolStripMenuItem_Click);
            // 
            // createMkvmergeBatchFileToolStripMenuItem
            // 
            this.createMkvmergeBatchFileToolStripMenuItem.Enabled = false;
            this.createMkvmergeBatchFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createMkvmergeBatchFileToolStripMenuItem.Name = "createMkvmergeBatchFileToolStripMenuItem";
            this.createMkvmergeBatchFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.createMkvmergeBatchFileToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createMkvmergeBatchFileToolStripMenuItem.Text = "Create mkvmerge Batch File";
            this.createMkvmergeBatchFileToolStripMenuItem.Click += new System.EventHandler(this.createMkvmergeBatchFileToolStripMenuItem_Click);
            // 
            // bgwMkvMergeWriteBatchFile
            // 
            this.bgwMkvMergeWriteBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMkvMergeWriteBatchFile_DoWork);
            this.bgwMkvMergeWriteBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMkvMergeWriteBatchFile_RunWorkerCompleted);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(3, 737);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 41;
            this.lblVersion.Text = "Version";
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.lblVersion, 0, 1);
            this.tlpForm.Controls.Add(this.gbScreen, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 24);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 2;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(944, 755);
            this.tlpForm.TabIndex = 42;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // aviSynthFileNameOnlyDataGridViewTextBoxColumn
            // 
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "AviSynthFileNameOnly";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.Name = "aviSynthFileNameOnlyDataGridViewTextBoxColumn";
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.ReadOnly = true;
            this.aviSynthFileNameOnlyDataGridViewTextBoxColumn.Width = 150;
            // 
            // aviSynthFilePathDataGridViewTextBoxColumn
            // 
            this.aviSynthFilePathDataGridViewTextBoxColumn.DataPropertyName = "AviSynthFilePath";
            this.aviSynthFilePathDataGridViewTextBoxColumn.HeaderText = "AviSynthFilePath";
            this.aviSynthFilePathDataGridViewTextBoxColumn.Name = "aviSynthFilePathDataGridViewTextBoxColumn";
            this.aviSynthFilePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // encodeNameDataGridViewTextBoxColumn
            // 
            this.encodeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.encodeNameDataGridViewTextBoxColumn.DataPropertyName = "EncodeName";
            this.encodeNameDataGridViewTextBoxColumn.HeaderText = "Encode Name (EX: E01.mkv)";
            this.encodeNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.encodeNameDataGridViewTextBoxColumn.Name = "encodeNameDataGridViewTextBoxColumn";
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "EpisodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.DataSource = this.bsEpisodeNumbersDropDownListItem;
            this.episodeNumberDataGridViewTextBoxColumn.DisplayMember = "DisplayMember";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Blu-ray Episode Number";
            this.episodeNumberDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            this.episodeNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.episodeNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.episodeNumberDataGridViewTextBoxColumn.ValueMember = "ValueMember";
            this.episodeNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsEpisodeNumbersDropDownListItem
            // 
            this.bsEpisodeNumbersDropDownListItem.AllowNew = false;
            this.bsEpisodeNumbersDropDownListItem.DataSource = typeof(BatchGuy.App.Shared.Models.DropDownListItem);
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(BatchGuy.App.X264.Models.X264File);
            // 
            // CreateX264BatchFileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 779);
            this.Controls.Add(this.tlpForm);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateX264BatchFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateX264BatchFileForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CreateX264BatchFileForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.tlpScreen.ResumeLayout(false);
            this.tlpScreen.PerformLayout();
            this.gbX264Template.ResumeLayout(false);
            this.tlpX264Template.ResumeLayout(false);
            this.tlpX264Template.PerformLayout();
            this.gbAviSynthFiles.ResumeLayout(false);
            this.tlpAVSFiles.ResumeLayout(false);
            this.tlpAVSFiles.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEpisodeNumbersDropDownListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label lblNumberOfFiles;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateX264BatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX264BatchFileOutputDirectory;
        private System.Windows.Forms.Button btnOpenX264BatchFileOutputDialog;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.GroupBox gbAviSynthFiles;
        private System.Windows.Forms.GroupBox gbX264Template;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.CheckBox chkSaveLogFileToDifferentDirectory;
        private System.Windows.Forms.TextBox txtX264LogFileSaveDirectory;
        private System.Windows.Forms.Button btnOpenX264LogFileOutputDialog;
        private System.Windows.Forms.BindingSource bsEpisodeNumbersDropDownListItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblOutputAndLogFileCaption;
        private System.Windows.Forms.TextBox txtX264EncodeOutputAndLogDirectory;
        private System.Windows.Forms.Label lblDirectoryType;
        private System.Windows.Forms.Label lblDirectoryTypeCaption;
        private System.ComponentModel.BackgroundWorker bgwMkvMergeWriteBatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviSynthFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox chkIgnoreInternalSubtitles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createX264BatchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMkvmergeBatchFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpScreen;
        private System.Windows.Forms.TableLayoutPanel tlpX264Template;
        private System.Windows.Forms.TableLayoutPanel tlpAVSFiles;
    }
}