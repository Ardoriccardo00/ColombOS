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
    public partial class Impostazioni : Form //Dimensione originali 338; 385    Dimensioni modificate 741; 384
    {
        public Point mouseLocation;
        public static string[] Colori = new string[] { };
        string Colore = "Blu";
        bool Aperto = false;

        public Impostazioni()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Impostazioni_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Impostazioni_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnCambiaSfondo_Click(object sender, EventArgs e)
        {
            //string immaginePerSfondo;

            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    panel8.Visible = true;
            //    listBox3.Items.Clear();
            //    string[] files = Directory.GetFiles(Principale.cartellaRadice + "/Immagini");
            //    string[] dirs = Directory.GetDirectories(Principale.cartellaRadice + "/Immagini");

            //    foreach (string file in files)
            //    {
            //        listBox3.Items.Add(Path.GetFileName(file));
            //    }
            //    foreach (string dir in dirs)
            //    {
            //        listBox3.Items.Add(Path.GetFileName(dir));
            //    }
            //}
            if (Aperto == false) { this.Size = new Size(741, 384); Aperto = true; }
            else if (Aperto == true) { this.Size = new Size(338, 385); Aperto = false; }

        }

        private void btnCambiaColori_Click(object sender, EventArgs e)
        {
            pannelloColori.Visible = true;
        }

        private void Rosso_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Rosso";
            Cartella.Colore = "Rosso";
            Colore = "Rosso";
            
        }

        private void Arancione_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Arancione";
            Cartella.Colore = "Arancione";
            Colore = "Arancione";
        }

        private void Giallo_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Giallo";
            Cartella.Colore = "Giallo";
            Colore = "Giallo";
        }

        private void Verde_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Verde";
            Cartella.Colore = "Verde";
            Colore = "Verde";
        }

        private void Azzurro_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Azzurro";
            Cartella.Colore = "Azzurro";
            Colore = "Azzurro";
        }

        private void Blu_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Blu";
            Cartella.Colore = "Blu";
            Colore = "Blu";
        }

        private void Viola_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Viola";
            Cartella.Colore = "Viola";
            Colore = "Viola";
        }

        private void Marrone_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Marrone";
            Cartella.Colore = "Marrone";
            Colore = "Marrone";
        }

        private void Nero_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Nero";
            Cartella.Colore = "Nero";
            Colore = "Nero";
        }

        private void Bianco_Click(object sender, EventArgs e)
        {
            Principale.Colore = "Bianco";
            Cartella.Colore = "Bianco";
            Colore = "Bianco";
        }

        private void timerColori_Tick(object sender, EventArgs e)
        {
            if (Colore == "Rosso") { panel1.BackColor = Color.Red; panel6.BackColor = Color.Red; }
            if (Colore == "Arancione") { panel1.BackColor = Color.Orange; panel6.BackColor = Color.Orange; }
            if (Colore == "Giallo") { panel1.BackColor = Color.Yellow; panel6.BackColor = Color.Yellow; }
            if (Colore == "Verde") { panel1.BackColor = Color.Green; panel6.BackColor = Color.Green; }
            if (Colore == "Azzurro") { panel1.BackColor = Color.LightBlue; panel6.BackColor = Color.LightBlue; }
            if (Colore == "Blu") { panel1.BackColor = Color.Blue; panel6.BackColor = Color.Blue; }
            if (Colore == "Viola") { panel1.BackColor = Color.Purple; panel6.BackColor = Color.Purple; }
            if (Colore == "Marrone") { panel1.BackColor = Color.Brown; panel6.BackColor = Color.Brown; }
            if (Colore == "Nero") { panel1.BackColor = Color.Black; panel6.BackColor = Color.Black; }
            if (Colore == "Bianco") { panel1.BackColor = Color.White; panel6.BackColor = Color.White; }
        }

        private void Impostazioni_Load(object sender, EventArgs e)
        {
            this.Size = new Size(338, 385);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Principale p = new Principale();
            Principale.Background = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Principale.Background = 2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Principale.Background = 3;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Principale.Background = 4;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Principale.Background = 5;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Principale.Background = 6;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Principale.Background = 7;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Principale.Background = 8;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Principale.Background = 9;
        }
    }
}
//private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
//{
//    string immaginePerSfondo = Convert.ToString(listBox2.SelectedItem);
//    string immaginePerSfondoCompleta = percorsoImmagini + "/" + immaginePerSfondo;

//    //this.BackgroundImage = immaginePerSfondoCompleta;
//    //Non so come si fa :(

//    PopupNotifier popup = new PopupNotifier();
//    //popup.Image = Properties.Resources.basic2_087_info_512;
//    popup.TitleText = "Errore!";
//    popup.ContentText = "No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No No ";
//    popup.Popup(); 
//    this.BackgroundImage = Properties.Resources.nothin_to_see_here__insect;
//    label7.Text = "Nothing to see here, insect";
//}