using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitDatabase initDatabase = new InitDatabase();
            initDatabase.init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.Run(new frmLogin());
        }
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            FirstRunChecker.RemoveFirstRunFlag();
        }
    }
}
