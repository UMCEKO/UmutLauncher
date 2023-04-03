using System;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;

namespace Updater
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string zipDir = args[0];
                string zipLoc = zipDir + @"\launcher.zip";
                string tempDir = args[1];
                string link = args[2];
                Console.WriteLine("a");
                Directory.CreateDirectory(tempDir);
                Directory.CreateDirectory(zipDir);
                using (var client = new WebClient())
                {
                    client.DownloadFile(link, zipLoc);
                }
                Console.WriteLine("a");
                var kek = new FastZip();
                kek.ExtractZip(zipLoc, tempDir, null);
                Console.WriteLine("a");
                FileSystem.CopyDirectory(tempDir, Directory.GetCurrentDirectory(), true);
                Console.WriteLine("a");
                Directory.Delete(zipDir,true);
                Directory.Delete(tempDir,true);
                Console.WriteLine("a");
                var updater = new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\UmutLauncher.exe");
                Process.Start(updater);
            }
        }


    }
}
