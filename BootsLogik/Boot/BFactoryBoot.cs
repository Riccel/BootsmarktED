namespace BootsLogik.Boot
{
    // Erbt von INFactoryIBoot, zum Erzeugen eines neuen Bootes
    public class BFactoryBoot : INFactoryIBoot
    {
        public INBoot Create()
        {
            return new Boot();
        }
    }
}
