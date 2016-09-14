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

        public BluRayTitleInfoExternalSubtitleForm()
        {
            InitializeComponent();
        }

        public void SetBluRayTitleInfoExternalSubtitleForAdd(BluRaySummaryInfo bluRaySummaryInfo)
        {
            _currentBluRaySummaryInfo = bluRaySummaryInfo;
            _isAdd = true;
            lblExternalSubtitleEAC3ToTrackId.Text = string.Empty;
        }

        private void BluRayTitleInfoExternalSubtitleForm_Load(object sender, EventArgs e)
        {
            this.LoadMKVMergeLangugeItemsDropDown();
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
        }
    }
}
