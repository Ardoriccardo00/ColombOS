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

        public Principale()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) // Pulsante start
        {
            if (panStart.Visible == false) { panStart.Visible = true; }
            else if (panStart.Visible == true) { panStart.Visible = false; }
        }

        private void btnSpegni_Click(object sender, EventArgs e) // Pulsante spegni
        {
            Application.Exit();
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

       

        private void listBox1_DoubleClick(object sender, EventArgs e) // Lista tutti i programmi
        {
            if (RecPulsanti == 0) { RecPos1 = 295; RecPos2 = 60; }
            if (RecPulsanti == 1) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 2) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 3) { RecPos1 = RecPos1 - 200; RecPos2 = RecPos2 + 100; }
            if (RecPulsanti == 4) { RecPos1 = RecPos1 + 100;}
            if (RecPulsanti == 5) { RecPos1 = RecPos1 + 100;}
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

        private void btnImmagini_Click(object sender, EventArgs e)
        {
            Cartella c = new Cartella();
            c.Show();

            //MessageBox.Show(percorsoImmagini);
            //Process.Start(percorsoImmagini);

            panelImmagini.Visible = true;
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Immagini");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Immagini");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            panelImmagini.Visible = true;
            lblNomeCartella.Text = "Musica";
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Musica");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Musica");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            panelImmagini.Visible = true;
            lblNomeCartella.Text = "Banco";
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Banco");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Banco");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            panelImmagini.Visible = true;
            lblNomeCartella.Text = "Video";
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Video");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Video");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void btnArchivio_Click(object sender, EventArgs e)
        {
            panelImmagini.Visible = true;
            lblNomeCartella.Text = "Archivio";
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Archivio");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Archivio");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void btnScaricati_Click(object sender, EventArgs e)
        {
            panelImmagini.Visible = true;
            lblNomeCartella.Text = "Scaricati";
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(cartellaRadice + "/Scaricati");
            string[] dirs = Directory.GetDirectories(cartellaRadice + "/Scaricati");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox2.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox2.Items.Add(Path.GetFileName(dir));
            }
        }

        private void Principale_Load(object sender, EventArgs e) // Load Principale
        {
            ControlExtension.Draggable(panelImmagini, true);

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
            panelImmagini.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e) // Pulsante Impostazioni
        {
            Impostazioni impostazioni = new Impostazioni();
            impostazioni.Show();
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