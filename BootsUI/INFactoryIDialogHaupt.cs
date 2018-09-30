using BootsLogik;

namespace BootsUI
{// Autor: Daniel Wolff, Edgar Wendler
    // Interface zum INDialog
    public interface INFactoryIDialogHaupt
    {
        INDialog Create(INLogik iLogik, INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto);
    }
}
