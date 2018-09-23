using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootsLogik;

namespace BootsUI
{
    internal partial class BDialogKonto : Form
    {
        #region Fields
        private INDialogKonto _iLogikKonto;
        private BDialogHaupt _dialogHaupt;
        #endregion


        #region ctor
        internal BDialogKonto(INDialogKonto LogikKonto, BDialogHaupt dialogHaupt)
        {
            InitializeComponent();
            _iLogikKonto = LogikKonto;
            _dialogHaupt = dialogHaupt;
        }

        #endregion
    }
}
