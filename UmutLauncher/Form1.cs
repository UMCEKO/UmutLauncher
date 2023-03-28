using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace UmutLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public XmlDocument XMLConfig;
        public XmlAttributeCollection attrList;
        static private LaunchInformation InfoL = new LaunchInformation();
        static ConfigForm configForm;

        private void Form1_Load(object sender, EventArgs a)
        {
            configForm = new ConfigForm(this, true);
            if (File.Exists(@"Config.xml"))
            {
                XMLConfig = new XmlDocument();
                try
                {
                    XMLConfig.Load(@"Config.xml");
                    attrList = XMLConfig.SelectSingleNode("/config").Attributes;
                }
                catch
                {
                    File.Delete(@"Config.xml");
                }
            }
            if (!File.Exists(@"Config.xml") || XMLConfig.SelectSingleNode("/config").Attributes.Count != 5)
            {
                configForm.Activate();
                configForm.Show();
                configForm.FormClosing += AfterFormClosed;
            }
        }

        private void AfterFormClosed(object what, FormClosingEventArgs the)
        {
            Console.WriteLine("Detected");
            XMLConfig = new XmlDocument();
            XMLConfig.Load(@"Config.xml");
            attrList = XMLConfig.SelectSingleNode("/config").Attributes;
            configForm.FormClosing -= AfterFormClosed;
        }

        private void KC_Click(object sender, EventArgs e)
        {
            InfoL.selectedProfile = "KnightCraft";
            InfoL.isForge = true;
            InfoL.forgeLink = "https://github.com/UMCEKO/AILUB-Public/releases/download/forge/forgeraw.zip";
            InfoL.mcVersion = "1.16.5";
            InfoL.isModsExternal = true;
            InfoL.externalModsLink = "";
            InfoL.forgeVersion = "forge-36.2.34";
            InfoL.serverIP = "";
            if (KCButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 5;
                SuvariButton.FlatAppearance.BorderSize = 1;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }
        private void Suvari_Click(object sender, EventArgs e)
        {
            InfoL.selectedProfile = "Suvari";
            InfoL.isForge = false;
            InfoL.mcVersion = "1.16.5";
            InfoL.serverIP = "193.35.154.158";
            if (SuvariButton.FlatAppearance.BorderSize != 5)
            {
                KCButton.FlatAppearance.BorderSize = 1;
                SuvariButton.FlatAppearance.BorderSize = 5;
            }
            ButtonPlay.BackColor = Color.FromArgb(255, 0, 255, 0);
        }


        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
            else
            {
                this.notifyIcon1.Visible = false;
                this.Show();
            }
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
            if (InfoL.selectedProfile != "null")
            {
                if (!Directory.Exists(@"instances/" + InfoL.selectedProfile))
                {
                    await Task.Run(() => { Minecrafto.mcInstall(InfoL, this); });
                }

                Minecrafto.mcRun(InfoL, attrList, this);
                if (this.Visible)
                {
                    this.Hide();
                    this.notifyIcon1.Visible = true;
                }
                else
                {
                    this.notifyIcon1.Visible = false;
                    this.Show();
                }
            }
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AyarBtn_Clck(object sender, EventArgs e)
        {



            configForm = new ConfigForm(this);
            configForm.Activate();
            configForm.Show();
            configForm.FormClosing += AfterFormClosed;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Minecrafto.mcInstall(InfoL, this);
        }
    }
}
