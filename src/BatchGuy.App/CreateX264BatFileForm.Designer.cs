namespace BatchGuy.App
{
    partial class CreateX264BatFileForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.btnCreateX264BatFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX264Template = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAVSFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVSFileNameOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadAVSFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVfw4x264exe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Encode Type:";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.Items.AddRange(new object[] {
            "CRF",
            "2Pass"});
            this.cbEncodeType.Location = new System.Drawing.Point(664, 343);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(148, 21);
            this.cbEncodeType.TabIndex = 15;
            this.cbEncodeType.SelectedIndexChanged += new System.EventHandler(this.cbEncodeType_SelectedIndexChanged);
            // 
            // btnCreateX264BatFile
            // 
            this.btnCreateX264BatFile.Location = new System.Drawing.Point(644, 595);
            this.btnCreateX264BatFile.Name = "btnCreateX264BatFile";
            this.btnCreateX264BatFile.Size = new System.Drawing.Size(168, 44);
            this.btnCreateX264BatFile.TabIndex = 14;
            this.btnCreateX264BatFile.Text = "Create x264 Bat File";
            this.btnCreateX264BatFile.UseVisualStyleBackColor = true;
            this.btnCreateX264BatFile.Click += new System.EventHandler(this.btnCreateX264BatFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "x264 Template:";
            // 
            // txtX264Template
            // 
            this.txtX264Template.Location = new System.Drawing.Point(37, 370);
            this.txtX264Template.Multiline = true;
            this.txtX264Template.Name = "txtX264Template";
            this.txtX264Template.Size = new System.Drawing.Size(775, 219);
            this.txtX264Template.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "AviSynth Files Directory:";
            // 
            // txtAVSFileLocation
            // 
            this.txtAVSFileLocation.Location = new System.Drawing.Point(155, 10);
            this.txtAVSFileLocation.Name = "txtAVSFileLocation";
            this.txtAVSFileLocation.Size = new System.Drawing.Size(434, 20);
            this.txtAVSFileLocation.TabIndex = 10;
            this.txtAVSFileLocation.Text = "C:\\temp\\My Torrent Encodes\\Blu-ray";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Names:";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aVSFileNameOnlyDataGridViewTextBoxColumn,
            this.encodeNameDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.bsFiles;
            this.dgvFiles.Location = new System.Drawing.Point(35, 107);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(776, 222);
            this.dgvFiles.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // aVSFileNameOnlyDataGridViewTextBoxColumn
            // 
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.DataPropertyName = "AVSFileNameOnly";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.HeaderText = "AviSynth File";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.Name = "aVSFileNameOnlyDataGridViewTextBoxColumn";
            this.aVSFileNameOnlyDataGridViewTextBoxColumn.Width = 200;
            // 
            // encodeNameDataGridViewTextBoxColumn
            // 
            this.encodeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.encodeNameDataGridViewTextBoxColumn.DataPropertyName = "EncodeName";
            this.encodeNameDataGridViewTextBoxColumn.HeaderText = "Encode Name";
            this.encodeNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.encodeNameDataGridViewTextBoxColumn.Name = "encodeNameDataGridViewTextBoxColumn";
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(BatchGuy.App.X264.Models.X264File);
            // 
            // btnLoadAVSFiles
            // 
            this.btnLoadAVSFiles.Location = new System.Drawing.Point(674, 79);
            this.btnLoadAVSFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAVSFiles.Name = "btnLoadAVSFiles";
            this.btnLoadAVSFiles.Size = new System.Drawing.Size(136, 24);
            this.btnLoadAVSFiles.TabIndex = 20;
            this.btnLoadAVSFiles.Text = "Load AviSynth Files";
            this.btnLoadAVSFiles.UseVisualStyleBackColor = true;
            this.btnLoadAVSFiles.Click += new System.EventHandler(this.btnLoadAVSFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "vfw4x264 Directory:";
            // 
            // txtVfw4x264exe
            // 
            this.txtVfw4x264exe.Location = new System.Drawing.Point(157, 42);
            this.txtVfw4x264exe.Name = "txtVfw4x264exe";
            this.txtVfw4x264exe.Size = new System.Drawing.Size(434, 20);
            this.txtVfw4x264exe.TabIndex = 21;
            this.txtVfw4x264exe.Text = "C:\\exe\\HDBits Encoding\\vfw4x264\\vfw4x264.exe";
            // 
            // CreateX264BatFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVfw4x264exe);
            this.Controls.Add(this.btnLoadAVSFiles);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEncodeType);
            this.Controls.Add(this.btnCreateX264BatFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX264Template);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAVSFileLocation);
            this.Name = "CreateX264BatFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create x264 Batch File";
            this.Load += new System.EventHandler(this.CreateX264BatFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.Button btnCreateX264BatFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX264Template;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAVSFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.Button btnLoadAVSFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVSFileNameOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVfw4x264exe;
    }
}