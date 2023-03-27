using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Drawing;
using System.Linq;
using CmlLib.Utils;
using System.IO;
using CmlLib.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Net.Http;
using CmlLib;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;
using CmlLib.Core.Installer;
using CmlLib.Core.Downloader;
using CmlLib.Core.Files;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;


namespace UmutLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private XmlDocument XMLConfig;
        private XmlAttributeCollection attrList;
        private void Form1_Load(object sender, EventArgs a)
        {
            
            

            if (File.Exists(@"Config.xml"))
            {
                XMLConfig = new XmlDocument();
                try
                {
                    XMLConfig.Load(@"Config.xml");
                }
                catch
                {
                    File.Delete(@"Config.xml");
                }
            }
            if (!File.Exists(@"Config.xml") || XMLConfig.SelectSingleNode("/config").Attributes.Count != 4)
            {
                File.Delete(@"Config.xml");
                string XMLContent = "" +
                    "<config \n" +
                    "isInstalled = \"false\" \n" +
                    "MaxRam = \"2048\" \n" +
                    "MinRam = \"1024\" \n" +
                    "JavaLoc = \"" + Minecrafto.GetJavaInstallationPath() + "\\bin\\javaw.exe\" /> ";
                File.AppendAllText(@"Config.xml", XMLContent);
                XMLConfig = new XmlDocument();
                XMLConfig.Load(@"Config.xml");
            }
            
            attrList = XMLConfig.SelectSingleNode("/config").Attributes;
        }

        


        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (this.Visible) {
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
            this.buttonMin.BackgroundImage = Properties.Resources.Sprite_0002;
        }
        private void buttonMin_UnHover(object sender, EventArgs e)
        {
            this.buttonMin.BackgroundImage = Properties.Resources.Sprite_0001;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonExit_Hover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.Resources.Sprite_00021;
        }
        private void buttonExit_UnHover(object sender, EventArgs e)
        {
            this.buttonExit.BackgroundImage = Properties.Resources.Sprite_00011;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void RunMC_Click(object sender, EventArgs a)
        {
            string ver = "1.16.5";
            if (attrList.Item(0).Value == "false")
            {
                await Task.Run(() => { Minecrafto.mcInstall(ver, this); });
                attrList.Item(0).Value = "true";
                XMLConfig.Save(@"Config.xml");
            }

            Minecrafto.mcRun(ver, "BX0W", attrList, this);
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
    }
}
