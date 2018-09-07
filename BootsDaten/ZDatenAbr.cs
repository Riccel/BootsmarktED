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
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("BootTable");
            DataTable dataTable = this.GetSchema(dbDataAdapter);
            iBoot.AddNewDataRow(dataTable);
        }

        public void SelectBoot(INBoot iBoot, ref DataTable dataTable)
        {
            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter("BootTable");
            DbCommand dbCommand = dbDataAdapter.SelectCommand;
            this.DbCommandSelectBoot(iBoot, dbCommand);
            dbDataAdapter.Fill(dataTable);
        }

        protected virtual void DbCommandSelectBoot(INBoot iBoot, DbCommand dbCommand)
        {

            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = @"SELECT * FROM BootTable";

            if (iBoot.Marke != "Alle")
            {
                dbCommand.CommandText += " WHERE Marke = [pMarke]";
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

            dbCommand.CommandText += " AND LIEGEPLATZ <= [pLiegeplatz]";
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
                throw new Exception(" ADatabase.Fill() dataTable is null");
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.Fill() dbDataAdapter is null");

            int nRows = 0;
            try
            {
                nRows = dbDataAdapter.Fill(dataTable);
                return nRows;
            }
            catch (Exception exception)
            {
                string sql = dbDataAdapter.SelectCommand.CommandText;
                string message = string.Format("ADatabase.Fill() {0} fails\n", sql) + exception.Message;
                throw new Exception(message);
            }
        }

        protected virtual int Update(DataTable dataTable, DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (dataTable == null)
                throw new Exception(" ADatabase.Update() dataTable is null");
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.Update() dbDataAdapter is null");

            int nRows = 0;
            try
            {
                nRows = dbDataAdapter.Update(dataTable);
                // post condition is nRows == 0 zulässig?
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.Update() fails\n") + exception.Message;
                throw new Exception(message);
            }
            return nRows;
        }

        public virtual DataTable GetSchema(DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.GetSchema() dbDataAdapter is null");

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = dbDataAdapter.FillSchema(dataTable, SchemaType.Source);
                return dataTable;
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.GetSchema() {0} fails\n") + exception.Message;
                throw new Exception(message);
            }
        }

    }
}




