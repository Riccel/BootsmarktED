using System;
using System.Data;
using System.Windows.Forms;

namespace BootsUI
{
    internal partial class BDialogSucheAusgabe : Form
    {

        #region fields
        private BDialogHaupt _dialogHaupt;
        private DataTable _dataTable;
        #endregion

        #region Properties Interface Implementierung des Dialogs der Suche
        public DataTable ResultTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }
        #endregion

        #region Ctor
        internal BDialogSucheAusgabe(BDialogHaupt dialogHaupt)
        {
            InitializeComponent();
            _dialogHaupt = dialogHaupt;
        }
        #endregion

        #region Methods
        private void BDialogSucheAusgabe_Load(object sender, EventArgs e)
        {

            // setze die Ausgabe in die GridView
            this.dataGridView1.DataSource = ResultTable;

            // setze die Spalten des primary key and foreign keys auf unsichtbar in der Ausgabe
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                if (column.Name.Substring(0, 2) == "ID" || column.Name.Substring(0, 2) == "fK")
                    column.Visible = false;
            }

            
            // Gebe die Ausgabe in der Spalten wieder/ AutoSize
            foreach (DataGridViewColumn dataGridViewColumn in this.dataGridView1.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        #endregion
    }
}
