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

        #region Properties Interface Implementierung der Dialog der Suche
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

            // set datasource
            this.dataGridView1.DataSource = ResultTable;

            // set primary key and foreign keys columns invisible
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                if (column.Name.Substring(0, 2) == "ID" ||
                    column.Name.Substring(0, 2) == "fk")
                    column.Visible = false;
            }

            // column width auto
            foreach (DataGridViewColumn dataGridViewColumn in this.dataGridView1.Columns)
            {
                dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        #endregion
    }
}
