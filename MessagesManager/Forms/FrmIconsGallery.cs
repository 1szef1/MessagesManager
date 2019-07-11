using DevExpress.Images;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace MessagesManager.Forms
{
    public partial class FrmIconsGallery : FrmBase
    {
        #region Właściwości

        public Image SelectedImage { get; private set; }

        #endregion

        #region Konstruktory i akcje formy 

        public FrmIconsGallery()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormIsLoad);
        }


        private void FormIsLoad(object sender, EventArgs e)
        {
            layoutControl.BeginUpdate();
            LoadImages();
            layoutControl.EndUpdate();
        }

        #endregion

        #region Dane

        private void LoadImages()
        {
            var group = galleryControl.Gallery.Groups.FirstOrDefault();
            if (group == null) return;

            galleryControl.Gallery.BeginUpdate();

            var resources = ImageResourceCache.Default.GetAllResourceKeys();
            var imageCollection = resources.Where(x => x.EndsWith(".png") && x.Contains("32x32"));

            foreach (var img in imageCollection)
                group.Items.Add(new GalleryItem(ImageResourceCache.Default.GetImage(img), img, img));
                
            galleryControl.Gallery.EndUpdate();
        }

        #endregion

        #region Wybór elementu

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            var group = galleryControl.Gallery.Groups.FirstOrDefault();
            if (group == null) return;

            Choose(group.GetCheckedItems().FirstOrDefault());
        }

        private void GalleryControl_Gallery_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            Choose(e.Item);
        }

        private void Choose(GalleryItem item)
        {
            if (item != null)
            {
                SelectedImage = item.Image;
                SelectedImage.Tag = item.Caption;

                Save();
            }
        }

        #endregion
    }
}
