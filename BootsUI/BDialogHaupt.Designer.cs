namespace BootsUI
{
    using System.Windows.Forms;
    partial class BDialogHaupt
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
            this.button4FAQ = new System.Windows.Forms.Button();
            this.button3Konto = new System.Windows.Forms.Button();
            this.button2Verkaufen = new System.Windows.Forms.Button();
            this.button1Suche = new System.Windows.Forms.Button();
            this.label1BooteZaehlen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4FAQ
            // 
            this.button4FAQ.Location = new System.Drawing.Point(0, 146);
            this.button4FAQ.Name = "button4FAQ";
            this.button4FAQ.Size = new System.Drawing.Size(197, 23);
            this.button4FAQ.TabIndex = 7;
            this.button4FAQ.Text = "FAQ";
            this.button4FAQ.UseVisualStyleBackColor = true;
            this.button4FAQ.Click += new System.EventHandler(this.button4FAQ_Click);
            // 
            // button3Konto
            // 
            this.button3Konto.Location = new System.Drawing.Point(0, 117);
            this.button3Konto.Name = "button3Konto";
            this.button3Konto.Size = new System.Drawing.Size(197, 23);
            this.button3Konto.TabIndex = 6;
            this.button3Konto.Text = "Konto";
            this.button3Konto.UseVisualStyleBackColor = true;
            this.button3Konto.Click += new System.EventHandler(this.button3Konto_Click);
            // 
            // button2Verkaufen
            // 
            this.button2Verkaufen.Location = new System.Drawing.Point(0, 88);
            this.button2Verkaufen.Name = "button2Verkaufen";
            this.button2Verkaufen.Size = new System.Drawing.Size(197, 23);
            this.button2Verkaufen.TabIndex = 5;
            this.button2Verkaufen.Text = "Verkaufen";
            this.button2Verkaufen.UseVisualStyleBackColor = true;
            this.button2Verkaufen.Click += new System.EventHandler(this.button2Verkaufen_Click);
            // 
            // button1Suche
            // 
            this.button1Suche.Location = new System.Drawing.Point(0, 59);
            this.button1Suche.Name = "button1Suche";
            this.button1Suche.Size = new System.Drawing.Size(197, 23);
            this.button1Suche.TabIndex = 4;
            this.button1Suche.Text = "Suche";
            this.button1Suche.UseVisualStyleBackColor = true;
            this.button1Suche.Click += new System.EventHandler(this.button1Suchen_Click);
            // 
            // label1BooteZaehlen
            // 
            this.label1BooteZaehlen.AutoSize = true;
            this.label1BooteZaehlen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1BooteZaehlen.Location = new System.Drawing.Point(141, 428);
            this.label1BooteZaehlen.Name = "label1BooteZaehlen";
            this.label1BooteZaehlen.Size = new System.Drawing.Size(47, 13);
            this.label1BooteZaehlen.TabIndex = 8;
            this.label1BooteZaehlen.Text = "0 Treffer";
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1BooteZaehlen);
            this.panel1.Controls.Add(this.button1Suche);
            this.panel1.Controls.Add(this.button4FAQ);
            this.panel1.Controls.Add(this.button2Verkaufen);
            this.panel1.Controls.Add(this.button3Konto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 449);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bootsmarkt";
            // 
            // BDialogHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BootsUI.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BDialogHaupt";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.BDialogHaupt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4FAQ;
        private System.Windows.Forms.Button button3Konto;
        private System.Windows.Forms.Button button2Verkaufen;
        private System.Windows.Forms.Button button1Suche;
        private System.Windows.Forms.Label label1BooteZaehlen;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
    }
}