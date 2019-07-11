namespace MessagesManager.Forms
{
    partial class FrmMessageSender
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
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.lciSend = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSaveSend = new DevExpress.XtraEditors.SimpleButton();
            this.lciSendSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNeedConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnClose);
            this.layoutControl.Controls.Add(this.btnSaveSend);
            this.layoutControl.Controls.Add(this.btnSend);
            this.layoutControl.Controls.SetChildIndex(this.pictureIcon, 0);
            this.layoutControl.Controls.SetChildIndex(this.checkNeedConfirm, 0);
            this.layoutControl.Controls.SetChildIndex(this.txtContent, 0);
            this.layoutControl.Controls.SetChildIndex(this.spinDuration, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnSend, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnSaveSend, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // lcgRoot
            // 
            this.lcgRoot.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.lcgRoot.AppearanceGroup.BackColor2 = System.Drawing.Color.BlanchedAlmond;
            this.lcgRoot.AppearanceGroup.BorderColor = System.Drawing.Color.Black;
            this.lcgRoot.AppearanceGroup.Options.UseBackColor = true;
            this.lcgRoot.AppearanceGroup.Options.UseBorderColor = true;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSend,
            this.lciSendSave,
            this.lciCancel});
            // 
            // pictureIcon
            // 
            this.pictureIcon.Properties.ContextButtonOptions.TopPanelColor = System.Drawing.Color.WhiteSmoke;
            // 
            // checkNeedConfirm
            // 
            this.checkNeedConfirm.Size = new System.Drawing.Size(250, 19);
            // 
            // txtContent
            // 
            // 
            // spinDuration
            // 
            this.spinDuration.Location = new System.Drawing.Point(372, 125);
            this.spinDuration.Properties.Mask.EditMask = "F0";
            this.spinDuration.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinDuration.Size = new System.Drawing.Size(81, 20);
            // 
            // btnSend
            // 
            this.btnSend.ImageOptions.Image = global::MessagesManager.Properties.Resources.save_16;
            this.btnSend.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSend.Location = new System.Drawing.Point(7, 195);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(154, 22);
            this.btnSend.StyleController = this.layoutControl;
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Wyślij";
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lciSend
            // 
            this.lciSend.Control = this.btnSend;
            this.lciSend.Location = new System.Drawing.Point(0, 188);
            this.lciSend.Name = "lciSend";
            this.lciSend.Size = new System.Drawing.Size(158, 26);
            this.lciSend.TextSize = new System.Drawing.Size(0, 0);
            this.lciSend.TextVisible = false;
            // 
            // btnSaveSend
            // 
            this.btnSaveSend.ImageOptions.Image = global::MessagesManager.Properties.Resources.save_16;
            this.btnSaveSend.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveSend.Location = new System.Drawing.Point(165, 195);
            this.btnSaveSend.Name = "btnSaveSend";
            this.btnSaveSend.Size = new System.Drawing.Size(151, 22);
            this.btnSaveSend.StyleController = this.layoutControl;
            this.btnSaveSend.TabIndex = 16;
            this.btnSaveSend.Text = "Zapisz i wyślij";
            this.btnSaveSend.Click += new System.EventHandler(this.BtnSaveSend_Click);
            // 
            // lciSendSave
            // 
            this.lciSendSave.Control = this.btnSaveSend;
            this.lciSendSave.Location = new System.Drawing.Point(158, 188);
            this.lciSendSave.Name = "lciSendSave";
            this.lciSendSave.Size = new System.Drawing.Size(155, 26);
            this.lciSendSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSendSave.TextVisible = false;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::MessagesManager.Properties.Resources.cancel_16;
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnClose.Location = new System.Drawing.Point(320, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 22);
            this.btnClose.StyleController = this.layoutControl;
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Zamknij";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnClose;
            this.lciCancel.Location = new System.Drawing.Point(313, 188);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(154, 26);
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // FrmMessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 224);
            this.Name = "FrmMessageSender";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNeedConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDuration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSaveSend;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraLayout.LayoutControlItem lciSend;
        private DevExpress.XtraLayout.LayoutControlItem lciSendSave;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
    }
}