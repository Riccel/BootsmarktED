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

        #region Methoden
        private void BDialogVerkaufen_Load(object sender, EventArgs e)
        {
            textBox5Baujahr.Clear();
            textBox6Marke.Clear();
            textBox3Material.Clear();
            textBox4Preis.Clear();
            textBox2Liegeplatz.Clear();

        }

       

        private void button1Verkaufen_Click(object sender, EventArgs e)
        {
            // Überprüfe Baujahr, soll eine Zahl sein
            int baujahr;
            bool istBaujahr = int.TryParse(textBox5Baujahr.Text, out baujahr);
            if (!istBaujahr)
            {
                textBox5Baujahr.Text = "Keine Zahl";

            }

            // Überprüfe Preis, soll eine Zahl sein
            double preis;
            bool istPreis = double.TryParse(textBox4Preis.Text, out preis);
            if (!istPreis)
            {
                textBox4Preis.Text = "Keine Zahl";

            }

            // Nach Überprüfung gebe Daten weiter an INBoot
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


        // Abbrechen
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
