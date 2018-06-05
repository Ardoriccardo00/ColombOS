﻿using System;
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

        public Principale()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SCPFinder_Click(object sender, EventArgs e)
        {
            SCPFinder scp = new SCPFinder();
            scp.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panStart.Visible = true;
        }

        private void btnSpegni_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTutti_Click(object sender, EventArgs e)
        {
            if (panProgrammi.Visible == false) { panProgrammi.Visible = true;}
            else if (panProgrammi.Visible == true) { panProgrammi.Visible = false;}

           

            // FolderBrowserDialog FBD = new FolderBrowserDialog();

            //if (FBD.ShowDialog() == DialogResult.OK)
            //{

            listBox1.Items.Clear();
            string[] files = Directory.GetFiles("C:/Users/Riccardo/Radice/Programmi");
            string[] dirs = Directory.GetDirectories("C:/Users/Riccardo/Radice/Programmi");  //FBD.SelectedPath

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
            //  }
        }

       

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (RecPulsanti == 0) { RecPos1 = 295; RecPos2 = 60; }
            if (RecPulsanti == 1) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 2) { RecPos1 = RecPos1 + 100; }
            if (RecPulsanti == 3) { RecPos1 = RecPos1 - 200; RecPos2 = RecPos2 + 100; }
            if (RecPulsanti == 4) { RecPos1 = RecPos1 + 100;}
            if (RecPulsanti == 5) { RecPos1 = RecPos1 + 100;}
            if (RecPulsanti == 6) { RecPulsanti = 0; }

            Programma = Convert.ToString(listBox1.SelectedItem);
            ProgrammaCompleto = "C:/Users/Riccardo/Radice/Programmi/" + Programma;
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

            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string FilePath = ofd.FileName;
            //    label7.Text = FilePath;
            //    Process.Start(FilePath);
            //}



        }

        private void btn_Click(object sender, EventArgs e)
        {
            string lol;
            lol = "C:/Users/Riccardo/Radice/Programmi/" + recProgrammaCompleto;
            Process.Start(lol);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUtente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Installazione.Radice);
            Process.Start(Installazione.Radice);
        }

        private void btnImmagini_Click(object sender, EventArgs e)
        {
           
        }

        private void Principale_Load(object sender, EventArgs e)
        {
            cartellaRadice = ciao + "/Radice";
        }
    }
}
