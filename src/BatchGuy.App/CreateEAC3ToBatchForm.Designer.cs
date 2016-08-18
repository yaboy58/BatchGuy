namespace BatchGuy.App
{
    partial class CreateEAC3ToBatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEAC3ToBatchForm));
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgwEac3toLoadSummary = new System.ComponentModel.BackgroundWorker();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkExtractForRemux = new System.Windows.Forms.CheckBox();
            this.gbExtractForRemux = new System.Windows.Forms.GroupBox();
            this.cbRemuxVideoFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRemuxMedium = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemuxTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemuxAudioType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRemuxVideoResolution = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemuxSeasonYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemuxSeasonNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemuxSeriesName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWriteToBatFile = new System.Windows.Forms.Button();
            this.gbDiscSummary = new System.Windows.Forms.GroupBox();
            this.dgvBluRaySummary = new System.Windows.Forms.DataGridView();
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.dgvBluRayDiscInfo = new System.Windows.Forms.DataGridView();
            this.btnOpenBatchFilePathDialog = new System.Windows.Forms.Button();
            this.txtBatFilePath = new System.Windows.Forms.TextBox();
            this.lblBatchFilePath = new System.Windows.Forms.Label();
            this.bgwEac3toWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.ttDirectoryUserControl = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenMKVMergeOutputPathDialog = new System.Windows.Forms.Button();
            this.txtMKVMergeOutputPath = new System.Windows.Forms.TextBox();
            this.lblMKVMergeOutputPath = new System.Windows.Forms.Label();
            this.setDirectoryUserControl = new BatchGuy.App.UserControls.SetDirectoryUserControl();
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eac3ToIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayTitleInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRaySummaryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSelectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayDiscInfo = new System.Windows.Forms.BindingSource(this.components);
            this.btnWriteToMKVMergeBatFile = new System.Windows.Forms.Button();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbExtractForRemux.SuspendLayout();
            this.gbDiscSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).BeginInit();
            this.gbDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // bgwEac3toLoadSummary
            // 
            this.bgwEac3toLoadSummary.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toLoadSummary_DoWork);
            this.bgwEac3toLoadSummary.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toLoadSummary_RunWorkerCompleted);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.btnWriteToMKVMergeBatFile);
            this.gbScreen.Controls.Add(this.btnOpenMKVMergeOutputPathDialog);
            this.gbScreen.Controls.Add(this.txtMKVMergeOutputPath);
            this.gbScreen.Controls.Add(this.lblMKVMergeOutputPath);
            this.gbScreen.Controls.Add(this.pictureBox1);
            this.gbScreen.Controls.Add(this.chkExtractForRemux);
            this.gbScreen.Controls.Add(this.gbExtractForRemux);
            this.gbScreen.Controls.Add(this.setDirectoryUserControl);
            this.gbScreen.Controls.Add(this.btnWriteToBatFile);
            this.gbScreen.Controls.Add(this.gbDiscSummary);
            this.gbScreen.Controls.Add(this.gbDisc);
            this.gbScreen.Controls.Add(this.btnOpenBatchFilePathDialog);
            this.gbScreen.Controls.Add(this.txtBatFilePath);
            this.gbScreen.Controls.Add(this.lblBatchFilePath);
            this.gbScreen.Location = new System.Drawing.Point(12, 28);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1310, 775);
            this.gbScreen.TabIndex = 30;
            this.gbScreen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BatchGuy.App.Properties.Resources.webdev_config_icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 132);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // chkExtractForRemux
            // 
            this.chkExtractForRemux.AutoSize = true;
            this.chkExtractForRemux.Location = new System.Drawing.Point(843, 19);
            this.chkExtractForRemux.Name = "chkExtractForRemux";
            this.chkExtractForRemux.Size = new System.Drawing.Size(15, 14);
            this.chkExtractForRemux.TabIndex = 43;
            this.chkExtractForRemux.UseVisualStyleBackColor = true;
            this.chkExtractForRemux.CheckedChanged += new System.EventHandler(this.chkExtractForRemux_CheckedChanged);
            // 
            // gbExtractForRemux
            // 
            this.gbExtractForRemux.Controls.Add(this.cbRemuxVideoFormat);
            this.gbExtractForRemux.Controls.Add(this.label9);
            this.gbExtractForRemux.Controls.Add(this.cbRemuxMedium);
            this.gbExtractForRemux.Controls.Add(this.label8);
            this.gbExtractForRemux.Controls.Add(this.label7);
            this.gbExtractForRemux.Controls.Add(this.txtRemuxTag);
            this.gbExtractForRemux.Controls.Add(this.label6);
            this.gbExtractForRemux.Controls.Add(this.txtRemuxAudioType);
            this.gbExtractForRemux.Controls.Add(this.label5);
            this.gbExtractForRemux.Controls.Add(this.cbRemuxVideoResolution);
            this.gbExtractForRemux.Controls.Add(this.label4);
            this.gbExtractForRemux.Controls.Add(this.txtRemuxSeasonYear);
            this.gbExtractForRemux.Controls.Add(this.label3);
            this.gbExtractForRemux.Controls.Add(this.txtRemuxSeasonNumber);
            this.gbExtractForRemux.Controls.Add(this.label2);
            this.gbExtractForRemux.Controls.Add(this.txtRemuxSeriesName);
            this.gbExtractForRemux.Controls.Add(this.label1);
            this.gbExtractForRemux.Enabled = false;
            this.gbExtractForRemux.Location = new System.Drawing.Point(864, 19);
            this.gbExtractForRemux.Name = "gbExtractForRemux";
            this.gbExtractForRemux.Size = new System.Drawing.Size(432, 226);
            this.gbExtractForRemux.TabIndex = 42;
            this.gbExtractForRemux.TabStop = false;
            this.gbExtractForRemux.Text = "Extract for Remux Naming Convention";
            // 
            // cbRemuxVideoFormat
            // 
            this.cbRemuxVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxVideoFormat.FormattingEnabled = true;
            this.cbRemuxVideoFormat.Items.AddRange(new object[] {
            "",
            "AVC",
            "H.264"});
            this.cbRemuxVideoFormat.Location = new System.Drawing.Point(310, 199);
            this.cbRemuxVideoFormat.Name = "cbRemuxVideoFormat";
            this.cbRemuxVideoFormat.Size = new System.Drawing.Size(113, 21);
            this.cbRemuxVideoFormat.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Video Format:";
            // 
            // cbRemuxMedium
            // 
            this.cbRemuxMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxMedium.FormattingEnabled = true;
            this.cbRemuxMedium.Items.AddRange(new object[] {
            "",
            "Remux"});
            this.cbRemuxMedium.Location = new System.Drawing.Point(88, 199);
            this.cbRemuxMedium.Name = "cbRemuxMedium";
            this.cbRemuxMedium.Size = new System.Drawing.Size(113, 21);
            this.cbRemuxMedium.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Medium:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Example: BatchGuy 1978 S01E01 Episode 1 1080p  Remux AVC TrueHD -Tag.mkv";
            // 
            // txtRemuxTag
            // 
            this.txtRemuxTag.Location = new System.Drawing.Point(266, 161);
            this.txtRemuxTag.Name = "txtRemuxTag";
            this.txtRemuxTag.Size = new System.Drawing.Size(85, 20);
            this.txtRemuxTag.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tag:";
            // 
            // txtRemuxAudioType
            // 
            this.txtRemuxAudioType.Location = new System.Drawing.Point(88, 162);
            this.txtRemuxAudioType.Name = "txtRemuxAudioType";
            this.txtRemuxAudioType.Size = new System.Drawing.Size(137, 20);
            this.txtRemuxAudioType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Audio Type:";
            // 
            // cbRemuxVideoResolution
            // 
            this.cbRemuxVideoResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxVideoResolution.FormattingEnabled = true;
            this.cbRemuxVideoResolution.Items.AddRange(new object[] {
            "",
            "720p",
            "1080i",
            "1080p"});
            this.cbRemuxVideoResolution.Location = new System.Drawing.Point(88, 126);
            this.cbRemuxVideoResolution.Name = "cbRemuxVideoResolution";
            this.cbRemuxVideoResolution.Size = new System.Drawing.Size(170, 21);
            this.cbRemuxVideoResolution.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resolution:";
            // 
            // txtRemuxSeasonYear
            // 
            this.txtRemuxSeasonYear.Location = new System.Drawing.Point(269, 87);
            this.txtRemuxSeasonYear.Name = "txtRemuxSeasonYear";
            this.txtRemuxSeasonYear.Size = new System.Drawing.Size(82, 20);
            this.txtRemuxSeasonYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // txtRemuxSeasonNumber
            // 
            this.txtRemuxSeasonNumber.Location = new System.Drawing.Point(88, 88);
            this.txtRemuxSeasonNumber.Name = "txtRemuxSeasonNumber";
            this.txtRemuxSeasonNumber.Size = new System.Drawing.Size(70, 20);
            this.txtRemuxSeasonNumber.TabIndex = 3;
            this.txtRemuxSeasonNumber.TextChanged += new System.EventHandler(this.txtSeasonNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Season# *:";
            // 
            // txtRemuxSeriesName
            // 
            this.txtRemuxSeriesName.Location = new System.Drawing.Point(88, 53);
            this.txtRemuxSeriesName.Name = "txtRemuxSeriesName";
            this.txtRemuxSeriesName.Size = new System.Drawing.Size(301, 20);
            this.txtRemuxSeriesName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series Name *:";
            // 
            // btnWriteToBatFile
            // 
            this.btnWriteToBatFile.Location = new System.Drawing.Point(932, 729);
            this.btnWriteToBatFile.Name = "btnWriteToBatFile";
            this.btnWriteToBatFile.Size = new System.Drawing.Size(133, 40);
            this.btnWriteToBatFile.TabIndex = 3;
            this.btnWriteToBatFile.Text = "Create eac3to Batch File";
            this.btnWriteToBatFile.UseVisualStyleBackColor = true;
            this.btnWriteToBatFile.Click += new System.EventHandler(this.btnWriteToBatFile_Click);
            // 
            // gbDiscSummary
            // 
            this.gbDiscSummary.Controls.Add(this.dgvBluRaySummary);
            this.gbDiscSummary.Location = new System.Drawing.Point(12, 472);
            this.gbDiscSummary.Name = "gbDiscSummary";
            this.gbDiscSummary.Size = new System.Drawing.Size(1284, 238);
            this.gbDiscSummary.TabIndex = 40;
            this.gbDiscSummary.TabStop = false;
            this.gbDiscSummary.Text = "Disc Summary";
            // 
            // dgvBluRaySummary
            // 
            this.dgvBluRaySummary.AllowUserToAddRows = false;
            this.dgvBluRaySummary.AllowUserToOrderColumns = true;
            this.dgvBluRaySummary.AutoGenerateColumns = false;
            this.dgvBluRaySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRaySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn,
            this.eac3ToIdDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn,
            this.headerTextDataGridViewTextBoxColumn,
            this.detailTextDataGridViewTextBoxColumn,
            this.bluRayTitleInfoDataGridViewTextBoxColumn});
            this.dgvBluRaySummary.DataSource = this.bsBluRaySummaryInfo;
            this.dgvBluRaySummary.Location = new System.Drawing.Point(6, 18);
            this.dgvBluRaySummary.Name = "dgvBluRaySummary";
            this.dgvBluRaySummary.Size = new System.Drawing.Size(1272, 214);
            this.dgvBluRaySummary.TabIndex = 23;
            this.dgvBluRaySummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellClick);
            this.dgvBluRaySummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellDoubleClick);
            // 
            // gbDisc
            // 
            this.gbDisc.Controls.Add(this.dgvBluRayDiscInfo);
            this.gbDisc.Location = new System.Drawing.Point(12, 286);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(1284, 180);
            this.gbDisc.TabIndex = 39;
            this.gbDisc.TabStop = false;
            this.gbDisc.Text = "Drag N Drop Blu-ray Folders";
            // 
            // dgvBluRayDiscInfo
            // 
            this.dgvBluRayDiscInfo.AllowDrop = true;
            this.dgvBluRayDiscInfo.AllowUserToAddRows = false;
            this.dgvBluRayDiscInfo.AllowUserToDeleteRows = false;
            this.dgvBluRayDiscInfo.AllowUserToOrderColumns = true;
            this.dgvBluRayDiscInfo.AutoGenerateColumns = false;
            this.dgvBluRayDiscInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRayDiscInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isSelectedDataGridViewCheckBoxColumn1,
            this.discNameDataGridViewTextBoxColumn,
            this.bluRayPathDataGridViewTextBoxColumn});
            this.dgvBluRayDiscInfo.DataSource = this.bsBluRayDiscInfo;
            this.dgvBluRayDiscInfo.Location = new System.Drawing.Point(6, 24);
            this.dgvBluRayDiscInfo.Name = "dgvBluRayDiscInfo";
            this.dgvBluRayDiscInfo.Size = new System.Drawing.Size(1272, 150);
            this.dgvBluRayDiscInfo.TabIndex = 24;
            this.dgvBluRayDiscInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayDiscInfo_CellClick);
            this.dgvBluRayDiscInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragDrop);
            this.dgvBluRayDiscInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragEnter);
            // 
            // btnOpenBatchFilePathDialog
            // 
            this.btnOpenBatchFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenBatchFilePathDialog.Location = new System.Drawing.Point(774, 51);
            this.btnOpenBatchFilePathDialog.Name = "btnOpenBatchFilePathDialog";
            this.btnOpenBatchFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenBatchFilePathDialog.TabIndex = 1;
            this.btnOpenBatchFilePathDialog.UseVisualStyleBackColor = true;
            this.btnOpenBatchFilePathDialog.Click += new System.EventHandler(this.btnOpenBatchFilePathDialog_Click);
            // 
            // txtBatFilePath
            // 
            this.txtBatFilePath.Location = new System.Drawing.Point(327, 64);
            this.txtBatFilePath.Name = "txtBatFilePath";
            this.txtBatFilePath.ReadOnly = true;
            this.txtBatFilePath.Size = new System.Drawing.Size(441, 20);
            this.txtBatFilePath.TabIndex = 33;
            // 
            // lblBatchFilePath
            // 
            this.lblBatchFilePath.AutoSize = true;
            this.lblBatchFilePath.Location = new System.Drawing.Point(181, 71);
            this.lblBatchFilePath.Name = "lblBatchFilePath";
            this.lblBatchFilePath.Size = new System.Drawing.Size(137, 13);
            this.lblBatchFilePath.TabIndex = 35;
            this.lblBatchFilePath.Text = "Batch File Save Directory *:";
            // 
            // bgwEac3toWriteBatchFile
            // 
            this.bgwEac3toWriteBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toWriteBatchFile_DoWork);
            this.bgwEac3toWriteBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toWriteBatchFile_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveSettingsFileToolStripMenuItem
            // 
            this.saveSettingsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.saveSettingsFileToolStripMenuItem.Name = "saveSettingsFileToolStripMenuItem";
            this.saveSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.saveSettingsFileToolStripMenuItem.Text = "Save / Restore";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loadToolStripMenuItem.Text = "Restore";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Custom_Icon_Design_Flatastic_10_New_file;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btnOpenMKVMergeOutputPathDialog
            // 
            this.btnOpenMKVMergeOutputPathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenMKVMergeOutputPathDialog.Location = new System.Drawing.Point(774, 206);
            this.btnOpenMKVMergeOutputPathDialog.Name = "btnOpenMKVMergeOutputPathDialog";
            this.btnOpenMKVMergeOutputPathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenMKVMergeOutputPathDialog.TabIndex = 45;
            this.btnOpenMKVMergeOutputPathDialog.UseVisualStyleBackColor = true;
            this.btnOpenMKVMergeOutputPathDialog.Click += new System.EventHandler(this.btnOpenMKVMergeOutputPathDialog_Click);
            // 
            // txtMKVMergeOutputPath
            // 
            this.txtMKVMergeOutputPath.Location = new System.Drawing.Point(327, 219);
            this.txtMKVMergeOutputPath.Name = "txtMKVMergeOutputPath";
            this.txtMKVMergeOutputPath.ReadOnly = true;
            this.txtMKVMergeOutputPath.Size = new System.Drawing.Size(441, 20);
            this.txtMKVMergeOutputPath.TabIndex = 46;
            // 
            // lblMKVMergeOutputPath
            // 
            this.lblMKVMergeOutputPath.AutoSize = true;
            this.lblMKVMergeOutputPath.Location = new System.Drawing.Point(181, 226);
            this.lblMKVMergeOutputPath.Name = "lblMKVMergeOutputPath";
            this.lblMKVMergeOutputPath.Size = new System.Drawing.Size(146, 13);
            this.lblMKVMergeOutputPath.TabIndex = 47;
            this.lblMKVMergeOutputPath.Text = "MKVMerge Output Directory :";
            // 
            // setDirectoryUserControl
            // 
            this.setDirectoryUserControl.ComboBoxCaptionText = "";
            this.setDirectoryUserControl.LabelDirectoryCaptionText = null;
            this.setDirectoryUserControl.Location = new System.Drawing.Point(18, 129);
            this.setDirectoryUserControl.Name = "setDirectoryUserControl";
            this.setDirectoryUserControl.Size = new System.Drawing.Size(824, 71);
            this.setDirectoryUserControl.TabIndex = 41;
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn.MinimumWidth = 70;
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            this.isSelectedDataGridViewCheckBoxColumn.Width = 70;
            // 
            // eac3ToIdDataGridViewTextBoxColumn
            // 
            this.eac3ToIdDataGridViewTextBoxColumn.DataPropertyName = "Eac3ToId";
            this.eac3ToIdDataGridViewTextBoxColumn.HeaderText = "eac3to Id";
            this.eac3ToIdDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.eac3ToIdDataGridViewTextBoxColumn.Name = "eac3ToIdDataGridViewTextBoxColumn";
            this.eac3ToIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.eac3ToIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "EpisodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Episode#";
            this.episodeNumberDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            this.episodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.episodeNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // headerTextDataGridViewTextBoxColumn
            // 
            this.headerTextDataGridViewTextBoxColumn.DataPropertyName = "HeaderText";
            this.headerTextDataGridViewTextBoxColumn.HeaderText = "Playlist / Videofile / Runtime";
            this.headerTextDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.headerTextDataGridViewTextBoxColumn.Name = "headerTextDataGridViewTextBoxColumn";
            this.headerTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.headerTextDataGridViewTextBoxColumn.Width = 400;
            // 
            // detailTextDataGridViewTextBoxColumn
            // 
            this.detailTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailTextDataGridViewTextBoxColumn.DataPropertyName = "DetailText";
            this.detailTextDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailTextDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.detailTextDataGridViewTextBoxColumn.Name = "detailTextDataGridViewTextBoxColumn";
            this.detailTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bluRayTitleInfoDataGridViewTextBoxColumn
            // 
            this.bluRayTitleInfoDataGridViewTextBoxColumn.DataPropertyName = "BluRayTitleInfo";
            this.bluRayTitleInfoDataGridViewTextBoxColumn.HeaderText = "BluRayTitleInfo";
            this.bluRayTitleInfoDataGridViewTextBoxColumn.Name = "bluRayTitleInfoDataGridViewTextBoxColumn";
            this.bluRayTitleInfoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsBluRaySummaryInfo
            // 
            this.bsBluRaySummaryInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRaySummaryInfo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // isSelectedDataGridViewCheckBoxColumn1
            // 
            this.isSelectedDataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn1.MinimumWidth = 100;
            this.isSelectedDataGridViewCheckBoxColumn1.Name = "isSelectedDataGridViewCheckBoxColumn1";
            // 
            // discNameDataGridViewTextBoxColumn
            // 
            this.discNameDataGridViewTextBoxColumn.DataPropertyName = "DiscName";
            this.discNameDataGridViewTextBoxColumn.HeaderText = "Disc Name";
            this.discNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.discNameDataGridViewTextBoxColumn.Name = "discNameDataGridViewTextBoxColumn";
            this.discNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.discNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // bluRayPathDataGridViewTextBoxColumn
            // 
            this.bluRayPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bluRayPathDataGridViewTextBoxColumn.DataPropertyName = "BluRayPath";
            this.bluRayPathDataGridViewTextBoxColumn.HeaderText = "Disc Directory";
            this.bluRayPathDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.bluRayPathDataGridViewTextBoxColumn.Name = "bluRayPathDataGridViewTextBoxColumn";
            this.bluRayPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBluRayDiscInfo
            // 
            this.bsBluRayDiscInfo.AllowNew = true;
            this.bsBluRayDiscInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayDiscInfo);
            // 
            // btnWriteToMKVMergeBatFile
            // 
            this.btnWriteToMKVMergeBatFile.Enabled = false;
            this.btnWriteToMKVMergeBatFile.Location = new System.Drawing.Point(1130, 729);
            this.btnWriteToMKVMergeBatFile.Name = "btnWriteToMKVMergeBatFile";
            this.btnWriteToMKVMergeBatFile.Size = new System.Drawing.Size(166, 40);
            this.btnWriteToMKVMergeBatFile.TabIndex = 48;
            this.btnWriteToMKVMergeBatFile.Text = "Create mkvmerge Batch File";
            this.btnWriteToMKVMergeBatFile.UseVisualStyleBackColor = true;
            // 
            // CreateEAC3ToBatchForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 815);
            this.Controls.Add(this.gbScreen);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CreateEAC3ToBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create eac3to Batch File";
            this.Load += new System.EventHandler(this.CreateEAC3ToBatchForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateEAC3ToBatchForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CreateEAC3ToBatchForm_DragEnter);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbExtractForRemux.ResumeLayout(false);
            this.gbExtractForRemux.PerformLayout();
            this.gbDiscSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).EndInit();
            this.gbDisc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadSummary;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.Button btnWriteToBatFile;
        private System.Windows.Forms.GroupBox gbDiscSummary;
        private System.Windows.Forms.DataGridView dgvBluRaySummary;
        private System.Windows.Forms.GroupBox gbDisc;
        private System.Windows.Forms.DataGridView dgvBluRayDiscInfo;
        private System.Windows.Forms.Button btnOpenBatchFilePathDialog;
        private System.Windows.Forms.TextBox txtBatFilePath;
        private System.Windows.Forms.Label lblBatchFilePath;
        private System.ComponentModel.BackgroundWorker bgwEac3toWriteBatchFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAC3ToConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip ttDirectoryUserControl;
        private System.Windows.Forms.GroupBox gbExtractForRemux;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkExtractForRemux;
        private System.Windows.Forms.TextBox txtRemuxSeriesName;
        private System.Windows.Forms.TextBox txtRemuxSeasonNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemuxSeasonYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRemuxVideoResolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemuxTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemuxAudioType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsBluRaySummaryInfo;
        private UserControls.SetDirectoryUserControl setDirectoryUserControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eac3ToIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bluRayTitleInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBluRayDiscInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bluRayPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRemuxMedium;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRemuxVideoFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnOpenMKVMergeOutputPathDialog;
        private System.Windows.Forms.TextBox txtMKVMergeOutputPath;
        private System.Windows.Forms.Label lblMKVMergeOutputPath;
        private System.Windows.Forms.Button btnWriteToMKVMergeBatFile;
    }
}