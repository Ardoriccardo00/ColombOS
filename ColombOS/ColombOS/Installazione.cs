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

        public Installazione()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progresso.Increment(1);
            Radice = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Scaricati");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Archivio");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Musica");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Immagini");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Video");
            txtRadice.Text = Radice;
            System.IO.Directory.CreateDirectory(@"C:\Users\Riccardo\Radice\Banco");
        }
    }
}
