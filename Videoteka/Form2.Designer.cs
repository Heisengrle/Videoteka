namespace Videoteka
{
    partial class Form2
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
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Iznajmi = new System.Windows.Forms.Button();
            this.Vrati = new System.Windows.Forms.Button();
            this.Pregledaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(3, 324);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(139, 48);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Vrati);
            this.panel1.Controls.Add(this.Pregledaj);
            this.panel1.Controls.Add(this.Iznajmi);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 384);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Location = new System.Drawing.Point(151, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 360);
            this.panel2.TabIndex = 2;
            // 
            // Iznajmi
            // 
            this.Iznajmi.Location = new System.Drawing.Point(3, 66);
            this.Iznajmi.Name = "Iznajmi";
            this.Iznajmi.Size = new System.Drawing.Size(139, 48);
            this.Iznajmi.TabIndex = 1;
            this.Iznajmi.Text = "Iznajmi";
            this.Iznajmi.UseVisualStyleBackColor = true;
            // 
            // Vrati
            // 
            this.Vrati.Location = new System.Drawing.Point(3, 120);
            this.Vrati.Name = "Vrati";
            this.Vrati.Size = new System.Drawing.Size(139, 48);
            this.Vrati.TabIndex = 2;
            this.Vrati.Text = "Vrati";
            this.Vrati.UseVisualStyleBackColor = true;
            // 
            // Pregledaj
            // 
            this.Pregledaj.Location = new System.Drawing.Point(3, 12);
            this.Pregledaj.Name = "Pregledaj";
            this.Pregledaj.Size = new System.Drawing.Size(139, 48);
            this.Pregledaj.TabIndex = 3;
            this.Pregledaj.Text = "Pregledaj";
            this.Pregledaj.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(584, 384);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Vrati;
        private System.Windows.Forms.Button Pregledaj;
        private System.Windows.Forms.Button Iznajmi;
    }
}