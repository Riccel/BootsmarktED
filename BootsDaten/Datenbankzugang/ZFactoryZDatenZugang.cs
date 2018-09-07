using BootsLogik;

namespace BootsDaten.Datenbankzugang
{
    public class ZFactoryZDatenZugang : INFactoryIDaten
    {
        public INDaten Create(string connectionString)
        {
            return new ZDatenVerbindung(connectionString);
        }
    }
}
