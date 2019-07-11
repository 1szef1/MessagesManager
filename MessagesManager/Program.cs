using DevExpress.XtraEditors;
using MessagesManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagesManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                MsgContext.CreateAndInitDb();
                Application.Run(new Forms.FrmMain());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Komunikaty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
