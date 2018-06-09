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
    public partial class Impostazioni : Form
    {
        public Point mouseLocation;

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
            Principale p = new Principale();
            p.BackgroundImage = Resource1.nothin_to_see_here__insect;
            p.Show();
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