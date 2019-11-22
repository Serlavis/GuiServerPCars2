using System;
using System.Windows.Forms;
using System.Threading;

namespace GuiServerPCars2V2._0
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(true, "Mon_Mutex_Pour_Mon_Application", out bool owned);
            if (owned)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
                MessageBox.Show("L'application est déjà lancée");
            
        }
    }
}
