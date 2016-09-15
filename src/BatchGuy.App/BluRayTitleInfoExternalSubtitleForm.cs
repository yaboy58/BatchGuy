using BatchGuy.App.Extensions;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Services;
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
    public partial class BluRayTitleInfoExternalSubtitleForm : Form
    {
        private bool _isAdd;
        private BluRaySummaryInfo _currentBluRaySummaryInfo;
        private BindingList<MKVMergeLanguageItem> _bindingListMKVMergeLanguageItem = new BindingList<MKVMergeLanguageItem>();
        private MKVMergeItem _currentMKVMergeItem;
        private BluRayTitleSubtitle _currentSubtitleForEdit;

        public bool WasSaved { get; set; }
        public bool WasCancelled { get; set; }

        public BluRayTitleInfoExternalSubtitleForm()
        {
            InitializeComponent();
        }

        public void SetBluRayTitleInfoExternalSubtitleForAdd(BluRaySummaryInfo bluRaySummaryInfo)
        {
            _currentBluRaySummaryInfo = bluRaySummaryInfo;
            _isAdd = true;
            lblExternalSubtitleEAC3ToTrackId.Text = string.Empty;
            _currentMKVMergeItem = new MKVMergeItem() { Compression = "determine automatically", DefaultTrackFlag = "no", ForcedTrackFlag = "no" };
        }

        public void SetBluRayTitleInfoExternalSubtitleForEdit(BluRayTitleSubtitle subtitle)
        {
            _isAdd = false;
            _currentSubtitleForEdit = subtitle;
            _currentMKVMergeItem = new MKVMergeItem()
            {
                Compression = _currentSubtitleForEdit.MKVMergeItem.Compression,
                DefaultTrackFlag = _currentSubtitleForEdit.MKVMergeItem.DefaultTrackFlag,
                ForcedTrackFlag = _currentSubtitleForEdit.MKVMergeItem.ForcedTrackFlag,
                TrackName = _currentSubtitleForEdit.MKVMergeItem.TrackName,
                Language = new MKVMergeLanguageItem() { Name = _currentSubtitleForEdit.MKVMergeItem.Language.Name, Value = _currentSubtitleForEdit.MKVMergeItem.Language.Value,
                 Language = _currentSubtitleForEdit.MKVMergeItem.Language.Language}
            };
            lblExternalSubtitleEAC3ToTrackId.Text = _currentSubtitleForEdit.Id;
            txtExternalSubtitlePath.Text = _currentSubtitleForEdit.ExternalSubtitlePath;
        }

        private void SetMKVMergeLanguageDropDownValue()
        {
            cbExternalSubtitleLanguage.SelectedValue = _currentSubtitleForEdit.MKVMergeItem.Language.Value;
        }

        private void BluRayTitleInfoExternalSubtitleForm_Load(object sender, EventArgs e)
        {
            this.LoadMKVMergeLangugeItemsDropDown();

            if (_isAdd == false)
            {
                this.SetMKVMergeLanguageDropDownValue();
            }
        }

        private void LoadMKVMergeLangugeItemsDropDown()
        {
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            foreach (MKVMergeLanguageItem item in service.GetLanguages())
            {
                _bindingListMKVMergeLanguageItem.Add(item);
            }

            bsMKVMergeLanguageItem.DataSource = _bindingListMKVMergeLanguageItem;
            _bindingListMKVMergeLanguageItem.AllowEdit = false;

            if (_isAdd)
            {
                _currentMKVMergeItem.Language = service.GetLanguageByName("undetermined");
            }
        }

        private void cbExternalSubtitleLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBExternalSubtitleLanguageSelectedIndexChanged();
        }

        private void HandlesCBExternalSubtitleLanguageSelectedIndexChanged()
        {
            _currentMKVMergeItem.Language = (MKVMergeLanguageItem)cbExternalSubtitleLanguage.SelectedItem;
        }

        private void btnOpenExternalSubtitleFilePathDialog_Click(object sender, EventArgs e)
        {
            this.HandlesBtnOpenExternalSubtitleFilePathDialogClick();
        }


        private void HandlesBtnOpenExternalSubtitleFilePathDialogClick()
        {
            ofdFileDialog.FileName = "Subtitle";
            ofdFileDialog.Filter = "SubRip|*.srt|Advanced SubStation Alpha|*.ass|DVDSubtitle|*.sub|SubStation Alpha|*.ssa";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var subtitlePath = ofdFileDialog.FileName;
                txtExternalSubtitlePath.Text = subtitlePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.HandlesBtnSaveClick();
        }

        private void HandlesBtnSaveClick()
        {
            if (this.IsScreenValid())
            {
                if (_isAdd)
                    this.AddExternalSubtitle();
                else
                    this.EditExternalSubtitle();

                this.WasSaved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select external subtitles", "External Subtitles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddExternalSubtitle()
        {
            string id = string.Empty;
            string file = txtExternalSubtitlePath.Text;

            if (_currentBluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
                id = this.GetNewSubtitleId();
            else
                id = "1:";

            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle()
            {
                CanEdit = true,
                IsCommentary = false,
                IsExternal = true,
                IsSelected = true,
                Id = id,
                MKVMergeItem = _currentMKVMergeItem,
                ExternalSubtitlePath = file,
                 Language = _currentMKVMergeItem.Language.Language
            };

            subtitle.Text = string.Format("{0} Subtitle ({1}), {2}", id, file.SubtitleFileExtension(), subtitle.MKVMergeItem.Language.Language);

            if (_currentBluRaySummaryInfo.BluRayTitleInfo.Subtitles == null)
                _currentBluRaySummaryInfo.BluRayTitleInfo.Subtitles = new List<BluRayTitleSubtitle>();

            _currentBluRaySummaryInfo.BluRayTitleInfo.Subtitles.Add(subtitle);
        }

        private void EditExternalSubtitle()
        {
            if (_currentMKVMergeItem != null)
            {
                string file = txtExternalSubtitlePath.Text;
                _currentSubtitleForEdit.MKVMergeItem.Language = _currentMKVMergeItem.Language;
                _currentSubtitleForEdit.Text = string.Format("{0} Subtitle ({1}), {2}", _currentSubtitleForEdit.Id, file.SubtitleFileExtension(), _currentSubtitleForEdit.MKVMergeItem.Language.Language);
                _currentSubtitleForEdit.Language = _currentMKVMergeItem.Language.Language;
            }
        }

        private bool IsScreenValid()
        {
            if (txtExternalSubtitlePath.Text != null && txtExternalSubtitlePath.Text != string.Empty)
                return true;
            else
                return false;
        }

        private string GetNewSubtitleId()
        {
            int sum = 0;

            foreach (var subtitle in _currentBluRaySummaryInfo.BluRayTitleInfo.Subtitles)
            {
                sum += subtitle.Id.RemoveColons().StringToInt();
            }

            return string.Format("{0}:", sum);
        }
    }
}
