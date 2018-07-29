using System;
using System.Windows.Forms;

namespace BatchGuy.App
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Program.GetApplicationVersion();
        }
    }
}
