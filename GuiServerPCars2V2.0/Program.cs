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
            using (var mutex = new Mutex(true, "MY_Mutex_For_My_App", out bool owned))
            {
                if (owned)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    MessageBox.Show("L'application est déjà lancée");
                    return;

                }
            }



        }
    }
}
