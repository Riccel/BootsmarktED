using System;
using System.Data;

namespace BootsLogik.Boot
{
    internal class Boot : INBoot
    {
        #region fields
        public string Marke { get; set; }
        public string Material { get; set; }
        public string Preis { get; set; }
        public string Baujahr { get; set; }
        public string Liegeplatz { get; set; }
        public int ID { get; set; }
        #endregion

        #region ctor
        public Boot() { }

        public Boot(int id)
        {
            ID = id;

        }
        #endregion

        #region methoden

        // Einfügen eines Tabelleneintrages
        public void AddNewDataRow(DataTable dataTable)
        {

            DataRow dataRow = dataTable.NewRow();
            if (this.ID != 0)
            {
                dataRow["ID"] = ID;
            }
            else
            {
                dataRow["ID"] = Werkzeug.CreateID();
            }
            dataRow["Marke"] = Marke;
            dataRow["Material"] = Material;
            dataRow["Preis"] = Preis;
            dataRow["Baujahr"] = Baujahr;
            dataRow["Liegeplatz"] = Liegeplatz;
            dataRow["fKey"] = -1;
            dataTable.Rows.Add(dataRow); 
        }

        // Aktualisiere den Eintrag in der Tabelle
        public void UpdateDataRow(DataTable dataTable)
        {

            DataRow dataRow = dataTable.Rows[0];
            
            dataRow["ID"] = ID;
           
            dataRow["Marke"] = Marke;
            dataRow["Material"] = Material;
            dataRow["Preis"] = Preis;
            dataRow["Baujahr"] = Baujahr;
            dataRow["Liegeplatz"] = Liegeplatz;
            //dataRow["fKey"] = -1;
            
        }

        // Füge ein Boot hinzu
        public INBoot ErzeugeBoot(DataRow dataRow)
        {
            INBoot iBoot = new BFactoryBoot().Create();
            iBoot.ID = (int)dataRow["ID"];
            iBoot.Marke = (string)dataRow["Marke"];
            iBoot.Material = (string)dataRow["Material"];
            iBoot.Liegeplatz = (string)dataRow["Liegeplatz"];
            iBoot.Baujahr = (string)dataRow["Baujahr"];
            iBoot.Preis = (string)dataRow["Preis"];
            
            if (!dataRow["Marke"].Equals(DBNull.Value))
            {
                iBoot.Marke = (string)dataRow["Marke"];
            }
            if (!dataRow["Material"].Equals(DBNull.Value))
            {
                iBoot.Material = (string)dataRow["Material"];
            }
            if (!dataRow["Liegenplatz"].Equals(DBNull.Value))
            {
                iBoot.Liegeplatz = (string)dataRow["Liegeplatz"];
            }
            if (!dataRow["Baujahr"].Equals(DBNull.Value))
            {
                iBoot.Baujahr = (string)dataRow["Baujahr"];
            }
            if (!dataRow["Preis"].Equals(DBNull.Value))
            {
                iBoot.Preis = (string)dataRow["Preis"];
            }


            return iBoot;
        }
        #endregion


    }
}
