using System;
using System.Windows.Forms;
using BootsLogik;
using BootsLogik.Boot;

namespace BootsUI
{
    internal partial class Suche : Form
    {
        #region Fields
        private INLogikSuche _iLogikSuche;
        private BDialogHaupt _dialogHaupt;


        #endregion

        #region Ctor
        internal Suche(INLogik iLogik, BDialogHaupt dialogHaupt)
        {
            InitializeComponent();
            _iLogikSuche = iLogik.LogikSuche;
            _dialogHaupt = dialogHaupt;
        }

        #endregion



        private void Suche_Load(object sender, EventArgs e)
        {
            comboBoxMarke.Items.Clear();
            comboBoxMarke.Items.AddRange(_dialogHaupt.Marke);
            comboBoxMarke.Items.Add("Alle");
            comboBoxMarke.Text = comboBoxMarke.Items[0].ToString();

            if (comboBoxBaujahr.Items.Count >= 1)
                comboBoxBaujahr.Text = comboBoxBaujahr.Items[0].ToString();

            if (comboBoxPreis.Items.Count >= 1)
                comboBoxPreis.Text = comboBoxPreis.Items[0].ToString();

            if (comboBoxLiegeplatz.Items.Count >= 1)
                comboBoxLiegeplatz.Text = comboBoxLiegeplatz.Items[0].ToString();
        }





        private void comboBoxMarke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxMarke.Items.Count <= 0) return;
            this.comboBoxMarke.Text = this.comboBoxMarke.SelectedItem.ToString();
            string Marke = this.comboBoxMarke.Text;
            if (Marke == "Alle") return;

            // Alle Marken mit dem Material aus der Datenbank lesen
            comboBoxMaterial.Items.Clear();
            comboBoxMaterial.Items.AddRange(_iLogikSuche.GetMaterial(Marke));
            comboBoxMaterial.Items.Add("Alle");
            comboBoxMaterial.Text = comboBoxMaterial.Items[0].ToString();

            
        }



        // Abbrechen
        private void button2Abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
            this.Close();
        }

        // Suchen drücken
        private void button1Suchen_Click(object sender, EventArgs e)
        {
           
            INBoot iBoot = _dialogHaupt.Boot;
            iBoot.Marke = this.comboBoxMarke.Text;
            iBoot.Material = this.comboBoxMaterial.Text;
            iBoot.Preis = this.comboBoxPreis.Text;
            iBoot.Baujahr = this.comboBoxBaujahr.Text;
            iBoot.Liegeplatz = this.comboBoxLiegeplatz.Text;
            _dialogHaupt.Boot = iBoot;
            //_iLogikSuche.SelectBoot(iBoot);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
