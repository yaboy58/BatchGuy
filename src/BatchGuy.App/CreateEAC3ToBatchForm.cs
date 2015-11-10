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
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App.EAC.Interfaces;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Enums;

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        private EnumAudioType _audioType;
        private List<BluRaySummaryInfo> _summaryInfoList;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();


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
                     AudioType = this._audioType,
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
            switch (this._audioType)
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
                    this._audioType = EnumAudioType.DTS;
                    break;
                case "AC3":
                    this._audioType = EnumAudioType.AC3;
                    break;
                case "FLAC":
                    this._audioType = EnumAudioType.FLAC;
                    break;
                case "TrueHD":
                    this._audioType = EnumAudioType.TrueHD;
                    break;
                default:
                    throw new Exception("Invalid Audio Type");
            }

            this.SetAudioSettingsTextBox();
        }

        private void btnLoadBluRay_Click(object sender, EventArgs e)
        {
            this.HandleLoadBluRay();
        }

        private void HandleLoadBluRay()
        {
            ////:Blu ray streams
            _commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = txtEAC3ToPath.Text,
                Arguments = string.Format("\"{0}\"", txtBluRayPath.Text)
            };

            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(_commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                ////:Get line items
                List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();
                ////:Get the Blu ray summary list
                ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, processOutputLineItems);
                _summaryInfoList = parserService.GetSummaryList();

                foreach (BluRaySummaryInfo info in _summaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }

                bsBluRaySummaryInfo.DataSource = _bindingListBluRaySummaryInfo;
                _bindingListBluRaySummaryInfo.AllowEdit = true;
            }
            else
            {
                System.Console.WriteLine("The following errors were found:");
                foreach (var error in commandLineProcessService.Errors)
                {
                    //TODO:Display Error Message
                }
            }
        }

        private void dgvBluRaySummary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDGVBluRaySummaryCellDoubleClick(e);
        }

        private void HandleDGVBluRaySummaryCellDoubleClick(DataGridViewCellEventArgs e)
        {
            var id = dgvBluRaySummary.Rows[e.RowIndex].Cells[1].Value;
            BluRaySummaryInfo summaryInfo = _summaryInfoList.SingleOrDefault(s => s.Id == id.ToString());

            BluRayTitleInfoForm form = new BluRayTitleInfoForm();
            form.SetBluRayTitleInfo(summaryInfo, _commandLineProcessStartInfo);
            form.ShowDialog();
        }
    }
}
