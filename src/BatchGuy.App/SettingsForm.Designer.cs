namespace BatchGuy.App
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEac3toPath = new System.Windows.Forms.TextBox();
            this.btnOpenEac3toFileDialog = new System.Windows.Forms.Button();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenVfw4x264FileDialog = new System.Windows.Forms.Button();
            this.txtVfw4x264 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbScreen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.groupBox1);
            this.gbScreen.Location = new System.Drawing.Point(12, 12);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Size = new System.Drawing.Size(713, 231);
            this.gbScreen.TabIndex = 0;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenVfw4x264FileDialog);
            this.groupBox1.Controls.Add(this.txtVfw4x264);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenEac3toFileDialog);
            this.groupBox1.Controls.Add(this.txtEac3toPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "eac3to.exe";
            // 
            // txtEac3toPath
            // 
            this.txtEac3toPath.Location = new System.Drawing.Point(98, 23);
            this.txtEac3toPath.Name = "txtEac3toPath";
            this.txtEac3toPath.ReadOnly = true;
            this.txtEac3toPath.Size = new System.Drawing.Size(476, 20);
            this.txtEac3toPath.TabIndex = 22;
            // 
            // btnOpenEac3toFileDialog
            // 
            this.btnOpenEac3toFileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenEac3toFileDialog.Location = new System.Drawing.Point(592, 10);
            this.btnOpenEac3toFileDialog.Name = "btnOpenEac3toFileDialog";
            this.btnOpenEac3toFileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenEac3toFileDialog.TabIndex = 0;
            this.btnOpenEac3toFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenEac3toFileDialog.Click += new System.EventHandler(this.btnOpenEac3toFileDialog_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpenVfw4x264FileDialog
            // 
            this.btnOpenVfw4x264FileDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnOpenVfw4x264FileDialog.Location = new System.Drawing.Point(592, 50);
            this.btnOpenVfw4x264FileDialog.Name = "btnOpenVfw4x264FileDialog";
            this.btnOpenVfw4x264FileDialog.Size = new System.Drawing.Size(61, 33);
            this.btnOpenVfw4x264FileDialog.TabIndex = 1;
            this.btnOpenVfw4x264FileDialog.UseVisualStyleBackColor = true;
            this.btnOpenVfw4x264FileDialog.Click += new System.EventHandler(this.btnOpenVfw4x264FileDialog_Click);
            // 
            // txtVfw4x264
            // 
            this.txtVfw4x264.Location = new System.Drawing.Point(98, 63);
            this.txtVfw4x264.Name = "txtVfw4x264";
            this.txtVfw4x264.ReadOnly = true;
            this.txtVfw4x264.Size = new System.Drawing.Size(476, 20);
            this.txtVfw4x264.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "vfw4x264.exe";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 301);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BatchGuy Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbScreen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEac3toPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenEac3toFileDialog;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.Button btnOpenVfw4x264FileDialog;
        private System.Windows.Forms.TextBox txtVfw4x264;
        private System.Windows.Forms.Label label2;
    }
}