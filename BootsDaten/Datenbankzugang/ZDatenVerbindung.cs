using BootsLogik;

namespace BootsDaten.Datenbankzugang
{
    // Erbt von ZDaten
    // Bereitet die Verbindung zur Datenbank vor
    // Mit Provider und Pfad
    internal class ZDatenVerbindung : ZDaten
    {
        #region ctor
        internal ZDatenVerbindung(string connectionString)
            : base()
        {
            _connectionString = connectionString;
            _providerString = "System.Data.OLEDB";
            this.Setup();

            _iDatenVerb = new ZDatenVerbZugang(this);
            _iDatenAbr = new ZDatenAbrZugang(this);
        }
        #endregion        
    }
}
