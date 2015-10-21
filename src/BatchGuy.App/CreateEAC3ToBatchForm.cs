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
            EAC3ToBluRayFile file = this.GetEAC3ToBluyRayFile();
            EAC3ToConfiguration config = this.GetEAC3ToConfiguration();
            IBatWriteService service = new BatWriteService(config, file);
            service.Write();
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
                 BluRayOutputFolder = txtBluRayOutputFolder.Text,
                  BluRaySteamNumber = txtBluRayStreamNumber.Text,
                   MainAudioStreamNumber = txtMainAudioStreamNumber.Text,
                   MainSubtitleStreamNumber = txtMainSubtitleStreamNumber.Text
            };
        }
    }
}
