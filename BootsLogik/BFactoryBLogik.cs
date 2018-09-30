namespace BootsLogik
{
    // erbt von INFactoryILogik 
    public class BFactoryBLogik : INFactoryILogik
    {// Autor: Daniel Wolff
        public INLogik Create(INDaten iDbase)
        {
            return new BLogik(iDbase);
        }
    }
}
