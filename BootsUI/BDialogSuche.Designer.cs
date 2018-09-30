namespace BootsUI
{
    partial class Suche
    {// Autor: Daniel Wolff, Edgar Wendler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLiegeplatz
            // 
            this.comboBoxLiegeplatz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLiegeplatz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLiegeplatz.FormattingEnabled = true;
            this.comboBoxLiegeplatz.Items.AddRange(new object[] {
            "",
            "Bremerhaven",
            "Hamburg",
            "Rügen",
            "SanktPeter Ording",
            "Norden",
            "Hiddensee",
            "Cuxhaven",
            "Kiel",
            "Rostock"});
            this.comboBoxLiegeplatz.Location = new System.Drawing.Point(76, 284);
            this.comboBoxLiegeplatz.Name = "comboBoxLiegeplatz";
            this.comboBoxLiegeplatz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLiegeplatz.TabIndex = 23;
            // 
            // comboBoxMarke
            // 
            this.comboBoxMarke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMarke.FormattingEnabled = true;
            this.comboBoxMarke.Items.AddRange(new object[] {
            "",
            "Typhoon",
            "Porsche",
            "BMW"});
            this.comboBoxMarke.Location = new System.Drawing.Point(76, 65);
            this.comboBoxMarke.Name = "comboBoxMarke";
            this.comboBoxMarke.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarke.TabIndex = 22;
            this.comboBoxMarke.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarke_SelectedIndexChanged);
            // 
            // comboBoxBaujahr
            // 
            this.comboBoxBaujahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaujahr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBaujahr.FormattingEnabled = true;
            this.comboBoxBaujahr.Items.AddRange(new object[] {
            "",
            "1980",
            "1985",
            "1990",
            "1995",
            "2000",
            "2002",
            "2004",
            "2002",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.comboBoxBaujahr.Location = new System.Drawing.Point(76, 117);
            this.comboBoxBaujahr.Name = "comboBoxBaujahr";
            this.comboBoxBaujahr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaujahr.TabIndex = 21;
            // 
            // comboBoxPreis
            // 
            this.comboBoxPreis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPreis.FormattingEnabled = true;
            this.comboBoxPreis.Items.AddRange(new object[] {
            "",
            "500",
            "1.000",
            "1.500",
            "2.000",
            "2.500",
            "3.000",
            "4.000",
            "5.000",
            "6.000",
            "7.000",
            "8.000",
            "9.000",
            "10.000",
            "12.500",
            "15.000",
            "17.500",
            "20.000",
            "25.000",
            "30.000",
            "40.000",
            "50.000",
            "100.000"});
            this.comboBoxPreis.Location = new System.Drawing.Point(76, 170);
            this.comboBoxPreis.Name = "comboBoxPreis";
            this.comboBoxPreis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreis.TabIndex = 20;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "",
            "GFK",
            "Holz"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(76, 224);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Baujahr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Liegeplatz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marke";
            // 
            // button2Abbrechen
            // 
            this.button2Abbrechen.Location = new System.Drawing.Point(24, 376);
            this.button2Abbrechen.Name = "button2Abbrechen";
            this.button2Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button2Abbrechen.TabIndex = 14;
            this.button2Abbrechen.Text = "Abbrechen";
            this.button2Abbrechen.UseVisualStyleBackColor = true;
            this.button2Abbrechen.Click += new System.EventHandler(this.button2Abbrechen_Click);
            // 
            // button1Suchen
            // 
            this.button1Suchen.Location = new System.Drawing.Point(107, 376);
            this.button1Suchen.Name = "button1Suchen";
            this.button1Suchen.Size = new System.Drawing.Size(75, 23);
            this.button1Suchen.TabIndex = 13;
            this.button1Suchen.Text = "Suchen";
            this.button1Suchen.UseVisualStyleBackColor = true;
            this.button1Suchen.Click += new System.EventHandler(this.button1Suchen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.comboBoxLiegeplatz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1Suchen);
            this.panel1.Controls.Add(this.button2Abbrechen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxMaterial);
            this.panel1.Controls.Add(this.comboBoxPreis);
            this.panel1.Controls.Add(this.comboBoxBaujahr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxMarke);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
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
            this.label6.Location = new System.Drawing.Point(-3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Finde dein Boot";
            // 
            // Suche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BootsUI.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Suche";
            this.Text = "Suchen Sie hier Ihr Boot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}