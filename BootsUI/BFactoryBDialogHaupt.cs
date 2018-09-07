using BootsLogik;

namespace BootsUI
{
    public class BFactoryBDialogHaupt : INFactoryIDialogHaupt
    {
        public INDialog Create(INLogik iLogik)
        {
            return new BDialogHaupt(iLogik);
        }
    }
}
