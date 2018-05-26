namespace ColombOS
{
    partial class Installazione
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRadice = new System.Windows.Forms.Label();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prima di poter utilizzare il sistema operativo, c\'è bisongo di impostare\r\nalcune " +
    "cartelle per contenere i tuoi file.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Radice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRadice
            // 
            this.txtRadice.AutoSize = true;
            this.txtRadice.Location = new System.Drawing.Point(120, 95);
            this.txtRadice.Name = "txtRadice";
            this.txtRadice.Size = new System.Drawing.Size(16, 13);
            this.txtRadice.TabIndex = 2;
            this.txtRadice.Text = "...";
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(181, 85);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(100, 23);
            this.progresso.TabIndex = 3;
            // 
            // Installazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.txtRadice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Installazione";
            this.Text = "Installazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtRadice;
        private System.Windows.Forms.ProgressBar progresso;
    }
}