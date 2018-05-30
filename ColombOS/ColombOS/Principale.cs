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
    public partial class Principale : Form
    {
        public Principale()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SCPFinder_Click(object sender, EventArgs e)
        {
            SCPFinder scp = new SCPFinder();
            scp.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panStart.Visible = true;
        }

        private void btnSpegni_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
