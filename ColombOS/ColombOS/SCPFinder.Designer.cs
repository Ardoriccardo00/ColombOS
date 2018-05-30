namespace ColombOS
{
    partial class SCPFinder
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
            this.testo = new System.Windows.Forms.TextBox();
            this.Cerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testo
            // 
            this.testo.Location = new System.Drawing.Point(81, 78);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(100, 20);
            this.testo.TabIndex = 2;
            // 
            // Cerca
            // 
            this.Cerca.Location = new System.Drawing.Point(91, 124);
            this.Cerca.Name = "Cerca";
            this.Cerca.Size = new System.Drawing.Size(75, 23);
            this.Cerca.TabIndex = 3;
            this.Cerca.Text = "Cerca";
            this.Cerca.UseVisualStyleBackColor = true;
            this.Cerca.Click += new System.EventHandler(this.Cerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SCPFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColombOS.Properties.Resources.scp_background;
            this.ClientSize = new System.Drawing.Size(268, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cerca);
            this.Controls.Add(this.testo);
            this.Name = "SCPFinder";
            this.Text = "SCPFinder";
            this.Load += new System.EventHandler(this.SCPFinder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SCPFinder_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testo;
        private System.Windows.Forms.Button Cerca;
        private System.Windows.Forms.Label label1;
    }
}