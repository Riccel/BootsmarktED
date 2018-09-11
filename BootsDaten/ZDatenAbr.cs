using System;
using System.Data;
using System.Data.Common;
using BootsLogik;

namespace BootsDaten
{
    internal abstract class ZDatenAbr : INDatenAbr
    {

        #region Fields        
        private ZDaten _aData;
        protected DbConnection _dbConnection;
        #endregion

        #region Ctor
        internal ZDatenAbr(ZDaten aData)
        {
            _aData = aData;
            _dbConnection = aData.Connection;
        }


        #endregion




        public virtual void InsertBoot(INBoot iBoot)
        {
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("Boote");
            DataTable dataTable = this.GetSchema(dbDataAdapter);
            DbCommand dbCommand = dbDataAdapter.SelectCommand;
            this.DbCommandInsertBoot(iBoot, dbCommand);
            int n = dbDataAdapter.Fill(dataTable);
            dbDataAdapter.Fill(dataTable);
            iBoot.UpdateDataRow(dataTable);
            dbDataAdapter.Update(dataTable);

        }



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















        public void SelectBoot(INBoot iBoot, ref DataTable dataTable)
        {
            
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("Boote");
            DbCommand dbCommand = dbDataAdapter.SelectCommand;
            this.DbCommandSelectBoot(iBoot, dbCommand);
            dbDataAdapter.SelectCommand = dbCommand;
            int n = dbDataAdapter.Fill(dataTable);
            dbDataAdapter.Fill(dataTable);
            dbDataAdapter.Update(dataTable);
        }




        #region Virtuelle Methoden
        protected virtual void DbCommandSelectBoot(INBoot iBoot, DbCommand dbCommand)
        {

            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = @"SELECT * FROM Boote WHERE 1";


            if (iBoot.Marke != "Alle")
            {
                dbCommand.CommandText += " AND Marke = [pMarke]";
                this.AddParameter(dbCommand, "pMake", iBoot.Marke);
            }
            
            if (iBoot.Material != "Alle")
            {
                dbCommand.CommandText += " AND Material = [pMaterial]";
                this.AddParameter(dbCommand, "pMaterial", iBoot.Material);
            }

            dbCommand.CommandText += " AND Preis <= [pPreis]";
            this.AddParameter(dbCommand, "pPreis", iBoot.Preis);

            dbCommand.CommandText += " AND Baujahr >= [pBaujahr]";
            this.AddParameter(dbCommand, "pBaujahr", iBoot.Baujahr);

            dbCommand.CommandText += " AND LIEGEPLATZ = [pLiegeplatz]";
            this.AddParameter(dbCommand, "pLiegeplatz", iBoot.Liegeplatz);
            
           

            dbCommand.CommandText += " ORDER BY Preis";
        }

        protected void AddParameter(DbCommand dbCommand, string name, object value)
        {
            DbParameter dbParameter = _aData.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = name;
            dbParameter.Value = value;
            dbCommand.Parameters.Add(dbParameter);
        }

        protected virtual DbDataAdapter CreateDbDataAdapter(string tableName)
        {

            DbCommand dbSelectCommand = _aData.ProviderFactory.CreateCommand();
            dbSelectCommand.Connection = _dbConnection;
            dbSelectCommand.CommandText = string.Format("SELECT * FROM {0}", tableName);

            DbDataAdapter dbDataAdapter = _aData.ProviderFactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = dbSelectCommand;
            // --- fertig, wenn keine schreibenden Datenbankzugriffe erforderlich ----

            DbCommandBuilder dbCommandBuilder = _aData.ProviderFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = dbDataAdapter;
            dbDataAdapter.InsertCommand = dbCommandBuilder.GetInsertCommand();
            dbDataAdapter.UpdateCommand = dbCommandBuilder.GetUpdateCommand();
            dbDataAdapter.DeleteCommand = dbCommandBuilder.GetDeleteCommand();

            return dbDataAdapter;
        }

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
                // post condition is nRows == 0 zulässig?
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




