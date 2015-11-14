namespace BatchGuy.App
{
    partial class CreateAviSynthFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAviSynthFilesForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAVSTemplate = new System.Windows.Forms.TextBox();
            this.btnCreateAVSFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfFiles = new System.Windows.Forms.TextBox();
            this.fbdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.bgwCreateAviSynthFiles = new System.ComponentModel.BackgroundWorker();
            this.gbScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(157, 23);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(434, 20);
            this.txtDirectory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AviSynth Template:";
            // 
            // txtAVSTemplate
            // 
            this.txtAVSTemplate.Location = new System.Drawing.Point(20, 108);
            this.txtAVSTemplate.Multiline = true;
            this.txtAVSTemplate.Name = "txtAVSTemplate";
            this.txtAVSTemplate.Size = new System.Drawing.Size(775, 161);
            this.txtAVSTemplate.TabIndex = 1;
            // 
            // btnCreateAVSFiles
            // 
            this.btnCreateAVSFiles.Location = new System.Drawing.Point(645, 288);
            this.btnCreateAVSFiles.Name = "btnCreateAVSFiles";
            this.btnCreateAVSFiles.Size = new System.Drawing.Size(150, 35);
            this.btnCreateAVSFiles.TabIndex = 2;
            this.btnCreateAVSFiles.Text = "Create AviSynth (.avs) Files";
            this.btnCreateAVSFiles.UseVisualStyleBackColor = true;
            this.btnCreateAVSFiles.Click += new System.EventHandler(this.btnCreateAVSFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Files (Episodes)";
            // 
            // txtNumberOfFiles
            // 
            this.txtNumberOfFiles.Location = new System.Drawing.Point(157, 54);
            this.txtNumberOfFiles.Name = "txtNumberOfFiles";
            this.txtNumberOfFiles.Size = new System.Drawing.Size(54, 20);
            this.txtNumberOfFiles.TabIndex = 0;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenDialog.Location = new System.Drawing.Point(597, 10);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenDialog.TabIndex = 11;
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.txtDirectory);
            this.gbScreen.Controls.Add(this.label3);
            this.gbScreen.Controls.Add(this.btnOpenDialog);
            this.gbScreen.Controls.Add(this.txtNumberOfFiles);
            this.gbScreen.Controls.Add(this.label2);
            this.gbScreen.Controls.Add(this.btnCreateAVSFiles);
            this.gbScreen.Controls.Add(this.txtAVSTemplate);
            this.gbScreen.Controls.Add(this.label1);
            this.gbScreen.Location = new System.Drawing.Point(12, 2);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(816, 334);
            this.gbScreen.TabIndex = 12;
            this.gbScreen.TabStop = false;
            // 
            // bgwCreateAviSynthFiles
            // 
            this.bgwCreateAviSynthFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateAviSynthFiles_DoWork);
            this.bgwCreateAviSynthFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateAviSynthFiles_RunWorkerCompleted);
            // 
            // CreateAviSynthFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 348);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAviSynthFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create AviSynth Files";
            this.Load += new System.EventHandler(this.CreateAVSFilesForm_Load);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAVSTemplate;
        private System.Windows.Forms.Button btnCreateAVSFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdDialog;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.ComponentModel.BackgroundWorker bgwCreateAviSynthFiles;
    }
}