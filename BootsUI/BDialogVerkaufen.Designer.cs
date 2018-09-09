namespace BootsUI
{
    partial class BDialogVerkaufen
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
            this.comboBoxLiegeplatz = new System.Windows.Forms.ComboBox();
            this.comboBoxMarke = new System.Windows.Forms.ComboBox();
            this.comboBoxBaujahr = new System.Windows.Forms.ComboBox();
            this.comboBoxPreis = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2Abbrechen = new System.Windows.Forms.Button();
            this.button1Verkaufen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLiegeplatz
            // 
            this.comboBoxLiegeplatz.FormattingEnabled = true;
            this.comboBoxLiegeplatz.Location = new System.Drawing.Point(188, 141);
            this.comboBoxLiegeplatz.Name = "comboBoxLiegeplatz";
            this.comboBoxLiegeplatz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLiegeplatz.TabIndex = 35;
            // 
            // comboBoxMarke
            //
            this.comboBoxMarke.Items.AddRange(new object[] {
            "Typhoon",
            "Porsche",
            "BMW"});
            this.comboBoxMarke.FormattingEnabled = true;
            this.comboBoxMarke.Location = new System.Drawing.Point(188, 228);
            this.comboBoxMarke.Name = "comboBoxMarke";
            this.comboBoxMarke.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarke.TabIndex = 34;
            this.comboBoxMarke.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarke_SelectedIndexChanged);
            // 
            // comboBoxBaujahr
            // 
            this.comboBoxBaujahr.FormattingEnabled = true;
            this.comboBoxBaujahr.Location = new System.Drawing.Point(494, 67);
            this.comboBoxBaujahr.Name = "comboBoxBaujahr";
            this.comboBoxBaujahr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaujahr.TabIndex = 33;
            // 
            // comboBoxPreis
            // 
            this.comboBoxPreis.FormattingEnabled = true;
            this.comboBoxPreis.Location = new System.Drawing.Point(494, 141);
            this.comboBoxPreis.Name = "comboBoxPreis";
            this.comboBoxPreis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreis.TabIndex = 32;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Location = new System.Drawing.Point(494, 228);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Preis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Baujahr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Liegeplatz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marke";
            // 
            // button2Abbrechen
            // 
            this.button2Abbrechen.Location = new System.Drawing.Point(388, 376);
            this.button2Abbrechen.Name = "button2Abbrechen";
            this.button2Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button2Abbrechen.TabIndex = 26;
            this.button2Abbrechen.Text = "Abbrechen";
            this.button2Abbrechen.UseVisualStyleBackColor = true;
            this.button2Abbrechen.Click += new System.EventHandler(this.button2Abbrechen_Click);
            // 
            // button1Verkaufen
            // 
            this.button1Verkaufen.Location = new System.Drawing.Point(494, 376);
            this.button1Verkaufen.Name = "button1Verkaufen";
            this.button1Verkaufen.Size = new System.Drawing.Size(75, 23);
            this.button1Verkaufen.TabIndex = 25;
            this.button1Verkaufen.Text = "Verkaufen";
            this.button1Verkaufen.UseVisualStyleBackColor = true;
            this.button1Verkaufen.Click += new System.EventHandler(this.button1Verkaufen_Click);
            // 
            // BDialogVerkaufen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLiegeplatz);
            this.Controls.Add(this.comboBoxMarke);
            this.Controls.Add(this.comboBoxBaujahr);
            this.Controls.Add(this.comboBoxPreis);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Abbrechen);
            this.Controls.Add(this.button1Verkaufen);
            this.Name = "BDialogVerkaufen";
            this.Text = "Was wollen Sie verkaufen?";
            this.Load += new System.EventHandler(this.BDialogVerkaufen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLiegeplatz;
        private System.Windows.Forms.ComboBox comboBoxMarke;
        private System.Windows.Forms.ComboBox comboBoxBaujahr;
        private System.Windows.Forms.ComboBox comboBoxPreis;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2Abbrechen;
        private System.Windows.Forms.Button button1Verkaufen;
    }
}