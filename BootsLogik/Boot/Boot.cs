using System;
using System.Data;

namespace BootsLogik.Boot
{
    internal class Boot : INBoot
    {
        public string Marke { get; set; }
        public string Material { get; set; }
        public double Preis { get; set; }
        public int Baujahr { get; set; }
        public string Liegeplatz { get; set; }
        public Boot()
        {
            DateTime dateTime = DateTime.Today;
            Baujahr = dateTime.Year;
        }

        public void AddNewDataRow(DataTable dataTable)
        {

            DataRow dataRow = dataTable.NewRow();
            dataRow["pkGUID"] = Werkzeug.CreateGUID();
            dataRow["Make"] = Marke;
            dataRow["Model"] = Material;
            dataRow["Price"] = Preis;
            dataRow["Registration"] = Baujahr;
            dataRow["Mileage"] = Liegeplatz;
            dataRow["fkSeller"] = -1;

            dataTable.Rows.Add(dataRow); // DataRow der Tabelle hinzufügen
                                         // RowState steht auf RowState.Added
        }
    }
}
