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
       private string _labelOutputDirectoryCaptionText;
       private EnumOutputDirectoryType _outputDirectoryType;
       private string _cliOutputDirectory;

       public string ComboBoxCaptionText { get { return _comboBoxCaptionText; } set { _comboBoxCaptionText = value; } }
       public string LabelOutputDirectoryCaptionText { get { return _labelOutputDirectoryCaptionText; } set { _labelOutputDirectoryCaptionText = value; } }
       public EnumOutputDirectoryType OutputDirectoryType { get { return _outputDirectoryType;} }
       public string CLIOutputDirectory { get { return _cliOutputDirectory; } }

        public SetDirectoryUserControl()
        {
            InitializeComponent();
        }

        private void SetDefaults()
        {
            lblComboBoxCaption.Text = string.Format("{0} Output Directory", _comboBoxCaptionText);
            _outputDirectoryType = EnumOutputDirectoryType.DirectoryPerEpisode;
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
            fsd.Title = string.Format("{0} output directory", _comboBoxCaptionText);
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtSetOuptDirectoryUserControl.Text = fsd.FileName;
                _cliOutputDirectory = txtSetOuptDirectoryUserControl.Text;
                this.HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(cbSetOutputDirectoryUserControlType.Text);
            }
        }

       private void SetOutputDirectoryUserControl_Load(object sender, EventArgs e)
       {
           this.SetDefaults();
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
                   _outputDirectoryType = EnumOutputDirectoryType.SingleDirectory;
                   break;
               case "Directory Per Episode":
                   _outputDirectoryType = EnumOutputDirectoryType.DirectoryPerEpisode;
                   if (_cliOutputDirectory != string.Empty)
                   {
                       stringLabelOutputDirectoryText = string.Format(_labelOutputDirectoryCaptionText, txtSetOuptDirectoryUserControl.Text);                       
                   }
                   break;
               default:
                   break;
           }
           lblDirectoryOutputCaption.Text = stringLabelOutputDirectoryText;
       }
    }
}
