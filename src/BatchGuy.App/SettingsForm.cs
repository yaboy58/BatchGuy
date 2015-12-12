using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Extensions;

namespace BatchGuy.App
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            txtEac3toPath.Text = this.LoadSetting("eac3to");
            txtVfw4x264.Text = this.LoadSetting("vfw4x264");
        }

        private string LoadSetting(string settingName)
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(settingName);
            if (setting != null)
                return setting.Value;
            else
                return string.Empty;
        }

        private void btnOpenEac3toFileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenEac3ToFileDialogClick();
        }

        private void HandleOpenEac3ToFileDialogClick()
        {
            ofdFileDialog.FileName = "eac3to executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               txtEac3toPath.Text = ofdFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gbScreen.SetEnabled(false);
            this.HandleSaveClick();
            this.Close();
        }

        private void HandleSaveClick()
        {
            Program.ApplicationSettings.Settings.Clear();
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "eac3to", Value = txtEac3toPath.Text } );
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "vfw4x264", Value = txtVfw4x264.Text });
            
            Program.ApplicationSettingsService.Save(Program.ApplicationSettings);
        }

        private bool IsScreenValid()
        {
            if (string.IsNullOrEmpty(txtEac3toPath.Text) || string.IsNullOrEmpty(txtVfw4x264.Text))
            {
                MessageBox.Show("All settings must be entered to save!", "Settings Information Not Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnOpenVfw4x264FileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenVfw4x264FileDialogClick();
        }

        private void HandleOpenVfw4x264FileDialogClick()
        {
            ofdFileDialog.FileName = "Vfw4x264 executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtVfw4x264.Text = ofdFileDialog.FileName;
            }
        }
    }
}
