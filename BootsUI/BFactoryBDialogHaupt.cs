using BootsLogik;

namespace BootsUI
{// Autor: Daniel Wolff, Edgar Wendler
    // erbe von INFactoryIDialogHaupt, Über Logik zum Erstellen des Dialogs
    public class BFactoryBDialogHaupt : INFactoryIDialogHaupt
    {
        public INDialog Create(INLogik iLogik,INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto)
        {
            return new BDialogHaupt(iLogik, iLogikFAQ, iLogikKonto);
        }
    }
}
