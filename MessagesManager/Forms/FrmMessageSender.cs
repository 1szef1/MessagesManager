using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MessagesManager.Api.Interfaces;
using MessagesManager.Data.Model;
using MessagesManager.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagesManager.Forms
{
    public partial class FrmMessageSender : FrmMessage
    {
        #region Pola

        private IApiMsgSender _sender;
        private IList<IApiMsg> _favorites;

        #endregion

        #region Konstruktory

        public FrmMessageSender()
        {
            InitializeComponent();
        }

        #endregion

        #region Dane

        protected override void Initialize()
        {
            base.Initialize();
            _sender = new SenderService();

            GetFavorites();
        }

        private async Task GetFavorites()
        {
            txtContent.Properties.BeforeShowMenu += new BeforeShowMenuEventHandler(this.TxtContent_Properties_BeforeShowMenu);

            try
            {
                _favorites = await _service.GetFavoriteList();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił błąd przy pobieraniu ulubionych komunikatów.{Environment.NewLine}{ex.Message}", 
                    "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TxtContent_Properties_BeforeShowMenu(object sender, BeforeShowMenuEventArgs e)
        {
            CreateFavoritesMenu(e.Menu);
        }

        private void CreateFavoritesMenu(DXPopupMenu menu)
        {
            for (int i = menu.Items.Count - 1; i >= 0; i--)
            {
                if (!object.Equals(menu.Items[i].Tag, StringId.TextEditMenuPaste))
                    menu.Items.RemoveAt(i);
            }

            if (_favorites != null && _favorites.Count > 0)
            {
                for (int i = 0; i < _favorites.Count; i++)
                {
                    DXMenuItem menuItem = new DXMenuItem()
                    {
                        Tag = _favorites[i],
                        Caption = _favorites[i].Content.Substring(0, Math.Min(_favorites[i].Content.Length, 50)),
                        BeginGroup = (i == 0)
                    };
                    menuItem.Click += (s, e) => ChangeMessage((s as DXMenuItem).Tag as WndMessage);
                    menu.Items.Add(menuItem);
                }
            }
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

                try
                {
                    await _sender.SendAsync(_message).ContinueWith((t) =>
                    {
                        if (t.Result == true)
                            XtraMessageBox.Show("Komunikat wysłano.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Wystąpił błąd przy wysyłaniu komunikatu.{Environment.NewLine}{ex.Message}", 
                        "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            _saveNeed = false;
            Save();
        }

        private void BtnSaveSend_Click(object sender, EventArgs e)
        {
            _saveNeed = true;
            Save();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        #endregion
    }
}
