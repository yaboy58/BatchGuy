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
            this.btnWriteToBatFile = new System.Windows.Forms.Button();
            this.gbDiscSummary = new System.Windows.Forms.GroupBox();
            this.dgvBluRaySummary = new System.Windows.Forms.DataGridView();
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.dgvBluRayDiscInfo = new System.Windows.Forms.DataGridView();
            this.btnOpenBatchFilePathDialog = new System.Windows.Forms.Button();
            this.txtBatFilePath = new System.Windows.Forms.TextBox();
            this.lblBatchFilePath = new System.Windows.Forms.Label();
            this.bgwEac3toWriteBatchFile = new System.ComponentModel.BackgroundWorker();
            this.ttBluRayDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.ttBatchFileOutputDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.ttDirectoryUserControl = new System.Windows.Forms.ToolTip(this.components);
            this.setDirectoryUserControl = new BatchGuy.App.UserControls.SetDirectoryUserControl();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpisodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluRayTitleInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRaySummaryInfo = new System.Windows.Forms.BindingSource(this.components);
            this.isSelectedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayDiscInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gbScreen.SuspendLayout();
            this.gbDiscSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).BeginInit();
            this.gbDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).BeginInit();
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
            this.gbScreen.Controls.Add(this.setDirectoryUserControl);
            this.gbScreen.Controls.Add(this.btnWriteToBatFile);
            this.gbScreen.Controls.Add(this.gbDiscSummary);
            this.gbScreen.Controls.Add(this.gbDisc);
            this.gbScreen.Controls.Add(this.btnOpenBatchFilePathDialog);
            this.gbScreen.Controls.Add(this.txtBatFilePath);
            this.gbScreen.Controls.Add(this.lblBatchFilePath);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1284, 632);
            this.gbScreen.TabIndex = 30;
            this.gbScreen.TabStop = false;
            // 
            // btnWriteToBatFile
            // 
            this.btnWriteToBatFile.Location = new System.Drawing.Point(1138, 578);
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
            this.gbDiscSummary.Location = new System.Drawing.Point(12, 334);
            this.gbDiscSummary.Name = "gbDiscSummary";
            this.gbDiscSummary.Size = new System.Drawing.Size(1258, 238);
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
            this.IsSelected,
            this.Id,
            this.EpisodeNumber,
            this.HeaderText,
            this.DetailText,
            this.bluRayTitleInfoDataGridViewTextBoxColumn});
            this.dgvBluRaySummary.DataSource = this.bsBluRaySummaryInfo;
            this.dgvBluRaySummary.Location = new System.Drawing.Point(6, 19);
            this.dgvBluRaySummary.Name = "dgvBluRaySummary";
            this.dgvBluRaySummary.Size = new System.Drawing.Size(1246, 208);
            this.dgvBluRaySummary.TabIndex = 23;
            this.dgvBluRaySummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellClick);
            this.dgvBluRaySummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRaySummary_CellDoubleClick);
            // 
            // gbDisc
            // 
            this.gbDisc.Controls.Add(this.dgvBluRayDiscInfo);
            this.gbDisc.Location = new System.Drawing.Point(17, 132);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(1253, 180);
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
            this.isSelectedDataGridViewCheckBoxColumn1,
            this.idDataGridViewTextBoxColumn1,
            this.discNameDataGridViewTextBoxColumn});
            this.dgvBluRayDiscInfo.DataSource = this.bsBluRayDiscInfo;
            this.dgvBluRayDiscInfo.Location = new System.Drawing.Point(6, 19);
            this.dgvBluRayDiscInfo.Name = "dgvBluRayDiscInfo";
            this.dgvBluRayDiscInfo.Size = new System.Drawing.Size(1241, 150);
            this.dgvBluRayDiscInfo.TabIndex = 24;
            this.dgvBluRayDiscInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBluRayDiscInfo_CellClick);
            this.dgvBluRayDiscInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragDrop);
            this.dgvBluRayDiscInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvBluRayDiscInfo_DragEnter);
            // 
            // btnOpenBatchFilePathDialog
            // 
            this.btnOpenBatchFilePathDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenBatchFilePathDialog.Location = new System.Drawing.Point(613, 15);
            this.btnOpenBatchFilePathDialog.Name = "btnOpenBatchFilePathDialog";
            this.btnOpenBatchFilePathDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenBatchFilePathDialog.TabIndex = 1;
            this.btnOpenBatchFilePathDialog.UseVisualStyleBackColor = true;
            this.btnOpenBatchFilePathDialog.Click += new System.EventHandler(this.btnOpenBatchFilePathDialog_Click);
            // 
            // txtBatFilePath
            // 
            this.txtBatFilePath.Location = new System.Drawing.Point(162, 28);
            this.txtBatFilePath.Name = "txtBatFilePath";
            this.txtBatFilePath.ReadOnly = true;
            this.txtBatFilePath.Size = new System.Drawing.Size(434, 20);
            this.txtBatFilePath.TabIndex = 33;
            // 
            // lblBatchFilePath
            // 
            this.lblBatchFilePath.AutoSize = true;
            this.lblBatchFilePath.Location = new System.Drawing.Point(20, 35);
            this.lblBatchFilePath.Name = "lblBatchFilePath";
            this.lblBatchFilePath.Size = new System.Drawing.Size(127, 13);
            this.lblBatchFilePath.TabIndex = 35;
            this.lblBatchFilePath.Text = "Batch File Save Directory";
            // 
            // bgwEac3toWriteBatchFile
            // 
            this.bgwEac3toWriteBatchFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEac3toWriteBatchFile_DoWork);
            this.bgwEac3toWriteBatchFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEac3toWriteBatchFile_RunWorkerCompleted);
            // 
            // setDirectoryUserControl
            // 
            this.setDirectoryUserControl.ComboBoxCaptionText = "";
            this.setDirectoryUserControl.LabelDirectoryCaptionText = null;
            this.setDirectoryUserControl.Location = new System.Drawing.Point(17, 48);
            this.setDirectoryUserControl.Name = "setDirectoryUserControl";
            this.setDirectoryUserControl.Size = new System.Drawing.Size(824, 71);
            this.setDirectoryUserControl.TabIndex = 41;
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Is Selected";
            this.IsSelected.MinimumWidth = 70;
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Width = 70;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "eac3to Id";
            this.Id.MinimumWidth = 80;
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // EpisodeNumber
            // 
            this.EpisodeNumber.DataPropertyName = "EpisodeNumber";
            this.EpisodeNumber.HeaderText = "Episode#";
            this.EpisodeNumber.MinimumWidth = 90;
            this.EpisodeNumber.Name = "EpisodeNumber";
            this.EpisodeNumber.ReadOnly = true;
            this.EpisodeNumber.Width = 90;
            // 
            // HeaderText
            // 
            this.HeaderText.DataPropertyName = "HeaderText";
            this.HeaderText.HeaderText = "Header";
            this.HeaderText.MinimumWidth = 250;
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.ReadOnly = true;
            this.HeaderText.Width = 400;
            // 
            // DetailText
            // 
            this.DetailText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DetailText.DataPropertyName = "DetailText";
            this.DetailText.HeaderText = "Detail";
            this.DetailText.MinimumWidth = 250;
            this.DetailText.Name = "DetailText";
            this.DetailText.ReadOnly = true;
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
            // isSelectedDataGridViewCheckBoxColumn1
            // 
            this.isSelectedDataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn1.HeaderText = "Is Selected";
            this.isSelectedDataGridViewCheckBoxColumn1.MinimumWidth = 100;
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
            // discNameDataGridViewTextBoxColumn
            // 
            this.discNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discNameDataGridViewTextBoxColumn.DataPropertyName = "DiscName";
            this.discNameDataGridViewTextBoxColumn.HeaderText = "Disc Name";
            this.discNameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.discNameDataGridViewTextBoxColumn.Name = "discNameDataGridViewTextBoxColumn";
            this.discNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBluRayDiscInfo
            // 
            this.bsBluRayDiscInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayDiscInfo);
            // 
            // CreateEAC3ToBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 655);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CreateEAC3ToBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create eac3to Batch File";
            this.Load += new System.EventHandler(this.CreateEAC3ToBatchForm_Load);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.gbDiscSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRaySummary)).EndInit();
            this.gbDisc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBluRayDiscInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRaySummaryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayDiscInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBluRayDiscInfo;
        private System.Windows.Forms.BindingSource bsBluRaySummaryInfo;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpisodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailText;
        private System.Windows.Forms.DataGridViewTextBoxColumn bluRayTitleInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAC3ToConfigurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discNameDataGridViewTextBoxColumn;
        private UserControls.SetDirectoryUserControl setDirectoryUserControl;
        private System.Windows.Forms.ToolTip ttBluRayDirectory;
        private System.Windows.Forms.ToolTip ttBatchFileOutputDirectory;
        private System.Windows.Forms.ToolTip ttDirectoryUserControl;
    }
}