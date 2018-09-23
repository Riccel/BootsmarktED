using BootsLogik;

namespace BootsDaten.Datenbankzugang
{
    //Factory, erbt von INFactoryIDaten, Logik wird benötigt, um eine neue Verbindung herzustellen
    public class ZFactoryZDatenZugang : INFactoryIDaten
    {
        public INDaten Create(string connectionString)
        {
            return new ZDatenVerbindung(connectionString);
        }
    }
}
