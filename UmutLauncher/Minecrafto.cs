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

        public static void mcRun(LaunchInformation InfoL, XmlDocument configXML, Launcher form)
        {
            form.Invoke(new Action(() => form.UpdateProgressBar(0)));
            var session = MSession.GetOfflineSession(configXML.SelectSingleNode("//name").InnerText);
            var MCPath = new MinecraftPath(@"instances/" + InfoL.selectedProfile + "/");
            var Launcher = new CMLauncher(MCPath);
            MVersion McVersion;
            if (InfoL.isForge)
            {
                McVersion = Launcher.GetVersion(InfoL.profileName);
            }
            else
            {
                McVersion = Launcher.GetVersion(InfoL.vanillaVersion);
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
                ServerIp = InfoL.serverIP,
                Session = session,
                Path = MCPath,
                StartVersion = McVersion
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

            
            var inst = Launcher.CreateProcess(McVersion, Options, false);
            form.Invoke(new Action(() => form.UpdateProgressBar(100)));
            inst.Start();

            //Launcher.Launch(McVersion.Id, Options);
        }

        public static void addValue(string xmlPath, string elementName, string elementValue)
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load(xmlPath);
            var newElement = xmldoc.CreateElement(elementName);
            newElement.InnerText = elementValue;
            xmldoc.DocumentElement.AppendChild(newElement);
            xmldoc.Save(xmlPath);
            return;
        }


        public static void mcInstall(LaunchInformation InfoL , Launcher passedForm)
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
                Launcher myForm = new Launcher();
                passedForm.Invoke(new Action(() => passedForm.UpdateProgressBar(e.ProgressPercentage)));
            };
            var McVersion = Launcher.GetVersion(InfoL.vanillaVersion);
            Launcher.CheckAndDownload(McVersion);


            string ZipDir = @"instances/zips/lmao.zip";
            string TempDir = @"instances/temp";

            //var ahk = new ProcessStartInfo();
            //ahk.Arguments = 
            //    ZipDir + " " + 
            //    TempDir + " " + 
            //    DestDir + " " + 
            //    InfoL.isForge + " " + 
            //    InfoL.forgeLink + " " + 
            //    InfoL.isModsExternal + " " + 
            //    InfoL.externalModsLink;
            //ahk.FileName = "forgeInst.exe";
            //Process process = Process.Start(ahk);
            //process.WaitForExit();

            if (InfoL.isForge)
            {
                Directory.CreateDirectory(ZipDir + @"\..");
                using (var client = new WebClient())
                {
                    client.DownloadFile(InfoL.externalVerLink, ZipDir);
                }

                FastZip kek = new FastZip();
                kek.ExtractZip(ZipDir, TempDir, null);
                File.Delete(ZipDir);
                FileSystem.CopyDirectory(TempDir, MCPath.BasePath , true);

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

        public static XmlDocument constructConfigPairs(string[][] configPairs,string rootElementName)
        {
            var newXMLDoc = new XmlDocument();
            newXMLDoc.CreateElement(rootElementName);
            XmlNode root = newXMLDoc.CreateElement(rootElementName);

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

        private class Folders
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
        public string vanillaVersion = "1.16.5";
        public string externalModsLink; 
        public string externalVerLink;
        public string serverIP;
        public string profileName;

        public bool isModsExternal
        {
            get
            {
                if (this.externalModsLink == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool isForge
        {
            get
            {
                if(this.externalVerLink == "")
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


}
