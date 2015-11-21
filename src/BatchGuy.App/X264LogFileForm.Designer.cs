namespace BatchGuy.App
{
    partial class X264LogFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X264LogFileForm));
            this.dgvLogFiles = new System.Windows.Forms.DataGridView();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.lblLogFileCount = new System.Windows.Forms.Label();
            this.bsLogFiles = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogFiles
            // 
            this.dgvLogFiles.AllowDrop = true;
            this.dgvLogFiles.AllowUserToAddRows = false;
            this.dgvLogFiles.AutoGenerateColumns = false;
            this.dgvLogFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameOnlyDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.logDataGridViewTextBoxColumn});
            this.dgvLogFiles.DataSource = this.bsLogFiles;
            this.dgvLogFiles.Location = new System.Drawing.Point(6, 36);
            this.dgvLogFiles.Name = "dgvLogFiles";
            this.dgvLogFiles.Size = new System.Drawing.Size(1030, 417);
            this.dgvLogFiles.TabIndex = 0;
            this.dgvLogFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogFiles_CellClick);
            this.dgvLogFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvLogFiles_RowsRemoved);
            this.dgvLogFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvLogFiles_DragDrop);
            this.dgvLogFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvLogFiles_DragEnter);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.lblLogFileCount);
            this.gbScreen.Controls.Add(this.dgvLogFiles);
            this.gbScreen.Controls.Add(this.btnViewLogs);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(1042, 510);
            this.gbScreen.TabIndex = 1;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "groupBox1";
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Location = new System.Drawing.Point(899, 469);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(137, 25);
            this.btnViewLogs.TabIndex = 2;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // lblLogFileCount
            // 
            this.lblLogFileCount.AutoSize = true;
            this.lblLogFileCount.Location = new System.Drawing.Point(6, 456);
            this.lblLogFileCount.Name = "lblLogFileCount";
            this.lblLogFileCount.Size = new System.Drawing.Size(38, 13);
            this.lblLogFileCount.TabIndex = 3;
            this.lblLogFileCount.Text = "Count:";
            // 
            // bsLogFiles
            // 
            this.bsLogFiles.DataSource = typeof(BatchGuy.App.X264Log.Models.X264LogFile);
            // 
            // fileNameOnlyDataGridViewTextBoxColumn
            // 
            this.fileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "FileNameOnly";
            this.fileNameOnlyDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.fileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.fileNameOnlyDataGridViewTextBoxColumn.Name = "fileNameOnlyDataGridViewTextBoxColumn";
            this.fileNameOnlyDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameOnlyDataGridViewTextBoxColumn.Width = 250;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "File Path";
            this.filePathDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logDataGridViewTextBoxColumn
            // 
            this.logDataGridViewTextBoxColumn.DataPropertyName = "Log";
            this.logDataGridViewTextBoxColumn.HeaderText = "Log";
            this.logDataGridViewTextBoxColumn.Name = "logDataGridViewTextBoxColumn";
            this.logDataGridViewTextBoxColumn.Visible = false;
            // 
            // X264LogFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "X264LogFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "x264 Log File Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogFiles;
        private System.Windows.Forms.BindingSource bsLogFiles;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathAndFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Label lblLogFileCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataGridViewTextBoxColumn;
    }
}