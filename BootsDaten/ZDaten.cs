using System;
using System.Data;
using System.Data.Common;
using BootsLogik;



namespace BootsDaten
{
    internal abstract class ZDaten : INDaten
    {
        #region Fields
        // Objektvariable        
        protected string _connectionString;
        protected string _providerString;

        // Kompositionen
        protected DbProviderFactory _dbProviderFactory;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;


        // Assoziationen
        protected INDatenVerb _iDatenVerb;
        protected INDatenAbr _iDatenAbr;

        #endregion

        #region Properties
        public INDatenVerb DatenVerb { get { return _iDatenVerb; } }
        public INDatenAbr DatenAbr { get { return _iDatenAbr; } }
        #endregion

        internal DbProviderFactory ProviderFactory { get { return _dbProviderFactory; } }
        internal DbConnection Connection { get { return _dbConnection; } }

        #region ctor
        internal ZDaten()
        {
           
        }
        #endregion


        #region interface Methoden für INDaten
        internal virtual void Setup()
        {
            // preconditions
            if (_connectionString == string.Empty)
                throw new NullReferenceException("ZugangDbase.Create() ConnectionString ist Null");
            if (_providerString == string.Empty)
                throw new NullReferenceException("ZugangDbase.Create() ProviderString ist Null");

            try
            {
                // Erstelle Provider Factory 
                _dbProviderFactory = DbProviderFactories.GetFactory(_providerString); // Provider

                // postcondition, wenn der Zugang zum Provider failt
                if (_dbProviderFactory == null)
                    throw new NullReferenceException("ZugangDbase.Create() fails _dbProviderFactory ist Null");

                // Erstelle Verbindung
                _dbConnection = _dbProviderFactory.CreateConnection();

                // postcondition, wenn keine Verbindung hergestellt werden kann
                if (_dbConnection == null)
                    throw new NullReferenceException("ZugangDbase.Create() fails _dbConnection ist Null");

                // Setze den ConnectionString
                _dbConnection.ConnectionString = _connectionString;

                // Setup DbCommand objects
                _dbCommand = _dbProviderFactory.CreateCommand();

                // Dependency Injection via Setter
                _dbCommand.Connection = _dbConnection; 
                _dbCommand.CommandType = CommandType.Text;

                

                // Test Verbindung
                if (_dbConnection.State != ConnectionState.Open)
                    _dbConnection.Open();
                if (_dbConnection.State == ConnectionState.Open)
                    _dbConnection.Close();
                else
                    throw new Exception("ADbase.TestConnection() Opening Database failed");
            }
            catch (Exception exception)
            {
                throw new DataException(
                    string.Format("ZugangDbase.Create() fails\nConnectionString:{0}\nProviderString:{1}\n{2}",
                    _connectionString, _providerString, exception));
            }
        }
        #endregion

    }
}


