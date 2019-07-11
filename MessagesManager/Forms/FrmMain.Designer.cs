namespace MessagesManager.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnMsgManager = new DevExpress.XtraEditors.SimpleButton();
            this.btnMsgSender = new DevExpress.XtraEditors.SimpleButton();
            this.lciMsgSender = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMsgManager = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsgSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsgManager)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnMsgManager);
            this.layoutControl.Controls.Add(this.btnMsgSender);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.lcgRoot;
            this.layoutControl.Size = new System.Drawing.Size(370, 148);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lcgRoot
            // 
            this.lcgRoot.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.lcgRoot.AppearanceGroup.BackColor2 = System.Drawing.Color.BlanchedAlmond;
            this.lcgRoot.AppearanceGroup.Options.UseBackColor = true;
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMsgSender,
            this.lciMsgManager});
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Size = new System.Drawing.Size(370, 148);
            this.lcgRoot.TextVisible = false;
            // 
            // btnMsgManager
            // 
            this.btnMsgManager.Appearance.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMsgManager.Appearance.Options.UseFont = true;
            this.btnMsgManager.Appearance.Options.UseTextOptions = true;
            this.btnMsgManager.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnMsgManager.ImageOptions.Image = global::MessagesManager.Properties.Resources.settings_32;
            this.btnMsgManager.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMsgManager.Location = new System.Drawing.Point(187, 12);
            this.btnMsgManager.Name = "btnMsgManager";
            this.btnMsgManager.Size = new System.Drawing.Size(171, 124);
            this.btnMsgManager.StyleController = this.layoutControl;
            this.btnMsgManager.TabIndex = 1;
            this.btnMsgManager.Text = "Zarządzanie komunikatami";
            this.btnMsgManager.Click += new System.EventHandler(this.BtnMsgManager_Click);
            // 
            // btnMsgSender
            // 
            this.btnMsgSender.Appearance.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMsgSender.Appearance.Options.UseFont = true;
            this.btnMsgSender.Appearance.Options.UseTextOptions = true;
            this.btnMsgSender.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnMsgSender.ImageOptions.Image = global::MessagesManager.Properties.Resources.envelopes_32;
            this.btnMsgSender.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMsgSender.Location = new System.Drawing.Point(12, 12);
            this.btnMsgSender.Name = "btnMsgSender";
            this.btnMsgSender.Size = new System.Drawing.Size(171, 124);
            this.btnMsgSender.StyleController = this.layoutControl;
            this.btnMsgSender.TabIndex = 0;
            this.btnMsgSender.Text = "Wysyłka komunikatów";
            this.btnMsgSender.Click += new System.EventHandler(this.BtnMsgSender_Click);
            // 
            // lciMsgSender
            // 
            this.lciMsgSender.Control = this.btnMsgSender;
            this.lciMsgSender.Location = new System.Drawing.Point(0, 0);
            this.lciMsgSender.MaxSize = new System.Drawing.Size(0, 128);
            this.lciMsgSender.MinSize = new System.Drawing.Size(80, 128);
            this.lciMsgSender.Name = "lciMsgSender";
            this.lciMsgSender.Size = new System.Drawing.Size(175, 128);
            this.lciMsgSender.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMsgSender.TextSize = new System.Drawing.Size(0, 0);
            this.lciMsgSender.TextVisible = false;
            // 
            // lciMsgManager
            // 
            this.lciMsgManager.Control = this.btnMsgManager;
            this.lciMsgManager.Location = new System.Drawing.Point(175, 0);
            this.lciMsgManager.MaxSize = new System.Drawing.Size(0, 128);
            this.lciMsgManager.MinSize = new System.Drawing.Size(80, 128);
            this.lciMsgManager.Name = "lciMsgManager";
            this.lciMsgManager.Size = new System.Drawing.Size(175, 128);
            this.lciMsgManager.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMsgManager.TextSize = new System.Drawing.Size(0, 0);
            this.lciMsgManager.TextVisible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 148);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie komunikatami";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsgSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsgManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraEditors.SimpleButton btnMsgManager;
        private DevExpress.XtraEditors.SimpleButton btnMsgSender;
        private DevExpress.XtraLayout.LayoutControlItem lciMsgSender;
        private DevExpress.XtraLayout.LayoutControlItem lciMsgManager;
    }
}

