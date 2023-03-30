using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;
using CefSharp.WinForms;
using CefSharp;

namespace UmutLauncher
{


    public partial class Launcher : Form
    {

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;


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
        static public XmlDocument XMLConfig;
        static private LaunchInformation InfoL = new LaunchInformation();
        static Config configForm;

        private void Form1_Load(object sender, EventArgs a)
        {
            this.chromiumWebBrowser1.LoadUrl("https://www.google.com");
            ChangeLoadingBar();
            label1.Font = myFont;
            configForm = new Config(this, true);
            bool gonnaCry = false;
            XMLConfig = new XmlDocument();
            try
            {
                XMLConfig.Load(@"Config.xml");
            }
            catch
            {
                gonnaCry = true;
                File.Delete(@"Config.xml");
            }
            if ((gonnaCry) || XMLConfig.SelectSingleNode("config").ChildNodes.Count != 8)
            {
                configForm.Shown += (asd,sdf) =>
                {
                    this.Hide();
                };
                configForm.Activate();
                configForm.Show();
                configForm.FormClosing += AfterFormClosed;
            }
        }

        private bool isBottomGone = false;

        private void ChangeLoadingBar()
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

        private void AfterFormClosed(object what, FormClosingEventArgs the)
        {
            Console.WriteLine("Detected");
            XMLConfig = new XmlDocument();
            XMLConfig.Load(@"Config.xml");
            configForm.FormClosing -= AfterFormClosed;
        }

        private void KC_Click(object sender, EventArgs e)
        {
            initLaunchInfo("KnightCraft", "1.16.5", "", "https://gith" + "ub.com/UM" + "CEKO/AILUB" + "-Public/releases/d" + "ownload/forge/forgeraw.zip", "1.16.5-forge-36.2.34");
            if (KCButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 5;
                SuvariButton.FlatAppearance.BorderSize = 1;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }
        private void Suvari_Click(object sender, EventArgs e)
        {
            initLaunchInfo("Suvari", "1.16.5");
            if (SuvariButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 1;
                SuvariButton.FlatAppearance.BorderSize = 5;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }


        private void initLaunchInfo(string profile, string version, string serverIP = "", string externalVersionLink = "",string profileName = "", string externalModsLink = "")
        {
            if(profileName == "")
            {
                profileName = profile;
            }
            InfoL.selectedProfile = profile;
            InfoL.vanillaVersion = version;
            InfoL.serverIP = serverIP;
            InfoL.externalVerLink = externalVersionLink;
            InfoL.profileName = profileName;
            InfoL.externalModsLink = externalModsLink;
        }


        private void ChangeWindowState()
        {
            
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
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
            this.Close();
        }
        private void buttonExit_Hover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.resources.Sprite_00021;
        }
        private void buttonExit_UnHover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.resources.Sprite_00011;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void RunMC_Click(object sender, EventArgs a)
        {
            ChangeLoadingBar();
            this.progressBar1.Visible = true;
            if (InfoL.selectedProfile != "null")
            {
                if (!Directory.Exists(@"instances/" + InfoL.selectedProfile))
                {
                    await Task.Run(() => { 
                        Minecrafto.mcInstall(InfoL, this);
                        Minecrafto.mcRun(InfoL, XMLConfig, this);
                    });
                }
                else
                {
                    await Task.Run(() =>
                    {
                        Minecrafto.mcRun(InfoL, XMLConfig, this);
                    });
                }

                ChangeWindowState();
            }
            ChangeLoadingBar();
        }

        public void UpdateProgressBar(int percentage)
        {
            progressBar1.Value = percentage;
        }

        public void UpdateLabel(string msg)
        {
            label4.Text = msg;
        }

        private bool dragging = false;
        private Point dragStart;

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



        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }


        private void discordJoin(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/FpzSt9WFYs");
        }


        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }
    }
}
