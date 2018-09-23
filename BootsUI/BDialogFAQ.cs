using System.Windows.Forms;
using BootsLogik;

namespace BootsUI
{
    internal partial class BDialogFAQ : Form
    {

        #region Fields
        private INDialogFAQ _iLogikFAQ;
        private BDialogHaupt _dialogHaupt;
        #endregion


        #region ctor
        internal BDialogFAQ(INDialogFAQ LogikFAQ,BDialogHaupt dialogHaupt)
        {
            InitializeComponent();
            _iLogikFAQ = LogikFAQ;
            _dialogHaupt = dialogHaupt;
        }

        #endregion
    }
}
