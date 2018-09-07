namespace BootsDaten.Datenbankzugang
{
    internal class ZDatenVerbindung : ZDaten
    {
        #region ctor
        internal ZDatenVerbindung(string connectionString)
            : base()
        {
            _connectionString = connectionString;
            _providerString = "System.Data.OleDb";
            this.Setup();

            _iDataCon = new ZDatenVerbZugang(this);
            _iDataDis = new ZDatenAbrZugang(this);
        }
        #endregion        
    }
}
