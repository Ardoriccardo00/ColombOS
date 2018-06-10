namespace ColombOS
{
    partial class Impostazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impostazioni));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiaColori = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pannelloColori = new System.Windows.Forms.Panel();
            this.Bianco = new System.Windows.Forms.Button();
            this.Nero = new System.Windows.Forms.Button();
            this.Marrone = new System.Windows.Forms.Button();
            this.Viola = new System.Windows.Forms.Button();
            this.Blu = new System.Windows.Forms.Button();
            this.Azzurro = new System.Windows.Forms.Button();
            this.Verde = new System.Windows.Forms.Button();
            this.Giallo = new System.Windows.Forms.Button();
            this.Arancione = new System.Windows.Forms.Button();
            this.Rosso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnCambiaSfondo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timerColori = new System.Windows.Forms.Timer(this.components);
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pannelloColori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnCambiaColori);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.btnCambiaSfondo);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 385);
            this.panel6.TabIndex = 8;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 28);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnCambiaColori
            // 
            this.btnCambiaColori.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCambiaColori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiaColori.Location = new System.Drawing.Point(257, 76);
            this.btnCambiaColori.Name = "btnCambiaColori";
            this.btnCambiaColori.Size = new System.Drawing.Size(75, 35);
            this.btnCambiaColori.TabIndex = 4;
            this.btnCambiaColori.Text = "Cambia colori";
            this.btnCambiaColori.UseVisualStyleBackColor = false;
            this.btnCambiaColori.Click += new System.EventHandler(this.btnCambiaColori_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Controls.Add(this.pannelloColori);
            this.panel8.Controls.Add(this.listBox3);
            this.panel8.Location = new System.Drawing.Point(5, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 261);
            this.panel8.TabIndex = 3;
            // 
            // pannelloColori
            // 
            this.pannelloColori.Controls.Add(this.Bianco);
            this.pannelloColori.Controls.Add(this.Nero);
            this.pannelloColori.Controls.Add(this.Marrone);
            this.pannelloColori.Controls.Add(this.Viola);
            this.pannelloColori.Controls.Add(this.Blu);
            this.pannelloColori.Controls.Add(this.Azzurro);
            this.pannelloColori.Controls.Add(this.Verde);
            this.pannelloColori.Controls.Add(this.Giallo);
            this.pannelloColori.Controls.Add(this.Arancione);
            this.pannelloColori.Controls.Add(this.Rosso);
            this.pannelloColori.Controls.Add(this.pictureBox1);
            this.pannelloColori.Location = new System.Drawing.Point(3, 16);
            this.pannelloColori.Name = "pannelloColori";
            this.pannelloColori.Size = new System.Drawing.Size(317, 238);
            this.pannelloColori.TabIndex = 2;
            this.pannelloColori.Visible = false;
            // 
            // Bianco
            // 
            this.Bianco.BackColor = System.Drawing.Color.White;
            this.Bianco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bianco.Location = new System.Drawing.Point(268, 109);
            this.Bianco.Name = "Bianco";
            this.Bianco.Size = new System.Drawing.Size(46, 46);
            this.Bianco.TabIndex = 11;
            this.Bianco.UseVisualStyleBackColor = false;
            this.Bianco.Click += new System.EventHandler(this.Bianco_Click);
            // 
            // Nero
            // 
            this.Nero.BackColor = System.Drawing.Color.Black;
            this.Nero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nero.Location = new System.Drawing.Point(207, 109);
            this.Nero.Name = "Nero";
            this.Nero.Size = new System.Drawing.Size(46, 46);
            this.Nero.TabIndex = 10;
            this.Nero.UseVisualStyleBackColor = false;
            this.Nero.Click += new System.EventHandler(this.Nero_Click);
            // 
            // Marrone
            // 
            this.Marrone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Marrone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marrone.Location = new System.Drawing.Point(142, 109);
            this.Marrone.Name = "Marrone";
            this.Marrone.Size = new System.Drawing.Size(46, 46);
            this.Marrone.TabIndex = 9;
            this.Marrone.UseVisualStyleBackColor = false;
            this.Marrone.Click += new System.EventHandler(this.Marrone_Click);
            // 
            // Viola
            // 
            this.Viola.BackColor = System.Drawing.Color.Fuchsia;
            this.Viola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viola.Location = new System.Drawing.Point(73, 109);
            this.Viola.Name = "Viola";
            this.Viola.Size = new System.Drawing.Size(46, 46);
            this.Viola.TabIndex = 8;
            this.Viola.UseVisualStyleBackColor = false;
            this.Viola.Click += new System.EventHandler(this.Viola_Click);
            // 
            // Blu
            // 
            this.Blu.BackColor = System.Drawing.Color.Blue;
            this.Blu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blu.Location = new System.Drawing.Point(4, 109);
            this.Blu.Name = "Blu";
            this.Blu.Size = new System.Drawing.Size(46, 46);
            this.Blu.TabIndex = 7;
            this.Blu.UseVisualStyleBackColor = false;
            this.Blu.Click += new System.EventHandler(this.Blu_Click);
            // 
            // Azzurro
            // 
            this.Azzurro.BackColor = System.Drawing.Color.Aqua;
            this.Azzurro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Azzurro.Location = new System.Drawing.Point(268, 29);
            this.Azzurro.Name = "Azzurro";
            this.Azzurro.Size = new System.Drawing.Size(46, 46);
            this.Azzurro.TabIndex = 6;
            this.Azzurro.UseVisualStyleBackColor = false;
            this.Azzurro.Click += new System.EventHandler(this.Azzurro_Click);
            // 
            // Verde
            // 
            this.Verde.BackColor = System.Drawing.Color.Lime;
            this.Verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verde.Location = new System.Drawing.Point(207, 29);
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(46, 46);
            this.Verde.TabIndex = 5;
            this.Verde.UseVisualStyleBackColor = false;
            this.Verde.Click += new System.EventHandler(this.Verde_Click);
            // 
            // Giallo
            // 
            this.Giallo.BackColor = System.Drawing.Color.Yellow;
            this.Giallo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giallo.Location = new System.Drawing.Point(142, 29);
            this.Giallo.Name = "Giallo";
            this.Giallo.Size = new System.Drawing.Size(46, 46);
            this.Giallo.TabIndex = 4;
            this.Giallo.UseVisualStyleBackColor = false;
            this.Giallo.Click += new System.EventHandler(this.Giallo_Click);
            // 
            // Arancione
            // 
            this.Arancione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Arancione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arancione.Location = new System.Drawing.Point(73, 29);
            this.Arancione.Name = "Arancione";
            this.Arancione.Size = new System.Drawing.Size(46, 46);
            this.Arancione.TabIndex = 3;
            this.Arancione.UseVisualStyleBackColor = false;
            this.Arancione.Click += new System.EventHandler(this.Arancione_Click);
            // 
            // Rosso
            // 
            this.Rosso.BackColor = System.Drawing.Color.Red;
            this.Rosso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rosso.Location = new System.Drawing.Point(4, 29);
            this.Rosso.Name = "Rosso";
            this.Rosso.Size = new System.Drawing.Size(46, 46);
            this.Rosso.TabIndex = 2;
            this.Rosso.UseVisualStyleBackColor = false;
            this.Rosso.Click += new System.EventHandler(this.Rosso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColombOS.Resource1.favicon__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(266, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(3, 16);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(317, 238);
            this.listBox3.TabIndex = 0;
            // 
            // btnCambiaSfondo
            // 
            this.btnCambiaSfondo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCambiaSfondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiaSfondo.Location = new System.Drawing.Point(5, 76);
            this.btnCambiaSfondo.Name = "btnCambiaSfondo";
            this.btnCambiaSfondo.Size = new System.Drawing.Size(75, 35);
            this.btnCambiaSfondo.TabIndex = 2;
            this.btnCambiaSfondo.Text = "Cambia sfondo";
            this.btnCambiaSfondo.UseVisualStyleBackColor = false;
            this.btnCambiaSfondo.Click += new System.EventHandler(this.btnCambiaSfondo_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(5, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 40);
            this.panel7.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(280, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Impostazioni";
            // 
            // timerColori
            // 
            this.timerColori.Enabled = true;
            this.timerColori.Tick += new System.EventHandler(this.timerColori_Tick);
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 384);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Impostazioni";
            this.Text = "Impostazioni";
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pannelloColori.ResumeLayout(false);
            this.pannelloColori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnCambiaSfondo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCambiaColori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pannelloColori;
        private System.Windows.Forms.Button Bianco;
        private System.Windows.Forms.Button Nero;
        private System.Windows.Forms.Button Marrone;
        private System.Windows.Forms.Button Viola;
        private System.Windows.Forms.Button Blu;
        private System.Windows.Forms.Button Azzurro;
        private System.Windows.Forms.Button Verde;
        private System.Windows.Forms.Button Giallo;
        private System.Windows.Forms.Button Arancione;
        private System.Windows.Forms.Button Rosso;
        private System.Windows.Forms.Timer timerColori;
    }
}