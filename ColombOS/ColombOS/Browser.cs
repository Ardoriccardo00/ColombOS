using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombOS
{
    public partial class Browser : Form
    {
        string Url;

        public Browser()
        {
            InitializeComponent();
        }

        private void panelImmagini_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Url = txtUrl.Text;
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = Url;
            Process.Start(prs);
        }
    }
}
