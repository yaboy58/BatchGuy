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

namespace BatchGuy.App
{
    public partial class X264LogFileForm : Form
    {
        private BindingList<X264LogFile> _logFiles = new BindingList<X264LogFile>();

        public X264LogFileForm()
        {
            InitializeComponent();
        }

        private void dgvLogFiles_DragEnter(object sender, DragEventArgs e)
        {
            this.HandleDgvDragEnter(e);
        }

        private void HandleDgvDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
