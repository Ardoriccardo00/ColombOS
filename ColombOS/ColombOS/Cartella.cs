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
        string Media = Principale.Media;

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
            timer1.Enabled = true;

            Lista.Items.Clear();
            if (Media == "Immagini")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Immagini");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Immagini");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Musica")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Musica");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Musica");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Video")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Video");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Video");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Banco")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Banco");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Banco");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Scaricati")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Scaricati");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Scaricati");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Archivio")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Archivio");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Archivio");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else if (Media == "Utente")
            {
                string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Utente");
                string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Utente");

                foreach (string file in files)
                {
                    Lista.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    Lista.Items.Add(Path.GetFileName(dir));
                }
            }
            else { MessageBox.Show("Non è stato possibile trovare il tipo di cartella!", "Errore!"); }
        }

        private void Lista_DoubleClick(object sender, EventArgs e)
        {
            Programma = Convert.ToString(Lista.SelectedItem);
            programmaCompleto = Principale.percorsoImmagini + "/" + Programma;

            if (Media == "Immagini")
            {
                PhotoViewer pw = new PhotoViewer();
                pw.Show();

            }
        
            else
            {System.Diagnostics.Process.Start(programmaCompleto); }

            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNomeCartella.Text = Media;
        }
    }
}
