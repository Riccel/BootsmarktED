namespace BootsUI
{
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
            this.SuspendLayout();
            // 
            // button4FAQ
            // 
            this.button4FAQ.Location = new System.Drawing.Point(255, 12);
            this.button4FAQ.Name = "button4FAQ";
            this.button4FAQ.Size = new System.Drawing.Size(75, 23);
            this.button4FAQ.TabIndex = 7;
            this.button4FAQ.Text = "FAQ";
            this.button4FAQ.UseVisualStyleBackColor = true;
            this.button4FAQ.Click += new System.EventHandler(this.button4FAQ_Click);
            // 
            // button3Konto
            // 
            this.button3Konto.Location = new System.Drawing.Point(174, 12);
            this.button3Konto.Name = "button3Konto";
            this.button3Konto.Size = new System.Drawing.Size(75, 23);
            this.button3Konto.TabIndex = 6;
            this.button3Konto.Text = "Konto";
            this.button3Konto.UseVisualStyleBackColor = true;
            this.button3Konto.Click += new System.EventHandler(this.button3Konto_Click);
            // 
            // button2Verkaufen
            // 
            this.button2Verkaufen.Location = new System.Drawing.Point(93, 12);
            this.button2Verkaufen.Name = "button2Verkaufen";
            this.button2Verkaufen.Size = new System.Drawing.Size(75, 23);
            this.button2Verkaufen.TabIndex = 5;
            this.button2Verkaufen.Text = "Verkaufen";
            this.button2Verkaufen.UseVisualStyleBackColor = true;
            this.button2Verkaufen.Click += new System.EventHandler(this.button2Verkaufen_Click);
            // 
            // button1Suche
            // 
            this.button1Suche.Location = new System.Drawing.Point(12, 12);
            this.button1Suche.Name = "button1Suche";
            this.button1Suche.Size = new System.Drawing.Size(75, 23);
            this.button1Suche.TabIndex = 4;
            this.button1Suche.Text = "Suche";
            this.button1Suche.UseVisualStyleBackColor = true;
            this.button1Suche.Click += new System.EventHandler(this.button1Suchen_Click);
            // 
            // label1BooteZaehlen
            // 
            this.label1BooteZaehlen.AutoSize = true;
            this.label1BooteZaehlen.Location = new System.Drawing.Point(22, 392);
            this.label1BooteZaehlen.Name = "label1BooteZaehlen";
            this.label1BooteZaehlen.Size = new System.Drawing.Size(47, 13);
            this.label1BooteZaehlen.TabIndex = 8;
            this.label1BooteZaehlen.Text = "0 Treffer";
            // 
            // BDialogHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1BooteZaehlen);
            this.Controls.Add(this.button4FAQ);
            this.Controls.Add(this.button3Konto);
            this.Controls.Add(this.button2Verkaufen);
            this.Controls.Add(this.button1Suche);
            this.Name = "BDialogHaupt";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.BDialogHaupt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4FAQ;
        private System.Windows.Forms.Button button3Konto;
        private System.Windows.Forms.Button button2Verkaufen;
        private System.Windows.Forms.Button button1Suche;
        private System.Windows.Forms.Label label1BooteZaehlen;
    }
}