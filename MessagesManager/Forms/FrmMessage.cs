using DevExpress.Images;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MessagesManager.Api.Interfaces;
using MessagesManager.Data.Model;
using MessagesManager.Data.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources = global::MessagesManager.Properties.Resources;

namespace MessagesManager.Forms
{
    public partial class FrmMessage : FrmBase
    {
        public static XtraForm Instance { get; protected set; }

        #region Pola

        protected MessageService _service;
        protected IApiMsg _message;
        protected bool _saveNeed;

        #endregion

        #region Właściwości

        public IApiMsg WndMessage => _message;

        #endregion

        #region Konstruktory i akcje formy

        public FrmMessage()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                this.FormClosed += new FormClosedEventHandler(this.FormIsClosed);
                this.Load += new EventHandler(this.FormIsLoad);
            }
        }

        private void FormIsLoad(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Initialize();
                Instance = this;
            }
        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        #endregion

        #region Dane

        protected virtual void Initialize()
        {
            _service = new MessageService();

            if (_message == null)
                _message = new WndMessage();

            InitControls();
        }

        protected void ChangeMessage(WndMessage msg)
        {
            if (msg != null)
            {
                _message = msg;
                InitControls();
            }
        }

        protected void ChangeMessage()
        {
            var frm = new FrmMessageList(Enums.FrmMode.Select);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _message = frm.SelectedMsg;
                InitControls();
            }
        }

        private void InitControls()
        {
            txtContent.EditValue = _message.Content;
            checkNeedConfirm.Checked = _message.NeedConfirm;
            spinDuration.EditValue = _message.Duration;

            GetResourceImage();
            SetFavoriteFlag();
        }

        protected void AssignData()
        {
            _message.Content = txtContent.EditValue.ToString();
            _message.NeedConfirm = checkNeedConfirm.Checked;
            _message.Duration = Convert.ToInt32(spinDuration.EditValue);
        }

        private void GetResourceImage()
        {
            if (!string.IsNullOrEmpty(_message.IconName))
            {
                var resource = ImageResourceCache.Default.GetImage(_message.IconName);
                AddCustomImage(resource, _message.IconName);
            }
            else
            {
                pictureIcon.Image = null;
                pictureIcon.Properties.ContextButtons.Clear();
            }
        }

        #endregion

        #region Zmiana danych

        private void SetFavoriteFlag()
        {
            var btn = txtContent.Properties.Buttons.FirstOrDefault(x => x.Kind == ButtonPredefines.Glyph);
            if (btn == null) return;

            if (_message.Favorite)
                btn.ImageOptions.Image = Resources.favorite_16;
            else
                btn.ImageOptions.Image = Resources.favorite_grey_16;
        }

        private void ChangeContent()
        {
            var frm = new FrmMessageContent(txtContent.Text);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtContent.Text = frm.Content;
            }
        }

        private void AddCustomImage(Image image, string imageName)
        {
            _message.IconName = imageName;
            pictureIcon.Image = image;

            pictureIcon.Properties.ContextButtons.Clear();
            ContextButton contextButton1 = new ContextButton();
            ContextButton contextButton2 = new ContextButton();

            contextButton1.ImageOptionsCollection.ItemNormal.Image = Resources.info_16;
            contextButton1.Name = "cbPictureInfo";
            contextButton1.ToolTip = imageName;
            contextButton2.AlignmentOptions.Position = ContextItemPosition.Far;
            contextButton2.ImageOptionsCollection.ItemNormal.Image = Resources.remove_16;
            contextButton2.Name = "cbPictureRemove";
            contextButton2.Click += ClearCustomImage;

            pictureIcon.Properties.ContextButtons.Add(contextButton1);
            pictureIcon.Properties.ContextButtons.Add(contextButton2);
            pictureIcon.Click -= PictureIcon_Click;
        }

        private void ClearCustomImage(object sender, ContextItemClickEventArgs e)
        {
            _message.IconName = null;
            pictureIcon.Image = null;
            pictureIcon.Properties.ContextButtons.Clear();
            pictureIcon.Click += PictureIcon_Click;
        }

        #endregion

        #region Walidacja

        public override bool ValidateData()
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                XtraMessageBox.Show("Należy uzupełnić treść komunikatu.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Przyciski specjalne

        private void TxtContent_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                if (bool.TryParse(e.Button.Tag.ToString(), out _))
                {
                    if (!_message.Favorite)
                    {
                        e.Button.ImageOptions.Image = Resources.favorite_16;
                        _message.Favorite = true;
                    }
                    else
                    {
                        e.Button.ImageOptions.Image = Resources.favorite_grey_16;
                        _message.Favorite = false;
                    }
                }
            }
            else if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                ChangeContent();
            }
            else if (e.Button.Kind == ButtonPredefines.Down)
            {
                ChangeMessage();
            }
        }

        private void TimeDuration_Properties_Spin(object sender, SpinEventArgs e)
        {
            if (!(sender is TimeEdit te)) return;

            te.Time = te.Time.AddSeconds((e.IsSpinUp) ? 1 : -1);
            e.Handled = true;
        }

        private void SpinDuration_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Clear)
                spinDuration.Value = 0;
        }

        private void PictureIcon_Click(object sender, EventArgs e)
        {
            var frm = new FrmIconsGallery();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var img = frm.SelectedImage;
                if (img != null)
                {
                    AddCustomImage(img, img.Tag.ToString());
                }
            }
        }

        #endregion
    }
}
