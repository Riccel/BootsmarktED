﻿using System;
using System.Data;
using System.Data.Common;
using BootsLogik;

namespace BootsDaten
{//Autor: Edgar Wendler
    internal abstract class ZDatenAbfragen : INDatenAbr
    {

        #region Fields        
        private ZDaten _zDaten;
        protected DbConnection _dbConnection;
        #endregion

        #region Ctor
        internal ZDatenAbfragen(ZDaten zDaten)
        {
            _zDaten = zDaten;
            _dbConnection = zDaten.Connection;
        }


        #endregion



        #region Interface Methoden

        // Methode fürs Verkaufen
        public virtual void InsertBoot(INBoot iBoot)
        {
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("Boote");
            DataTable dataTable = this.GetSchema(dbDataAdapter);
            DbCommand dbCommand = dbDataAdapter.SelectCommand;
            iBoot.AddNewDataRow(dataTable);
            if (this.Update(dataTable, dbDataAdapter) != 1)
            {
                throw new Exception("ZDatenbank.InsertNuzter() fails");
            }
        }

        // Methode fürs Suchen
        public void SelectBoot(INBoot iBoot, ref DataTable dataTable)
        {
            
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("Boote");
            DbCommand dbCommand = dbDataAdapter.SelectCommand;
            this.DbCommandSelectBoot(iBoot, dbCommand);
            int n = this.Fill(dataTable,dbDataAdapter);
           
        }
        #endregion

        #region Virtuelle Methoden

        // Abfrage für die Suchen Methode
        protected virtual void DbCommandSelectBoot(INBoot iBoot, DbCommand dbCommand)
        {

            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = @"SELECT * FROM Boote WHERE 1";

            if (iBoot.Marke != null && iBoot.Marke != "" && iBoot.Marke != "Alle")
            {
                dbCommand.CommandText += " AND Marke = [pMarke]";
                this.AddParameter(dbCommand, "pMarke", iBoot.Marke);
            }
            
            if (iBoot.Material != null && iBoot.Material != "" && iBoot.Material != "Alle")
            {
                dbCommand.CommandText += " AND Material = [pMaterial]";
                this.AddParameter(dbCommand, "pMaterial", iBoot.Material);
            }

            if (iBoot.Preis != null && iBoot.Preis != "")
            {
                dbCommand.CommandText += " AND Preis <= [pPreis]";
                this.AddParameter(dbCommand, "pPreis", iBoot.Preis);
            }


            if (iBoot.Baujahr != null && iBoot.Baujahr != "")
            {
                dbCommand.CommandText += " AND Baujahr >= [pBaujahr]";
                this.AddParameter(dbCommand, "pBaujahr", iBoot.Baujahr);
            }

            if (iBoot.Liegeplatz != null && iBoot.Liegeplatz != "" && iBoot.Liegeplatz != " ")
            {
                dbCommand.CommandText += " AND Liegeplatz = [pLiegeplatz]";
                this.AddParameter(dbCommand, "pLiegeplatz", iBoot.Liegeplatz);
            }

            dbCommand.CommandText += " ORDER BY Preis";
        }


        // Abfrage für die Verkaufen Methode
        protected virtual void DbCommandInsertBoot(INBoot iBoot, DbCommand dbCommand)
        {


            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();

            dbCommand.CommandText = @"SELECT * FROM Boote WHERE 1";

            if (iBoot.Marke != null)
            {
                dbCommand.CommandText += " AND Marke = [pMarke]";
                this.AddParameter(dbCommand, "pMake", iBoot.Marke);
            }
            if (iBoot.Material != null)
            {
                dbCommand.CommandText += " AND Material = [pMaterial]";
                this.AddParameter(dbCommand, "pMaterial", iBoot.Material);
            }

            // Nicht höher als 99999
            dbCommand.CommandText += " AND Preis <= [pPreis]";
            this.AddParameter(dbCommand, "pPreis", iBoot.Preis);

            // Ab 1950 beginnend
            dbCommand.CommandText += " AND Baujahr >= [pBaujahr]";
            this.AddParameter(dbCommand, "pBaujahr", iBoot.Baujahr);

            if (iBoot.Liegeplatz != null)
            {
                dbCommand.CommandText += " AND LIEGEPLATZ = [pLiegeplatz]";
                this.AddParameter(dbCommand, "pLiegeplatz", iBoot.Liegeplatz);
            }

            dbCommand.CommandText += " ORDER BY Preis";
        }

        

        // Hinzufügen der Parameter, wenn Zugang zur Datenbank
        protected void AddParameter(DbCommand dbCommand, string name, object value)
        {
            DbParameter dbParameter = _zDaten.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = name;
            dbParameter.Value = value;
            dbCommand.Parameters.Add(dbParameter);
        }

        // Adapter
        protected virtual DbDataAdapter CreateDbDataAdapter(string tableName)
        {

            DbCommand dbSelectCommand = _zDaten.ProviderFactory.CreateCommand();
            dbSelectCommand.Connection = _dbConnection;
            dbSelectCommand.CommandText = string.Format("SELECT * FROM {0}", tableName);

            DbDataAdapter dbDataAdapter = _zDaten.ProviderFactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = dbSelectCommand;
      
            DbCommandBuilder dbCommandBuilder = _zDaten.ProviderFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = dbDataAdapter;
            dbDataAdapter.InsertCommand = dbCommandBuilder.GetInsertCommand();
            dbDataAdapter.UpdateCommand = dbCommandBuilder.GetUpdateCommand();
            dbDataAdapter.DeleteCommand = dbCommandBuilder.GetDeleteCommand();

            return dbDataAdapter;
        }

        // Befüllen der Bootstabellen mit Exceptions
        protected virtual int Fill(DataTable dataTable, DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (dataTable == null)
                throw new Exception(" ZDatenbank.Fill() dataTable is null");
            if (dbDataAdapter == null)
                throw new Exception(" ZDatenbank.Fill() dbDataAdapter is null");

            int nRows = 0;
            try
            {
                nRows = dbDataAdapter.Fill(dataTable);
                return nRows;
            }
            catch (Exception exception)
            {
                string access = dbDataAdapter.SelectCommand.CommandText;
                string message = string.Format("ZDatenbank.Fill() {0} fails\n", access) + exception.Message;
                throw new Exception(message);
            }
        }

        // Update Methode beim Schreiben in die Datenbank
        protected virtual int Update(DataTable dataTable, DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (dataTable == null)
                throw new Exception(" ZDatenbank.Update() dataTable is null");
            if (dbDataAdapter == null)
                throw new Exception(" ZDatenbank.Update() dbDataAdapter is null");

            int nRows = 0;
            try
            {
                nRows = dbDataAdapter.Update(dataTable);
                
            }
            catch (Exception exception)
            {
                string message = string.Format("ZDatenbank.Update() fails\n") + exception.Message;
                throw new Exception(message);
            }
            return nRows;
        }

        
        public virtual DataTable GetSchema(DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (dbDataAdapter == null)
                throw new Exception(" ZDatenbank.GetSchema() dbDataAdapter is null");

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = dbDataAdapter.FillSchema(dataTable, SchemaType.Source);
                return dataTable;
            }
            catch (Exception exception)
            {
                string message = string.Format("ZDatenbank.GetSchema() fails\n") + exception.Message;
                throw new Exception(message);
            }
        }
        #endregion

    }
}




