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
        public string ID { get; set; }


        public Boot() { }

        public Boot(string id)
        {
            ID = id;
            DateTime dateTime = DateTime.Today;
            Baujahr = dateTime.Year;
        }

        public void UpdateDataRow(DataTable dataTable)
        {

            DataRow dataRow = dataTable.NewRow();
            dataRow["ID"] = Werkzeug.CreateID();
            dataRow["Marke"] = Marke;
            dataRow["Material"] = Material;
            dataRow["Preis"] = Preis;
            dataRow["Baujahr"] = Baujahr;
            dataRow["Liegeplatz"] = Liegeplatz;
            dataRow["fKey"] = -1;
            dataTable.Rows.Add(dataRow); 
        }

        public Boot(DataRow dataRow)
        {
            ID = Convert.ToString(dataRow.ItemArray[0]);
            Marke = Convert.ToString(dataRow.ItemArray[1]);
            Material = Convert.ToString(dataRow.ItemArray[2]);
            Preis = Convert.ToDouble(dataRow.ItemArray[3]);
            Baujahr = Convert.ToInt32(dataRow.ItemArray[4]);
            Liegeplatz = Convert.ToString(dataRow.ItemArray[5]);
            
        }

    }
}
