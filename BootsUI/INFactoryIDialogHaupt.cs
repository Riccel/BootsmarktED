using BootsLogik;

namespace BootsUI
{
    public interface INFactoryIDialogHaupt
    {
        INDialog Create(INLogik iLogik, INDialogFAQ iLogikFAQ, INDialogKonto iLogikKonto);
    }
}
