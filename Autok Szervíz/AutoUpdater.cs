using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok_Szervíz
{
    public class AutoUpdater
    {
        private static string updateServerPath = @"\\192.168.0.16\AutokSzervizUpdate";
        private static string localAppPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string versionFileName = "version.txt";
        private static string exeName = "Autok Szerviz.exe";

        public static bool CheckForUpdate()
        {
            try
            {
                string serverVersionPath = Path.Combine(updateServerPath, versionFileName);
                string localVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                if (!File.Exists(serverVersionPath))
                    return false;

                string serverVersion = File.ReadAllText(serverVersionPath).Trim();

                return serverVersion != localVersion;
            }
            catch
            {
                return false;
            }
        }

        public static void PerformUpdate()
        {
            try
            {
                string serverExe = Path.Combine(updateServerPath, exeName);
                string localExe = Path.Combine(localAppPath, exeName);

                if (File.Exists(serverExe))
                {
                    File.Copy(serverExe, localExe, true);
                    MessageBox.Show("Frissítés sikeres! A program újraindul.");
                    Process.Start(localExe);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Frissítés sikertelen: " + ex.Message);
            }
        }
    }
}
