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
            return new X264FileSettings() { AVSFileFilter = "encode*", AVSPath = txtAVSFileLocation.Text };
        }

        private void LoadAVSFiles()
        {
            X264FileSettings x264FileSettings = this.GetX264FileSettings();
            IValidationService validationService = new ValidationService(x264FileSettings);
            if (validationService.Validate().Count() == 0)
            {
                IFileService fileService = new FileService(x264FileSettings);
                bsFiles.DataSource = fileService.GetAVSFiles();
            }
        }
    }
}
