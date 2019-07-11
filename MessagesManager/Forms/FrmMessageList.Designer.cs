namespace MessagesManager.Forms
{
    partial class FrmMessageList
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnWybierz = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridMsg = new DevExpress.XtraGrid.GridControl();
            this.viewMsg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFavorite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conIconName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeddConfirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMsg = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChoose = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnWybierz);
            this.layoutControl.Controls.Add(this.btnEdit);
            this.layoutControl.Controls.Add(this.btnRemove);
            this.layoutControl.Controls.Add(this.btnAdd);
            this.layoutControl.Controls.Add(this.gridMsg);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.lcgRoot;
            this.layoutControl.Size = new System.Drawing.Size(630, 289);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btnWybierz
            // 
            this.btnWybierz.ImageOptions.Image = global::MessagesManager.Properties.Resources.apply_16;
            this.btnWybierz.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnWybierz.Location = new System.Drawing.Point(7, 260);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(616, 22);
            this.btnWybierz.StyleController = this.layoutControl;
            this.btnWybierz.TabIndex = 9;
            this.btnWybierz.Text = "Wybierz";
            this.btnWybierz.Click += new System.EventHandler(this.BtnWybierz_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = global::MessagesManager.Properties.Resources.edit_16;
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.Location = new System.Drawing.Point(212, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(207, 22);
            this.btnEdit.StyleController = this.layoutControl;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ImageOptions.Image = global::MessagesManager.Properties.Resources.remove_16;
            this.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRemove.Location = new System.Drawing.Point(423, 234);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 22);
            this.btnRemove.StyleController = this.layoutControl;
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::MessagesManager.Properties.Resources.add_16;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.Location = new System.Drawing.Point(7, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 22);
            this.btnAdd.StyleController = this.layoutControl;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gridMsg
            // 
            this.gridMsg.Location = new System.Drawing.Point(7, 7);
            this.gridMsg.MainView = this.viewMsg;
            this.gridMsg.Name = "gridMsg";
            this.gridMsg.Size = new System.Drawing.Size(616, 223);
            this.gridMsg.TabIndex = 4;
            this.gridMsg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewMsg});
            // 
            // viewMsg
            // 
            this.viewMsg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colContent,
            this.colFavorite,
            this.conIconName,
            this.colNeddConfirm,
            this.colDuration});
            this.viewMsg.GridControl = this.gridMsg;
            this.viewMsg.Name = "viewMsg";
            this.viewMsg.OptionsBehavior.Editable = false;
            this.viewMsg.OptionsBehavior.ReadOnly = true;
            this.viewMsg.OptionsMenu.ShowConditionalFormattingItem = true;
            this.viewMsg.OptionsView.ShowAutoFilterRow = true;
            this.viewMsg.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.ViewMsg_RowCellClick);
            this.viewMsg.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewMsg_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colContent
            // 
            this.colContent.Caption = "Treść";
            this.colContent.FieldName = "Content";
            this.colContent.Name = "colContent";
            this.colContent.Visible = true;
            this.colContent.VisibleIndex = 1;
            // 
            // colFavorite
            // 
            this.colFavorite.Caption = "Ulubiony";
            this.colFavorite.FieldName = "Favorite";
            this.colFavorite.Name = "colFavorite";
            this.colFavorite.Visible = true;
            this.colFavorite.VisibleIndex = 2;
            // 
            // conIconName
            // 
            this.conIconName.Caption = "Nazwa ikony";
            this.conIconName.FieldName = "IconName";
            this.conIconName.Name = "conIconName";
            this.conIconName.Visible = true;
            this.conIconName.VisibleIndex = 3;
            // 
            // colNeddConfirm
            // 
            this.colNeddConfirm.Caption = "Wymaga potwierdzenia";
            this.colNeddConfirm.FieldName = "NeedConfirm";
            this.colNeddConfirm.Name = "colNeddConfirm";
            this.colNeddConfirm.Visible = true;
            this.colNeddConfirm.VisibleIndex = 4;
            // 
            // colDuration
            // 
            this.colDuration.Caption = "Czas trwania";
            this.colDuration.FieldName = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.Visible = true;
            this.colDuration.VisibleIndex = 5;
            // 
            // lcgRoot
            // 
            this.lcgRoot.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.lcgRoot.AppearanceGroup.BackColor2 = System.Drawing.Color.BlanchedAlmond;
            this.lcgRoot.AppearanceGroup.Options.UseBackColor = true;
            this.lcgRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMsg,
            this.lciAdd,
            this.lciRemove,
            this.lciEdit,
            this.lciChoose});
            this.lcgRoot.Name = "lcgRoot";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgRoot.Size = new System.Drawing.Size(630, 289);
            this.lcgRoot.TextVisible = false;
            // 
            // lciMsg
            // 
            this.lciMsg.Control = this.gridMsg;
            this.lciMsg.Location = new System.Drawing.Point(0, 0);
            this.lciMsg.Name = "lciMsg";
            this.lciMsg.Size = new System.Drawing.Size(620, 227);
            this.lciMsg.TextSize = new System.Drawing.Size(0, 0);
            this.lciMsg.TextVisible = false;
            // 
            // lciAdd
            // 
            this.lciAdd.Control = this.btnAdd;
            this.lciAdd.Location = new System.Drawing.Point(0, 227);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(205, 26);
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // lciRemove
            // 
            this.lciRemove.Control = this.btnRemove;
            this.lciRemove.Location = new System.Drawing.Point(416, 227);
            this.lciRemove.Name = "lciRemove";
            this.lciRemove.Size = new System.Drawing.Size(204, 26);
            this.lciRemove.TextSize = new System.Drawing.Size(0, 0);
            this.lciRemove.TextVisible = false;
            // 
            // lciEdit
            // 
            this.lciEdit.Control = this.btnEdit;
            this.lciEdit.Location = new System.Drawing.Point(205, 227);
            this.lciEdit.Name = "lciEdit";
            this.lciEdit.Size = new System.Drawing.Size(211, 26);
            this.lciEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciEdit.TextVisible = false;
            // 
            // lciChoose
            // 
            this.lciChoose.Control = this.btnWybierz;
            this.lciChoose.Location = new System.Drawing.Point(0, 253);
            this.lciChoose.Name = "lciChoose";
            this.lciChoose.Size = new System.Drawing.Size(620, 26);
            this.lciChoose.TextSize = new System.Drawing.Size(0, 0);
            this.lciChoose.TextVisible = false;
            // 
            // FrmMessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 289);
            this.Controls.Add(this.layoutControl);
            this.Name = "FrmMessageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista komunikatów";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChoose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraGrid.GridControl gridMsg;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMsg;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colContent;
        private DevExpress.XtraGrid.Columns.GridColumn colFavorite;
        private DevExpress.XtraGrid.Columns.GridColumn conIconName;
        private DevExpress.XtraLayout.LayoutControlItem lciMsg;
        private DevExpress.XtraGrid.Columns.GridColumn colNeddConfirm;
        private DevExpress.XtraGrid.Columns.GridColumn colDuration;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
        private DevExpress.XtraLayout.LayoutControlItem lciRemove;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
        private DevExpress.XtraEditors.SimpleButton btnWybierz;
        private DevExpress.XtraLayout.LayoutControlItem lciChoose;
    }
}