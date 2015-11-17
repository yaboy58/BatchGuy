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
   public partial class SetOutputDirectoryUserControl : UserControl
    {
       private string _clilName;
       private EnumOutputDirectoryType _outputDirectoryType;
       private string _cliOutputDirectory;

       public string CLIName { get { return _clilName; } set { _clilName = value; } }
       public EnumOutputDirectoryType OutputDirectoryType { get { return _outputDirectoryType;} }
       public string CLIOutputDirectory { get { return _cliOutputDirectory; } }

        public SetOutputDirectoryUserControl()
        {
            InitializeComponent();
            this.SetDefaults();
        }

        private void SetDefaults()
        {
            _clilName = string.Empty;
            _outputDirectoryType = EnumOutputDirectoryType.DirectoryPerEpisode;
            cbSetOutputDirectoryUserControlType.SelectedIndex = 0;
            lblSetOutputDirectoryText.Text = "";
            _cliOutputDirectory = string.Empty;
        }

        private void btnSetOutputDirectoryUserControlOpenDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnSetOutputDirectoryUserControlOpenDialogClick();
        }

       private void HandleBtnSetOutputDirectoryUserControlOpenDialogClick()
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = string.Format("{0} output directory", _clilName);
            fsd.InitialDirectory = @"c:\";
            if (fsd.ShowDialog(IntPtr.Zero))
            {
                txtSetOuptDirectoryUserControl.Text = fsd.FileName;
                this.HandleCbSetOutputDirectoryUserControlTypeSelectedIndexChanged(cbSetOutputDirectoryUserControlType.Text);
                _cliOutputDirectory = txtSetOuptDirectoryUserControl.Text;
            }
        }

       private void SetOutputDirectoryUserControl_Load(object sender, EventArgs e)
       {
           lblSetOutputDirectoryUserControlOutputType.Text = string.Format("{0} Output Directory",_clilName);
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
                   stringLabelOutputDirectoryText = string.Format(@"{0} Output Directory: {1}\e##", _clilName, txtSetOuptDirectoryUserControl.Text);
                   break;
               default:
                   break;
           }
           lblSetOutputDirectoryText.Text = stringLabelOutputDirectoryText;
       }
    }
}
