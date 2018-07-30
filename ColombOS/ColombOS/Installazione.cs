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
    public partial class Installazione : Form
    {
       public static string Radice;
       public static string nomeUtente;
        public static string percorsoNomeUtente;
        public static string percorsoBanco;
        public static string percorsoScaricati;
        public static string percorsoArchivio;
        public static string percorsoMusica;
        public static string percorsoImmagini;
        public static string percorsoVideo;
        public static string percorsoProgrammi;
       public static string cartellaRadice;
        string ciao;


        public Installazione()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radice = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            percorsoNomeUtente = cartellaRadice + "/" + nomeUtente;
            percorsoProgrammi = cartellaRadice + "/Programmi";
            percorsoBanco = cartellaRadice + "/Banco";
            percorsoArchivio = cartellaRadice + "/Archivio";
            percorsoImmagini = cartellaRadice + "/Immagini";
            percorsoMusica = cartellaRadice + "/Musica";
            percorsoProgrammi = cartellaRadice + "/Programmi";
            percorsoScaricati = cartellaRadice + "/Scaricati";
            percorsoVideo = cartellaRadice + "/Video";
           


            System.IO.Directory.CreateDirectory(cartellaRadice);
            txtRadice.Text = Radice;
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoProgrammi);
            txtRadice.Text = "Programmi";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoNomeUtente);
            label2.Text = percorsoNomeUtente;
            txtRadice.Text = percorsoNomeUtente;
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoBanco);
            txtRadice.Text = "Banco da lavoro";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoScaricati);
            txtRadice.Text = "Scaricati";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoArchivio);
            txtRadice.Text = "Archivio";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoMusica);
            txtRadice.Text = "Musica";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoImmagini);
            txtRadice.Text = "Immagini";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(percorsoVideo);
            txtRadice.Text = "Video";
            progresso.Increment(20);

            txtRadice.Text = "Finito";

            btnCopia.PerformClick();

            Avvio.installato = true;

            Attesa.Enabled = true;

            

        }

        private void Installazione_Load(object sender, EventArgs e)
        {
            string ciao = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            cartellaRadice = ciao + "/Radice";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            nomeUtente = textBox1.Text;
        }

        private void Attesa_Tick(object sender, EventArgs e)
        {
            Attesa.Enabled = false;
            this.Hide();
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            string ciao;
            string cciao;

            ciao = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            cciao = ciao + "/Radice/ciao.txt";

            //MessageBox.Show(ciao);
            //MessageBox.Show(cciao);

            StreamWriter File = new StreamWriter(cciao);
            File.Write("1");
            File.Close();
            
        }
    }
}
