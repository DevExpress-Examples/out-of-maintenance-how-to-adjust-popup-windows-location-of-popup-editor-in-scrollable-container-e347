using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;



namespace MyComboBoxEdit
{
    public partial class FormMain : Form
    {
        private MyPopupHelper popupHelper;


        public FormMain()
        {
            InitializeComponent();
            popupHelper = new MyPopupHelper(panelControl1);   
        }
    }
}
