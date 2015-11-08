namespace BatchGuy.App
{
    partial class BluRayTitleInfoForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbVideo = new System.Windows.Forms.GroupBox();
            this.lblVideoText = new System.Windows.Forms.Label();
            this.chkVideoIsSelected = new System.Windows.Forms.CheckBox();
            this.gbAudio = new System.Windows.Forms.GroupBox();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audioTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBluRayTitleAudio = new System.Windows.Forms.BindingSource(this.components);
            this.bsBluRayTitleVideo = new System.Windows.Forms.BindingSource(this.components);
            this.bsBluRayTitleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.gbVideo.SuspendLayout();
            this.gbAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // gbVideo
            // 
            this.gbVideo.Controls.Add(this.lblVideoText);
            this.gbVideo.Controls.Add(this.chkVideoIsSelected);
            this.gbVideo.Location = new System.Drawing.Point(15, 62);
            this.gbVideo.Name = "gbVideo";
            this.gbVideo.Size = new System.Drawing.Size(896, 65);
            this.gbVideo.TabIndex = 1;
            this.gbVideo.TabStop = false;
            this.gbVideo.Text = "Video";
            // 
            // lblVideoText
            // 
            this.lblVideoText.AutoSize = true;
            this.lblVideoText.Location = new System.Drawing.Point(77, 28);
            this.lblVideoText.Name = "lblVideoText";
            this.lblVideoText.Size = new System.Drawing.Size(37, 13);
            this.lblVideoText.TabIndex = 1;
            this.lblVideoText.Text = "Video:";
            // 
            // chkVideoIsSelected
            // 
            this.chkVideoIsSelected.AutoSize = true;
            this.chkVideoIsSelected.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsBluRayTitleVideo, "IsSelected", true));
            this.chkVideoIsSelected.Location = new System.Drawing.Point(6, 28);
            this.chkVideoIsSelected.Name = "chkVideoIsSelected";
            this.chkVideoIsSelected.Size = new System.Drawing.Size(56, 17);
            this.chkVideoIsSelected.TabIndex = 0;
            this.chkVideoIsSelected.Text = "Select";
            this.chkVideoIsSelected.UseVisualStyleBackColor = true;
            // 
            // gbAudio
            // 
            this.gbAudio.Controls.Add(this.dgvAudio);
            this.gbAudio.Location = new System.Drawing.Point(12, 155);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(896, 278);
            this.gbAudio.TabIndex = 2;
            this.gbAudio.TabStop = false;
            this.gbAudio.Text = "Audio";
            // 
            // dgvAudio
            // 
            this.dgvAudio.AllowUserToAddRows = false;
            this.dgvAudio.AllowUserToDeleteRows = false;
            this.dgvAudio.AutoGenerateColumns = false;
            this.dgvAudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.audioTypeDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn,
            this.IsSelected,
            this.textDataGridViewTextBoxColumn});
            this.dgvAudio.DataSource = this.bsBluRayTitleAudio;
            this.dgvAudio.Location = new System.Drawing.Point(9, 30);
            this.dgvAudio.Name = "dgvAudio";
            this.dgvAudio.Size = new System.Drawing.Size(881, 179);
            this.dgvAudio.TabIndex = 0;
            this.dgvAudio.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudio_CellEndEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // audioTypeDataGridViewTextBoxColumn
            // 
            this.audioTypeDataGridViewTextBoxColumn.DataPropertyName = "AudioType";
            this.audioTypeDataGridViewTextBoxColumn.HeaderText = "AudioType";
            this.audioTypeDataGridViewTextBoxColumn.Name = "audioTypeDataGridViewTextBoxColumn";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "IsSelected";
            this.IsSelected.Name = "IsSelected";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // bsBluRayTitleAudio
            // 
            this.bsBluRayTitleAudio.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleAudio);
            // 
            // bsBluRayTitleVideo
            // 
            this.bsBluRayTitleVideo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleVideo);
            // 
            // bsBluRayTitleInfo
            // 
            this.bsBluRayTitleInfo.DataSource = typeof(BatchGuy.App.Parser.Models.BluRayTitleInfo);
            // 
            // BluRayTitleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 464);
            this.Controls.Add(this.gbAudio);
            this.Controls.Add(this.gbVideo);
            this.Controls.Add(this.lblTitle);
            this.Name = "BluRayTitleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BluRayTitleForm";
            this.Load += new System.EventHandler(this.BluRayTitleForm_Load);
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            this.gbAudio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBluRayTitleInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbVideo;
        private System.Windows.Forms.Label lblVideoText;
        private System.Windows.Forms.CheckBox chkVideoIsSelected;
        private System.Windows.Forms.BindingSource bsBluRayTitleInfo;
        private System.Windows.Forms.BindingSource bsBluRayTitleVideo;
        private System.Windows.Forms.GroupBox gbAudio;
        private System.Windows.Forms.DataGridView dgvAudio;
        private System.Windows.Forms.BindingSource bsBluRayTitleAudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audioTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    }
}