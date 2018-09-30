using System.Data;

namespace BootsLogik
{
    public interface INBoot
    {// Autor: Daniel Wolff
        #region fields
        string Marke { get; set; }
        string Liegeplatz { get; set; }
        string Baujahr { get; set; }
        string Preis { get; set; }
        string Material { get; set; }
        int ID { get; set; }
        #endregion

        #region ctor

        #endregion

        #region Interface Methoden
        void AddNewDataRow(DataTable dataTable);

        void UpdateDataRow(DataTable dataTable);

        INBoot ErzeugeBoot(DataRow dataRow);
        #endregion
    }
}
