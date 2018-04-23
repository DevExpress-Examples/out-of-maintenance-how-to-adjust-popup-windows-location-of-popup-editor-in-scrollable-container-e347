using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;



namespace MyComboBoxEdit
{
    public class MyPopupHelper
    {
        private EventHandler handleGotFocus;
        ScrollableControl scrControl;



        public MyPopupHelper(ScrollableControl scrControl)
        {
            handleGotFocus = null;
            this.scrControl = null;
            if (scrControl != null)
            {
                handleGotFocus = new EventHandler(OnGotFocus);
                this.scrControl = scrControl;
                SetEvents(this.scrControl);
            }
        }



        private void SetEvents(ScrollableControl sContrl)
        {
            foreach (Control contr in sContrl.Controls)
            {
                ScrollableControl s_contrl = contr as ScrollableControl;
                if (s_contrl != null)
                {
                    SetEvents(s_contrl);
                    continue;
                }

                PopupBaseEdit pbe = contr as PopupBaseEdit;
                if (pbe == null) continue;
                pbe.GotFocus += handleGotFocus;
            }
        }



        private void UnsetEvents(ScrollableControl sContrl)
        {
            foreach (Control contr in sContrl.Controls)
            {
                ScrollableControl s_contrl = contr as ScrollableControl;
                if (s_contrl != null)
                {
                    UnsetEvents(s_contrl);
                    continue;
                }

                PopupBaseEdit pbe = contr as PopupBaseEdit;
                if (pbe == null) continue;
                pbe.GotFocus -= handleGotFocus;
            }
        }



        private void OnGotFocus(object sender, EventArgs e)
        {
            (sender as Control).BeginInvoke(new MethodInvoker(delegate
            {
                PopupBaseEdit editor = sender as PopupBaseEdit;
                if (editor.IsPopupOpen)
                {
                    editor.ClosePopup();
                    editor.ShowPopup();
                }
            }));
        }



        ~MyPopupHelper()
        {
            if (scrControl != null && handleGotFocus != null)
            {
                try
                {
                    UnsetEvents(scrControl);
                }
                catch
                {
                }
            }
        }
    }
}
