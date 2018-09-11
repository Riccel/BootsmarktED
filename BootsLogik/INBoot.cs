using System.Data;

namespace BootsLogik
{
    public interface INBoot
    {
        string Marke { get; set; }
        string Liegeplatz { get; set; }
        int Baujahr { get; set; }
        double Preis { get; set; }
        string Material { get; set; }
        string ID { get; set; }
        void UpdateDataRow(DataTable dataTable);
    }
}
