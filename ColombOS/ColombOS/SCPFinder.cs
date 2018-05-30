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
using System.Diagnostics;

namespace ColombOS
{
    public partial class SCPFinder : Form
    {
        string LinkBase = "http://www.scp-wiki.net/scp-";
        string LinkCerca;

        public SCPFinder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cerca_Click(object sender, EventArgs e)
        {
            string LinkCerca = LinkBase + Convert.ToString(testo.Text);
            label1.Text = LinkCerca;
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = LinkCerca;
            Process.Start(prs);
        }

        private void Ingrandisci_Click(object sender, EventArgs e)
        {
           
        }

        private void SCPFinder_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            testo.Focus();
        }

        private void SCPFinder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Cerca.Focus(); Cerca.PerformClick(); }
        }
    }
}
