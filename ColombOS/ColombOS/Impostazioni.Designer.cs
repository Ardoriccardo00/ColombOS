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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impostazioni));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiaColori = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnCambiaSfondo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.listBox3);
            this.panel8.Location = new System.Drawing.Point(5, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 261);
            this.panel8.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColombOS.Resource1.favicon__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(272, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}