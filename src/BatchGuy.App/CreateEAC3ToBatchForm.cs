using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.EAC.Models;
using BatchGuy.App.EAC.Services;

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        private EnumAudioType AudioType { get; set; }

        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
        }

        private void CreateEAC3ToBatchForm_Load(object sender, EventArgs e)
        {
            this.SetComboBoxAudioType();
            this.SetAudioSettingsTextBox();
            this.SetComboBoxAudioLanguage();

        }

        private void btnWriteToBatFile_Click(object sender, EventArgs e)
        {
            this.WriteToBatchFile();
        }

        private void WriteToBatchFile()
        {
            EAC3ToBluRayFile file = this.GetEAC3ToBluyRayFile();
            EAC3ToConfiguration config = this.GetEAC3ToConfiguration();
            IEACOutputService eacOutputService = new EACOutputService(config, file);
            IBatFileWriteService batFileWriteService = new BatFileWriteService(config, file, eacOutputService);
            batFileWriteService.Write();
            this.Clear();
            this.IncrementEpisodeNumber();
        }

        private EAC3ToConfiguration GetEAC3ToConfiguration()
        {
            return new EAC3ToConfiguration()
            {
                 BatFilePath = txtBatFilePath.Text,
                  BluRayPath = txtBluRayPath.Text,
                   EAC3ToPath = txtEAC3ToPath.Text,
                    AudioSettings = txtAudioSettings.Text,
                     AudioType = this.AudioType,
                     AudioLanguage = cbAudioLanguage.Text
            };
        }

        private EAC3ToBluRayFile GetEAC3ToBluyRayFile()
        {
            return new EAC3ToBluRayFile()
            {
                 BluRayEpisodeFolder = txtBluRayEpisodeFolder.Text,
                  BluRaySteamNumber = txtBluRayStreamNumber.Text,
                   MainAudioStreamNumber = txtMainAudioStreamNumber.Text,
                   MainSubtitleStreamNumber = txtMainSubtitleStreamNumber.Text,
                   ChapterStreamNumber = txtChapterStreamNumber.Text,
                    MovieStreamNumber = txtMovieStreamNumber.Text
            };
        }

        private void Clear()
        {
            txtBluRayStreamNumber.Text = string.Empty;
            txtBluRayStreamNumber.Focus();
        }

        private void IncrementEpisodeNumber()
        {
            int episode = Convert.ToInt32(txtBluRayEpisodeFolder.Text) + 1;
            txtBluRayEpisodeFolder.Text = episode.ToString();
        }

        private void CreateEAC3ToBatchForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.WriteToBatchFile();
            }
        }

        private void SetComboBoxAudioType()
        {
            this.cbAudioType.SelectedIndex = 0;
        }

        private void SetComboBoxAudioLanguage()
        {
            this.cbAudioLanguage.SelectedIndex = 0;
        }

        private void SetAudioSettingsTextBox()
        {
            switch (this.AudioType)
            {
                case EnumAudioType.DTS:
                    txtAudioSettings.Text = "-core";
                    break;
                case EnumAudioType.AC3:
                    txtAudioSettings.Text = string.Empty;
                    break;
                case EnumAudioType.FLAC:
                    txtAudioSettings.Text = string.Empty;
                    break;
                case EnumAudioType.TrueHD:
                    txtAudioSettings.Text = "-640";
                    break;
                default:
                    break;
            }
        }

        private void cbAudioType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleAudioTypeChanged(cbAudioType.Text);
        }

        private void HandleAudioTypeChanged(string value)
        {
            switch (value)
            {
                case "DTS":
                    this.AudioType = EnumAudioType.DTS;
                    break;
                case "AC3":
                    this.AudioType = EnumAudioType.AC3;
                    break;
                case "FLAC":
                    this.AudioType = EnumAudioType.FLAC;
                    break;
                case "TrueHD":
                    this.AudioType = EnumAudioType.TrueHD;
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }

            this.SetAudioSettingsTextBox();
        }
    }
}
