using clubApp.Views;
using System;
using System.Windows.Forms;

namespace clubApp
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
            Application.Run(MainView.Instance); // uso de la unica instancia admitida en el sistema.
        }
    }
}
