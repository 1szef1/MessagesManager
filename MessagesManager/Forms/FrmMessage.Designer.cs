namespace MessagesManager.Forms
{
    partial class FrmMessage
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblLogo = new DevExpress.XtraEditors.LabelControl();
            this.spinDuration = new DevExpress.XtraEditors.SpinEdit();
            this.txtContent = new DevExpress.XtraEditors.ButtonEdit();
            this.checkNeedConfirm = new DevExpress.XtraEditors.CheckEdit();
            this.pictureIcon = new DevExpress.XtraEditors.PictureEdit();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptyItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptyItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciIcon = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNeedConfirm = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptyItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDuration = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLogo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNeedConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNeedConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblLogo);
            this.layoutControl.Controls.Add(this.spinDuration);
            this.layoutControl.Controls.Add(this.txtContent);
            this.layoutControl.Controls.Add(this.checkNeedConfirm);
            this.layoutControl.Controls.Add(this.pictureIcon);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.lcgRoot;
            this.layoutControl.Size = new System.Drawing.Size(477, 224);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // lblLogo
            // 
            this.lblLogo.Appearance.BackColor = System.Drawing.Color.White;
            this.lblLogo.Appearance.BackColor2 = System.Drawing.Color.PeachPuff;
            this.lblLogo.Appearance.Options.UseBackColor = true;
            this.lblLogo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLogo.Location = new System.Drawing.Point(24, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(353, 72);
            this.lblLogo.StyleController = this.layoutControl;
            this.lblLogo.TabIndex = 14;
            // 
            // spinDuration
            // 
            this.spinDuration.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDuration.Location = new System.Drawing.Point(365, 125);
            this.spinDuration.Name = "spinDuration";
            this.spinDuration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.spinDuration.Properties.Mask.EditMask = "F0";
            this.spinDuration.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinDuration.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinDuration.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SpinDuration_ButtonClick);
            this.spinDuration.Size = new System.Drawing.Size(88, 20);
            this.spinDuration.StyleController = this.layoutControl;
            this.spinDuration.TabIndex = 13;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(24, 99);
            this.txtContent.Name = "txtContent";
            editorButtonImageOptions1.Image = global::MessagesManager.Properties.Resources.favorite_grey_16;
            this.txtContent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Ulubiony", false, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Wybór z listy", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtContent.Size = new System.Drawing.Size(429, 22);
            this.txtContent.StyleController = this.layoutControl;
            this.txtContent.TabIndex = 12;
            this.txtContent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtContent_ButtonClick);
            // 
            // checkNeedConfirm
            // 
            this.checkNeedConfirm.Location = new System.Drawing.Point(24, 125);
            this.checkNeedConfirm.Name = "checkNeedConfirm";
            this.checkNeedConfirm.Properties.Caption = "Wymaga potwierdzenia";
            this.checkNeedConfirm.Size = new System.Drawing.Size(243, 19);
            this.checkNeedConfirm.StyleController = this.layoutControl;
            this.checkNeedConfirm.TabIndex = 9;
            // 
            // pictureIcon
            // 
            this.pictureIcon.Location = new System.Drawing.Point(381, 7);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Properties.ContextButtonOptions.TopPanelColor = System.Drawing.Color.WhiteSmoke;
            this.pictureIcon.Properties.NullText = "Kliknij aby\nwybrać ikonę";
            this.pictureIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureIcon.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.True;
            this.pictureIcon.Size = new System.Drawing.Size(72, 72);
            this.pictureIcon.StyleController = this.layoutControl;
            this.pictureIcon.TabIndex = 7;
            this.pictureIcon.Click += new System.EventHandler(this.PictureIcon_Click);
            // 
            // lcgRoot
            // 
            this.lcgRoot.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.lcgRoot.AppearanceGroup.BackColor2 = System.Drawing.Color.BlanchedAlmond;
            this.lcgRoot.AppearanceGroup.BorderColor = System.Drawing.Color.Black;
            this.lcgRoot.AppearanceGroup.Options.UseBackColor = true;
            this.lcgRoot.AppearanceGroup.Options.UseBorderColor = true;
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptyItem1,
            this.emptyItem4,
            this.lciIcon,
            this.lciNeedConfirm,
            this.emptyItem2,
            this.lciContent,
            this.lciDuration,
            this.lciLogo});
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgRoot.Size = new System.Drawing.Size(477, 224);
            this.lcgRoot.TextVisible = false;
            // 
            // emptyItem1
            // 
            this.emptyItem1.AllowHotTrack = false;
            this.emptyItem1.Location = new System.Drawing.Point(0, 0);
            this.emptyItem1.MaxSize = new System.Drawing.Size(17, 0);
            this.emptyItem1.MinSize = new System.Drawing.Size(17, 10);
            this.emptyItem1.Name = "emptyItem1";
            this.emptyItem1.Size = new System.Drawing.Size(17, 214);
            this.emptyItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptyItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptyItem4
            // 
            this.emptyItem4.AllowHotTrack = false;
            this.emptyItem4.Location = new System.Drawing.Point(450, 0);
            this.emptyItem4.MaxSize = new System.Drawing.Size(17, 0);
            this.emptyItem4.MinSize = new System.Drawing.Size(17, 10);
            this.emptyItem4.Name = "emptyItem4";
            this.emptyItem4.Size = new System.Drawing.Size(17, 214);
            this.emptyItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptyItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciIcon
            // 
            this.lciIcon.Control = this.pictureIcon;
            this.lciIcon.Location = new System.Drawing.Point(374, 0);
            this.lciIcon.MaxSize = new System.Drawing.Size(76, 76);
            this.lciIcon.MinSize = new System.Drawing.Size(76, 76);
            this.lciIcon.Name = "lciIcon";
            this.lciIcon.Size = new System.Drawing.Size(76, 76);
            this.lciIcon.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciIcon.TextSize = new System.Drawing.Size(0, 0);
            this.lciIcon.TextVisible = false;
            // 
            // lciNeedConfirm
            // 
            this.lciNeedConfirm.Control = this.checkNeedConfirm;
            this.lciNeedConfirm.Location = new System.Drawing.Point(17, 118);
            this.lciNeedConfirm.Name = "lciNeedConfirm";
            this.lciNeedConfirm.Size = new System.Drawing.Size(247, 24);
            this.lciNeedConfirm.TextSize = new System.Drawing.Size(0, 0);
            this.lciNeedConfirm.TextVisible = false;
            // 
            // emptyItem2
            // 
            this.emptyItem2.AllowHotTrack = false;
            this.emptyItem2.Location = new System.Drawing.Point(17, 142);
            this.emptyItem2.Name = "emptyItem2";
            this.emptyItem2.Size = new System.Drawing.Size(433, 72);
            this.emptyItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciContent
            // 
            this.lciContent.Control = this.txtContent;
            this.lciContent.Location = new System.Drawing.Point(17, 76);
            this.lciContent.Name = "lciContent";
            this.lciContent.Size = new System.Drawing.Size(433, 42);
            this.lciContent.Text = "Treść komunikatu";
            this.lciContent.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciContent.TextSize = new System.Drawing.Size(83, 13);
            // 
            // lciDuration
            // 
            this.lciDuration.Control = this.spinDuration;
            this.lciDuration.Location = new System.Drawing.Point(264, 118);
            this.lciDuration.Name = "lciDuration";
            this.lciDuration.Size = new System.Drawing.Size(186, 24);
            this.lciDuration.Text = "Czas trwania (sek)";
            this.lciDuration.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDuration.TextSize = new System.Drawing.Size(89, 13);
            this.lciDuration.TextToControlDistance = 5;
            // 
            // lciLogo
            // 
            this.lciLogo.Control = this.lblLogo;
            this.lciLogo.Location = new System.Drawing.Point(17, 0);
            this.lciLogo.MaxSize = new System.Drawing.Size(0, 76);
            this.lciLogo.MinSize = new System.Drawing.Size(14, 76);
            this.lciLogo.Name = "lciLogo";
            this.lciLogo.Size = new System.Drawing.Size(357, 76);
            this.lciLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLogo.TextSize = new System.Drawing.Size(0, 0);
            this.lciLogo.TextVisible = false;
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 224);
            this.Controls.Add(this.layoutControl);
            this.MaximizeBox = false;
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunikat";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNeedConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNeedConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.EmptySpaceItem emptyItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciIcon;
        private DevExpress.XtraLayout.EmptySpaceItem emptyItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptyItem4;
        private DevExpress.XtraLayout.LayoutControlItem lciNeedConfirm;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
        private DevExpress.XtraLayout.LayoutControlItem lciDuration;
        private DevExpress.XtraLayout.LayoutControlItem lciLogo;
        protected DevExpress.XtraLayout.LayoutControl layoutControl;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraEditors.LabelControl lblLogo;
        protected DevExpress.XtraEditors.PictureEdit pictureIcon;
        protected DevExpress.XtraEditors.CheckEdit checkNeedConfirm;
        protected DevExpress.XtraEditors.ButtonEdit txtContent;
        protected DevExpress.XtraEditors.SpinEdit spinDuration;
    }
}