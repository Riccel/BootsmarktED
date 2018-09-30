using System.Data;

namespace BootsLogik
{
    internal class BLogik : INLogikSuche, INLogikVerkaufen, INLogik
    {// Autor: Daniel Wolff
        #region Fields
        private INDaten _iDaten;
        private INDatenVerb _iDatenVerb;
        private INDatenAbr _iDatenAbr;
        #endregion

        #region Properties         
        public INLogikSuche LogikSuche { get { return this; } }
        public INLogikVerkaufen LogikVerkaufen { get { return this; } }
        #endregion

        #region Ctor
        internal BLogik(INDaten iDaten)
        {
            _iDaten = iDaten;
            _iDatenVerb = iDaten.DatenVerb;
            _iDatenAbr = iDaten.DatenAbr;
        }
        #endregion

        #region Interface INLogikSuche Methods

        // Für die Suche. Methoden

        public void Init(ref int nBoote, out object[] arrayMarke)
        {
            _iDatenVerb.Init(ref nBoote, out arrayMarke);
        }

        public object[] GetMaterial(string Marke)
        {
            return _iDatenVerb.GetMaterial(Marke);
        }

        public void SelectBoot(INBoot iBoot, ref DataTable datatable)
        {
            _iDatenAbr.SelectBoot(iBoot, ref datatable);
        }

        #endregion


        // Für das Verkaufen. Methode
        #region Interface INLogikVerkaufen Methods
        public void InsertBoot(INBoot iBoot)
        {
            
            _iDatenAbr.InsertBoot(iBoot);
            
        }
        #endregion
    }
}
