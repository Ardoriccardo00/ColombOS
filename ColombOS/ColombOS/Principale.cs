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
using Tulpep.NotificationWindow;

namespace ColombOS
{
    public partial class Principale : Form
    {
        public static string Programma;
        public static string ProgrammaCompleto;
        public static string recProgrammaCompleto;
        public static string cartellaRadice;
        string ciao = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        int RecPos1 = 295;
        int RecPos2 = 60;
        int RecPulsanti = 0;

        string percorsoProgrammi;
        string percorsoBanco;
        string percorsoArchivio;
       public static string percorsoImmagini;
        string percorsoMusica;
        string pProgrammi;
        string percorsoScaricati;
        string percorsoVideo;

       public static string Media;

        public Principale()
        {
            InitializeComponent();
        }

        private void btnTutti_Click(object sender, EventArgs e) // Pulsante Tutti i programmi
        {
            if (panProgrammi.Visible == false) { panProgrammi.Visible = true;}
            else if (panProgrammi.Visible == true) { panProgrammi.Visible = false;}

            listaProgrammi.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Programmi");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Programmi");

            foreach (string file in files)
            {
                listaProgrammi.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listaProgrammi.Items.Add(Path.GetFileName(dir));
            }
        }

        private void listaProgrammi_DoubleClick(object sender, EventArgs e)
        {
            if (RecPulsanti == 0) { RecPos1 = 295; RecPos2 = 60; }
            if (RecPulsanti == 1) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 2) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 3) { RecPos1 = RecPos1 - 200; RecPos2 = RecPos2 + 100; }
            if (RecPulsanti == 4) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 5) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 6) { RecPulsanti = 0; }

            Programma = Convert.ToString(listaProgrammi.SelectedItem);
            ProgrammaCompleto = percorsoProgrammi + "/" + Programma;

            Button btn = new Button();
            btn.Name = Programma;
            btn.Text = Programma;
            btn.Location = new Point(RecPos1, RecPos2);
            btn.Height = 47;
            btn.Width = 75;
            btn.Click += new EventHandler(btn_Click);
            Controls.Add(btn);
            recProgrammaCompleto = btn.Text;
            label7.Text = Convert.ToString(RecPulsanti);
            RecPulsanti = RecPulsanti + 1;
            btn.BringToFront();

            Process.Start(ProgrammaCompleto);
            label7.Text = Convert.ToString(ProgrammaCompleto);
        }

        private void btn_Click(object sender, EventArgs e) // Click pulsante
        {
            string lol;
            lol = percorsoProgrammi + "/" + recProgrammaCompleto;
            label7.Text = Convert.ToString(lol);
            Process.Start(lol);
        }

        private void btnUtente_Click(object sender, EventArgs e) // Click utente
        {
            //MessageBox.Show(Installazione.percorsoNomeUtente);
            //Process.Start(Installazione.percorsoNomeUtente);
        }

        private void Principale_Load(object sender, EventArgs e) // Load Principale
        {
            ControlExtension.Draggable(pannello, true);

            cartellaRadice = ciao + "/" + "Radice";
            label7.Text = cartellaRadice;

             percorsoProgrammi = cartellaRadice + "/Programmi";
            label7.Text = percorsoProgrammi;
            percorsoBanco = cartellaRadice + "/Banco";
            percorsoArchivio = cartellaRadice + "/Archivio";
            percorsoImmagini = cartellaRadice + "/" + "Immagini";
            percorsoMusica = cartellaRadice + "/Musica";
           pProgrammi = cartellaRadice + "/Programmi";
            percorsoScaricati = cartellaRadice + "/Scaricati";
            percorsoVideo = cartellaRadice + "/Video";
        }

        private void btnAggiungiUltimo_Click(object sender, EventArgs e) // Pulsante Aggiungi ultimo
        {
            Button Icona = new Button(); // 742, 434
            Icona.Name = Programma;
            Icona.Text = Programma;
            Icona.Location = new Point(742, 434);
            Icona.Height = 47;
            Icona.Width = 75;
            Icona.Click += new EventHandler(btn_Click);
            Controls.Add(Icona);

            ControlExtension.Draggable(Icona, true);
        }

        private void button1_Click(object sender, EventArgs e) // Cerca
        {
            MessageBox.Show("Tanto non funziona lol", "Avviso");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e) // Click lista
        {
            string Immagine = Convert.ToString(listBox2.SelectedItem);
            string ImmagineCompleta = percorsoImmagini + "/" + Immagine;
            Process.Start(ImmagineCompleta);
        }

        private void btnChiudi_Click(object sender, EventArgs e) // Pulsante chiudi
        {
            pannello.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Pulsante spegni
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panStart.Visible == false) { panStart.Visible = true; }
            else if (panStart.Visible == true) { panStart.Visible = false; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Impostazioni impostazioni = new Impostazioni();
            impostazioni.Show();
        }

        private void btnImmagini_Click_1(object sender, EventArgs e)
        {
            Media = "Immagini";

            Cartella c = new Cartella();
            c.Show();
        }

        private void btnVideo_Click_1(object sender, EventArgs e)
        {
            Media = "Video";

            Cartella c = new Cartella();
            c.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Media = "Musica";

            Cartella c = new Cartella();
            c.Show();
        } // Pulsante musica

        private void btnBanco_Click_1(object sender, EventArgs e)
        {
            Media = "Banco";

            Cartella c = new Cartella();
            c.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Media = "Archivio";

            Cartella c = new Cartella();
            c.Show();
        }

        private void btnScaricati_Click_1(object sender, EventArgs e)
        {
            Media = "Scaricati";

            Cartella c = new Cartella();
            c.Show();
        }
    }
}


//OpenFileDialog ofd = new OpenFileDialog();
//if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//{
//    string FilePath = ofd.FileName;
//    label7.Text = FilePath;
//    Process.Start(FilePath);
//}