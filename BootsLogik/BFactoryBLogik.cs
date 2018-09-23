namespace BootsLogik
{
    // erbt von INFactoryILogik 
    public class BFactoryBLogik : INFactoryILogik
    {
        public INLogik Create(INDaten iDbase)
        {
            return new BLogik(iDbase);
        }
    }
}
