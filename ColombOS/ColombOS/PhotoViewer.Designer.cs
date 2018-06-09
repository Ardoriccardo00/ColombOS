namespace ColombOS
{
    partial class PhotoViewer
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
            this.panelImmagini = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.lblNomeCartella = new System.Windows.Forms.Label();
            this.finestraImmagine = new System.Windows.Forms.PictureBox();
            this.panelImmagini.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finestraImmagine)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImmagini
            // 
            this.panelImmagini.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelImmagini.Controls.Add(this.finestraImmagine);
            this.panelImmagini.Controls.Add(this.panel5);
            this.panelImmagini.Location = new System.Drawing.Point(0, 0);
            this.panelImmagini.Name = "panelImmagini";
            this.panelImmagini.Size = new System.Drawing.Size(1347, 736);
            this.panelImmagini.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.btnChiudi);
            this.panel5.Controls.Add(this.lblNomeCartella);
            this.panel5.Location = new System.Drawing.Point(3, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1329, 40);
            this.panel5.TabIndex = 1;
            // 
            // btnChiudi
            // 
            this.btnChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudi.Location = new System.Drawing.Point(1283, 3);
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
            this.lblNomeCartella.Location = new System.Drawing.Point(7, 13);
            this.lblNomeCartella.Name = "lblNomeCartella";
            this.lblNomeCartella.Size = new System.Drawing.Size(67, 13);
            this.lblNomeCartella.TabIndex = 0;
            this.lblNomeCartella.Text = "PhotoViewer";
            // 
            // finestraImmagine
            // 
            this.finestraImmagine.BackColor = System.Drawing.SystemColors.HighlightText;
            this.finestraImmagine.Location = new System.Drawing.Point(3, 66);
            this.finestraImmagine.Name = "finestraImmagine";
            this.finestraImmagine.Size = new System.Drawing.Size(1326, 623);
            this.finestraImmagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.finestraImmagine.TabIndex = 2;
            this.finestraImmagine.TabStop = false;
            // 
            // PhotoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 704);
            this.Controls.Add(this.panelImmagini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhotoViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoViewer";
            this.Load += new System.EventHandler(this.PhotoViewer_Load);
            this.panelImmagini.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finestraImmagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImmagini;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Label lblNomeCartella;
        private System.Windows.Forms.PictureBox finestraImmagine;
    }
}