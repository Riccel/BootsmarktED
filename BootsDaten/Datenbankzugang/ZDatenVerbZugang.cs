namespace BootsDaten.Datenbankzugang
{

    // Erbt von ZDatenverbindung
    internal class ZDatenVerbZugang : BootsDaten.ZDatenVerbindung
    {
        #region ctor
        internal ZDatenVerbZugang(ZDaten zDaten)
            : base(zDaten)
        {
        }
        #endregion 

    }
}
