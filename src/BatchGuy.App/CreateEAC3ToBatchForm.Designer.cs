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
            this.btnAddBluRayDisc = new System.Windows.Forms.Button();
            this.fbdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgwEac3toLoadSummary = new System.ComponentModel.BackgroundWorker();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.btnWriteToBatFile = new System.Windows.Forms.Button();
            this.gbDiscSummary = new System.Windows.Forms.GroupBox();
            this.dgvBluRaySummary = new System.Windows.Forms.DataGridView();
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayTitleInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRaySummaryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.dgvBluRayDiscInfo = new System.Windows.Forms.DataGridView();
            this.isSelectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAC3ToConfigurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayDiscInfo = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpenBatchFilePathDialog = new System.Windows.Forms.Button();
            this.btnOpenEac3ToFileDialog = new System.Windows.Forms.Button();
            this.btnOpenBluRayPathDialog = new System.Windows.Forms.Button();
            this.txtBatFilePath = new System.Windows.Forms.TextBox();
            this.lblBatchFilePath = new System.Windows.Forms.Label();
            this.txtBluRayPath = new System.Windows.Forms.TextBox();
            this.lblBluRayFolderPath = new System.Windows.Forms.Label();
            this.txtEAC3ToPath = new System.Windows.Forms.TextBox();
            this.lblEac3ToExePath = new System.Windows.Forms.Label();
            this.bgwEac3toWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.gbScreen.SuspendLayout();
            this.gbDiscSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).BeginInit();
            this.gbDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBluRayDisc
            // 
            this.btnAddBluRayDisc.Location = new System.Drawing.Point(1134, 122);
            this.btnAddBluRayDisc.Name = "btnAddBluRayDisc";
            this.btnAddBluRayDisc.Size = new System.Drawing.Size(132, 33);
            this.btnAddBluRayDisc.TabIndex = 24;
            this.btnAddBluRayDisc.Text = "Add Blu-ray Disc";
            this.btnAddBluRayDisc.UseVisualStyleBackColor = true;
            this.btnAddBluRayDisc.Click += new System.EventHandler(this.btnAddBluRayDisc_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // bgwEac3toLoadSummary
            // 
            this.bgwEac3toLoadSummary.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3to_DoWork);
            this.bgwEac3toLoadSummary.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3to_RunWorkerCompleted);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.btnWriteToBatFile);
            this.gbScreen.Controls.Add(this.gbDiscSummary);
            this.gbScreen.Controls.Add(this.gbDisc);
            this.gbScreen.Controls.Add(this.btnOpenBatchFilePathDialog);
            this.gbScreen.Controls.Add(this.btnOpenEac3ToFileDialog);
            this.gbScreen.Controls.Add(this.btnOpenBluRayPathDialog);
            this.gbScreen.Controls.Add(this.txtBatFilePath);
            this.gbScreen.Controls.Add(this.lblBatchFilePath);
            this.gbScreen.Controls.Add(this.txtBluRayPath);
            this.gbScreen.Controls.Add(this.lblBluRayFolderPath);
            this.gbScreen.Controls.Add(this.txtEAC3ToPath);
            this.gbScreen.Controls.Add(this.lblEac3ToExePath);
            this.gbScreen.Controls.Add(this.btnAddBluRayDisc);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1284, 678);
            this.gbScreen.TabIndex = 30;
            this.gbScreen.TabStop = false;
            // 
            // btnWriteToBatFile
            // 
            this.btnWriteToBatFile.Location = new System.Drawing.Point(1133, 625);
            this.btnWriteToBatFile.Name = "btnWriteToBatFile";
            this.btnWriteToBatFile.Size = new System.Drawing.Size(133, 40);
            this.btnWriteToBatFile.TabIndex = 41;
            this.btnWriteToBatFile.Text = "Create eac3to Batch File";
            this.btnWriteToBatFile.UseVisualStyleBackColor = true;
            this.btnWriteToBatFile.Click += new System.EventHandler(this.btnWriteToBatFile_Click);
            // 
            // gbDiscSummary
            // 
            this.gbDiscSummary.Controls.Add(this.dgvBluRaySummary);
            this.gbDiscSummary.Location = new System.Drawing.Point(14, 376);
            this.gbDiscSummary.Name = "gbDiscSummary";
            this.gbDiscSummary.Size = new System.Drawing.Size(1253, 243);
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
            this.idDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn,
            this.headerTextDataGridViewTextBoxColumn,
            this.detailTextDataGridViewTextBoxColumn,
            this.bluRayTitleInfoDataGridViewTextBoxColumn});
            this.dgvBluRaySummary.DataSource = this.bsBluRaySummaryInfo;
            this.dgvBluRaySummary.Location = new System.Drawing.Point(6, 19);
            this.dgvBluRaySummary.Name = "dgvBluRaySummary";
            this.dgvBluRaySummary.Size = new System.Drawing.Size(1241, 208);
            this.dgvBluRaySummary.TabIndex = 23;
            this.dgvBluRaySummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellClick);
            this.dgvBluRaySummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellDoubleClick);
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            this.isSelectedDataGridViewCheckBoxColumn.Width = 70;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "EpisodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Episode#";
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            this.episodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.episodeNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // headerTextDataGridViewTextBoxColumn
            // 
            this.headerTextDataGridViewTextBoxColumn.DataPropertyName = "HeaderText";
            this.headerTextDataGridViewTextBoxColumn.HeaderText = "Header";
            this.headerTextDataGridViewTextBoxColumn.Name = "headerTextDataGridViewTextBoxColumn";
            this.headerTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.headerTextDataGridViewTextBoxColumn.Width = 400;
            // 
            // detailTextDataGridViewTextBoxColumn
            // 
            this.detailTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailTextDataGridViewTextBoxColumn.DataPropertyName = "DetailText";
            this.detailTextDataGridViewTextBoxColumn.HeaderText = "Detail";
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
            this.gbDisc.Controls.Add(this.dgvBluRayDiscInfo);
            this.gbDisc.Location = new System.Drawing.Point(14, 161);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(1253, 194);
            this.gbDisc.TabIndex = 39;
            this.gbDisc.TabStop = false;
            this.gbDisc.Text = "Disc";
            // 
            // dgvBluRayDiscInfo
            // 
            this.dgvBluRayDiscInfo.AllowUserToAddRows = false;
            this.dgvBluRayDiscInfo.AllowUserToDeleteRows = false;
            this.dgvBluRayDiscInfo.AllowUserToOrderColumns = true;
            this.dgvBluRayDiscInfo.AutoGenerateColumns = false;
            this.dgvBluRayDiscInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBluRayDiscInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn1,
            this.idDataGridViewTextBoxColumn1,
            this.eAC3ToConfigurationDataGridViewTextBoxColumn,
            this.discNameDataGridViewTextBoxColumn});
            this.dgvBluRayDiscInfo.DataSource = this.bsBluRayDiscInfo;
            this.dgvBluRayDiscInfo.Location = new System.Drawing.Point(6, 22);
            this.dgvBluRayDiscInfo.Name = "dgvBluRayDiscInfo";
            this.dgvBluRayDiscInfo.Size = new System.Drawing.Size(1241, 150);
            this.dgvBluRayDiscInfo.TabIndex = 24;
            this.dgvBluRayDiscInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayDiscInfo_CellClick);
            // 
            // isSelectedDataGridViewCheckBoxColumn1
            // 
            this.isSelectedDataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn1.Name = "isSelectedDataGridViewCheckBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // eAC3ToConfigurationDataGridViewTextBoxColumn
            // 
            this.eAC3ToConfigurationDataGridViewTextBoxColumn.DataPropertyName = "EAC3ToConfiguration";
            this.eAC3ToConfigurationDataGridViewTextBoxColumn.HeaderText = "EAC3ToConfiguration";
            this.eAC3ToConfigurationDataGridViewTextBoxColumn.Name = "eAC3ToConfigurationDataGridViewTextBoxColumn";
            this.eAC3ToConfigurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.eAC3ToConfigurationDataGridViewTextBoxColumn.Visible = false;
            // 
            // discNameDataGridViewTextBoxColumn
            // 
            this.discNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discNameDataGridViewTextBoxColumn.DataPropertyName = "DiscName";
            this.discNameDataGridViewTextBoxColumn.HeaderText = "Disc Name";
            this.discNameDataGridViewTextBoxColumn.Name = "discNameDataGridViewTextBoxColumn";
            this.discNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBluRayDiscInfo
            // 
            this.bsBluRayDiscInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayDiscInfo);
            // 
            // btnOpenBatchFilePathDialog
            // 
            this.btnOpenBatchFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenBatchFilePathDialog.Location = new System.Drawing.Point(869, 91);
            this.btnOpenBatchFilePathDialog.Name = "btnOpenBatchFilePathDialog";
            this.btnOpenBatchFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenBatchFilePathDialog.TabIndex = 38;
            this.btnOpenBatchFilePathDialog.UseVisualStyleBackColor = true;
            this.btnOpenBatchFilePathDialog.Click += new System.EventHandler(this.btnOpenBatchFilePathDialog_Click);
            // 
            // btnOpenEac3ToFileDialog
            // 
            this.btnOpenEac3ToFileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenEac3ToFileDialog.Location = new System.Drawing.Point(869, 52);
            this.btnOpenEac3ToFileDialog.Name = "btnOpenEac3ToFileDialog";
            this.btnOpenEac3ToFileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenEac3ToFileDialog.TabIndex = 37;
            this.btnOpenEac3ToFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenEac3ToFileDialog.Click += new System.EventHandler(this.btnOpenEac3ToFileDialog_Click);
            // 
            // btnOpenBluRayPathDialog
            // 
            this.btnOpenBluRayPathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenBluRayPathDialog.Location = new System.Drawing.Point(869, 14);
            this.btnOpenBluRayPathDialog.Name = "btnOpenBluRayPathDialog";
            this.btnOpenBluRayPathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenBluRayPathDialog.TabIndex = 36;
            this.btnOpenBluRayPathDialog.UseVisualStyleBackColor = true;
            this.btnOpenBluRayPathDialog.Click += new System.EventHandler(this.btnOpenBluRayPathDialog_Click);
            // 
            // txtBatFilePath
            // 
            this.txtBatFilePath.Location = new System.Drawing.Point(138, 104);
            this.txtBatFilePath.Name = "txtBatFilePath";
            this.txtBatFilePath.ReadOnly = true;
            this.txtBatFilePath.Size = new System.Drawing.Size(725, 20);
            this.txtBatFilePath.TabIndex = 33;
            this.txtBatFilePath.Text = "C:\\temp\\My Encodes\\Blu-ray";
            // 
            // lblBatchFilePath
            // 
            this.lblBatchFilePath.AutoSize = true;
            this.lblBatchFilePath.Location = new System.Drawing.Point(26, 111);
            this.lblBatchFilePath.Name = "lblBatchFilePath";
            this.lblBatchFilePath.Size = new System.Drawing.Size(99, 13);
            this.lblBatchFilePath.TabIndex = 35;
            this.lblBatchFilePath.Text = "Batch File Directory";
            // 
            // txtBluRayPath
            // 
            this.txtBluRayPath.Location = new System.Drawing.Point(136, 27);
            this.txtBluRayPath.Name = "txtBluRayPath";
            this.txtBluRayPath.ReadOnly = true;
            this.txtBluRayPath.Size = new System.Drawing.Size(727, 20);
            this.txtBluRayPath.TabIndex = 30;
            this.txtBluRayPath.Text = "C:\\temp\\My Encodes\\Blu-ray\\DISC\\D1";
            // 
            // lblBluRayFolderPath
            // 
            this.lblBluRayFolderPath.AutoSize = true;
            this.lblBluRayFolderPath.Location = new System.Drawing.Point(26, 34);
            this.lblBluRayFolderPath.Name = "lblBluRayFolderPath";
            this.lblBluRayFolderPath.Size = new System.Drawing.Size(84, 13);
            this.lblBluRayFolderPath.TabIndex = 34;
            this.lblBluRayFolderPath.Text = "Blu-ray Directory";
            // 
            // txtEAC3ToPath
            // 
            this.txtEAC3ToPath.Location = new System.Drawing.Point(136, 65);
            this.txtEAC3ToPath.Name = "txtEAC3ToPath";
            this.txtEAC3ToPath.ReadOnly = true;
            this.txtEAC3ToPath.Size = new System.Drawing.Size(727, 20);
            this.txtEAC3ToPath.TabIndex = 32;
            this.txtEAC3ToPath.Text = "C:\\exe\\eac3to\\eac3to.exe";
            // 
            // lblEac3ToExePath
            // 
            this.lblEac3ToExePath.AutoSize = true;
            this.lblEac3ToExePath.Location = new System.Drawing.Point(26, 72);
            this.lblEac3ToExePath.Name = "lblEac3ToExePath";
            this.lblEac3ToExePath.Size = new System.Drawing.Size(64, 13);
            this.lblEac3ToExePath.TabIndex = 31;
            this.lblEac3ToExePath.Text = "eac3To.exe";
            // 
            // bgwEac3toWriteBatchFile
            // 
            this.bgwEac3toWriteBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toWriteBatchFile_DoWork);
            this.bgwEac3toWriteBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toWriteBatchFile_RunWorkerCompleted);
            // 
            // CreateEAC3ToBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 702);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CreateEAC3ToBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create eac3to Batch File";
            this.Load += new System.EventHandler(this.CreateEAC3ToBatchForm_Load);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.gbDiscSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).EndInit();
            this.gbDisc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn ignoreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource bsBluRayDiscInfo;
        private System.Windows.Forms.Button btnAddBluRayDisc;
        private System.Windows.Forms.BindingSource bsBluRaySummaryInfo;
        private System.Windows.Forms.FolderBrowserDialog fbdDialog;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.ComponentModel.BackgroundWorker bgwEac3toLoadSummary;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.Button btnWriteToBatFile;
        private System.Windows.Forms.GroupBox gbDiscSummary;
        private System.Windows.Forms.DataGridView dgvBluRaySummary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bluRayTitleInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbDisc;
        private System.Windows.Forms.DataGridView dgvBluRayDiscInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAC3ToConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOpenBatchFilePathDialog;
        private System.Windows.Forms.Button btnOpenEac3ToFileDialog;
        private System.Windows.Forms.Button btnOpenBluRayPathDialog;
        private System.Windows.Forms.TextBox txtBatFilePath;
        private System.Windows.Forms.Label lblBatchFilePath;
        private System.Windows.Forms.TextBox txtBluRayPath;
        private System.Windows.Forms.Label lblBluRayFolderPath;
        private System.Windows.Forms.TextBox txtEAC3ToPath;
        private System.Windows.Forms.Label lblEac3ToExePath;
        private System.ComponentModel.BackgroundWorker bgwEac3toWriteBatchFile;
    }
}