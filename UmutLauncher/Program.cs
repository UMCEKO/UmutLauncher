using System;
using System.Reflection;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace UmutLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] needsInstalling)
        {
            if (LauncherData.HasInternetConnection)
            {
                Console.WriteLine("has internet");

            }
            else
            {
                Console.WriteLine("doesnt have internet");
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }
    }



}
