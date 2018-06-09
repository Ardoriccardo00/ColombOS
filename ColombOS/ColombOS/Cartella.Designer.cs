namespace ColombOS
{
    partial class Cartella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartella));
            this.panelImmagini = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.lblNomeCartella = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelImmagini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImmagini
            // 
            this.panelImmagini.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelImmagini.Controls.Add(this.pictureBox1);
            this.panelImmagini.Controls.Add(this.panel5);
            this.panelImmagini.Controls.Add(this.Lista);
            this.panelImmagini.Location = new System.Drawing.Point(0, 2);
            this.panelImmagini.Name = "panelImmagini";
            this.panelImmagini.Size = new System.Drawing.Size(336, 385);
            this.panelImmagini.TabIndex = 7;
            this.panelImmagini.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelImmagini_MouseDown);
            this.panelImmagini.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelImmagini_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColombOS.Resource1.favicon__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(276, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.btnChiudi);
            this.panel5.Controls.Add(this.lblNomeCartella);
            this.panel5.Location = new System.Drawing.Point(5, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 40);
            this.panel5.TabIndex = 1;
            // 
            // btnChiudi
            // 
            this.btnChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudi.Location = new System.Drawing.Point(280, 3);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(43, 33);
            this.btnChiudi.TabIndex = 1;
            this.btnChiudi.Text = "X";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // lblNomeCartella
            // 
            this.lblNomeCartella.AutoSize = true;
            this.lblNomeCartella.Location = new System.Drawing.Point(142, 13);
            this.lblNomeCartella.Name = "lblNomeCartella";
            this.lblNomeCartella.Size = new System.Drawing.Size(16, 13);
            this.lblNomeCartella.TabIndex = 0;
            this.lblNomeCartella.Text = "...";
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(5, 75);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(327, 303);
            this.Lista.TabIndex = 0;
            this.Lista.DoubleClick += new System.EventHandler(this.Lista_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cartella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 385);
            this.Controls.Add(this.panelImmagini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cartella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartella";
            this.Load += new System.EventHandler(this.Cartella_Load);
            this.panelImmagini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImmagini;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.ListBox Lista;
        public System.Windows.Forms.Label lblNomeCartella;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}