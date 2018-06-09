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
        public static string Media;

        string Programma;
        public static string programmaCompleto;
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
            MessageBox.Show("Il nome della cartella è" + Media);
            lblNomeCartella.Text = Media;

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
            Programma = Convert.ToString(Lista.SelectedItem);
            programmaCompleto = Principale.percorsoImmagini + "/" + Programma;

            PhotoViewer pw = new PhotoViewer();
            pw.Show();

            //System.Diagnostics.Process.Start(programmaCompleto);
        }
    }
}
