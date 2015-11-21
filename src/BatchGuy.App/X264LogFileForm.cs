using BatchGuy.App.X264Log.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Extensions;

namespace BatchGuy.App
{
    public partial class X264LogFileForm : Form
    {
        private BindingList<X264LogFile> _bindingListLogFiles = new BindingList<X264LogFile>();
        private string _logExtension = "log";
        private SortConfiguration _logFilesGridSortConfiguration = new SortConfiguration();

        public X264LogFileForm()
        {
            InitializeComponent();
        }

        private void dgvLogFiles_DragEnter(object sender, DragEventArgs e)
        {
            this.HandleDgvLogFilesDragEnter(e);
        }

        private void HandleDgvLogFilesDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvLogFiles_DragDrop(object sender, DragEventArgs e)
        {
            this.HandleDgvLogFilesDragDrop(e);
        }

        private void HandleDgvLogFilesDragDrop(DragEventArgs e)
        {
            foreach (string file in (Array) e.Data.GetData(DataFormats.FileDrop))
            {
                if (this.IsALogFile(file) && this.NotADuplicate(file))
                {
                    _bindingListLogFiles.Add(new X264LogFile() { FileNameOnly = Path.GetFileName(file), FilePath = file });
                }
            }
            if (_bindingListLogFiles.Count() > 0)
            {
                this.BindLogFilesGrid();
            }
        }

        private bool IsALogFile(string file)
        {
            if (file.EndsWith(_logExtension))
                return true;
            else
                return false;
        }

        private bool NotADuplicate(string file)
        {
            var t = Path.GetFileName(file);
            if (_bindingListLogFiles.Where(l => l.FileNameOnly == Path.GetFileName(file)).Count() == 0)
                return true;
            else
                return false;
        }

        private void BindLogFilesGrid()
        {
            bsLogFiles.DataSource = _bindingListLogFiles;
            bsLogFiles.ResetBindings(false);
            _bindingListLogFiles.AllowEdit = false;
            this.SetLabelLogFileCount();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            this.HandleBtnViewLogs();
        }

        private void HandleBtnViewLogs()
        { 
        }

        private void dgvLogFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.HandleDgvLogFilesRowsRemoved(e);
        }

        private void HandleDgvLogFilesRowsRemoved(DataGridViewRowsRemovedEventArgs e)
        {
            this.SetLabelLogFileCount();
        }

        private void SetLabelLogFileCount()
        {
            lblLogFileCount.Text = string.Format("Count: {0}", _bindingListLogFiles.Count().ToString());
        }

        private void dgvLogFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.SortLogFilesGrid(e.ColumnIndex);
            }
        }

        private void SortLogFilesGrid(int sortColumnNumber)
        {
            if (_bindingListLogFiles.Count() == 0)
                return;

            gbScreen.SetEnabled(false);

            List<X264LogFile> logFiles = new List<X264LogFile>();
            string sortColumnName = dgvLogFiles.Columns[sortColumnNumber].DataPropertyName;
            _logFilesGridSortConfiguration.SortByColumnName = sortColumnName;
            ISortService<X264LogFile> sortService = new SortService<X264LogFile>(_logFilesGridSortConfiguration, logFiles);

            foreach (X264LogFile log in _bindingListLogFiles)
            {
                logFiles.Add(new X264LogFile() { FileNameOnly = log.FileNameOnly, FilePath = log.FilePath });
            }

            IBindingListSortService<X264LogFile> bindingListSortService = new BindingListSortService<X264LogFile>(logFiles, dgvLogFiles,
                _logFilesGridSortConfiguration, sortService);
            _bindingListLogFiles = bindingListSortService.Sort();

            this.BindLogFilesGrid();

           gbScreen.SetEnabled(true);
        }
    }
}
