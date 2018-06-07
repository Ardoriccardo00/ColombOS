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
    public partial class Avvio : Form
    {
        public static bool installato; //cambiare con false
        string ciao = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        string cartellaRadice;

        public Avvio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Avvio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInizio_Click(object sender, EventArgs e)
        {
            string cartellaRadice = ciao + "/" + "Radice";
            string file = cartellaRadice + "/ciao.txt";
            if (File.Exists(file)) { installato = true; } else { installato = false; }

            if (installato == false)
            {
                Installazione installazione = new Installazione();
                installazione.Show();
            }
            else { Principale principale = new Principale(); principale.Show(); this.Hide(); }
        }
    }
}
