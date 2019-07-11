using DevExpress.XtraEditors;
using MessagesManager.Interfaces;
using System.Windows.Forms;

namespace MessagesManager.Forms
{
    public partial class FrmBase : XtraForm, IFrmOptions, IDataValidator
    {
        #region Konstruktor i zdarzenia formy

        public FrmBase()
        {
            InitializeComponent();
        }

        #endregion

        #region IFrmOptions, IDataValidator - akcje formy

        public virtual void Save()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public virtual void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public virtual void Add()
        {
        }

        public virtual void Edit()
        {
        }

        public virtual void Remove()
        {
        }

        public virtual bool ValidateData()
        {
            return true;
        }

        #endregion
    }
}
