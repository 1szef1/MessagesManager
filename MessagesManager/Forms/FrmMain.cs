using System;
using DevExpress.XtraEditors;

namespace MessagesManager.Forms
{
    public partial class FrmMain : XtraForm
    {
        #region Konstruktory

        public FrmMain()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Przyciski

        private void BtnMsgSender_Click(object sender, EventArgs e)
        {
            if (FrmMessageSender.Instance == null)
            {
                FrmMessageSender frm = new FrmMessageSender();
                frm.Show();
            }
            else
                FrmMessageSender.Instance.Focus();
        }

        private void BtnMsgManager_Click(object sender, EventArgs e)
        {
            if (FrmMessageList.Instance == null)
            {
                FrmMessageList frm = new FrmMessageList(Enums.FrmMode.Edit);
                frm.Show();
            }
            else
                FrmMessageList.Instance.Focus();
        }

        #endregion
    }
}
