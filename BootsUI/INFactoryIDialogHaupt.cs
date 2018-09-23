using BootsLogik;

namespace BootsUI
{
    // Interface zum INDialog
    public interface INFactoryIDialogHaupt
    {
        INDialog Create(INLogik iLogik, INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto);
    }
}
