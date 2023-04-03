using System;
using System.Diagnostics;
using Microsoft.Win32;
using System.Xml;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using CmlLib.Core;
using CmlLib.Core.Version;
using CmlLib.Core.Auth;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic.FileIO;

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

        public async static void mcRun(XmlDocument configXML, Launcher form)
        {
            form.Invoke(new Action(() => form.UpdateProgressBar(0)));
            var session = MSession.GetOfflineSession(configXML.SelectSingleNode("//name").InnerText);
            var MCPath = new MinecraftPath(@"minecraft/instances/" + LaunchInformation.selectedProfile + "/", @"minecraft/common/");
            MCPath.Library = @"minecraft/common/libraries/";
            MCPath.Resource = @"minecraft/common/resources/";
            MCPath.Versions = @"minecraft/common/versions/";
            MCPath.Runtime = @"minecraft/common/runtime/";
            var Launcher = new CMLauncher(MCPath);
            

            MVersion McVersion;
            if (LaunchInformation.isForge)
            {
                McVersion = Launcher.GetVersion(LaunchInformation.versionName);
            }
            else
            {
                McVersion = Launcher.GetVersion(LaunchInformation.vanillaVersion);
            }

            form.Invoke(new Action(() => form.UpdateProgressBar(20)));
            Launcher.FileChanged += (e) =>
            {
                Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
            };

            Launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
                form.Invoke(new Action(() => form.UpdateProgressBar(e.ProgressPercentage)));
            };
            form.Invoke(new Action(() => form.UpdateProgressBar(40)));

            var Options = new MLaunchOption
            {
                FullScreen = bool.Parse(configXML.SelectSingleNode("//fullscreen").InnerText),
                MinimumRamMb = Int32.Parse(configXML.SelectSingleNode("//minRam").InnerText),
                MaximumRamMb = Int32.Parse(configXML.SelectSingleNode("//maxRam").InnerText),
                ServerIp = LaunchInformation.serverIP,
                Session = session,
                Path = MCPath,
                StartVersion = McVersion,
            };
            form.Invoke(new Action(() => form.UpdateProgressBar(60)));
            if (configXML.SelectSingleNode("//javaPath").InnerText == "")
            {
                Options.JavaPath = Minecrafto.GetJavaInstallationPath() + @"\bin\javaw.exe";
            }
            else
            {
                Options.JavaPath = configXML.SelectSingleNode("//javaPath").InnerText + @"\bin\javaw.exe";
            }
            form.Invoke(new Action(() => form.UpdateProgressBar(80)));
            if ((configXML.SelectSingleNode("//javaArgs").InnerText.Length == 0) && isValidJVM(configXML.SelectSingleNode("//javaArgs").InnerText))
            {
                string[] JVMParsed = parseJVM(configXML.SelectSingleNode("//javaArgs").InnerText);
                Options.JVMArguments = JVMParsed;
                for (int i = 0; Options.JVMArguments.Length > i; i++)
                {
                    Console.WriteLine(JVMParsed[i]);
                }
            }
            form.Invoke(new Action(() => form.UpdateProgressBar(100)));

            
            //Launcher.CheckAndDownload(McVersion);
            form.Invoke(new Action(() => form.ChangeWindowState()));
            
            form.Invoke(new Action(() => form.ChangeLoadingBar()));
            form.Invoke(new Action(() => form.isRunning = false));
            var inst = Launcher.CreateProcess(McVersion, Options, false);
            inst.StartInfo.UseShellExecute = false;
            inst.StartInfo.RedirectStandardOutput = true;
            inst.StartInfo.RedirectStandardError = true;
            inst.OutputDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    Console.WriteLine(args.Data);
                }
            };
            inst.ErrorDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    Console.WriteLine(args.Data);
                }
            };
            inst.Start();
            inst.BeginOutputReadLine();
            inst.BeginErrorReadLine();

            inst.WaitForExit();

            form.Invoke(new Action(() => form.ChangeWindowState()));
        }




        public async static void mcInstall(Launcher passedForm)
        {
            var MCPath = new MinecraftPath(@"minecraft/instances/" + LaunchInformation.selectedProfile + "/", @"minecraft/common/");
            MCPath.Library = @"minecraft/common/libraries/";
            MCPath.Resource = @"minecraft/common/resources/";
            MCPath.Versions = @"minecraft/common/versions/";
            MCPath.Runtime = @"minecraft/common/runtime/";
            var Launcher = new CMLauncher(MCPath);
            Launcher.FileChanged += (e) =>
            {
                Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
                passedForm.Invoke(new Action(() => passedForm.UpdateLabel("[" + e.FileKind.ToString() + "] %" + ((e.ProgressedFileCount * 100) / e.TotalFileCount) + " Şuan indirilen dosya:" + e.FileName)));
            };
            Launcher.ProgressChanged += (s, e) =>
            {
                Launcher myForm = new Launcher();
                passedForm.Invoke(new Action(() => passedForm.UpdateProgressBar(e.ProgressPercentage)));
            };
            var McVersion = Launcher.GetVersion(LaunchInformation.vanillaVersion);
            Launcher.CheckAndDownload(McVersion);
            Console.WriteLine(LaunchInformation.isModsExternal);
            Console.WriteLine(LaunchInformation.isForge);
            Console.WriteLine(LaunchInformation.externalModsLink);
            Console.WriteLine(LaunchInformation.externalVerLink);
            Console.WriteLine("a");
            if (LaunchInformation.isForge)
            {

                string ZipDir = @"minecraft/zips/lmao.zip";
                string TempDir = @"minecraft/temp";
                Directory.CreateDirectory(ZipDir + @"\..");
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += (progress, what) =>
                    {
                        Console.WriteLine("a");
                        Console.WriteLine(progress);
                        Console.WriteLine(what);
                    };
                    client.DownloadFile(LaunchInformation.externalVerLink, ZipDir);
                }

                FastZip kek = new FastZip();
                kek.ExtractZip(ZipDir, TempDir, null);
                File.Delete(ZipDir);
                FileSystem.CopyDirectory(TempDir, @"minecraft\common\" , true);
                Directory.Delete(ZipDir + @"\..");
                Directory.Delete(TempDir, true);
                if (LaunchInformation.isModsExternal)
                {
                    ZipDir = @"minecraft/zips/mods.zip";
                    TempDir = @"minecraft/temp";
                    Directory.CreateDirectory(ZipDir + @"\..");
                    using (var client = new WebClient())
                    {
                        client.DownloadProgressChanged += (progress, what) =>
                        {
                            Console.WriteLine("b");
                            Console.WriteLine(progress);
                            Console.WriteLine(what);
                        };
                        client.DownloadFile(LaunchInformation.externalVerLink, ZipDir);
                    }
                    kek.ExtractZip(ZipDir, TempDir, null);
                    File.Delete(ZipDir);
                    FileSystem.CopyDirectory(TempDir, @"minecraft\instances\" + LaunchInformation.selectedProfile, true);
                    Directory.Delete(ZipDir + @"\..");
                    Directory.Delete(TempDir, true);
                }
            }
        }

        public static bool isValidJVM(string arg)
        {
            if (arg.Length == 0)
            {
                return true;
            }
            if (arg[0] == ' ' || arg[arg.Length - 1] == ' ')
            {
                return false;
            }
            for(int i = 1; i<arg.Length; i++)
            {
                if(arg[i-1]==arg[i] && arg[i] == ' ')
                {
                    return false;
                } 
            }

            return true;
        }

        private static string[] parseJVM(string arg)
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


        public static XmlDocument constructConfigPairs(string[][] configPairs, XmlDocument configFile = null)
        {
            
            if(configFile == null)
            {
                var newXMLDoc = new XmlDocument();
                newXMLDoc.CreateElement("config");
                XmlNode root = newXMLDoc.CreateElement("config");

                XmlNode childNode;
                for (int i = 0; i < configPairs.Length; i++)
                {
                    childNode = newXMLDoc.CreateElement(configPairs[i][0]);
                    childNode.InnerText = configPairs[i][1];
                    root.AppendChild(childNode);
                }
                newXMLDoc.AppendChild(root);
                return newXMLDoc;
            }
            else
            {
                for (int i = 0; i < configPairs.Length; i++)
                {
                    configFile.SelectSingleNode("config/" + configPairs[i][0]).InnerText = configPairs[i][1];
                }
                return configFile;
            }
        }


    }


    public static class LaunchInformation
    {
        public static string selectedProfile = "null";
        public static string vanillaVersion = "1.16.5";
        public static string externalModsLink; 
        public static string externalVerLink;
        public static string serverIP;
        public static string versionName;
        public static string XMLProfile;

        public static bool isModsExternal
        {
            get
            {
                if (LaunchInformation.externalModsLink == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool isForge
        {
            get
            {
                if(LaunchInformation.externalVerLink == "")
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }
    }


    public static class KullaniciBilgi
    {
        public static string ad = "hgfshjg";


    }


}
