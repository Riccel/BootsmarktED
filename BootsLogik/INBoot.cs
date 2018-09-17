using System.Data;

namespace BootsLogik
{
    public interface INBoot
    {
        string Marke { get; set; }
        string Liegeplatz { get; set; }
        string Baujahr { get; set; }
        string Preis { get; set; }
        string Material { get; set; }
        long ID { get; set; }
        
        void AddNewDataRow(DataTable dataTable);

        void UpdateDataRow(DataTable dataTable);

        INBoot ErzeugeBoot(DataRow dataRow);
    }
}
