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
            comboBoxMarke.Items.Clear();
            comboBoxMarke.Items.AddRange(_dialogHaupt.Marke);
            comboBoxMarke.Items.Add("Alle");
            comboBoxMarke.Text = comboBoxMarke.Items[0].ToString();
        }

        private void comboBoxMarke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxMarke.Items.Count <= 0) return;
            this.comboBoxMarke.Text = this.comboBoxMarke.SelectedItem.ToString();
            string marke = this.comboBoxMarke.Text;
            if (marke == "Alle") return;

            // Alle Modelle des Herstellers aus der Datenbank lesen
            comboBoxMaterial.Items.Clear();
            comboBoxMaterial.Items.AddRange(_iLogikSuche.GetMaterial(marke));
            comboBoxMaterial.Items.Add("Alle");
            comboBoxMaterial.Text = comboBoxMaterial.Items[0].ToString();
        }

        private void button1Verkaufen_Click(object sender, EventArgs e)
        {
            INBoot iBoot = _dialogHaupt.Boot;
            iBoot.Marke = this.comboBoxMarke.Text;
            iBoot.Material = this.comboBoxMaterial.Text;
            iBoot.Preis = Werkzeug.ParseDouble(this.comboBoxPreis.Text, 99999);
            iBoot.Baujahr = Werkzeug.ParseInt(this.comboBoxBaujahr.Text, 9999);
            iBoot.Liegeplatz = this.comboBoxLiegeplatz.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        #endregion

        private void button2Abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
