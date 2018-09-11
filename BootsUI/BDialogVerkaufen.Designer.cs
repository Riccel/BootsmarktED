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
            this.button2Abbrechen = new System.Windows.Forms.Button();
            this.button1Verkaufen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLiegeplatz
            // 
            this.comboBoxLiegeplatz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLiegeplatz.FormattingEnabled = true;
            this.comboBoxLiegeplatz.Location = new System.Drawing.Point(76, 284);
            this.comboBoxLiegeplatz.Name = "comboBoxLiegeplatz";
            this.comboBoxLiegeplatz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLiegeplatz.TabIndex = 35;
            // 
            // comboBoxMarke
            // 
            this.comboBoxMarke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarke.FormattingEnabled = true;
            this.comboBoxMarke.Items.AddRange(new object[] {
            "Typhoon",
            "Porsche",
            "BMW"});
            this.comboBoxMarke.Location = new System.Drawing.Point(76, 68);
            this.comboBoxMarke.Name = "comboBoxMarke";
            this.comboBoxMarke.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarke.TabIndex = 34;
            this.comboBoxMarke.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarke_SelectedIndexChanged);
            // 
            // comboBoxBaujahr
            // 
            this.comboBoxBaujahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaujahr.FormattingEnabled = true;
            this.comboBoxBaujahr.Location = new System.Drawing.Point(76, 120);
            this.comboBoxBaujahr.Name = "comboBoxBaujahr";
            this.comboBoxBaujahr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaujahr.TabIndex = 33;
            // 
            // comboBoxPreis
            // 
            this.comboBoxPreis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreis.FormattingEnabled = true;
            this.comboBoxPreis.Location = new System.Drawing.Point(76, 175);
            this.comboBoxPreis.Name = "comboBoxPreis";
            this.comboBoxPreis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreis.TabIndex = 32;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Location = new System.Drawing.Point(76, 229);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 36;
            // 
            // button2Abbrechen
            // 
            this.button2Abbrechen.Location = new System.Drawing.Point(97, 375);
            this.button2Abbrechen.Name = "button2Abbrechen";
            this.button2Abbrechen.Size = new System.Drawing.Size(75, 23);
            this.button2Abbrechen.TabIndex = 26;
            this.button2Abbrechen.Text = "Abbrechen";
            this.button2Abbrechen.UseVisualStyleBackColor = true;
            this.button2Abbrechen.Click += new System.EventHandler(this.button2Abbrechen_Click);
            // 
            // button1Verkaufen
            // 
            this.button1Verkaufen.Location = new System.Drawing.Point(113, 375);
            this.button1Verkaufen.Name = "button1Verkaufen";
            this.button1Verkaufen.Size = new System.Drawing.Size(75, 23);
            this.button1Verkaufen.TabIndex = 25;
            this.button1Verkaufen.Text = "Verkaufen";
            this.button1Verkaufen.UseVisualStyleBackColor = true;
            this.button1Verkaufen.Click += new System.EventHandler(this.button1Verkaufen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Verkaufen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxLiegeplatz);
            this.panel1.Controls.Add(this.comboBoxMaterial);
            this.panel1.Controls.Add(this.button1Verkaufen);
            this.panel1.Controls.Add(this.comboBoxPreis);
            this.panel1.Controls.Add(this.comboBoxBaujahr);
            this.panel1.Controls.Add(this.comboBoxMarke);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 449);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Liegeplatz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Baujahr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Marke";
            // 
            // BDialogVerkaufen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BootsUI.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2Abbrechen);
            this.Name = "BDialogVerkaufen";
            this.Text = "Was wollen Sie verkaufen?";
            this.Load += new System.EventHandler(this.BDialogVerkaufen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLiegeplatz;
        private System.Windows.Forms.ComboBox comboBoxMarke;
        private System.Windows.Forms.ComboBox comboBoxBaujahr;
        private System.Windows.Forms.ComboBox comboBoxPreis;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button button2Abbrechen;
        private System.Windows.Forms.Button button1Verkaufen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}