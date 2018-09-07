

namespace BootsLogik.Boot
{
    public class BFactoryBoot : INFactoryIBoot
    {
        public INBoot Create()
        {
            return new Boot();
        }
    }
}
