using System.Data;

namespace BootsLogik
{

    // Interface für INDaten
    public interface INDaten
    {
        INDatenAbr DatenAbr { get; }
        INDatenVerb DatenVerb { get; }

        
    }

    // Interface für INDatenVerb
    public interface INDatenVerb
    {
        void Init(ref int nBoote, out object[] arrayMarke);
        object[] GetMaterial(string Marke);

    }

    // Interface für INDatenAbr
    public interface INDatenAbr
    {
        void SelectBoot(INBoot iBoot, ref DataTable dataTable);
        void InsertBoot(INBoot iBoot);
  
    }

}
