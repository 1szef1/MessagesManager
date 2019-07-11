using System;

namespace MessagesManager.Forms
{
    public partial class FrmMessageContent : FrmBase
    {
        public string Content { get; private set; }

        protected FrmMessageContent()
        {
            InitializeComponent();
        }

        public FrmMessageContent(string content)
            : this()
        {
            memoContent.Text = content;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Content = memoContent.Text;
            base.Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            base.Cancel();
        }
    }
}
