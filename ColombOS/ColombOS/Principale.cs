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
        string percorsoUtente;

        public static string Media;
        public static string Sfondo = "x";

        public static string Colore = "Blu";
        public static int Background;

        public Principale()
        {
            InitializeComponent();
        }

        private void btnTutti_Click(object sender, EventArgs e) // Pulsante Tutti i programmi
        {
            if (panProgrammi.Visible == false) { panProgrammi.Visible = true; }
            else if (panProgrammi.Visible == true) { panProgrammi.Visible = false; }

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
            Media = "Utente";

            Cartella c = new Cartella();
            c.Show();
        }

        private void Principale_Load(object sender, EventArgs e) // Load Principale
        {

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
            percorsoUtente = cartellaRadice + "/Utente";
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
            btnImpostazioniAperte.Visible = true;
        }

        private void btnImmagini_Click_1(object sender, EventArgs e)
        {
            Media = "Immagini";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        }

        private void btnVideo_Click_1(object sender, EventArgs e)
        {
            Media = "Video";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Media = "Musica";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        } // Pulsante musica

        private void btnBanco_Click_1(object sender, EventArgs e)
        {
            Media = "Banco";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Media = "Archivio";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        }

        private void btnScaricati_Click_1(object sender, EventArgs e)
        {
            Media = "Scaricati";

            Cartella c = new Cartella();
            c.Show();

            btnCartellaAperta.Visible = true;
        }

        private void timerSfondo_Tick(object sender, EventArgs e)
        {
            if (Sfondo != "x") { /*this.BackgroundImage = Sfondo*/; }

            if (Colore == "Rosso") { panStart.BackColor = Color.Red; panProgrammi.BackColor = Color.Red; panProgrammiAperti.BackColor = Color.Red; }
            if (Colore == "Arancione") { panStart.BackColor = Color.Orange; panProgrammi.BackColor = Color.Orange; panProgrammiAperti.BackColor = Color.Orange; }
            if (Colore == "Giallo") { panStart.BackColor = Color.Yellow; panProgrammi.BackColor = Color.Yellow; panProgrammiAperti.BackColor = Color.Yellow; }
            if (Colore == "Verde") { panStart.BackColor = Color.Green; panProgrammi.BackColor = Color.Green; panProgrammiAperti.BackColor = Color.Green; }
            if (Colore == "Azzurro") { panStart.BackColor = Color.LightBlue; panProgrammi.BackColor = Color.LightBlue; panProgrammiAperti.BackColor = Color.LightBlue; }
            if (Colore == "Blu") { panStart.BackColor = Color.Blue; panProgrammi.BackColor = Color.Blue; panProgrammiAperti.BackColor = Color.Blue; }
            if (Colore == "Viola") { panStart.BackColor = Color.Purple; panProgrammi.BackColor = Color.Purple; panProgrammiAperti.BackColor = Color.Purple; }
            if (Colore == "Marrone") { panStart.BackColor = Color.Brown; panProgrammi.BackColor = Color.Brown; panProgrammiAperti.BackColor = Color.Brown; }
            if (Colore == "Nero") { panStart.BackColor = Color.Black; panProgrammi.BackColor = Color.Black; panProgrammiAperti.BackColor = Color.Black; }
            if (Colore == "Bianco") { panStart.BackColor = Color.White; panProgrammi.BackColor = Color.White; panProgrammiAperti.BackColor = Color.White; }

            if (Background == 1) { this.BackgroundImage = Sfondi._279810_vaporwave_background_1920x1080_windows_xp; }
            if (Background == 2) { this.BackgroundImage = Sfondi.gaben_windows_xp; }
            if (Background == 3) { this.BackgroundImage = Sfondi.meet_the_soldier_but_it_s_fortnite; }
            if (Background == 4) { this.BackgroundImage = Sfondi._279810_vaporwave_background_1920x1080_windows_xp; }
            if (Background == 5) { this.BackgroundImage = Sfondi.nana_finna_woke; }
            if (Background == 6) { this.BackgroundImage = Sfondi.new_president_levi; }
            if (Background == 7) { this.BackgroundImage = Sfondi.nothin_to_see_here__insect; }
            if (Background == 8) { this.BackgroundImage = Sfondi.popuko; }
            if (Background == 9) { this.BackgroundImage = Sfondi.you_know_Siena_had_to_do_it_to_em; }
            
        }

        private void btnCartellaAperta_Click(object sender, EventArgs e)
        {
            Cartella c = new Cartella();
            c.Show();
        }

        private void btnImpostazioniAperte_Click(object sender, EventArgs e)
        {
            Impostazioni i = new Impostazioni();
            i.Show();
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