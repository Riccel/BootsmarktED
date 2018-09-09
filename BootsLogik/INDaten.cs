using System.Data;

namespace BootsLogik
{
    public interface INDaten
    {
        INDatenAbr DataDis { get; }
        INDatenVerb DataCon { get; }
    }

    public interface INDatenVerb
    {
        void Init(ref int nBoote, out object[] arrayMarke);
        object[] GetMaterial(string Marke);

    }

    public interface INDatenAbr
    {
        void SelectBoot(INBoot iBoot, ref DataTable dataTable);
        void InsertBoot(INBoot iBoot);
    }

    
}
