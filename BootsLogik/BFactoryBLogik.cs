namespace BootsLogik
{
    public class BFactoryBLogik : INFactoryILogik
    {
        public INLogik Create(INDaten iDbase)
        {
            return new BLogik(iDbase);
        }
    }
}
