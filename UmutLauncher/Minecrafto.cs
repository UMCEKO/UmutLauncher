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
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib;


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

        public static void mcRun(LaunchInformation InfoL, XmlAttributeCollection attrList, Form1 form)
        {
            Console.WriteLine(attrList.Item(0).Value);
            var session = MSession.GetOfflineSession(attrList.Item(0).Value);
            var MCPath = new MinecraftPath(@"instances/" + InfoL.selectedProfile + "/");
            var Launcher = new CMLauncher(MCPath);
            MVersion McVersion;
            if (InfoL.isForge)
            {
                McVersion = Launcher.GetVersion(InfoL.forgeVersion);
            }
            else
            {
                McVersion = Launcher.GetVersion(InfoL.mcVersion);
            }
            Launcher.FileChanged += (e) =>
            {
                Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
            };

            Launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
                form.Invoke(new Action(() => form.UpdateProgressBar(e.ProgressPercentage)));
            };
            Console.WriteLine(attrList.Item(3).Value);



            var Options = new MLaunchOption
            {
                FullScreen = false,
                MinimumRamMb = Int32.Parse(attrList.Item(2).Value),
                MaximumRamMb = Int32.Parse(attrList.Item(1).Value),
                ScreenHeight = 1080,
                ScreenWidth = 1920,
                JavaPath = attrList.Item(3).Value,
                ServerIp = InfoL.serverIP,
                Session = session,
                Path = MCPath,
                StartVersion = McVersion
            };

            if (isValidJVM(attrList.Item(4).Value))
            {
                string[] JVMParsed = parseJVM(attrList.Item(4).Value);
                Options.JVMArguments = JVMParsed;
                for (int i = 0; Options.JVMArguments.Length > i; i++)
                {
                    Console.WriteLine(JVMParsed[i]);
                }
            }

            
            var inst = Launcher.CreateProcess(McVersion, Options, false);
            
            inst.Start();

            //Launcher.Launch(McVersion.Id, Options);
        }


        public async static void mcInstall(LaunchInformation InfoL , Form1 passedForm)
        {

                var MCPath = new MinecraftPath(@"instances/" + InfoL.selectedProfile + "/");
                var Launcher = new CMLauncher(MCPath);
                Launcher.FileChanged += (e) =>
                {
                    Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
                    passedForm.Invoke(new Action(() => passedForm.UpdateLabel("[" + e.FileKind.ToString() + "] %" + ((e.ProgressedFileCount * 100) / e.TotalFileCount) + " Şuan indirilen dosya:" + e.FileName)));
                };
                Launcher.ProgressChanged += (s, e) =>
                {
                    Form1 myForm = new Form1();
                    passedForm.Invoke(new Action(() => passedForm.UpdateProgressBar(e.ProgressPercentage)));
                };
                var McVersion = Launcher.GetVersion(InfoL.mcVersion);
                Launcher.CheckAndDownload(McVersion);

            if (InfoL.isForge)
            {
                passedForm.Invoke(new Action(() => passedForm.UpdateLabel("[Forge] Forge Alınıyor")));
                await Task.Run(() =>
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                        {
                            passedForm.Invoke(new Action(() => passedForm.UpdateProgressBar(e.ProgressPercentage)));
                        };
                        wc.DownloadFile(new System.Uri(InfoL.forgeLink), @"instances/forgeraw.zip");
                    };
                });
                string TempDir = @"instances/temp/unzippedforge";
                string ZipDir = @"instances/zips/forge.zip";
                string DestDir = @"instances/KnightCraft";
                Directory.CreateDirectory(TempDir + "/..");
                Directory.CreateDirectory(ZipDir + "/..");
                var fastZip = new FastZip
                {
                    CreateEmptyDirectories = true
                };
                fastZip.ExtractZip(ZipDir,TempDir,null);
                File.Delete(ZipDir);

                MoveDirectory(TempDir, DestDir);
                if (InfoL.isModsExternal)
                {
                    TempDir = @"instances/temp/unzippedmods";
                    ZipDir = @"instances/zips/mods.zip";
                    passedForm.Invoke(new Action(() => passedForm.UpdateLabel("[Modlar] Modlar Alınıyor")));
                    await Task.Run(() =>
                    {
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                            {
                                passedForm.Invoke(new Action(() => passedForm.UpdateProgressBar(e.ProgressPercentage)));
                            };
                            wc.DownloadFile(new System.Uri(InfoL.externalModsLink), ZipDir);
                        };
                        fastZip.ExtractZip(ZipDir, TempDir, null);
                        File.Delete(ZipDir);

                        MoveDirectory(TempDir, DestDir);
                    });
                    fastZip.ExtractZip(ZipDir, TempDir, null);
                }
            }
        }

        public static bool isValidJVM(string arg)
        {
            if (arg[0] == ' ' || arg[arg.Length - 1] == ' ')
                return false;
            for(int i = 1; i<arg.Length; i++)
            {
                if(arg[i-1]==arg[i] && arg[i] == ' ')
                {
                    return false;
                } 
            }


            return true;
        }

        public static string[] parseJVM(string arg)
        {
            string[] JavaArgs = {"false"};

            int spaceCtr = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] == ' ')
                {
                    spaceCtr++;
                }
            }
            JavaArgs = new string[spaceCtr + 2];
            int strStartIndex = 0;
            int len = 0;
            int currentIndex = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] == ' ')
                {
                    JavaArgs[currentIndex] = arg.Substring(strStartIndex, len);
                    strStartIndex = i + 1;


                    currentIndex++;
                    len = 0;
                }else if(i + 1 == arg.Length)
                {
                    JavaArgs[currentIndex] = arg.Substring(strStartIndex, len+1);
                }
                else
                {
                    len++;
                }
            }

            return JavaArgs;
        }

        public static void MoveDirectory(string source, string target)
        {
            var stack = new Stack<Folders>();
            stack.Push(new Folders(source, target));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Target);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                    if (File.Exists(targetFile)) File.Delete(targetFile);
                    File.Move(file, targetFile);
                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                }
            }
            Directory.Delete(source, true);
        }
        public class Folders
        {
            public string Source { get; private set; }
            public string Target { get; private set; }

            public Folders(string source, string target)
            {
                Source = source;
                Target = target;
            }
        }

    }

    public class LaunchInformation
    {
        public string selectedProfile = "null";
        public bool isForge = false;
        public string mcVersion = "1.16.5";
        public bool isModsExternal = false;
        public string externalModsLink; 
        public string forgeLink;
        public string serverIP;
        private string ForgeVersion;
        public string forgeVersion
        {
            set
            {
                ForgeVersion = value;
            }
            get
            {
                return mcVersion + "-" + ForgeVersion;
            }
        }
    }
}
