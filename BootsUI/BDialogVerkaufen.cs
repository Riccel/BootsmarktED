using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootsLogik;
using BootsLogik.Boot;

namespace BootsUI
{
    internal partial class BDialogVerkaufen : Form
    {
        #region Fields
        private INLogikSuche _iLogikSuche;
        private INLogikVerkaufen _iLogikVerkaufen;
        private BDialogHaupt _dialogHaupt;
        #endregion

        #region Ctor
        internal BDialogVerkaufen(INLogik iLogik, BDialogHaupt dialogHaupt)
        {
            InitializeComponent();
            _iLogikSuche = iLogik.LogikSuche;
            _iLogikVerkaufen = iLogik.LogikVerkaufen;
            _dialogHaupt = dialogHaupt;
        }
        #endregion

        #region Method
        private void BDialogVerkaufen_Load(object sender, EventArgs e)
        {
            textBox5Baujahr.Clear();
            textBox6Marke.Clear();
            textBox3Material.Clear();
            textBox4Preis.Clear();
            textBox2Liegeplatz.Clear();



            //textBox6Marke.Addrange(_dialogHaupt.Marke);
            //textBox6Marke.Add("Alle");
            //textBox6Marke.Text = textBox6Marke.Items[0].ToString();
        }

        //private void comboBoxMarke_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.comboBoxMarke.Items.Count <= 0) return;
        //    this.comboBoxMarke.Text = this.comboBoxMarke.SelectedItem.ToString();
        //    string marke = this.comboBoxMarke.Text;
        //    if (marke == "Alle") return;

        //    // Alle Modelle des Herstellers aus der Datenbank lesen
        //    comboBoxMaterial.Items.Clear();
        //    comboBoxMaterial.Items.AddRange(_iLogikSuche.GetMaterial(marke));
        //    comboBoxMaterial.Items.Add("Alle");
        //    comboBoxMaterial.Text = comboBoxMaterial.Items[0].ToString();
        //}

        private void button1Verkaufen_Click(object sender, EventArgs e)
        {
            int baujahr;
            bool istBaujahr = int.TryParse(textBox5Baujahr.Text, out baujahr);
            if (!istBaujahr)
            {
                textBox5Baujahr.Text = "Keine Zahl";

            }

            double preis;
            bool istPreis = double.TryParse(textBox4Preis.Text, out preis);
            if (!istPreis)
            {
                textBox4Preis.Text = "Keine Zahl";

            }

            
            else
            {
                INBoot iBoot = _dialogHaupt.Boot;
                iBoot.ID = Werkzeug.CreateID();
                iBoot.Marke = this.textBox6Marke.Text;
                iBoot.Material = this.textBox3Material.Text;
                iBoot.Preis = this.textBox4Preis.Text;
                iBoot.Baujahr = this.textBox5Baujahr.Text;
                iBoot.Liegeplatz = this.textBox2Liegeplatz.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        #endregion

        private void button2Abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            textBox5Baujahr.Clear();
            textBox6Marke.Clear();
            textBox3Material.Clear();
            textBox4Preis.Clear();
            textBox2Liegeplatz.Clear();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
