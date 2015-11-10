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
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private List<BluRaySummaryInfo> _summaryInfoList;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();
        private BindingList<BluRayDiscInfo> _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();


        public CreateEAC3ToBatchForm()
        {
            InitializeComponent();
        }

        private void CreateEAC3ToBatchForm_Load(object sender, EventArgs e)
        {
        }

        private void btnWriteToBatFile_Click(object sender, EventArgs e)
        {
            this.WriteToBatchFile();
        }

        private void WriteToBatchFile()
        {
            /*
            EAC3ToBluRayFile file = this.GetEAC3ToBluyRayFile();
            EAC3ToConfiguration config = this.GetEAC3ToConfiguration();
            IEACOutputService eacOutputService = new EACOutputService(config, file);
            IBatFileWriteService batFileWriteService = new BatFileWriteService(config, file, eacOutputService);
            batFileWriteService.Write();
            this.Clear();
            this.IncrementEpisodeNumber();
            */
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

        private void btnAddBluRayDisc_Click(object sender, EventArgs e)
        {
            this.HandleAddBluRayDiscClick();
        }

        private void HandleAddBluRayDiscClick()
        {
            if (_bluRayDiscInfoList == null)
                _bluRayDiscInfoList = new List<BluRayDiscInfo>();

            BluRayDiscInfo info = new BluRayDiscInfo()
            {
                Id = _bluRayDiscInfoList.Count + 1,
                IsSelected = false,
                EAC3ToConfiguration = new EAC3ToConfiguration()
                {
                    BatFilePath = string.Format("\"{0}\"", txtBatFilePath.Text),
                    BluRayPath = string.Format("\"{0}\"", txtBluRayPath.Text),
                    EAC3ToPath = string.Format("\"{0}\"", txtEAC3ToPath.Text)
                }
            };

            _bluRayDiscInfoList.Add(info);
            _bindingListBluRayDiscInfo.Add(info);

            bsBluRayDiscInfo.DataSource = _bindingListBluRayDiscInfo;
        }
    }
}
