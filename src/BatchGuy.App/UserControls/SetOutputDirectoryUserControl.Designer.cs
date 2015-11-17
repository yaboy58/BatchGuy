namespace BatchGuy.App.UserControls
{
    partial class SetOutputDirectoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSetOutputDirectoryUserControlOutputType = new System.Windows.Forms.Label();
            this.cbSetOutputDirectoryUserControlType = new System.Windows.Forms.ComboBox();
            this.btnSetOutputDirectoryUserControlOpenDialog = new System.Windows.Forms.Button();
            this.txtSetOuptDirectoryUserControl = new System.Windows.Forms.TextBox();
            this.lblSetOutputDirectoryText = new System.Windows.Forms.Label();
            this.gbSetOutputDirectoryUserControl = new System.Windows.Forms.GroupBox();
            this.gbSetOutputDirectoryUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSetOutputDirectoryUserControlOutputType
            // 
            this.lblSetOutputDirectoryUserControlOutputType.AutoSize = true;
            this.lblSetOutputDirectoryUserControlOutputType.Location = new System.Drawing.Point(6, 33);
            this.lblSetOutputDirectoryUserControlOutputType.Name = "lblSetOutputDirectoryUserControlOutputType";
            this.lblSetOutputDirectoryUserControlOutputType.Size = new System.Drawing.Size(84, 13);
            this.lblSetOutputDirectoryUserControlOutputType.TabIndex = 0;
            this.lblSetOutputDirectoryUserControlOutputType.Text = "Output Directory";
            // 
            // cbSetOutputDirectoryUserControlType
            // 
            this.cbSetOutputDirectoryUserControlType.FormattingEnabled = true;
            this.cbSetOutputDirectoryUserControlType.Items.AddRange(new object[] {
            "Single Directory",
            "Directory Per Episode"});
            this.cbSetOutputDirectoryUserControlType.Location = new System.Drawing.Point(133, 26);
            this.cbSetOutputDirectoryUserControlType.Name = "cbSetOutputDirectoryUserControlType";
            this.cbSetOutputDirectoryUserControlType.Size = new System.Drawing.Size(102, 21);
            this.cbSetOutputDirectoryUserControlType.TabIndex = 1;
            this.cbSetOutputDirectoryUserControlType.SelectedIndexChanged += new System.EventHandler(this.cbSetOutputDirectoryUserControlType_SelectedIndexChanged);
            // 
            // btnSetOutputDirectoryUserControlOpenDialog
            // 
            this.btnSetOutputDirectoryUserControlOpenDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnSetOutputDirectoryUserControlOpenDialog.Location = new System.Drawing.Point(632, 13);
            this.btnSetOutputDirectoryUserControlOpenDialog.Name = "btnSetOutputDirectoryUserControlOpenDialog";
            this.btnSetOutputDirectoryUserControlOpenDialog.Size = new System.Drawing.Size(61, 33);
            this.btnSetOutputDirectoryUserControlOpenDialog.TabIndex = 12;
            this.btnSetOutputDirectoryUserControlOpenDialog.UseVisualStyleBackColor = true;
            this.btnSetOutputDirectoryUserControlOpenDialog.Click += new System.EventHandler(this.btnSetOutputDirectoryUserControlOpenDialog_Click);
            // 
            // txtSetOuptDirectoryUserControl
            // 
            this.txtSetOuptDirectoryUserControl.Enabled = false;
            this.txtSetOuptDirectoryUserControl.Location = new System.Drawing.Point(241, 26);
            this.txtSetOuptDirectoryUserControl.Name = "txtSetOuptDirectoryUserControl";
            this.txtSetOuptDirectoryUserControl.Size = new System.Drawing.Size(385, 20);
            this.txtSetOuptDirectoryUserControl.TabIndex = 13;
            // 
            // lblSetOutputDirectoryText
            // 
            this.lblSetOutputDirectoryText.AutoSize = true;
            this.lblSetOutputDirectoryText.Location = new System.Drawing.Point(21, 63);
            this.lblSetOutputDirectoryText.Name = "lblSetOutputDirectoryText";
            this.lblSetOutputDirectoryText.Size = new System.Drawing.Size(42, 13);
            this.lblSetOutputDirectoryText.TabIndex = 14;
            this.lblSetOutputDirectoryText.Text = "Output:";
            // 
            // gbSetOutputDirectoryUserControl
            // 
            this.gbSetOutputDirectoryUserControl.Controls.Add(this.lblSetOutputDirectoryUserControlOutputType);
            this.gbSetOutputDirectoryUserControl.Controls.Add(this.lblSetOutputDirectoryText);
            this.gbSetOutputDirectoryUserControl.Controls.Add(this.cbSetOutputDirectoryUserControlType);
            this.gbSetOutputDirectoryUserControl.Controls.Add(this.txtSetOuptDirectoryUserControl);
            this.gbSetOutputDirectoryUserControl.Controls.Add(this.btnSetOutputDirectoryUserControlOpenDialog);
            this.gbSetOutputDirectoryUserControl.Location = new System.Drawing.Point(8, 5);
            this.gbSetOutputDirectoryUserControl.Name = "gbSetOutputDirectoryUserControl";
            this.gbSetOutputDirectoryUserControl.Size = new System.Drawing.Size(704, 86);
            this.gbSetOutputDirectoryUserControl.TabIndex = 15;
            this.gbSetOutputDirectoryUserControl.TabStop = false;
            // 
            // SetOutputDirectoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSetOutputDirectoryUserControl);
            this.Name = "SetOutputDirectoryUserControl";
            this.Size = new System.Drawing.Size(722, 100);
            this.Load += new System.EventHandler(this.SetOutputDirectoryUserControl_Load);
            this.gbSetOutputDirectoryUserControl.ResumeLayout(false);
            this.gbSetOutputDirectoryUserControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSetOutputDirectoryUserControlOutputType;
        private System.Windows.Forms.ComboBox cbSetOutputDirectoryUserControlType;
        private System.Windows.Forms.Button btnSetOutputDirectoryUserControlOpenDialog;
        private System.Windows.Forms.TextBox txtSetOuptDirectoryUserControl;
        private System.Windows.Forms.Label lblSetOutputDirectoryText;
        private System.Windows.Forms.GroupBox gbSetOutputDirectoryUserControl;
    }
}
