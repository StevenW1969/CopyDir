using System;
using System.Windows.Forms;

namespace CopyDir
{

    static class Program
    {        
       public static FrmMain_Treeview frmMain_Treeview;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmMain_Treeview = new FrmMain_Treeview());
        }
    }
}
