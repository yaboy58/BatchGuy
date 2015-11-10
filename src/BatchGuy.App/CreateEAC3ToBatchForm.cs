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
using BatchGuy.App.Helpers;

namespace BatchGuy.App
{
    public partial class CreateEAC3ToBatchForm : Form
    {
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private BluRayDiscInfo _currentBluRayDiscInfo;
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private BindingList<BluRayDiscInfo> _bindingListBluRayDiscInfo = new BindingList<BluRayDiscInfo>();
        private BindingList<BluRaySummaryInfo> _bindingListBluRaySummaryInfo;


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
            IBatchFileWriteService batFileWriteService = new BatchFileWriteService(_bluRayDiscInfoList);
            batFileWriteService.Write();
            MessageBox.Show("Batch File created!", "Process Complete", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
        }

        private void btnLoadBluRay_Click(object sender, EventArgs e)
        {

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
                    BatFilePath = txtBatFilePath.Text,
                    BluRayPath = txtBluRayPath.Text,
                    EAC3ToPath = txtEAC3ToPath.Text
                }
            };

            _bluRayDiscInfoList.Add(info);
            _bindingListBluRayDiscInfo.Add(info);

            bsBluRayDiscInfo.DataSource = _bindingListBluRayDiscInfo;
        }

        private void dgvBluRayDiscInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDgvBluRayDiscInfoCellClick(e);
            if (_currentBluRayDiscInfo.BluRaySummaryInfoList == null)
            {
                this.HandleLoadBluRay();
            }
            else
            {
                _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();
                foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }
            }
            this.BindDgvBluRaySummaryGrid();
            gbDiscSummary.Text = string.Format("Disc Summary: {0}", _currentBluRayDiscInfo.DiscName);
        }

        private void HandleDgvBluRayDiscInfoCellClick(DataGridViewCellEventArgs e)
        {
            var id = dgvBluRayDiscInfo.Rows[e.RowIndex].Cells[1].Value;
            _currentBluRayDiscInfo = _bluRayDiscInfoList.SingleOrDefault(d => d.Id == HelperFunctions.StringToInt(id.ToString()));
        }

        private void HandleLoadBluRay()
        {
            _bindingListBluRaySummaryInfo = new BindingList<BluRaySummaryInfo>();

            //Blu ray streams
            _commandLineProcessStartInfo = new CommandLineProcessStartInfo()
            {
                FileName = txtEAC3ToPath.Text,
                Arguments = string.Format("\"{0}\"", txtBluRayPath.Text)
            };

            ICommandLineProcessService commandLineProcessService = new CommandLineProcessService(_commandLineProcessStartInfo);
            if (commandLineProcessService.Errors.Count() == 0)
            {
                //Get line items
                List<ProcessOutputLineItem> processOutputLineItems = commandLineProcessService.GetProcessOutputLineItems();
                ////:Get the Blu ray summary list
                ILineItemIdentifierService lineItemService = new BluRaySummaryLineItemIdentifierService();
                IBluRaySummaryParserService parserService = new BluRaySummaryParserService(lineItemService, processOutputLineItems);
                _currentBluRayDiscInfo.BluRaySummaryInfoList = parserService.GetSummaryList();

                foreach (BluRaySummaryInfo info in _currentBluRayDiscInfo.BluRaySummaryInfoList)
                {
                    _bindingListBluRaySummaryInfo.Add(info);
                }
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

        private void BindDgvBluRaySummaryGrid()
        {
            bsBluRaySummaryInfo.DataSource = _bindingListBluRaySummaryInfo;
            bsBluRaySummaryInfo.ResetBindings(false);
            _bindingListBluRaySummaryInfo.AllowEdit = true;
        }

        private void dgvBluRaySummary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.HandleDgvBluRaySummaryCellClick(e);
        }

        private void HandleDgvBluRaySummaryCellClick(DataGridViewCellEventArgs e)
        {
            var id = dgvBluRaySummary.Rows[e.RowIndex].Cells[1].Value;
            BluRaySummaryInfo summaryInfo = _currentBluRayDiscInfo.BluRaySummaryInfoList.SingleOrDefault(s => s.Id == id.ToString());

            BluRayTitleInfoForm form = new BluRayTitleInfoForm();
            form.SetBluRayTitleInfo(summaryInfo, _commandLineProcessStartInfo);
            form.ShowDialog();
            this.BindDgvBluRaySummaryGrid();
        }
    }
}
