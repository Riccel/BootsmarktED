using BootsLogik;

namespace BootsUI
{
    // erbe von INFactoryIDialogHaupt, Über Logik zum Erstellen des Dialogs
    public class BFactoryBDialogHaupt : INFactoryIDialogHaupt
    {
        public INDialog Create(INLogik iLogik,INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto)
        {
            return new BDialogHaupt(iLogik, iLogikFAQ, iLogikKonto);
        }
    }
}
