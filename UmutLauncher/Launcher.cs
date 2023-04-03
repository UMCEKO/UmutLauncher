using System;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;
using ICSharpCode.SharpZipLib.Zip;

namespace UmutLauncher
{


    public partial class Launcher : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        
        Font myFont;
        XmlDocument RemoteData = new XmlDocument();


        private bool dragging = false;
        private Point dragStart;
        private bool isBottomGone = false;
        static public XmlDocument XMLConfig;
        static Config configForm;
        bool isConfigValid = true;
        public bool isRunning = false;
        public Launcher()
        {
            InitializeComponent();
            byte[] fontData = Properties.resources.Rose_Knight;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.resources.Rose_Knight.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.resources.Rose_Knight.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 20.0F); 
        }
        private void Form1_Load(object sender, EventArgs a)
        {

            XMLConfig = new XmlDocument();
            try
            {
                XMLConfig.Load(@"Config.xml");
            }
            catch
            {
                isConfigValid = false;
                File.Delete(@"Config.xml");
            }

            string[] requiredConfigElements = { "name", "maxRam", "minRam", "javaPath", "javaArgs", "advChecked", "fullscreen", "KCPass" };

            if (isConfigValid)
            {
                for (int i = 0; i < requiredConfigElements.Length; i++)
                {
                    if (XMLConfig.SelectSingleNode("config").SelectSingleNode(requiredConfigElements[i]) == null)
                    {
                        isConfigValid = false;
                        break;
                    }
                }
            }
            
            if (!isConfigValid)
            {
                configForm = new Config(this, true);
                configForm.Shown += (asd, sdf) =>
                {
                    this.Hide();
                };
                configForm.Activate();
                configForm.Show();
                configForm.FormClosing += AfterFormClosed;
            }

            string xmlUrl = "htt"+"ps:"+"//ra" + "w.gi"+"thub" + "userconte" + "nt.com/UM" + "CEKO/UmutL" + "auncher-Da" + "ta/main/lau" + "ncherData.xml";
            WebClient client = new WebClient();
            string stringXml = client.DownloadString(xmlUrl);
            Console.WriteLine(stringXml + "\n\n");
            RemoteData.LoadXml(stringXml);
            var OldData = new XmlDocument();
            bool VersionDataExists = true;
            try
            {
                OldData.Load("VersionData.xml");

            }
            catch
            {
                VersionDataExists = false;
            }
            if (Assembly.GetExecutingAssembly().GetName().Version.ToString() != RemoteData.SelectSingleNode("root/Launcher/version").InnerText)
            {
                var updater = new ProcessStartInfo
                {
                    FileName = Directory.GetCurrentDirectory() + @"\Updater.exe",
                    Arguments = Directory.GetCurrentDirectory() + @"\temp\zip " + Directory.GetCurrentDirectory() + @"\temp\dir " + RemoteData.SelectSingleNode("root/Launcher/updateLink").InnerText,
                    WorkingDirectory = Directory.GetCurrentDirectory()
                };
                Process.Start(updater);
                Console.WriteLine("I am at version" + Assembly.GetExecutingAssembly().GetName().Version.ToString());
                Environment.Exit(1);

            }
            if (VersionDataExists)
            {
                checkInstanceVersion("Suvari");
                checkInstanceVersion("KnightCraft");
            }

            RemoteData.Save("VersionData.xml");
            chromiumWebBrowser1.LoadUrl("http:"+"//umc"+"eko.g"+"ithu"+"b.io");
            ChangeLoadingBar();
            label1.Font = myFont;

        }



        public void ChangeLoadingBar()
        {
            if (isBottomGone == true)
            {
                this.ClientSize = new System.Drawing.Size(960, 600);
                this.panel1.Size = new System.Drawing.Size(960, 70);
                isBottomGone = false;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(960, 540);
                this.panel1.Size = new System.Drawing.Size(960, 10);
                isBottomGone = true;
            }

        }
        private void checkInstanceVersion(string Instance)
        {
            var OldData = new XmlDocument();
            OldData.Load("VersionData.xml");
            if (XMLConfig.DocumentElement.SelectSingleNode("Instances/" + Instance) != null || OldData.SelectSingleNode("root/instances/" + Instance + "/version").InnerText != RemoteData.SelectSingleNode("root/instances/" + Instance + "/version").InnerText)
            {
                XMLConfig.SelectSingleNode("config/Instances/"+ Instance +"/deleteOldFiles").InnerText = RemoteData.SelectSingleNode("root/instances/"+ Instance +"/deleteOldFiles").InnerText;
                XMLConfig.SelectSingleNode("config/Instances/"+ Instance +"/isUpToDate").InnerText = "false";
            }
            XMLConfig.Save("Config.xml");
        }
        private void AfterFormClosed(object what, FormClosingEventArgs the)
        {
            Console.WriteLine("Detected");
            XMLConfig = new XmlDocument();
            XMLConfig.Load(@"Config.xml");
            configForm.FormClosing -= AfterFormClosed;
            isConfigValid = true;
        }


        private void initLaunchInfo(string InstanceTree)
        {
            LaunchInformation.XMLProfile = InstanceTree;
            LaunchInformation.selectedProfile = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("selectedProfile").InnerText;
            LaunchInformation.vanillaVersion = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("vanillaVersion").InnerText;
            LaunchInformation.serverIP = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("serverIP").InnerText;
            LaunchInformation.externalVerLink = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("externalVerLink").InnerText;
            LaunchInformation.externalModsLink = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("externalModsLink").InnerText;


            if (RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("profileName").InnerText == "")
            {
                LaunchInformation.versionName = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("selectedProfile").InnerText;
            }
            else
            {
                LaunchInformation.versionName = RemoteData.SelectSingleNode("//" + InstanceTree).SelectSingleNode("profileName").InnerText;
            }
            if (XMLConfig.DocumentElement.SelectSingleNode("Instances") == null)
            {
                //Create isInstalled for each of the nodes inside config
                XMLConfig.DocumentElement.AppendChild(XMLConfig.CreateElement("Instances"));
            }
            if (XMLConfig.DocumentElement.SelectSingleNode("Instances/" + LaunchInformation.selectedProfile) == null)
            {
                var childElement = XMLConfig.CreateElement(LaunchInformation.selectedProfile);
                XmlElement[] childOfChildElement = { XMLConfig.CreateElement("isUpToDate") , XMLConfig.CreateElement("deleteOldFiles") };
                childOfChildElement[0].InnerText = "false";
                childOfChildElement[1].InnerText = RemoteData.SelectSingleNode("root/instances/"+ LaunchInformation.selectedProfile +"/deleteOldFiles").InnerText;
                childElement.AppendChild(childOfChildElement[0]);
                childElement.AppendChild(childOfChildElement[1]);
                XMLConfig.DocumentElement.SelectSingleNode("Instances").AppendChild(childElement);
                XMLConfig.Save("Config.xml");
            }

        }




        private async void RunMC_Click(object sender, EventArgs a)
        {
            if(isRunning == false)
            {
                isRunning = true;
                ChangeLoadingBar();
                this.progressBar1.Visible = true;
                if (LaunchInformation.selectedProfile != "null")
                {
                    if (XMLConfig.SelectSingleNode("config/Instances/" + LaunchInformation.selectedProfile + "/isUpToDate").InnerText == "false")
                    {
                        await Task.Run(() => { Minecrafto.mcInstall(this); });
                        
                        XMLConfig.SelectSingleNode("config/Instances/" + LaunchInformation.selectedProfile + "/isUpToDate").InnerText = "true";
                        XMLConfig.Save("Config.xml");
                        await Task.Run(() => { Minecrafto.mcRun(XMLConfig, this); });
                        

                    }
                    else
                    {

                        await Task.Run(() => { Minecrafto.mcRun(XMLConfig, this); });
                    }
                }

            }
        }
        private void KC_Click(object sender, EventArgs e)
        {
            initLaunchInfo("KnightCraft");
            if (KCButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 5;
                SuvariButton.FlatAppearance.BorderSize = 1;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }
        private void Suvari_Click(object sender, EventArgs e)
        {
            initLaunchInfo("Suvari");
            if (SuvariButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 1;
                SuvariButton.FlatAppearance.BorderSize = 5;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }





        private void AyarBtn_Clck(object sender, EventArgs e)
        {
            configForm = new Config(this);
            configForm.Shown += (qwe, wer)=>{
                this.Hide();
            };
            configForm.Show();
            configForm.Activate();
            configForm.FormClosing += AfterFormClosed;
        }
        private void buttonMin_Click(object sender, EventArgs e)
        {
            ChangeWindowState();
        }
        private void buttonMin_Hover(object sender, EventArgs e)
        {
            this.buttonMin.BackgroundImage = Properties.resources.Sprite_0002;
        }
        private void buttonMin_UnHover(object sender, EventArgs e)
        {
            this.buttonMin.BackgroundImage = Properties.resources.Sprite_0001;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void buttonExit_Hover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.resources.Sprite_00021;
        }
        private void buttonExit_UnHover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.resources.Sprite_00011;
        }


        public void UpdateProgressBar(int percentage)
        {
            progressBar1.Value = percentage;
        }
        public void ChangeWindowState()
        {
            
            if (this.Visible)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else
            {
                this.Show();
                notifyIcon1.Visible = false;
            }
        }
        public void UpdateLabel(string msg)
        {
            label4.Text = msg;
        }


        private void DragHandle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStart = e.Location;
        }
        private void DragHandle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void DragHandle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.Location.X - dragStart.X;
                newLocation.Y += e.Location.Y - dragStart.Y;
                this.Location = newLocation;
            }
        }



    }
}
