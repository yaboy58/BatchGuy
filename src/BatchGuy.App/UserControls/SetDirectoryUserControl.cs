using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.ThirdParty.FolderSelectDialog;
using BatchGuy.App.Enums;

namespace BatchGuy.App.UserControls
{
   public partial class SetDirectoryUserControl : UserControl
    {
       private string _comboBoxCaptionText;
       private string _labelDirectoryCaptionText;
       private EnumDirectoryType _directoryType;
       private string _cliOutputDirectory;

       public string ComboBoxCaptionText { get { return _comboBoxCaptionText; } set { _comboBoxCaptionText = value; } }
       public string LabelDirectoryCaptionText { get { return _labelDirectoryCaptionText; } set { _labelDirectoryCaptionText = value; } }
       public EnumDirectoryType OutputDirectoryType { get { return _directoryType;} }
       public string CLIDirectory { get { return _cliOutputDirectory; } }

        public SetDirectoryUserControl()
        {
            InitializeComponent();
            this.SetDefaults();
        }

       public void SetControlValues(string cliOutputDirectory, EnumDirectoryType directoryType)
       {
           _cliOutputDirectory = cliOutputDirectory;
           _directoryType = directoryType;
           this.SetTxtSetOuptDirectoryUserControl();
           this.SetCbSetOutputDirectoryUserControlType();
           this.HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(cbSetOutputDirectoryUserControlType.Text);
       }

       private void SetTxtSetOuptDirectoryUserControl()
       {
           txtSetOuptDirectoryUserControl.Text = _cliOutputDirectory;
       }

       private void SetCbSetOutputDirectoryUserControlType()
       {
           if (_directoryType == EnumDirectoryType.DirectoryPerEpisode)
           {
               cbSetOutputDirectoryUserControlType.SelectedIndex = 0;
           }
           else
           {
               cbSetOutputDirectoryUserControlType.SelectedIndex = 1;
           }
       }

        private void SetDefaults()
        {
            _directoryType = EnumDirectoryType.DirectoryPerEpisode;
            cbSetOutputDirectoryUserControlType.SelectedIndex = 0;
            lblDirectoryOutputCaption.Text = "";
            _cliOutputDirectory = string.Empty;
        }

        private void btnSetOutputDirectoryUserControlOpenDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnSetOutputDirectoryUserControlOpenDialogClick();
        }

       private void HandleBtnSetOutputDirectoryUserControlOpenDialogClick()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = string.Format("{0}", _comboBoxCaptionText);
            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtSetOuptDirectoryUserControl.Text = fsd.FileName;
                _cliOutputDirectory = txtSetOuptDirectoryUserControl.Text;
                this.HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(cbSetOutputDirectoryUserControlType.Text);
            }
        }

       private void SetOutputDirectoryUserControl_Load(object sender, EventArgs e)
       {
           lblComboBoxCaption.Text = string.Format("{0}", _comboBoxCaptionText);
       }

       private void cbSetOutputDirectoryUserControlType_SelectedIndexChanged(object sender, EventArgs e)
       {
           this.HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(cbSetOutputDirectoryUserControlType.Text);
       }

       private void HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(string value)
       {
           string stringLabelOutputDirectoryText = string.Empty;

           switch (value)
           {
               case "Single Directory":
                   _directoryType = EnumDirectoryType.SingleDirectory;
                   break;
               case "Directory Per Episode":
                   _directoryType = EnumDirectoryType.DirectoryPerEpisode;
                   if (!string.IsNullOrEmpty(_cliOutputDirectory) && !string.IsNullOrEmpty(txtSetOuptDirectoryUserControl.Text))
                   {
                       stringLabelOutputDirectoryText = string.Format(_labelDirectoryCaptionText, txtSetOuptDirectoryUserControl.Text);                       
                   }
                   break;
               default:
                   break;
           }
           lblDirectoryOutputCaption.Text = stringLabelOutputDirectoryText;
       }
    }
}
