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
using Newtonsoft.Json;
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
        private void Form1_Load(object sender, EventArgs a)
        {
        }



        public void setLabel(string val)
        {
            this.label1.Text = val;
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
            var XMLConfig = new XmlDocument();
            XMLConfig.Load(@"../../XMLFile1.xml");
            var attrInst = XMLConfig.SelectSingleNode("/config").Attributes.Item(0);
            string ver = "1.16.5";
            if (attrInst.Value == "false")
            {
                await Task.Run(() => { Minecrafto.mcInstall(ver); });
                attrInst.Value = "true";
                XMLConfig.Save(@"../../XMLFile1.xml");
            }

            await Task.Run(() => { Minecrafto.mcRun(ver,"BX0W"); });


        }

    }
}
