namespace ColombOS
{
    partial class Browser
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
            this.nome = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.panelImmagini.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImmagini
            // 
            this.panelImmagini.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelImmagini.Controls.Add(this.lblUrl);
            this.panelImmagini.Controls.Add(this.label1);
            this.panelImmagini.Controls.Add(this.btnCerca);
            this.panelImmagini.Controls.Add(this.txtUrl);
            this.panelImmagini.Controls.Add(this.panel5);
            this.panelImmagini.Location = new System.Drawing.Point(2, 2);
            this.panelImmagini.Name = "panelImmagini";
            this.panelImmagini.Size = new System.Drawing.Size(336, 385);
            this.panelImmagini.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.btnChiudi);
            this.panel5.Controls.Add(this.nome);
            this.panel5.Location = new System.Drawing.Point(5, 15);
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
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(109, 13);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(87, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Cerca su internet";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(28, 74);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(272, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Location = new System.Drawing.Point(117, 135);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(84, 37);
            this.btnCerca.TabIndex = 3;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mostra risultati per:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(129, 235);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(10, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = ".";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 389);
            this.ControlBox = false;
            this.Controls.Add(this.panelImmagini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Browser";
            this.Text = "Browser";
            this.panelImmagini.ResumeLayout(false);
            this.panelImmagini.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImmagini;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChiudi;
        public System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtUrl;
    }
}