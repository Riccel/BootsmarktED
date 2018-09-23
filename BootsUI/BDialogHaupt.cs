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
    internal partial class BDialogHaupt : Form, INDialog
    {

        #region Fields
        private int _nBoote;
        private object[] _arrayMarke;

        // Komposition
        private Suche _dialogSuche;
        private BDialogSucheAusgabe _dialogSucheAusgabe;
        private BDialogVerkaufen _dialogVerkaufen;
        private BDialogFAQ _dialogFAQ;
        private BDialogKonto _dialogKonto;
        

        // externe Komponenten
        private INLogik _iLogik;
        private INLogikSuche _iLogikSuche;
        private INLogikVerkaufen _iLogikVerkaufen;
        private INDialogFAQ _iLogikFAQ;
        private INDialogKonto _iLogikKonto;
        private INBoot _iBoot;
        #endregion

        #region Properties
        internal INBoot Boot { get { return _iBoot; }set { _iBoot = value; } }
        internal object[] Marke { get { return _arrayMarke; } }
        #endregion

        #region Ctor
        internal BDialogHaupt(INLogik iLogik, INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto)
        {
            InitializeComponent();
            _iLogik = iLogik;
            _iLogikSuche = iLogik.LogikSuche;
            _iLogikVerkaufen = iLogik.LogikVerkaufen;
            _iLogikFAQ = iLogikFAQ;
            _iLogikKonto = iLogikKonto;
            _iBoot = new BFactoryBoot().Create();
            _dialogSuche = new Suche(iLogik, this);
            _dialogSucheAusgabe = new BDialogSucheAusgabe(this);
            _dialogVerkaufen = new BDialogVerkaufen(iLogik, this);
            _dialogFAQ = new BDialogFAQ(iLogikFAQ,this);
            _dialogKonto = new BDialogKonto(iLogikKonto, this);
        }

        #endregion





        #region Methode fürs Interface

        // Initialisiere die Suche der Abfrage der Anzahl der Boote
        public void Init()
        {
            _iLogikSuche.Init(ref _nBoote, out _arrayMarke);
            
        }

        #endregion

        #region Events

        private void BDialogHaupt_Load(object sender, EventArgs e)
        {
            // Gib die Anzahl der Boote im Label wieder
            this.Init();
            this.label1BooteZaehlen.Text = _nBoote.ToString() + " Treffer";


            InitializeComponent();
        }

        
    
        #endregion


        // Suchen Button
        private void button1Suchen_Click(object sender, EventArgs e)
        {
  
            DialogResult dialogResult = _dialogSuche.ShowDialog();
            DataTable dataTable = new DataTable();
            if (dialogResult == DialogResult.OK)
            {
                // Suchen ausführen
                _iLogikSuche.SelectBoot(_iBoot, ref dataTable);
               
                // Ergebnis in DialogSearchView darstellen
                if (_dialogSucheAusgabe is BDialogSucheAusgabe)
                {
                    // Down Cast
                    (_dialogSucheAusgabe as BDialogSucheAusgabe).ResultTable = dataTable;
                }
                dialogResult = _dialogSucheAusgabe.ShowDialog();
            }

        }


        // Verkaufen Button
        private void button2Verkaufen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = _dialogVerkaufen.ShowDialog();
            DataTable dataTable = new DataTable();
            if (dialogResult == DialogResult.OK)
            {
                // Einfügen ausführen
                _iLogikVerkaufen.InsertBoot(_iBoot);
            }

            
        }

        // FAQ
        private void button4FAQ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = _dialogFAQ.ShowDialog();
        }

        // Konto
        private void button3Konto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = _dialogKonto.ShowDialog();
        }

        
    }
}
