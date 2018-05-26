namespace ColombOS
{
    partial class Avvio
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
            this.btnInizio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvenuto su ColombOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInizio
            // 
            this.btnInizio.Location = new System.Drawing.Point(271, 196);
            this.btnInizio.Name = "btnInizio";
            this.btnInizio.Size = new System.Drawing.Size(261, 129);
            this.btnInizio.TabIndex = 1;
            this.btnInizio.Text = "INIZIO";
            this.btnInizio.UseVisualStyleBackColor = true;
            this.btnInizio.Click += new System.EventHandler(this.btnInizio_Click);
            // 
            // Avvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInizio);
            this.Controls.Add(this.label1);
            this.Name = "Avvio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Avvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInizio;
    }
}

