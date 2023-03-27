using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using CmlLib;

namespace UmutLauncher
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

            Thread main = new Thread(() =>
            {
                XmlDocument configxml = new XmlDocument();
                configxml.Load(@"../../XMLFile1.xml");
                XmlAttributeCollection config = configxml.SelectNodes("//*").Item(0).Attributes;

                    Application.Run(new Form1());
            });
            
            main.Start();
            
        }



    }

}
