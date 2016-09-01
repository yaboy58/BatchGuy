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
using BatchGuy.App.Settings.Models;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;

namespace BatchGuy.App
{
    public partial class SettingsForm : Form
    {
        private BindingList<BluRayTitleInfoDefaultSettingsAudio> _bindingBluRayTitleInfoDefaultSettingsAudio = new BindingList<BluRayTitleInfoDefaultSettingsAudio>();
        private BindingList<MKVMergeLanguageItem> _bindingListSubtitlesAndMKVMergeDefaultSettingsLanguage = new BindingList<MKVMergeLanguageItem>();

        public SettingsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.LoadMKVLanguageDropDownBoxes();
            this.LoadSettings();
            this.LoadControls();
        }

        private void LoadSettings()
        {
            txtEac3toPath.Text = this.LoadSetting("eac3to");
            txtVfw4x264.Text = this.LoadSetting("vfw4x264");
            txtMKVMerge.Text = this.LoadSetting("mkvmerge");

            foreach (BluRayTitleInfoDefaultSettingsAudio bluRayTitleInfoDefaultSettingsAudio in Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.Audio)
            {
                _bindingBluRayTitleInfoDefaultSettingsAudio.Add(bluRayTitleInfoDefaultSettingsAudio);
            }
            bsBluRayTitleInfoDefaultSettingsAudio.DataSource = _bindingBluRayTitleInfoDefaultSettingsAudio;
        }

        private void LoadControls()
        {
            chkBluRayTitleInfoDefaultSettingsSelectChapters.Checked = Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectChapters;
            chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Checked = Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectAllSubtitles;
            chkShowProgressNumbers.Checked = Program.ApplicationSettings.EAC3ToDefaultSettings.ShowProgressNumbers;
            chkSubtitleLanguageAlwaysSelectedEnabled.Checked = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;
            cbSubtitlesMKVMergeDefaultSettingsLanguage.SelectedValue = Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Value;
            cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.SelectedIndex = cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.FindString(Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag);
            gbSubtitlesMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;
        }

        private void LoadMKVLanguageDropDownBoxes()
        {
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            foreach (MKVMergeLanguageItem item in service.GetLanguages())
            {
                _bindingListSubtitlesAndMKVMergeDefaultSettingsLanguage.Add(item);
            }

            bsSubtitlesAndMKVMergeDefaultSettingsLanguage.DataSource = _bindingListSubtitlesAndMKVMergeDefaultSettingsLanguage;
            _bindingListSubtitlesAndMKVMergeDefaultSettingsLanguage.AllowEdit = false;
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
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "mkvmerge", Value = txtMKVMerge.Text });

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

        private void btnOpenMKVMergeFileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenMKVMergeFileDialogClick();
        }

        private void HandleOpenMKVMergeFileDialogClick()
        {
            ofdFileDialog.FileName = "mkvmerge executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
              txtMKVMerge.Text = ofdFileDialog.FileName;
            }
        }

        private void chkBluRayTitleInfoDefaultSettingsSelectSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkBluRayTitleInfoDefaultSettingsSelectSubtitlesCheckedChanged();
        }

        private void HandlesChkBluRayTitleInfoDefaultSettingsSelectSubtitlesCheckedChanged()
        {
            Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectAllSubtitles = chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Checked;
        }

        private void chkBluRayTitleInfoDefaultSettingsSelectChapters_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkBluRayTitleInfoDefaultSettingsSelectChaptersCheckedChanged();
        }

        private void HandlesChkBluRayTitleInfoDefaultSettingsSelectChaptersCheckedChanged()
        {
            Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectChapters = chkBluRayTitleInfoDefaultSettingsSelectChapters.Checked;
        }

        private void dgvBluRayTitleInfoDefaultSettingsAudio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBluRayTitleInfoDefaultSettingsAudio.Rows[e.RowIndex].Selected = true; 
        }

        private void chkShowProgressNumbers_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkShowProgressNumbersCheckedChanged();
        }

        private void HandlesChkShowProgressNumbersCheckedChanged()
        {
            Program.ApplicationSettings.EAC3ToDefaultSettings.ShowProgressNumbers = chkShowProgressNumbers.Checked;
        }

        private void chkSubtitleLanguageAlwaysSelectedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkSubtitleLanguageAlwaysSelecedEnabledCheckedChanged();
        }

        private void HandlesChkSubtitleLanguageAlwaysSelecedEnabledCheckedChanged()
        {
            Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled = chkSubtitleLanguageAlwaysSelectedEnabled.Checked;
            gbSubtitlesMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;
        }

        private void cbSubtitlesMKVMergeDefaultSettingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBSubtitlesMKVMergeDefaultSettingsLanguageSelectedIndexChanged();
        }

        private void HandlesCBSubtitlesMKVMergeDefaultSettingsLanguageSelectedIndexChanged()
        {
            Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language = (MKVMergeLanguageItem)cbSubtitlesMKVMergeDefaultSettingsLanguage.SelectedItem;
        }

        private void cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBSubtitlesMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged();
        }

        private void HandlesCBSubtitlesMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged()
        {
            Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag = cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Text;
        }
    }
}
