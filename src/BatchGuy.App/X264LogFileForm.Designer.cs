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
            this.dgvLogFiles = new System.Windows.Forms.DataGridView();
            this.fileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathAndFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLogFiles = new System.Windows.Forms.BindingSource(this.components);
            this.gbScreen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogFiles)).BeginInit();
            this.gbScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogFiles
            // 
            this.dgvLogFiles.AllowDrop = true;
            this.dgvLogFiles.AutoGenerateColumns = false;
            this.dgvLogFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameOnlyDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.logDataGridViewTextBoxColumn,
            this.pathAndFileNameDataGridViewTextBoxColumn});
            this.dgvLogFiles.DataSource = this.bsLogFiles;
            this.dgvLogFiles.Location = new System.Drawing.Point(49, 62);
            this.dgvLogFiles.Name = "dgvLogFiles";
            this.dgvLogFiles.Size = new System.Drawing.Size(586, 150);
            this.dgvLogFiles.TabIndex = 0;
            this.dgvLogFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvLogFiles_DragEnter);
            // 
            // fileNameOnlyDataGridViewTextBoxColumn
            // 
            this.fileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "FileNameOnly";
            this.fileNameOnlyDataGridViewTextBoxColumn.HeaderText = "FileNameOnly";
            this.fileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.fileNameOnlyDataGridViewTextBoxColumn.Name = "fileNameOnlyDataGridViewTextBoxColumn";
            this.fileNameOnlyDataGridViewTextBoxColumn.Width = 150;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // logDataGridViewTextBoxColumn
            // 
            this.logDataGridViewTextBoxColumn.DataPropertyName = "Log";
            this.logDataGridViewTextBoxColumn.HeaderText = "Log";
            this.logDataGridViewTextBoxColumn.Name = "logDataGridViewTextBoxColumn";
            this.logDataGridViewTextBoxColumn.Visible = false;
            // 
            // pathAndFileNameDataGridViewTextBoxColumn
            // 
            this.pathAndFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathAndFileNameDataGridViewTextBoxColumn.DataPropertyName = "PathAndFileName";
            this.pathAndFileNameDataGridViewTextBoxColumn.HeaderText = "PathAndFileName";
            this.pathAndFileNameDataGridViewTextBoxColumn.Name = "pathAndFileNameDataGridViewTextBoxColumn";
            this.pathAndFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsLogFiles
            // 
            this.bsLogFiles.DataSource = typeof(BatchGuy.App.X264Log.Models.X264LogFile);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.dgvLogFiles);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(701, 284);
            this.gbScreen.TabIndex = 1;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "groupBox1";
            // 
            // X264LogFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 613);
            this.Controls.Add(this.gbScreen);
            this.Name = "X264LogFileForm";
            this.Text = "X264LogFileForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogFiles)).EndInit();
            this.gbScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogFiles;
        private System.Windows.Forms.BindingSource bsLogFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathAndFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbScreen;
    }
}