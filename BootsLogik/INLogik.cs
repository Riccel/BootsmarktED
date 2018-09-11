using System.Data;

namespace BootsLogik
{
    public interface INLogik
    {
        INLogikSuche LogikSuche { get; }
        INLogikVerkaufen LogikVerkaufen { get; }

        
    }

    public interface INLogikSuche
    {
        void Init(ref int nBoote, out object[] arrayMarke);
        object[] GetMaterial(string Marke);

        object[] GetLiegeplatz(string Liegeplatz);

        void SelectBoot(INBoot iBoot, ref DataTable dataTable);
    }

    public interface INLogikVerkaufen
    {
       
        void InsertBoot(INBoot iBoot);

    }

   

   
}
