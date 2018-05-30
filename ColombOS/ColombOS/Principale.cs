using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            Application.Exit();
        }

        private void btnTutti_Click(object sender, EventArgs e)
        {
            panProgrammi.Visible = true;

            // FolderBrowserDialog FBD = new FolderBrowserDialog();

            //if (FBD.ShowDialog() == DialogResult.OK)
            //{

                listBox1.Items.Clear();
                string[] files = Directory.GetFiles("C:/Users/Riccardo/Radice/Programmi");
                string[] dirs = Directory.GetDirectories("C:/Users/Riccardo/Radice/Programmi");  //FBD.SelectedPath

                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
          //  }
        }
    }
}
