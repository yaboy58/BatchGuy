using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.AviSynth.Models;
using BatchGuy.App.AviSynth.Services;
using BatchGuy.App.AviSynth.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Helpers;
using BatchGuy.App.Extensions;

namespace BatchGuy.App
{
    public partial class CreateAviSynthFilesForm : Form
    {
        private IFileService _fileService; //ioc
        private IValidationService _validationService; //ioc
        private IAVSService _avsService; //ioc

        public CreateAviSynthFilesForm()
        {
            InitializeComponent();
        }

        private void CreateAVSFilesForm_Load(object sender, EventArgs e)
        {
            this.SetAVSTemplateTextBox();
        }

        private void SetAVSTemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crop(0,0,0,0)");
            sb.AppendLine(string.Format("{0}Spline36Resize(1280,720)",Environment.NewLine));
            txtAVSTemplate.Text = sb.ToString();
        }

        private void btnCreateAVSFiles_Click(object sender, EventArgs e)
        {
            if (this.IsScreenValid())
            {
                Process();                
            }
        }

        private void Process()
        {
            AVSBatchSettings avsBatchSettings = this.GetAVSBatchSettings();
            AVSTemplateScript avsTemplateScript = this.GetAVSScript();

            _fileService = new FileService(avsBatchSettings, avsTemplateScript);
            _validationService = new ValidationService(avsBatchSettings);
            _avsService = new AVSService(_fileService, _validationService, avsTemplateScript, avsBatchSettings);

            List<Error> errors = _avsService.CreateAVSFiles();

            if (errors.Count() > 0 ) // errors
            {
                MessageBox.Show("Errors occurred!"); //print errors in a loop at some point
            }
            else
            {
                MessageBox.Show("AVS Scripts have been created!", "Success.",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private AVSBatchSettings GetAVSBatchSettings()
        {
            return new AVSBatchSettings()
            {
                 BatchDirectoryPath = txtDirectory.Text,
                  NamingConvention = "encode", //hardcoded for now
                   NumberOfFiles = Convert.ToInt32(txtNumberOfFiles.Text),
                    VideoFilter = "FFVideoSource" //hardcoded for now
            };
        }

        private AVSTemplateScript GetAVSScript()
        {
            return new AVSTemplateScript() { Script = txtAVSTemplate.Text };
        }

        private bool IsScreenValid()
        {
            if (txtDirectory.Text == string.Empty)
            {
                MessageBox.Show("Please enter a file directory", "Directory Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNumberOfFiles.Text == string.Empty || !txtNumberOfFiles.Text.IsNumeric())
            {
                MessageBox.Show("Invalid number of files", "Number of files Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
            return true;
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            this.HandleBtnOpenDialogClick();
        }

        private void HandleBtnOpenDialogClick()
        {
            fbdDialog.ShowNewFolderButton = true;
            fbdDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = fbdDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectory.Text = fbdDialog.SelectedPath;
            }
        }
    }
}
