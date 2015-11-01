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
        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
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
                   EAC3ToPath = txtEAC3ToPath.Text
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
        
    }
}
