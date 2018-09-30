using System.Data;

namespace BootsLogik
{// Autor: Daniel Wolff

    // Interface INLogik
    public interface INLogik
    {
        INLogikSuche LogikSuche { get; }
        INLogikVerkaufen LogikVerkaufen { get; }
  
    }

    // Interface Suche
    public interface INLogikSuche
    {
        void Init(ref int nBoote, out object[] arrayMarke);
        object[] GetMaterial(string Marke);


        void SelectBoot(INBoot iBoot, ref DataTable dataTable);

    }

    // Interface Verkaufen
    public interface INLogikVerkaufen
    {
       
        void InsertBoot(INBoot iBoot);

    }

   

   
}
