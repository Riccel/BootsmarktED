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
        private object[] _arrayMake;

        // Komposition
        private Suche _dialogSuche;
        private BDialogSucheAusgabe _dialogSucheAusgabe;
        private BDialogVerkaufen _dialogVerkaufen;

        // externe Komponenten
        private INLogik _iLogik;
        private INLogikSuche _iLogikSuche;
        private INLogikVerkaufen _iLogikVerkaufen;
        private INBoot _iBoot;
        #endregion

        #region Properties
        internal INBoot Boot { get { return _iBoot; } }
        internal object[] Marke { get { return _arrayMake; } }
        #endregion

        #region Ctor
        internal BDialogHaupt(INLogik iLogik)
        {
            InitializeComponent();
            _iLogik = iLogik;
            _iLogikSuche = iLogik.LogikSuche;
            _iLogikVerkaufen = iLogik.LogikVerkaufen;
            _iBoot = new BFactoryBoot().Create();
            _dialogSuche = new Suche(iLogik, this);
            _dialogSucheAusgabe = new BDialogSucheAusgabe(this);
            _dialogVerkaufen = new BDialogVerkaufen(iLogik, this);
        }
        
        #endregion





        #region Methode fürs Interface
        public void Init()
        {
            _iLogikSuche.Init(ref _nBoote, out _arrayMake);
        }

        #endregion

        #region Events

        private void BDialogHaupt_Load(object sender, EventArgs e)
        {
            this.Init();
            this.label1BooteZaehlen.Text = _nBoote.ToString() + " Treffer";


            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
