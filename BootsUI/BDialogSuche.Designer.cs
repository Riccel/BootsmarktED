namespace BootsUI
{
    partial class Suche
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
            this.button1Suchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLiegeplatz
            // 
            this.comboBoxLiegeplatz.FormattingEnabled = true;
            this.comboBoxLiegeplatz.Location = new System.Drawing.Point(188, 141);
            this.comboBoxLiegeplatz.Name = "comboBoxLiegeplatz";
            this.comboBoxLiegeplatz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLiegeplatz.TabIndex = 23;
            // 
            // comboBoxMarke
            // 
            this.comboBoxMarke.FormattingEnabled = true;
            this.comboBoxMarke.Location = new System.Drawing.Point(188, 228);
            this.comboBoxMarke.Name = "comboBoxMarke";
            this.comboBoxMarke.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarke.TabIndex = 22;
            // 
            // comboBoxBaujahr
            // 
            this.comboBoxBaujahr.FormattingEnabled = true;
            this.comboBoxBaujahr.Location = new System.Drawing.Point(494, 67);
            this.comboBoxBaujahr.Name = "comboBoxBaujahr";
            this.comboBoxBaujahr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaujahr.TabIndex = 21;
            // 
            // comboBoxPreis
            // 
            this.comboBoxPreis.FormattingEnabled = true;
            this.comboBoxPreis.Location = new System.Drawing.Point(494, 141);
            this.comboBoxPreis.Name = "comboBoxPreis";
            this.comboBoxPreis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreis.TabIndex = 20;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Location = new System.Drawing.Point(494, 228);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Baujahr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Liegeplatz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marke";
            // 
            // button2Abbrechen
            // 
            this.button2Abbrechen.Location = new System.Drawing.Point(388, 376);
            this.button2Abbrechen.Name = "button2Abbrechen";
            this.button2Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button2Abbrechen.TabIndex = 14;
            this.button2Abbrechen.Text = "Abbrechen";
            this.button2Abbrechen.UseVisualStyleBackColor = true;
            // 
            // button1Suchen
            // 
            this.button1Suchen.Location = new System.Drawing.Point(494, 376);
            this.button1Suchen.Name = "button1Suchen";
            this.button1Suchen.Size = new System.Drawing.Size(75, 23);
            this.button1Suchen.TabIndex = 13;
            this.button1Suchen.Text = "Suchen";
            this.button1Suchen.UseVisualStyleBackColor = true;
            // 
            // BDialogSuche
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
            this.Controls.Add(this.button1Suchen);
            this.Name = "BDialogSuche";
            this.Text = "Suchen Sie hier Ihr Boot";
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
        private System.Windows.Forms.Button button1Suchen;
    }
}