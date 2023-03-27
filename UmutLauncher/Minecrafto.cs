using System;
using Microsoft.Win32;
using System.Xml;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmlLib;
using CmlLib.Core;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;
using CmlLib.Core.Installer;
using CmlLib.Core.Downloader;
using CmlLib.Core.Files;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace UmutLauncher
{
    public static class Minecrafto
    {
        public static string GetJavaInstallationPath()
        {
            String javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey))
            {
                String currentVersion = baseKey.GetValue("CurrentVersion").ToString();
                using (var homeKey = baseKey.OpenSubKey(currentVersion))
                    return homeKey.GetValue("JavaHome").ToString();
            }
        }

        public static void mcRun(string Version, string PlayerName, string javapath = null)
        {
            var session = MSession.GetOfflineSession(PlayerName);
            var MCPath = new MinecraftPath(@"mc/");


            var Launcher = new CMLauncher(MCPath);
            var McVersion = Launcher.GetVersion(Version);

            Launcher.FileChanged += (e) =>
            {
                Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
            };

            Launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
            };

            string[] JavaArgs = { "-XX:+UseConcMarkSweepGC", " -XX:+CMSIncrementalMode", "-XX:-UseAdaptiveSizePolicy", "-Xmn128M" };
            var Options = new MLaunchOption
            {
                FullScreen = false,
                MinimumRamMb = 1024,
                MaximumRamMb = 2048,
                ScreenHeight = 1080,
                ScreenWidth = 1920,
                JavaPath = @"C:\Program Files\Java\jre1.8.0_341\bin\javaw.exe",
                //JVMArguments = JavaArgs,
                ServerIp = "play.mavibugday.com",
                Session = session,
                Path = MCPath,
                StartVersion = McVersion
            };
            var inst = Launcher.CreateProcess(McVersion, Options, false);
            inst.Start();

            //Launcher.Launch(McVersion.Id, Options);
        }


        public static void mcInstall(string version)
        {
            var MCPath = new MinecraftPath(@"mc/");
            var Launcher = new CMLauncher(MCPath);
            Launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
            };
            var McVersion = Launcher.GetVersion(version);
            Launcher.CheckAndDownload(McVersion);
        }

    }
}
