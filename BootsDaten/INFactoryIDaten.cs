using BootsLogik;

namespace BootsDaten
{//Autor: Edgar Wendler

    // Interface zu INDaten, wichtig für die Erstellung einer neuen Verbindung
    public interface INFactoryIDaten
    {
        INDaten Create(string connectionString);

    }
}
