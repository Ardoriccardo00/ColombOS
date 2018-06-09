using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombOS
{
    public partial class Cartella : Form
    {
        public Point mouseLocation;

        public Cartella()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelImmagini_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelImmagini_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Cartella_Load(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Immagini");
            string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Immagini");  //FBD.SelectedPath

            foreach (string file in files)
            {
                Lista.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                Lista.Items.Add(Path.GetFileName(dir));
            }
        }

        private void Lista_DoubleClick(object sender, EventArgs e)
        {
            string Programma = Convert.ToString(Lista.SelectedItem);
            string ProgrammaCompleto = Principale.percorsoImmagini + "/" + Programma;

            System.Diagnostics.Process.Start(ProgrammaCompleto);
        }
    }
}
