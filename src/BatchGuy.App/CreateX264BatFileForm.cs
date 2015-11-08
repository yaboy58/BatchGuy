using BatchGuy.App.Enums;
using BatchGuy.App.X264.Interfaces;
using BatchGuy.App.X264.Models;
using BatchGuy.App.X264.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchGuy.App
{
    public partial class CreateX264BatFileForm : Form
    {
        private EnumEncodeType EncodeType { get; set; }
        private List<X264File> _x264Files;

        public CreateX264BatFileForm()
        {
            InitializeComponent();
        }

        private void CreateX264BatFileForm_Load(object sender, EventArgs e)
        {
            this.SetComboBoxEncodeType();
        }

        private void SetComboBoxEncodeType()
        {
            this.cbEncodeType.SelectedIndex = 0;
        }

        private void cbEncodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleEncodeType(cbEncodeType.Text);
        }

        private void SetX264TemplateTextBox()
        {
            StringBuilder sb = new StringBuilder();
            switch (this.EncodeType)
            {
                case EnumEncodeType.CRF:
                    sb.Append(string.Format("--crf 17 --level 4.1 --stats "));
                    sb.Append("\".stats\"");
                    sb.Append(" --preset veryslow --deblock -3:-3 --aq-strength 0.8 --psy-rd 1.00:0.00 --me tesa --merange 32 --subme 10 --no-mbtree --threads 12 --no-dct-decimate --no-fast-pskip");
                    break;
                case EnumEncodeType.TwoPass:
                    sb.Append("--bitrate 3000 --level 4.1 --stats ");
                    sb.Append("\".stats\"");
                    sb.Append(" --preset veryslow --deblock -3:-3 --aq-strength 0.8 --psy-rd 1.00:0.00 --me tesa --merange 32 --subme 10 --no-mbtree --threads 12 --no-dct-decimate --no-fast-pskip");
                    break;
                default:
                    throw new Exception("Invalid Encode Type");
            }

            txtX264Template.Text = sb.ToString();
        }

        private void HandleEncodeType(string value)
        {
            switch (value)
            {
                case "CRF":
                    this.EncodeType = EnumEncodeType.CRF;
                    break;
                case "2Pass":
                    this.EncodeType = EnumEncodeType.TwoPass;
                    break;
                default:
                    throw new Exception("Invalid Encode Type");
            }

            this.SetX264TemplateTextBox();
        }

        private void btnLoadAVSFiles_Click(object sender, EventArgs e)
        {
            this.LoadAVSFiles();
        }

        private X264FileSettings GetX264FileSettings()
        {
            return new X264FileSettings() { AVSFileFilter = "encode*", AVSPath = txtAVSFileLocation.Text, EncodeType = EncodeType,
             vfw4x264Exe = txtVfw4x264exe.Text, X264Template = txtX264Template.Text};
        }

        private void LoadAVSFiles()
        {
            X264FileSettings x264FileSettings = this.GetX264FileSettings();
            IValidationService validationService = new ValidationService(x264FileSettings);
            if (validationService.Validate().Count() == 0)
            {
                IFileService fileService = new FileService(x264FileSettings);
                _x264Files = fileService.GetAVSFiles();
                bsFiles.DataSource = _x264Files;
            }
        }

        private void btnCreateX264BatFile_Click(object sender, EventArgs e)
        {
            this.CreateX264BatFile();
        }

        private void CreateX264BatFile()
        {
            X264FileSettings x264Settings = this.GetX264FileSettings();
            IEncodeService encodeService = new EncodeService(x264Settings, _x264Files);
            if (encodeService.CreateX264File().Count() == 0)
            {
                MessageBox.Show("The x264 batch file has been created!");
                this.SetComboBoxEncodeType();
                bsFiles.Clear();
                this.HandleRowsRemoved();
            }
            else
            {
                //Show errors
            }
        }

        private void dgvFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.HandleRowsRemoved();
        }

        private void HandleRowsRemoved()
        {
            lblNumberOfFiles.Text = string.Format("Number of Files: {0}", _x264Files.Count());
        }
    }
}
