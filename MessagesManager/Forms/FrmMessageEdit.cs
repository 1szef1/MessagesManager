using DevExpress.XtraEditors;
using MessagesManager.Api.Interfaces;
using System;
using System.Windows.Forms;

namespace MessagesManager.Forms
{
    public partial class FrmMessageEdit : FrmMessage
    {
        #region Konstruktory

        public FrmMessageEdit()
        {
            InitializeComponent();
        }

        public FrmMessageEdit(IApiMsg message)
            : this()
        {
            _message = message;
        }

        #endregion

        #region Przyciski akcji

        public override async void Save()
        {
            if (ValidateData())
            {
                AssignData();

                if (_saveNeed)
                {
                    try
                    {
                        if (_message.Id > 0)
                            await _service.UpdateAsync(_message);
                        else
                            await _service.AddAsync(_message);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Wystąpił błąd przy zapisie komunikatu.{Environment.NewLine}{ex.Message}", 
                            "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                base.Save();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            _saveNeed = true;
            Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        #endregion
    }
}
