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
    public partial class X264LogFileDisplayForm : Form
    {
        private string _logs = string.Empty;
        public X264LogFileDisplayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public void SetLogs(string logs)
        {
            _logs = logs;
        }

        private void X264LogFileDisplayForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Program.GetApplicationVersion();
            txtLogs.Text = _logs;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
