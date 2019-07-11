namespace MessagesManager.Forms
{
    partial class FrmMessageEdit
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnCancel);
            this.layoutControl.Controls.Add(this.simpleButton2);
            this.layoutControl.Controls.SetChildIndex(this.simpleButton2, 0);
            this.layoutControl.Controls.SetChildIndex(this.btnCancel, 0);
            // 
            // lcgRoot
            // 
            this.lcgRoot.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.lcgRoot.AppearanceGroup.BackColor2 = System.Drawing.Color.BlanchedAlmond;
            this.lcgRoot.AppearanceGroup.BorderColor = System.Drawing.Color.Black;
            this.lcgRoot.AppearanceGroup.Options.UseBackColor = true;
            this.lcgRoot.AppearanceGroup.Options.UseBorderColor = true;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSave,
            this.lciCancel});
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::MessagesManager.Properties.Resources.save_16;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(7, 195);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(229, 22);
            this.simpleButton2.StyleController = this.layoutControl;
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Zapisz";
            this.simpleButton2.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lciSave
            // 
            this.lciSave.Control = this.simpleButton2;
            this.lciSave.Location = new System.Drawing.Point(0, 188);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(233, 26);
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::MessagesManager.Properties.Resources.cancel_16;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(240, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 22);
            this.btnCancel.StyleController = this.layoutControl;
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.Location = new System.Drawing.Point(233, 188);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(234, 26);
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // FrmMessageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 224);
            this.Name = "FrmMessageEdit";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
    }
}