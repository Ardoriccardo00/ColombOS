namespace ColombOS
{
    partial class Principale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principale));
            this.panStart = new System.Windows.Forms.Panel();
            this.panTools = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panPR = new System.Windows.Forms.Panel();
            this.SCPFinder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSpegni = new System.Windows.Forms.Button();
            this.panStart.SuspendLayout();
            this.panTools.SuspendLayout();
            this.panPR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panStart
            // 
            this.panStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panStart.Controls.Add(this.panTools);
            this.panStart.Controls.Add(this.panPR);
            this.panStart.Controls.Add(this.label1);
            this.panStart.Controls.Add(this.textBox1);
            this.panStart.Location = new System.Drawing.Point(85, 12);
            this.panStart.Name = "panStart";
            this.panStart.Size = new System.Drawing.Size(1273, 155);
            this.panStart.TabIndex = 0;
            this.panStart.Visible = false;
            // 
            // panTools
            // 
            this.panTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panTools.Controls.Add(this.label3);
            this.panTools.Location = new System.Drawing.Point(677, 3);
            this.panTools.Name = "panTools";
            this.panTools.Size = new System.Drawing.Size(336, 149);
            this.panTools.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tools";
            // 
            // panPR
            // 
            this.panPR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panPR.Controls.Add(this.SCPFinder);
            this.panPR.Controls.Add(this.label2);
            this.panPR.Location = new System.Drawing.Point(325, 3);
            this.panPR.Name = "panPR";
            this.panPR.Size = new System.Drawing.Size(336, 149);
            this.panPR.TabIndex = 4;
            // 
            // SCPFinder
            // 
            this.SCPFinder.Location = new System.Drawing.Point(6, 32);
            this.SCPFinder.Name = "SCPFinder";
            this.SCPFinder.Size = new System.Drawing.Size(60, 47);
            this.SCPFinder.TabIndex = 6;
            this.SCPFinder.Text = "SCP Finder";
            this.SCPFinder.UseVisualStyleBackColor = true;
            this.SCPFinder.Click += new System.EventHandler(this.SCPFinder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programmi recenti";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cerca file e programmi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 56);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSpegni
            // 
            this.btnSpegni.Location = new System.Drawing.Point(12, 682);
            this.btnSpegni.Name = "btnSpegni";
            this.btnSpegni.Size = new System.Drawing.Size(75, 56);
            this.btnSpegni.TabIndex = 3;
            this.btnSpegni.Text = "Spegni";
            this.btnSpegni.UseVisualStyleBackColor = true;
            this.btnSpegni.Click += new System.EventHandler(this.btnSpegni_Click);
            // 
            // Principale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.btnSpegni);
            this.Controls.Add(this.panStart);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principale";
            this.panStart.ResumeLayout(false);
            this.panStart.PerformLayout();
            this.panTools.ResumeLayout(false);
            this.panTools.PerformLayout();
            this.panPR.ResumeLayout(false);
            this.panPR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panTools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SCPFinder;
        private System.Windows.Forms.Button btnSpegni;
    }
}