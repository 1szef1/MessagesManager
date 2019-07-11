namespace MessagesManager.Forms
{
    partial class FrmIconsGallery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.galleryControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGallery = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChoose = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).BeginInit();
            this.galleryControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnChoose);
            this.layoutControl.Controls.Add(this.galleryControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.lcgRoot;
            this.layoutControl.Size = new System.Drawing.Size(493, 264);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoose.ImageOptions.Image = global::MessagesManager.Properties.Resources.apply_16;
            this.btnChoose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChoose.Location = new System.Drawing.Point(7, 226);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(479, 31);
            this.btnChoose.StyleController = this.layoutControl;
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Wybierz";
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // galleryControl
            // 
            this.galleryControl.Controls.Add(this.galleryControlClient1);
            // 
            // 
            // 
            this.galleryControl.Gallery.CheckSelectedItemViaKeyboard = true;
            this.galleryControl.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryControl.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            this.galleryControl.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.GalleryControl_Gallery_ItemDoubleClick);
            this.galleryControl.Location = new System.Drawing.Point(7, 7);
            this.galleryControl.Name = "galleryControl";
            this.galleryControl.Size = new System.Drawing.Size(479, 215);
            this.galleryControl.StyleController = this.layoutControl;
            this.galleryControl.TabIndex = 4;
            this.galleryControl.Text = "galleryControl";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(458, 211);
            // 
            // lcgRoot
            // 
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGallery,
            this.lciChoose});
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgRoot.Size = new System.Drawing.Size(493, 264);
            this.lcgRoot.TextVisible = false;
            // 
            // lciGallery
            // 
            this.lciGallery.Control = this.galleryControl;
            this.lciGallery.Location = new System.Drawing.Point(0, 0);
            this.lciGallery.Name = "lciGallery";
            this.lciGallery.Size = new System.Drawing.Size(483, 219);
            this.lciGallery.TextSize = new System.Drawing.Size(0, 0);
            this.lciGallery.TextVisible = false;
            // 
            // lciChoose
            // 
            this.lciChoose.Control = this.btnChoose;
            this.lciChoose.Location = new System.Drawing.Point(0, 219);
            this.lciChoose.MaxSize = new System.Drawing.Size(0, 35);
            this.lciChoose.MinSize = new System.Drawing.Size(52, 35);
            this.lciChoose.Name = "lciChoose";
            this.lciChoose.Size = new System.Drawing.Size(483, 35);
            this.lciChoose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciChoose.TextSize = new System.Drawing.Size(0, 0);
            this.lciChoose.TextVisible = false;
            // 
            // FrmIconsGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 264);
            this.Controls.Add(this.layoutControl);
            this.Name = "FrmIconsGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria ikon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).EndInit();
            this.galleryControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChoose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl;
        private DevExpress.XtraLayout.LayoutControlItem lciGallery;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraLayout.LayoutControlItem lciChoose;
    }
}