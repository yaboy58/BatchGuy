namespace BatchGuy.App.UserControls
{
    partial class SetDirectoryUserControl
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
            this.lblComboBoxCaption = new System.Windows.Forms.Label();
            this.cbSetOutputDirectoryUserControlType = new System.Windows.Forms.ComboBox();
            this.btnSetOutputDirectoryUserControlOpenDialog = new System.Windows.Forms.Button();
            this.txtSetOuptDirectoryUserControl = new System.Windows.Forms.TextBox();
            this.lblDirectoryOutputCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComboBoxCaption
            // 
            this.lblComboBoxCaption.AutoSize = true;
            this.lblComboBoxCaption.Location = new System.Drawing.Point(2, 22);
            this.lblComboBoxCaption.Name = "lblComboBoxCaption";
            this.lblComboBoxCaption.Size = new System.Drawing.Size(84, 13);
            this.lblComboBoxCaption.TabIndex = 0;
            this.lblComboBoxCaption.Text = "Output Directory";
            // 
            // cbSetOutputDirectoryUserControlType
            // 
            this.cbSetOutputDirectoryUserControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetOutputDirectoryUserControlType.FormattingEnabled = true;
            this.cbSetOutputDirectoryUserControlType.Items.AddRange(new object[] {
            "Single Directory",
            "Directory Per Episode"});
            this.cbSetOutputDirectoryUserControlType.Location = new System.Drawing.Point(129, 15);
            this.cbSetOutputDirectoryUserControlType.Name = "cbSetOutputDirectoryUserControlType";
            this.cbSetOutputDirectoryUserControlType.Size = new System.Drawing.Size(181, 21);
            this.cbSetOutputDirectoryUserControlType.TabIndex = 1;
            this.cbSetOutputDirectoryUserControlType.SelectedIndexChanged += new System.EventHandler(this.cbSetOutputDirectoryUserControlType_SelectedIndexChanged);
            // 
            // btnSetOutputDirectoryUserControlOpenDialog
            // 
            this.btnSetOutputDirectoryUserControlOpenDialog.Image = global::BatchGuy.App.Properties.Resources.Avosoft_Warm_Toolbar_Folder_open;
            this.btnSetOutputDirectoryUserControlOpenDialog.Location = new System.Drawing.Point(756, 3);
            this.btnSetOutputDirectoryUserControlOpenDialog.Name = "btnSetOutputDirectoryUserControlOpenDialog";
            this.btnSetOutputDirectoryUserControlOpenDialog.Size = new System.Drawing.Size(61, 33);
            this.btnSetOutputDirectoryUserControlOpenDialog.TabIndex = 12;
            this.btnSetOutputDirectoryUserControlOpenDialog.UseVisualStyleBackColor = true;
            this.btnSetOutputDirectoryUserControlOpenDialog.Click += new System.EventHandler(this.btnSetOutputDirectoryUserControlOpenDialog_Click);
            // 
            // txtSetOuptDirectoryUserControl
            // 
            this.txtSetOuptDirectoryUserControl.Location = new System.Drawing.Point(316, 16);
            this.txtSetOuptDirectoryUserControl.Name = "txtSetOuptDirectoryUserControl";
            this.txtSetOuptDirectoryUserControl.ReadOnly = true;
            this.txtSetOuptDirectoryUserControl.Size = new System.Drawing.Size(434, 20);
            this.txtSetOuptDirectoryUserControl.TabIndex = 13;
            // 
            // lblDirectoryOutputCaption
            // 
            this.lblDirectoryOutputCaption.AutoSize = true;
            this.lblDirectoryOutputCaption.Location = new System.Drawing.Point(126, 48);
            this.lblDirectoryOutputCaption.Name = "lblDirectoryOutputCaption";
            this.lblDirectoryOutputCaption.Size = new System.Drawing.Size(42, 13);
            this.lblDirectoryOutputCaption.TabIndex = 14;
            this.lblDirectoryOutputCaption.Text = "Output:";
            // 
            // SetDirectoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComboBoxCaption);
            this.Controls.Add(this.lblDirectoryOutputCaption);
            this.Controls.Add(this.cbSetOutputDirectoryUserControlType);
            this.Controls.Add(this.btnSetOutputDirectoryUserControlOpenDialog);
            this.Controls.Add(this.txtSetOuptDirectoryUserControl);
            this.Name = "SetDirectoryUserControl";
            this.Size = new System.Drawing.Size(824, 71);
            this.Load += new System.EventHandler(this.SetOutputDirectoryUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComboBoxCaption;
        private System.Windows.Forms.ComboBox cbSetOutputDirectoryUserControlType;
        private System.Windows.Forms.Button btnSetOutputDirectoryUserControlOpenDialog;
        private System.Windows.Forms.TextBox txtSetOuptDirectoryUserControl;
        private System.Windows.Forms.Label lblDirectoryOutputCaption;
    }
}
