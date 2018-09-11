using System;
using System.Windows.Forms;
using BootsUI;
using BootsLogik;
using BootsDaten.Datenbankzugang;

namespace BootsmarktED
{
    class Programm
    {

        #region Fields
        // BootsUI
        private INDialog _iDialog;
        private INDialogFAQ _iLogikFAQ;
        private INDialogKonto _iLogikKonto;


        // BootsLogik
        private INLogik _iLogik;
        // BootsDaten
        private INDaten _iDbase;

        

        
        #endregion

        void Run()
        {

            string wegDbZugang = Properties.Settings.Default.WegDbZugang;
            string providerDbZugang = Properties.Settings.Default.ProviderDbZugang;
            string connectionString = providerDbZugang + wegDbZugang + ";";

            // Dependency Injection via Ctor
            _iDbase = new ZFactoryZDatenZugang().Create(connectionString);
            _iLogik = new BFactoryBLogik().Create(_iDbase);
            _iDialog = new BFactoryBDialogHaupt().Create(_iLogik,_iLogikFAQ,_iLogikKonto);

            // CDialogMain starten
            if (_iDialog is Form)
            {
                Application.Run(_iDialog as Form);
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Programm().Run();
            
        }
    }
}

