using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using MessagesManager.Api.Interfaces;
using MessagesManager.Data.Services;
using MessagesManager.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagesManager.Forms
{
    public partial class FrmMessageList : FrmBase
    {
        public static XtraForm Instance { get; protected set; } 

        #region Pola

        private readonly FrmMode _mode;
        private MessageService _service;
        private IList<IApiMsg> _msgList;

        #endregion

        #region Właściwości

        public IApiMsg SelectedMsg => viewMsg.GetFocusedRow() as IApiMsg;

        #endregion

        #region Konstruktory i akcje formy

        public FrmMessageList(FrmMode mode)
        {
            InitializeComponent();
            this._mode = mode;

            if (mode == FrmMode.Select)
                lciAdd.Visibility = lciEdit.Visibility = lciRemove.Visibility = LayoutVisibility.Never;
            else
                lciChoose.Visibility = LayoutVisibility.Never;

            this.FormClosed += new FormClosedEventHandler(this.FormIsClosed);
            this.Load += new EventHandler(this.FormIsLoad);
        }

        private async void FormIsLoad(object sender, EventArgs e)
        {
            await GetData();
            Instance = this;
        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        #endregion

        #region Dane

        private async Task GetData()
        {
            _service = new MessageService();

            try
            {
                _msgList = await _service.GetListAsync();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił błąd przy pobraniu komunikatów.{Environment.NewLine}{ex.Message}", 
                    "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
            gridMsg.DataSource = _msgList;
        }

        #endregion

        #region Przyciski akcji

        public override void Add()
        {
            var frm = new FrmMessageEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _msgList.Add(frm.WndMessage);
                gridMsg.RefreshDataSource();
            }

            base.Add();
        }

        public override void Edit()
        {
            var msg = SelectedMsg;
            if (msg == null) return;

            var frm = new FrmMessageEdit(msg);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                gridMsg.RefreshDataSource();
            }

            base.Edit();
        }

        public override async void Remove()
        {
            var msg = SelectedMsg;
            if (msg == null) return;

            var dr = XtraMessageBox.Show("Czy na pewno usunąć wybrany komunikat?", "Komunikat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            try
            {
                await _service.RemoveAsync(msg);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił błąd przy usuwaniu komunikatu.{Environment.NewLine}{ex.Message}", 
                    "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _msgList.Remove(msg);
            gridMsg.RefreshDataSource();

            base.Remove();
        }

        public override void Save()
        {
            var msg = SelectedMsg;
            if (msg == null) return;

            base.Save();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            Edit();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void BtnWybierz_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion

        #region Zdarzenia siatki

        private void ViewMsg_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            btnEdit.Enabled = btnRemove.Enabled = SelectedMsg != null;
        }

        private void ViewMsg_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                if (_mode == FrmMode.Select)
                    Save();
                else if (_mode == FrmMode.Edit)
                    Edit();
            }
        }

        #endregion
    }
}
