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
            this.DbCommandZaehleBoote(_dbCommand);
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

        // Liste für bestimmtes Material sortiert nach Marke
        public object[] GetMaterial(string Marke)
        {
            this.DbCommandGetMaterial(Marke, _dbCommand);
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

        // Liste für bestimmte Liegeplätze sortiert nach Marke
        public object[] GetLiegeplatz(string Liegeplatz)
        {
            this.DbCommandGetLiegeplatz(Liegeplatz, _dbCommand);
            this.Open();
            DbDataReader dbDataReader = this.ExecuteQuery(_dbCommand);
            List<object> listLiegeplatz = new List<object>();
            while (dbDataReader.Read())
            {
                listLiegeplatz.Add(dbDataReader[0]);
            }
            if (!dbDataReader.IsClosed) dbDataReader.Close();
            this.Close();
            return listLiegeplatz.ToArray();
        }








        #endregion

        #region virtual methods
        protected virtual void DbCommandZaehleBoote(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT COUNT(*) FROM Boote";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            
        }

        protected virtual void DbCommandGetMarke(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT DISTINCT Marke FROM Boote ORDER BY Marke";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
        }

        protected virtual void DbCommandGetLiegeplatz(string Liegeplatz, DbCommand dbCommand)
        {
            dbCommand.CommandText =
                @"SELECT DISTINCT Liegeplatz FROM Boote WHERE Marke = [pMarke] ORDER BY Preis";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            DbParameter dbParameter = _aData.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = "pLiegeplatz";
            dbParameter.Value = Liegeplatz;
            dbCommand.Parameters.Add(dbParameter);
        }


        protected virtual void DbCommandGetMaterial(string Marke, DbCommand dbCommand)
        {
            dbCommand.CommandText =
                @"SELECT DISTINCT Material FROM Boote WHERE Marke = [pMarke] ORDER BY Material";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            DbParameter dbParameter = _aData.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = "pMarke";
            dbParameter.Value = Marke;
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
                string access = dbCommand.CommandText;
                string message = string.Format("ZDatenbank.ExecuteScalar() {0} fails\n", access)
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
                string access = dbCommand.CommandText;
                string message = string.Format("ZDatenbank.ExecuteQuery() {0} fails\n", access) + exception.Message;
                throw new Exception(message);
            }
        }
        #endregion
    }
}


