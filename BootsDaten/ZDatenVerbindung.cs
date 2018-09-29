using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using BootsLogik;

namespace BootsDaten
{//Autor: Edgar Wendler
    internal abstract class ZDatenVerbindung : INDatenVerb
    {
        #region Fields        
        private ZDaten _zDaten;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region Ctor
        public ZDatenVerbindung(ZDaten zDaten)
        {
            _zDaten = zDaten;
            _dbConnection = zDaten.Connection;
            _dbCommand = zDaten.ProviderFactory.CreateCommand();
            _dbCommand.Connection = zDaten.Connection;
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

  
        #endregion

        #region virtual methods

        // Abfrage zum Zählen der Anzahl der Boote in der Datenbank
        protected virtual void DbCommandZaehleBoote(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT COUNT(*) FROM Boote";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            
        }

        // Abfrage der Boote nur nach Marke
        protected virtual void DbCommandGetMarke(DbCommand dbCommand)
        {
            dbCommand.CommandText =
                 @"SELECT DISTINCT Marke FROM Boote ORDER BY Marke";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
        }

       

        // Abfrage des Materials nach Marke
        protected virtual void DbCommandGetMaterial(string Marke, DbCommand dbCommand)
        {
            dbCommand.CommandText =
                @"SELECT DISTINCT Material FROM Boote WHERE Marke = [Marke] ORDER BY Material";
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            DbParameter dbParameter = _zDaten.ProviderFactory.CreateParameter();
            dbParameter.ParameterName = "Marke";
            dbParameter.Value = Marke;
            dbCommand.Parameters.Add(dbParameter);
        }

        

        // Datenbank öffnen
        protected virtual void Open()
        {
            // Datenbank geöffnet
            if (_dbConnection.State != ConnectionState.Open)
            {
                // Datenbank offen
                _dbConnection.Open();
                // gib zurück, ob Datenbank offen
                if (_dbConnection.State != ConnectionState.Open) return;
            }
        }

        // Datenbank schließen
        protected virtual void Close()
        {
            // Wenn Datenbank offen, dann schließe
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }


        // Gib die Objekte der Abfragen zurück
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


        // Gib die Afragen von der Datenbank zurück
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


