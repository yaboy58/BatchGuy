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
            this.tlpScreen = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUpperLeft = new System.Windows.Forms.TableLayoutPanel();
            this.cbEac3ToOutputDirectoryType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBatchFilePath = new System.Windows.Forms.Label();
            this.txtBatFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenBatchFilePathDialog = new System.Windows.Forms.Button();
            this.gbMKVMergeInfo = new System.Windows.Forms.GroupBox();
            this.tlpMKVMergeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMKVMergeOutputPath = new System.Windows.Forms.TextBox();
            this.btnOpenMKVMergeOutputPathDialog = new System.Windows.Forms.Button();
            this.lblMKVMergeOutputPath = new System.Windows.Forms.Label();
            this.txtMKVMergeBatFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenMKVMergeFilePathDialog = new System.Windows.Forms.Button();
            this.btnEac3toOutputDirectory = new System.Windows.Forms.Button();
            this.lblEac3ToOutputDirectory = new System.Windows.Forms.Label();
            this.tlpEac3toOutputDirectory = new System.Windows.Forms.TableLayoutPanel();
            this.lblEac3ToDirectoryOutputCaption = new System.Windows.Forms.Label();
            this.txtEac3toOutputDirectory = new System.Windows.Forms.TextBox();
            this.gbDiscSummary = new System.Windows.Forms.GroupBox();
            this.tlpDiscSummaries = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBluRaySummary = new System.Windows.Forms.DataGridView();
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eac3ToIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayTitleInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRaySummaryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.tlpDiscs = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBluRayDiscInfo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSelectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayDiscInfo = new System.Windows.Forms.BindingSource(this.components);
            this.tlpUpperRight = new System.Windows.Forms.TableLayoutPanel();
            this.chkExtractForRemux = new System.Windows.Forms.CheckBox();
            this.gbExtractForRemux = new System.Windows.Forms.GroupBox();
            this.tlpRemuxTemplate = new System.Windows.Forms.TableLayoutPanel();
            this.chkRemuxUsePeriodsInFileName = new System.Windows.Forms.CheckBox();
            this.lblRemuxSeriesName = new System.Windows.Forms.Label();
            this.cbRemuxVideoFormat = new System.Windows.Forms.ComboBox();
            this.txtRemuxSeriesName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRemuxMedium = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemuxTag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemuxAudioType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemuxNamingConventionCurrentTemplateExample = new System.Windows.Forms.Label();
            this.chkIsThisRemuxForAMovie = new System.Windows.Forms.CheckBox();
            this.lblRemuxForMovieWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemuxSeasonNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemuxSeasonYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRemuxVideoResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRemuxCountry = new System.Windows.Forms.ComboBox();
            this.bsCountries = new System.Windows.Forms.BindingSource(this.components);
            this.bgwEac3toWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.ttDirectoryUserControl = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createEac3toBatchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMkvmergeBatchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMkvMergeWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.gbScreen.SuspendLayout();
            this.tlpScreen.SuspendLayout();
            this.tlpUpperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMKVMergeInfo.SuspendLayout();
            this.tlpMKVMergeInfo.SuspendLayout();
            this.tlpEac3toOutputDirectory.SuspendLayout();
            this.gbDiscSummary.SuspendLayout();
            this.tlpDiscSummaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).BeginInit();
            this.gbDisc.SuspendLayout();
            this.tlpDiscs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).BeginInit();
            this.tlpUpperRight.SuspendLayout();
            this.gbExtractForRemux.SuspendLayout();
            this.tlpRemuxTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tlpForm.SuspendLayout();
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
            this.gbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScreen.Controls.Add(this.tlpScreen);
            this.gbScreen.Location = new System.Drawing.Point(3, 3);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1413, 787);
            this.gbScreen.TabIndex = 30;
            this.gbScreen.TabStop = false;
            // 
            // tlpScreen
            // 
            this.tlpScreen.ColumnCount = 2;
            this.tlpScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 866F));
            this.tlpScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScreen.Controls.Add(this.tlpUpperLeft, 0, 0);
            this.tlpScreen.Controls.Add(this.gbDiscSummary, 0, 2);
            this.tlpScreen.Controls.Add(this.gbDisc, 0, 1);
            this.tlpScreen.Controls.Add(this.tlpUpperRight, 1, 0);
            this.tlpScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScreen.Location = new System.Drawing.Point(3, 16);
            this.tlpScreen.Name = "tlpScreen";
            this.tlpScreen.RowCount = 3;
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tlpScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tlpScreen.Size = new System.Drawing.Size(1407, 768);
            this.tlpScreen.TabIndex = 0;
            // 
            // tlpUpperLeft
            // 
            this.tlpUpperLeft.ColumnCount = 4;
            this.tlpUpperLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpUpperLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tlpUpperLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 505F));
            this.tlpUpperLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpUpperLeft.Controls.Add(this.cbEac3ToOutputDirectoryType, 1, 1);
            this.tlpUpperLeft.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpUpperLeft.Controls.Add(this.lblBatchFilePath, 1, 0);
            this.tlpUpperLeft.Controls.Add(this.txtBatFilePath, 2, 0);
            this.tlpUpperLeft.Controls.Add(this.btnOpenBatchFilePathDialog, 3, 0);
            this.tlpUpperLeft.Controls.Add(this.gbMKVMergeInfo, 0, 2);
            this.tlpUpperLeft.Controls.Add(this.btnEac3toOutputDirectory, 3, 1);
            this.tlpUpperLeft.Controls.Add(this.lblEac3ToOutputDirectory, 0, 1);
            this.tlpUpperLeft.Controls.Add(this.tlpEac3toOutputDirectory, 2, 1);
            this.tlpUpperLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpperLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpUpperLeft.Name = "tlpUpperLeft";
            this.tlpUpperLeft.RowCount = 3;
            this.tlpUpperLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpperLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpUpperLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpUpperLeft.Size = new System.Drawing.Size(860, 344);
            this.tlpUpperLeft.TabIndex = 0;
            // 
            // cbEac3ToOutputDirectoryType
            // 
            this.cbEac3ToOutputDirectoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEac3ToOutputDirectoryType.FormattingEnabled = true;
            this.cbEac3ToOutputDirectoryType.Items.AddRange(new object[] {
            "Directory Per Playlist",
            "Single Directory"});
            this.cbEac3ToOutputDirectoryType.Location = new System.Drawing.Point(139, 161);
            this.cbEac3ToOutputDirectoryType.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cbEac3ToOutputDirectoryType.Name = "cbEac3ToOutputDirectoryType";
            this.cbEac3ToOutputDirectoryType.Size = new System.Drawing.Size(141, 21);
            this.cbEac3ToOutputDirectoryType.TabIndex = 1;
            this.cbEac3ToOutputDirectoryType.SelectedIndexChanged += new System.EventHandler(this.cbEac3ToOutputDirectoryType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BatchGuy.App.Properties.Resources.webdev_config_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 132);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lblBatchFilePath
            // 
            this.lblBatchFilePath.AutoSize = true;
            this.lblBatchFilePath.Location = new System.Drawing.Point(139, 30);
            this.lblBatchFilePath.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblBatchFilePath.Name = "lblBatchFilePath";
            this.lblBatchFilePath.Size = new System.Drawing.Size(97, 13);
            this.lblBatchFilePath.TabIndex = 35;
            this.lblBatchFilePath.Text = "eac3to Batch File*:";
            // 
            // txtBatFilePath
            // 
            this.txtBatFilePath.Location = new System.Drawing.Point(286, 28);
            this.txtBatFilePath.Margin = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.txtBatFilePath.Name = "txtBatFilePath";
            this.txtBatFilePath.ReadOnly = true;
            this.txtBatFilePath.Size = new System.Drawing.Size(494, 20);
            this.txtBatFilePath.TabIndex = 33;
            // 
            // btnOpenBatchFilePathDialog
            // 
            this.btnOpenBatchFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenBatchFilePathDialog.Location = new System.Drawing.Point(791, 15);
            this.btnOpenBatchFilePathDialog.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnOpenBatchFilePathDialog.Name = "btnOpenBatchFilePathDialog";
            this.btnOpenBatchFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenBatchFilePathDialog.TabIndex = 0;
            this.btnOpenBatchFilePathDialog.UseVisualStyleBackColor = true;
            this.btnOpenBatchFilePathDialog.Click += new System.EventHandler(this.btnOpenBatchFilePathDialog_Click);
            // 
            // gbMKVMergeInfo
            // 
            this.gbMKVMergeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUpperLeft.SetColumnSpan(this.gbMKVMergeInfo, 4);
            this.gbMKVMergeInfo.Controls.Add(this.tlpMKVMergeInfo);
            this.gbMKVMergeInfo.Location = new System.Drawing.Point(3, 237);
            this.gbMKVMergeInfo.Name = "gbMKVMergeInfo";
            this.gbMKVMergeInfo.Size = new System.Drawing.Size(854, 101);
            this.gbMKVMergeInfo.TabIndex = 51;
            this.gbMKVMergeInfo.TabStop = false;
            this.gbMKVMergeInfo.Text = "MKVMerge Info";
            // 
            // tlpMKVMergeInfo
            // 
            this.tlpMKVMergeInfo.ColumnCount = 3;
            this.tlpMKVMergeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMKVMergeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 592F));
            this.tlpMKVMergeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpMKVMergeInfo.Controls.Add(this.label10, 0, 0);
            this.tlpMKVMergeInfo.Controls.Add(this.txtMKVMergeOutputPath, 1, 1);
            this.tlpMKVMergeInfo.Controls.Add(this.btnOpenMKVMergeOutputPathDialog, 2, 1);
            this.tlpMKVMergeInfo.Controls.Add(this.lblMKVMergeOutputPath, 0, 1);
            this.tlpMKVMergeInfo.Controls.Add(this.txtMKVMergeBatFilePath, 1, 0);
            this.tlpMKVMergeInfo.Controls.Add(this.btnOpenMKVMergeFilePathDialog, 2, 0);
            this.tlpMKVMergeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMKVMergeInfo.Location = new System.Drawing.Point(3, 16);
            this.tlpMKVMergeInfo.Name = "tlpMKVMergeInfo";
            this.tlpMKVMergeInfo.RowCount = 2;
            this.tlpMKVMergeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMKVMergeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMKVMergeInfo.Size = new System.Drawing.Size(848, 82);
            this.tlpMKVMergeInfo.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "mkvmerge Batch File :";
            // 
            // txtMKVMergeOutputPath
            // 
            this.txtMKVMergeOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMKVMergeOutputPath.Location = new System.Drawing.Point(191, 51);
            this.txtMKVMergeOutputPath.Name = "txtMKVMergeOutputPath";
            this.txtMKVMergeOutputPath.ReadOnly = true;
            this.txtMKVMergeOutputPath.Size = new System.Drawing.Size(586, 20);
            this.txtMKVMergeOutputPath.TabIndex = 46;
            // 
            // btnOpenMKVMergeOutputPathDialog
            // 
            this.btnOpenMKVMergeOutputPathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenMKVMergeOutputPathDialog.Location = new System.Drawing.Point(783, 44);
            this.btnOpenMKVMergeOutputPathDialog.Name = "btnOpenMKVMergeOutputPathDialog";
            this.btnOpenMKVMergeOutputPathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenMKVMergeOutputPathDialog.TabIndex = 4;
            this.btnOpenMKVMergeOutputPathDialog.UseVisualStyleBackColor = true;
            this.btnOpenMKVMergeOutputPathDialog.Click += new System.EventHandler(this.btnOpenMKVMergeOutputPathDialog_Click);
            // 
            // lblMKVMergeOutputPath
            // 
            this.lblMKVMergeOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMKVMergeOutputPath.AutoSize = true;
            this.lblMKVMergeOutputPath.Location = new System.Drawing.Point(3, 55);
            this.lblMKVMergeOutputPath.Name = "lblMKVMergeOutputPath";
            this.lblMKVMergeOutputPath.Size = new System.Drawing.Size(142, 13);
            this.lblMKVMergeOutputPath.TabIndex = 47;
            this.lblMKVMergeOutputPath.Text = "mkvmerge Output Directory :";
            // 
            // txtMKVMergeBatFilePath
            // 
            this.txtMKVMergeBatFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMKVMergeBatFilePath.Location = new System.Drawing.Point(191, 10);
            this.txtMKVMergeBatFilePath.Name = "txtMKVMergeBatFilePath";
            this.txtMKVMergeBatFilePath.ReadOnly = true;
            this.txtMKVMergeBatFilePath.Size = new System.Drawing.Size(586, 20);
            this.txtMKVMergeBatFilePath.TabIndex = 49;
            // 
            // btnOpenMKVMergeFilePathDialog
            // 
            this.btnOpenMKVMergeFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenMKVMergeFilePathDialog.Location = new System.Drawing.Point(783, 3);
            this.btnOpenMKVMergeFilePathDialog.Name = "btnOpenMKVMergeFilePathDialog";
            this.btnOpenMKVMergeFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenMKVMergeFilePathDialog.TabIndex = 3;
            this.btnOpenMKVMergeFilePathDialog.UseVisualStyleBackColor = true;
            this.btnOpenMKVMergeFilePathDialog.Click += new System.EventHandler(this.btnOpenMKVMergeFilePathDialog_Click);
            // 
            // btnEac3toOutputDirectory
            // 
            this.btnEac3toOutputDirectory.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnEac3toOutputDirectory.Location = new System.Drawing.Point(791, 152);
            this.btnEac3toOutputDirectory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnEac3toOutputDirectory.Name = "btnEac3toOutputDirectory";
            this.btnEac3toOutputDirectory.Size = new System.Drawing.Size(61, 33);
            this.btnEac3toOutputDirectory.TabIndex = 2;
            this.btnEac3toOutputDirectory.UseVisualStyleBackColor = true;
            this.btnEac3toOutputDirectory.Click += new System.EventHandler(this.btnEac3toOutputDirectory_Click);
            // 
            // lblEac3ToOutputDirectory
            // 
            this.lblEac3ToOutputDirectory.AutoSize = true;
            this.lblEac3ToOutputDirectory.Location = new System.Drawing.Point(3, 164);
            this.lblEac3ToOutputDirectory.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.lblEac3ToOutputDirectory.Name = "lblEac3ToOutputDirectory";
            this.lblEac3ToOutputDirectory.Size = new System.Drawing.Size(127, 13);
            this.lblEac3ToOutputDirectory.TabIndex = 52;
            this.lblEac3ToOutputDirectory.Text = "eac3to Output Directory*:";
            // 
            // tlpEac3toOutputDirectory
            // 
            this.tlpEac3toOutputDirectory.ColumnCount = 1;
            this.tlpEac3toOutputDirectory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEac3toOutputDirectory.Controls.Add(this.lblEac3ToDirectoryOutputCaption, 0, 1);
            this.tlpEac3toOutputDirectory.Controls.Add(this.txtEac3toOutputDirectory, 0, 0);
            this.tlpEac3toOutputDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEac3toOutputDirectory.Location = new System.Drawing.Point(286, 149);
            this.tlpEac3toOutputDirectory.Name = "tlpEac3toOutputDirectory";
            this.tlpEac3toOutputDirectory.RowCount = 2;
            this.tlpEac3toOutputDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEac3toOutputDirectory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEac3toOutputDirectory.Size = new System.Drawing.Size(499, 82);
            this.tlpEac3toOutputDirectory.TabIndex = 55;
            // 
            // lblEac3ToDirectoryOutputCaption
            // 
            this.lblEac3ToDirectoryOutputCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEac3ToDirectoryOutputCaption.AutoSize = true;
            this.lblEac3ToDirectoryOutputCaption.Location = new System.Drawing.Point(3, 55);
            this.lblEac3ToDirectoryOutputCaption.Name = "lblEac3ToDirectoryOutputCaption";
            this.lblEac3ToDirectoryOutputCaption.Size = new System.Drawing.Size(42, 13);
            this.lblEac3ToDirectoryOutputCaption.TabIndex = 53;
            this.lblEac3ToDirectoryOutputCaption.Text = "Output:";
            // 
            // txtEac3toOutputDirectory
            // 
            this.txtEac3toOutputDirectory.Location = new System.Drawing.Point(3, 13);
            this.txtEac3toOutputDirectory.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.txtEac3toOutputDirectory.Name = "txtEac3toOutputDirectory";
            this.txtEac3toOutputDirectory.ReadOnly = true;
            this.txtEac3toOutputDirectory.Size = new System.Drawing.Size(491, 20);
            this.txtEac3toOutputDirectory.TabIndex = 48;
            // 
            // gbDiscSummary
            // 
            this.gbDiscSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScreen.SetColumnSpan(this.gbDiscSummary, 2);
            this.gbDiscSummary.Controls.Add(this.tlpDiscSummaries);
            this.gbDiscSummary.Location = new System.Drawing.Point(3, 548);
            this.gbDiscSummary.Name = "gbDiscSummary";
            this.gbDiscSummary.Size = new System.Drawing.Size(1401, 194);
            this.gbDiscSummary.TabIndex = 40;
            this.gbDiscSummary.TabStop = false;
            this.gbDiscSummary.Text = "Disc Summary";
            // 
            // tlpDiscSummaries
            // 
            this.tlpDiscSummaries.ColumnCount = 1;
            this.tlpDiscSummaries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscSummaries.Controls.Add(this.dgvBluRaySummary, 0, 0);
            this.tlpDiscSummaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDiscSummaries.Location = new System.Drawing.Point(3, 16);
            this.tlpDiscSummaries.Name = "tlpDiscSummaries";
            this.tlpDiscSummaries.RowCount = 1;
            this.tlpDiscSummaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscSummaries.Size = new System.Drawing.Size(1395, 175);
            this.tlpDiscSummaries.TabIndex = 0;
            // 
            // dgvBluRaySummary
            // 
            this.dgvBluRaySummary.AllowUserToAddRows = false;
            this.dgvBluRaySummary.AllowUserToDeleteRows = false;
            this.dgvBluRaySummary.AllowUserToOrderColumns = true;
            this.dgvBluRaySummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvBluRaySummary.Location = new System.Drawing.Point(3, 3);
            this.dgvBluRaySummary.Name = "dgvBluRaySummary";
            this.dgvBluRaySummary.Size = new System.Drawing.Size(1389, 169);
            this.dgvBluRaySummary.TabIndex = 18;
            this.dgvBluRaySummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellClick);
            this.dgvBluRaySummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellDoubleClick);
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
            // gbDisc
            // 
            this.gbDisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScreen.SetColumnSpan(this.gbDisc, 2);
            this.gbDisc.Controls.Add(this.tlpDiscs);
            this.gbDisc.Location = new System.Drawing.Point(3, 353);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(1401, 180);
            this.gbDisc.TabIndex = 39;
            this.gbDisc.TabStop = false;
            this.gbDisc.Text = "Drag N Drop Blu-ray Folders";
            // 
            // tlpDiscs
            // 
            this.tlpDiscs.ColumnCount = 1;
            this.tlpDiscs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscs.Controls.Add(this.dgvBluRayDiscInfo, 0, 0);
            this.tlpDiscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDiscs.Location = new System.Drawing.Point(3, 16);
            this.tlpDiscs.Name = "tlpDiscs";
            this.tlpDiscs.RowCount = 1;
            this.tlpDiscs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscs.Size = new System.Drawing.Size(1395, 161);
            this.tlpDiscs.TabIndex = 0;
            // 
            // dgvBluRayDiscInfo
            // 
            this.dgvBluRayDiscInfo.AllowDrop = true;
            this.dgvBluRayDiscInfo.AllowUserToAddRows = false;
            this.dgvBluRayDiscInfo.AllowUserToDeleteRows = false;
            this.dgvBluRayDiscInfo.AllowUserToOrderColumns = true;
            this.dgvBluRayDiscInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBluRayDiscInfo.AutoGenerateColumns = false;
            this.dgvBluRayDiscInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRayDiscInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isSelectedDataGridViewCheckBoxColumn1,
            this.discNameDataGridViewTextBoxColumn,
            this.bluRayPathDataGridViewTextBoxColumn});
            this.dgvBluRayDiscInfo.DataSource = this.bsBluRayDiscInfo;
            this.dgvBluRayDiscInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvBluRayDiscInfo.Name = "dgvBluRayDiscInfo";
            this.dgvBluRayDiscInfo.Size = new System.Drawing.Size(1389, 155);
            this.dgvBluRayDiscInfo.TabIndex = 17;
            this.dgvBluRayDiscInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayDiscInfo_CellClick);
            this.dgvBluRayDiscInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragDrop);
            this.dgvBluRayDiscInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragEnter);
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
            // tlpUpperRight
            // 
            this.tlpUpperRight.ColumnCount = 2;
            this.tlpUpperRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.288499F));
            this.tlpUpperRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.7115F));
            this.tlpUpperRight.Controls.Add(this.chkExtractForRemux, 0, 0);
            this.tlpUpperRight.Controls.Add(this.gbExtractForRemux, 1, 0);
            this.tlpUpperRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpperRight.Location = new System.Drawing.Point(869, 3);
            this.tlpUpperRight.Name = "tlpUpperRight";
            this.tlpUpperRight.RowCount = 1;
            this.tlpUpperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpperRight.Size = new System.Drawing.Size(535, 344);
            this.tlpUpperRight.TabIndex = 41;
            // 
            // chkExtractForRemux
            // 
            this.chkExtractForRemux.AutoSize = true;
            this.chkExtractForRemux.Location = new System.Drawing.Point(3, 3);
            this.chkExtractForRemux.Name = "chkExtractForRemux";
            this.chkExtractForRemux.Size = new System.Drawing.Size(15, 14);
            this.chkExtractForRemux.TabIndex = 5;
            this.chkExtractForRemux.UseVisualStyleBackColor = true;
            this.chkExtractForRemux.CheckedChanged += new System.EventHandler(this.chkExtractForRemux_CheckedChanged);
            // 
            // gbExtractForRemux
            // 
            this.gbExtractForRemux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExtractForRemux.Controls.Add(this.tlpRemuxTemplate);
            this.gbExtractForRemux.Enabled = false;
            this.gbExtractForRemux.Location = new System.Drawing.Point(25, 3);
            this.gbExtractForRemux.Name = "gbExtractForRemux";
            this.gbExtractForRemux.Size = new System.Drawing.Size(507, 335);
            this.gbExtractForRemux.TabIndex = 42;
            this.gbExtractForRemux.TabStop = false;
            this.gbExtractForRemux.Text = "Extract for Remux Naming Convention";
            // 
            // tlpRemuxTemplate
            // 
            this.tlpRemuxTemplate.ColumnCount = 4;
            this.tlpRemuxTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRemuxTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpRemuxTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRemuxTemplate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tlpRemuxTemplate.Controls.Add(this.chkRemuxUsePeriodsInFileName, 0, 9);
            this.tlpRemuxTemplate.Controls.Add(this.lblRemuxSeriesName, 0, 3);
            this.tlpRemuxTemplate.Controls.Add(this.cbRemuxVideoFormat, 3, 8);
            this.tlpRemuxTemplate.Controls.Add(this.txtRemuxSeriesName, 1, 3);
            this.tlpRemuxTemplate.Controls.Add(this.label9, 2, 8);
            this.tlpRemuxTemplate.Controls.Add(this.cbRemuxMedium, 1, 8);
            this.tlpRemuxTemplate.Controls.Add(this.label8, 0, 8);
            this.tlpRemuxTemplate.Controls.Add(this.txtRemuxTag, 3, 7);
            this.tlpRemuxTemplate.Controls.Add(this.label6, 2, 7);
            this.tlpRemuxTemplate.Controls.Add(this.txtRemuxAudioType, 1, 7);
            this.tlpRemuxTemplate.Controls.Add(this.label5, 0, 7);
            this.tlpRemuxTemplate.Controls.Add(this.lblRemuxNamingConventionCurrentTemplateExample, 0, 0);
            this.tlpRemuxTemplate.Controls.Add(this.chkIsThisRemuxForAMovie, 0, 1);
            this.tlpRemuxTemplate.Controls.Add(this.lblRemuxForMovieWarning, 0, 2);
            this.tlpRemuxTemplate.Controls.Add(this.label2, 0, 4);
            this.tlpRemuxTemplate.Controls.Add(this.txtRemuxSeasonNumber, 1, 4);
            this.tlpRemuxTemplate.Controls.Add(this.label3, 2, 4);
            this.tlpRemuxTemplate.Controls.Add(this.txtRemuxSeasonYear, 3, 4);
            this.tlpRemuxTemplate.Controls.Add(this.label4, 0, 5);
            this.tlpRemuxTemplate.Controls.Add(this.cbRemuxVideoResolution, 1, 5);
            this.tlpRemuxTemplate.Controls.Add(this.label1, 0, 6);
            this.tlpRemuxTemplate.Controls.Add(this.cbRemuxCountry, 1, 6);
            this.tlpRemuxTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRemuxTemplate.Location = new System.Drawing.Point(3, 16);
            this.tlpRemuxTemplate.Name = "tlpRemuxTemplate";
            this.tlpRemuxTemplate.RowCount = 10;
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.22951F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.77049F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRemuxTemplate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpRemuxTemplate.Size = new System.Drawing.Size(501, 316);
            this.tlpRemuxTemplate.TabIndex = 0;
            // 
            // chkRemuxUsePeriodsInFileName
            // 
            this.chkRemuxUsePeriodsInFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRemuxUsePeriodsInFileName.AutoSize = true;
            this.tlpRemuxTemplate.SetColumnSpan(this.chkRemuxUsePeriodsInFileName, 4);
            this.chkRemuxUsePeriodsInFileName.Location = new System.Drawing.Point(3, 291);
            this.chkRemuxUsePeriodsInFileName.Name = "chkRemuxUsePeriodsInFileName";
            this.chkRemuxUsePeriodsInFileName.Size = new System.Drawing.Size(147, 17);
            this.chkRemuxUsePeriodsInFileName.TabIndex = 16;
            this.chkRemuxUsePeriodsInFileName.Text = "User Periods in File Name";
            this.chkRemuxUsePeriodsInFileName.UseVisualStyleBackColor = true;
            this.chkRemuxUsePeriodsInFileName.CheckedChanged += new System.EventHandler(this.chkRemuxUsePeriodsInFileName_CheckedChanged);
            // 
            // lblRemuxSeriesName
            // 
            this.lblRemuxSeriesName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemuxSeriesName.AutoSize = true;
            this.lblRemuxSeriesName.Location = new System.Drawing.Point(3, 87);
            this.lblRemuxSeriesName.Name = "lblRemuxSeriesName";
            this.lblRemuxSeriesName.Size = new System.Drawing.Size(77, 13);
            this.lblRemuxSeriesName.TabIndex = 0;
            this.lblRemuxSeriesName.Text = "Series Name *:";
            // 
            // cbRemuxVideoFormat
            // 
            this.cbRemuxVideoFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRemuxVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxVideoFormat.FormattingEnabled = true;
            this.cbRemuxVideoFormat.ItemHeight = 13;
            this.cbRemuxVideoFormat.Items.AddRange(new object[] {
            "",
            "AVC",
            "H.264",
            "HEVC",
            "MPEG-2",
            "VC-1",
            "XviD"});
            this.cbRemuxVideoFormat.Location = new System.Drawing.Point(265, 256);
            this.cbRemuxVideoFormat.Name = "cbRemuxVideoFormat";
            this.cbRemuxVideoFormat.Size = new System.Drawing.Size(113, 21);
            this.cbRemuxVideoFormat.TabIndex = 15;
            this.cbRemuxVideoFormat.SelectedIndexChanged += new System.EventHandler(this.cbRemuxVideoFormat_SelectedIndexChanged);
            // 
            // txtRemuxSeriesName
            // 
            this.txtRemuxSeriesName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpRemuxTemplate.SetColumnSpan(this.txtRemuxSeriesName, 3);
            this.txtRemuxSeriesName.Location = new System.Drawing.Point(103, 83);
            this.txtRemuxSeriesName.Name = "txtRemuxSeriesName";
            this.txtRemuxSeriesName.Size = new System.Drawing.Size(395, 20);
            this.txtRemuxSeriesName.TabIndex = 7;
            this.txtRemuxSeriesName.TextChanged += new System.EventHandler(this.txtRemuxSeriesName_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Video Format:";
            // 
            // cbRemuxMedium
            // 
            this.cbRemuxMedium.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRemuxMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxMedium.FormattingEnabled = true;
            this.cbRemuxMedium.ItemHeight = 13;
            this.cbRemuxMedium.Items.AddRange(new object[] {
            "",
            "Remux"});
            this.cbRemuxMedium.Location = new System.Drawing.Point(103, 256);
            this.cbRemuxMedium.Name = "cbRemuxMedium";
            this.cbRemuxMedium.Size = new System.Drawing.Size(76, 21);
            this.cbRemuxMedium.TabIndex = 14;
            this.cbRemuxMedium.SelectedIndexChanged += new System.EventHandler(this.cbRemuxMedium_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Medium:";
            // 
            // txtRemuxTag
            // 
            this.txtRemuxTag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemuxTag.Location = new System.Drawing.Point(265, 223);
            this.txtRemuxTag.Name = "txtRemuxTag";
            this.txtRemuxTag.Size = new System.Drawing.Size(175, 20);
            this.txtRemuxTag.TabIndex = 13;
            this.txtRemuxTag.TextChanged += new System.EventHandler(this.txtRemuxTag_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tag:";
            // 
            // txtRemuxAudioType
            // 
            this.txtRemuxAudioType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemuxAudioType.Location = new System.Drawing.Point(103, 223);
            this.txtRemuxAudioType.Name = "txtRemuxAudioType";
            this.txtRemuxAudioType.Size = new System.Drawing.Size(76, 20);
            this.txtRemuxAudioType.TabIndex = 12;
            this.txtRemuxAudioType.TextChanged += new System.EventHandler(this.txtRemuxAudioType_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Audio Type:";
            // 
            // lblRemuxNamingConventionCurrentTemplateExample
            // 
            this.lblRemuxNamingConventionCurrentTemplateExample.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemuxNamingConventionCurrentTemplateExample.AutoSize = true;
            this.tlpRemuxTemplate.SetColumnSpan(this.lblRemuxNamingConventionCurrentTemplateExample, 4);
            this.lblRemuxNamingConventionCurrentTemplateExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemuxNamingConventionCurrentTemplateExample.Location = new System.Drawing.Point(3, 11);
            this.lblRemuxNamingConventionCurrentTemplateExample.Name = "lblRemuxNamingConventionCurrentTemplateExample";
            this.lblRemuxNamingConventionCurrentTemplateExample.Size = new System.Drawing.Size(403, 13);
            this.lblRemuxNamingConventionCurrentTemplateExample.TabIndex = 14;
            this.lblRemuxNamingConventionCurrentTemplateExample.Text = "Example: BatchGuy 1978 S01E01 Episode 1 1080p  Remux AVC TrueHD -Tag.mkv";
            // 
            // chkIsThisRemuxForAMovie
            // 
            this.chkIsThisRemuxForAMovie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsThisRemuxForAMovie.AutoSize = true;
            this.tlpRemuxTemplate.SetColumnSpan(this.chkIsThisRemuxForAMovie, 4);
            this.chkIsThisRemuxForAMovie.Location = new System.Drawing.Point(3, 40);
            this.chkIsThisRemuxForAMovie.Name = "chkIsThisRemuxForAMovie";
            this.chkIsThisRemuxForAMovie.Size = new System.Drawing.Size(151, 17);
            this.chkIsThisRemuxForAMovie.TabIndex = 6;
            this.chkIsThisRemuxForAMovie.Text = "Is this Remux for a Movie?";
            this.chkIsThisRemuxForAMovie.UseVisualStyleBackColor = true;
            this.chkIsThisRemuxForAMovie.CheckedChanged += new System.EventHandler(this.chkIsThisRemuxForAMovie_CheckedChanged);
            // 
            // lblRemuxForMovieWarning
            // 
            this.lblRemuxForMovieWarning.AutoSize = true;
            this.tlpRemuxTemplate.SetColumnSpan(this.lblRemuxForMovieWarning, 4);
            this.lblRemuxForMovieWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemuxForMovieWarning.ForeColor = System.Drawing.Color.Red;
            this.lblRemuxForMovieWarning.Location = new System.Drawing.Point(3, 62);
            this.lblRemuxForMovieWarning.Name = "lblRemuxForMovieWarning";
            this.lblRemuxForMovieWarning.Size = new System.Drawing.Size(409, 13);
            this.lblRemuxForMovieWarning.TabIndex = 66;
            this.lblRemuxForMovieWarning.Text = "(Make sure a disc summary row is highlighed before entering movie remux informati" +
    "on)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Season#:";
            // 
            // txtRemuxSeasonNumber
            // 
            this.txtRemuxSeasonNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemuxSeasonNumber.Location = new System.Drawing.Point(103, 118);
            this.txtRemuxSeasonNumber.Name = "txtRemuxSeasonNumber";
            this.txtRemuxSeasonNumber.Size = new System.Drawing.Size(76, 20);
            this.txtRemuxSeasonNumber.TabIndex = 8;
            this.txtRemuxSeasonNumber.TextChanged += new System.EventHandler(this.txtSeasonNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // txtRemuxSeasonYear
            // 
            this.txtRemuxSeasonYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemuxSeasonYear.Location = new System.Drawing.Point(265, 118);
            this.txtRemuxSeasonYear.Name = "txtRemuxSeasonYear";
            this.txtRemuxSeasonYear.Size = new System.Drawing.Size(82, 20);
            this.txtRemuxSeasonYear.TabIndex = 9;
            this.txtRemuxSeasonYear.TextChanged += new System.EventHandler(this.txtRemuxSeasonYear_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resolution:";
            // 
            // cbRemuxVideoResolution
            // 
            this.cbRemuxVideoResolution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRemuxVideoResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxVideoResolution.FormattingEnabled = true;
            this.cbRemuxVideoResolution.ItemHeight = 13;
            this.cbRemuxVideoResolution.Items.AddRange(new object[] {
            "",
            "720p",
            "1080i",
            "1080p"});
            this.cbRemuxVideoResolution.Location = new System.Drawing.Point(103, 150);
            this.cbRemuxVideoResolution.Name = "cbRemuxVideoResolution";
            this.cbRemuxVideoResolution.Size = new System.Drawing.Size(76, 21);
            this.cbRemuxVideoResolution.TabIndex = 10;
            this.cbRemuxVideoResolution.SelectedIndexChanged += new System.EventHandler(this.cbRemuxVideoResolution_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Country";
            // 
            // cbRemuxCountry
            // 
            this.cbRemuxCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpRemuxTemplate.SetColumnSpan(this.cbRemuxCountry, 3);
            this.cbRemuxCountry.DataSource = this.bsCountries;
            this.cbRemuxCountry.DisplayMember = "Name";
            this.cbRemuxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemuxCountry.FormattingEnabled = true;
            this.cbRemuxCountry.Location = new System.Drawing.Point(103, 186);
            this.cbRemuxCountry.Name = "cbRemuxCountry";
            this.cbRemuxCountry.Size = new System.Drawing.Size(384, 21);
            this.cbRemuxCountry.TabIndex = 11;
            this.cbRemuxCountry.ValueMember = "Value";
            this.cbRemuxCountry.SelectedIndexChanged += new System.EventHandler(this.cbRemuxCountry_SelectedIndexChanged);
            // 
            // bsCountries
            // 
            this.bsCountries.AllowNew = false;
            this.bsCountries.DataSource = typeof(BatchGuy.App.Shared.Models.CountryCodeItem);
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
            this.menuStrip1.Size = new System.Drawing.Size(1419, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveSettingsFileToolStripMenuItem
            // 
            this.saveSettingsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.createEac3toBatchFileToolStripMenuItem,
            this.createMkvmergeBatchFileToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
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
            // createEac3toBatchFileToolStripMenuItem
            // 
            this.createEac3toBatchFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createEac3toBatchFileToolStripMenuItem.Name = "createEac3toBatchFileToolStripMenuItem";
            this.createEac3toBatchFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.createEac3toBatchFileToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createEac3toBatchFileToolStripMenuItem.Text = "Create eac3to Batch File";
            this.createEac3toBatchFileToolStripMenuItem.Click += new System.EventHandler(this.createEac3toBatchFileToolStripMenuItem_Click);
            // 
            // createMkvmergeBatchFileToolStripMenuItem
            // 
            this.createMkvmergeBatchFileToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.Fasticon_Green_Ville_2_File;
            this.createMkvmergeBatchFileToolStripMenuItem.Name = "createMkvmergeBatchFileToolStripMenuItem";
            this.createMkvmergeBatchFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.createMkvmergeBatchFileToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createMkvmergeBatchFileToolStripMenuItem.Text = "Create mkvmerge Batch File";
            this.createMkvmergeBatchFileToolStripMenuItem.Click += new System.EventHandler(this.createMkvmergeBatchFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::BatchGuy.App.Properties.Resources.close_red;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.lblVersion.Location = new System.Drawing.Point(3, 796);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 32;
            this.lblVersion.Text = "Version";
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.Controls.Add(this.lblVersion, 0, 1);
            this.tlpForm.Controls.Add(this.gbScreen, 0, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 24);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 2;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.57576F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.424242F));
            this.tlpForm.Size = new System.Drawing.Size(1419, 813);
            this.tlpForm.TabIndex = 33;
            // 
            // CreateEAC3ToBatchForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 837);
            this.Controls.Add(this.tlpForm);
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
            this.tlpScreen.ResumeLayout(false);
            this.tlpUpperLeft.ResumeLayout(false);
            this.tlpUpperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMKVMergeInfo.ResumeLayout(false);
            this.tlpMKVMergeInfo.ResumeLayout(false);
            this.tlpMKVMergeInfo.PerformLayout();
            this.tlpEac3toOutputDirectory.ResumeLayout(false);
            this.tlpEac3toOutputDirectory.PerformLayout();
            this.gbDiscSummary.ResumeLayout(false);
            this.tlpDiscSummaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).EndInit();
            this.gbDisc.ResumeLayout(false);
            this.tlpDiscs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).EndInit();
            this.tlpUpperRight.ResumeLayout(false);
            this.tlpUpperRight.PerformLayout();
            this.gbExtractForRemux.ResumeLayout(false);
            this.tlpRemuxTemplate.ResumeLayout(false);
            this.tlpRemuxTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadSummary;
        private System.Windows.Forms.GroupBox gbScreen;
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
        private System.Windows.Forms.Label lblRemuxSeriesName;
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
        private System.Windows.Forms.Label lblRemuxNamingConventionCurrentTemplateExample;
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
        private System.Windows.Forms.Button btnOpenMKVMergeFilePathDialog;
        private System.Windows.Forms.TextBox txtMKVMergeBatFilePath;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker bgwMkvMergeWriteBatchFile;
        private System.Windows.Forms.GroupBox gbMKVMergeInfo;
        private System.Windows.Forms.CheckBox chkRemuxUsePeriodsInFileName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createEac3toBatchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMkvmergeBatchFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpScreen;
        private System.Windows.Forms.TableLayoutPanel tlpUpperLeft;
        private System.Windows.Forms.TableLayoutPanel tlpMKVMergeInfo;
        private System.Windows.Forms.TableLayoutPanel tlpDiscSummaries;
        private System.Windows.Forms.TableLayoutPanel tlpDiscs;
        private System.Windows.Forms.TableLayoutPanel tlpUpperRight;
        private System.Windows.Forms.TableLayoutPanel tlpRemuxTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkIsThisRemuxForAMovie;
        private System.Windows.Forms.Label lblEac3ToOutputDirectory;
        private System.Windows.Forms.Button btnEac3toOutputDirectory;
        private System.Windows.Forms.ComboBox cbEac3ToOutputDirectoryType;
        private System.Windows.Forms.TableLayoutPanel tlpEac3toOutputDirectory;
        private System.Windows.Forms.Label lblEac3ToDirectoryOutputCaption;
        private System.Windows.Forms.TextBox txtEac3toOutputDirectory;
        private System.Windows.Forms.Label lblRemuxForMovieWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRemuxCountry;
        private System.Windows.Forms.BindingSource bsCountries;
    }
}