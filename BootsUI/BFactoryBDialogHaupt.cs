using BootsLogik;

namespace BootsUI
{
    public class BFactoryBDialogHaupt : INFactoryIDialogHaupt
    {
        public INDialog Create(INLogik iLogik,INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto)
        {
            return new BDialogHaupt(iLogik, iLogikFAQ, iLogikKonto);
        }
    }
}
