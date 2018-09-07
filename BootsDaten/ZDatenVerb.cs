using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using BootsLogik;

namespace BootsDaten
{
    internal abstract class ZDatenVerb : INDatenVerb
    {
        #region Fields        
        private ZDaten _aData;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region Ctor
        public ZDatenVerb(ZDaten aData)
        {
            _aData = aData;
            _dbConnection = aData.Connection;
            _dbCommand = aData.ProviderFactory.CreateCommand();
            _dbCommand.Connection = aData.Connection;
            _dbCommand.CommandType = CommandType.Text;
        }
        #endregion

        #region Interface InterfaceDatenverbindung Methode
        // Nummer der Boote aus der Datenbank lesen
        public void Init(ref int nBoote, out object[] arrayMarke)
        {
            this.DbCommandCountBoote(_dbCommand);
            this.Open();
            nBoote = (int)this.ExecuteScalar(_dbCommand);

            this.DbCommandGetMarke(_dbCommand);
            DbDataReader dbDataReader = this.ExecuteQuery(_dbCommand);
            // Schleife über ResultSet
            List<object> listMarke = new List<object>();
            while (dbDataReader.Read())
            {
                listMarke.Add(dbDataReader[0]);
            }
            arrayMarke = listMarke.ToArray();
            if (!dbDataReader.IsClosed) dbDataReader.Close();
            this.Close();
        }

        // List of models for a specified maker
        public object[] GetMaterial(string marke)
        {
            this.DbCommandGetMaterial(marke, _dbCommand);
            this.Open();
            DbDataReader dbDataReader = this.ExecuteQuery(_dbCommand);
            List<object> listMaterial = new List<object>();
            while (dbDataReader.Read())
            {
                listMaterial.Add(dbDataReader[0]);
            }
            if (!dbDataReader.IsClosed) dbDataReader.Close();
            this.Close();
            return listMaterial.ToArray();
        }
        #endregion

        #region virtual methods
        protected virtual void DbCommandCountBoote(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT COUNT(*) FROM BootTable";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
        }

        protected virtual void DbCommandGetMarke(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT DISTINCT Marke FROM BootTable ORDER BY Marke";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
        }

        protected virtual void DbCommandGetMaterial(string marke, DbCommand dbCommand)
        {
            dbCommand.CommandText =
                @"SELECT DISTINCT Material FROM BootTable WHERE Marke = [pMarke] ORDER BY Material";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            DbParameter dbParameter = _aData.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = "pMarke";
            dbParameter.Value = marke;
            dbCommand.Parameters.Add(dbParameter);
        }

        protected virtual void Open()
        {
            // Ist die Db schon geöffent -> nichts tun
            if (_dbConnection.State != ConnectionState.Open)
            {
                // DB öffnen
                _dbConnection.Open();
                // Test ob DB jetz offen ist
                if (_dbConnection.State != ConnectionState.Open) return;
            }
        }

        protected virtual void Close()
        {
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        protected virtual object ExecuteScalar(DbCommand dbCommand)
        {
            if (!(_dbConnection.State == ConnectionState.Open))
                _dbConnection.Open();
            try
            {
                object obj = dbCommand.ExecuteScalar();
                return obj;
            }
            catch (Exception exception)
            {
                string sql = dbCommand.CommandText;
                string message = string.Format("ADatabase.ExecuteScalar() {0} fails\n", sql)
                               + exception.Message;
                throw new Exception(message);
            }

        }

        protected virtual DbDataReader ExecuteQuery(DbCommand dbCommand)
        {

            DbDataReader dbDataReader = null;
            if (!(_dbConnection.State == ConnectionState.Open))
                _dbConnection.Open();

            try
            {
                dbDataReader = dbCommand.ExecuteReader();
                return dbDataReader;
            }
            catch (Exception exception)
            {
                string sql = dbCommand.CommandText;
                string message = string.Format("ADatabase.ExecuteQuery() {0} fails\n", sql) + exception.Message;
                throw new Exception(message);
            }
        }
        #endregion
    }
}


