using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombOS
{
    public partial class Installazione : Form
    {
        string Radice;
        string nomeUtente;
        string percorsoNomeUtente;
        string percorsoBanco;
        string percorsoScaricati;
        string percorsoArchivio;
        string percorsoMusica;
        string percorsoImmagini;
        string percorsoVideo;
        

        public Installazione()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radice = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice");
            txtRadice.Text = Radice;
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Programmi");
            txtRadice.Text = "Programmi";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\" + nomeUtente);
            txtRadice.Text = percorsoNomeUtente;
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Banco");
            txtRadice.Text = "Banco da lavoro";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Scaricati");
            txtRadice.Text = "Scaricati";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Archivio");
            txtRadice.Text = "Archivio";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Musica");
            txtRadice.Text = "Musica";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Immagini");
            txtRadice.Text = "Immagini";
            progresso.Increment(10);

            System.IO.Directory.CreateDirectory(@"C: \Users\Riccardo\Radice\" + nomeUtente + "Video");
            txtRadice.Text = "Video";
            progresso.Increment(20);

            txtRadice.Text = "Finito";

            Avvio.installato = true;

            Attesa.Enabled = true;

        }

        private void Installazione_Load(object sender, EventArgs e)
        {
            
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
    }
}
