using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok_Szervíz
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // ELLENŐRZÉS CSAK EGYSZER!
            bool updateAvailable = AutoUpdater.CheckForUpdate();

            if (updateAvailable)
            {
                MessageBox.Show("Frissítés elérhető! A program most frissül.");
                AutoUpdater.PerformUpdate();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
