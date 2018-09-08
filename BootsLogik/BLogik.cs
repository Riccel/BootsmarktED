using System.Data;

namespace BootsLogik
{
    internal class BLogik : INLogikSuche, INLogikVerkaufen, INLogik
    {
        #region Fields
        private INDaten _iData;
        private INDatenVerb _iDataCon;
        private INDatenAbr _iDataDis;
        //private INBoot _iBoot;

        #endregion

        #region Properties         
        public INLogikSuche LogikSuche { get { return this; } }
        public INLogikVerkaufen LogikVerkaufen { get { return this; } }
        #endregion

        #region Ctor
        internal BLogik(INDaten iData)
        {
            _iData = iData;
            _iDataCon = iData.DataCon;
            _iDataDis = iData.DataDis;
        }
        #endregion

        #region Interface INLogikSuche Methods
        public void Init(ref int nBoote, out object[] arrayMarke)
        {
            _iDataCon.Init(ref nBoote, out arrayMarke);
        }

        public object[] GetMaterial(string Marke)
        {
            return _iDataCon.GetMaterial(Marke);
        }

        public void SelectBoot(INBoot iBoot, ref DataTable datatable)
        {
            _iDataDis.SelectBoot(iBoot, ref datatable);
        }
        #endregion

        #region Interface INLogikVerkaufen Methods
        public void InsertBoot(INBoot iBoot)
        {
            _iDataDis.InsertBoot(iBoot);
        }
        #endregion
    }
}
