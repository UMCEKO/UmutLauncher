using System;
using System.Threading;
using System.Diagnostics;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UmutLauncher
{
    public partial class Config : Form
    {
        static private bool isFirstTime;
        static private Launcher form1;
        public Config(Launcher passedForm ,bool IsFirstTime = false)
        {
            form1 = passedForm;
            isFirstTime = IsFirstTime;
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine(isFirstTime);
            if (isFirstTime)
            {
                MaxRamBox.Text = "2048";
                MinRamBox.Text = "1024";

                if (!checkBox1.Checked)
                {
                    javaPathBox.Visible = false;
                    JavaArgBox.Visible = false;
                    MinRamBox.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label2.Visible = false;
                }
            }
            else
            {
                var ConfXML = new XmlDocument();
                ConfXML.Load(@"Config.xml");
                playerNameBox.Text = ConfXML.SelectSingleNode("//name").InnerText;
                MaxRamBox.Text = ConfXML.SelectSingleNode("//maxRam").InnerText;
                MinRamBox.Text = ConfXML.SelectSingleNode("//minRam").InnerText;
                javaPathBox.Text = ConfXML.SelectSingleNode("//javaPath").InnerText;
                JavaArgBox.Text = ConfXML.SelectSingleNode("//javaArgs").InnerText;
                checkBox2.Checked = Boolean.Parse(ConfXML.SelectSingleNode("//fullscreen").InnerText);
                checkBox1.Checked = Boolean.Parse(ConfXML.SelectSingleNode("//advChecked").InnerText);
                KCPassBox.Text = ConfXML.SelectSingleNode("//KCPass").InnerText;

                if (!checkBox1.Checked)
                {
                    javaPathBox.Visible = false;
                    JavaArgBox.Visible = false;
                    MinRamBox.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label2.Visible = false;
                }
            }
        }

        private void SaveButt(object sender, EventArgs e)
        {
            if (Minecrafto.isValidJVM(JavaArgBox.Text))
            {
                form1.Invoke(new Action(() => {
                    form1.Show();
                }));
                this.Close();
            }
            else
            {
                flashJavaArg();
            }
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

        private bool isFlashing = false; 

        private async void flashJavaArg()
        {
            if (!isFlashing)
            {
                isFlashing = true;
                await Task.Run(() =>
                {
                    while (true)
                    {
                        label5.ForeColor = Color.Red;
                        Thread.Sleep(300);
                        label5.ForeColor = Color.White;
                        Thread.Sleep(300);
                        if(!isFlashing)
                        {
                            return;
                        }
                    }
                    
                });
            }
        }

        private void fc(object sender, FormClosingEventArgs e)
        {
            if (!savefunc())
            {
                form1.Invoke(new Action(() => {
                    form1.Show();
                }));
            }
        }
        private bool savefunc()
        {
            if (Minecrafto.isValidJVM(JavaArgBox.Text))
            {
                string[][] configPairs = {
                    new string[] {"name", playerNameBox.Text},
                    new string[] {"maxRam", MaxRamBox.Text},
                    new string[] {"minRam", MinRamBox.Text},
                    new string[] {"javaPath", javaPathBox.Text},
                    new string[] {"javaArgs", JavaArgBox.Text},
                    new string[] {"advChecked", checkBox1.Checked.ToString()},
                    new string[] {"fullscreen", checkBox2.Checked.ToString()},
                    new string[] {"KCPass", KCPassBox.Text},
                };
                var newXmlDoc = new XmlDocument();
                try
                {
                    newXmlDoc.Load("Config.xml");
                    newXmlDoc = Minecrafto.constructConfigPairs(configPairs, newXmlDoc);
                    Console.WriteLine("Did not catch exception in loading config");
                }
                catch
                {
                    Console.WriteLine("Caught exception in loading config");
                    newXmlDoc = Minecrafto.constructConfigPairs(configPairs);
                }
                newXmlDoc.Save("Config.xml");
                return true;
            }
            return false;
        }

        private void oyunklasoru(object sender, EventArgs e)
        {
            var procStartInf = new ProcessStartInfo
            {
                FileName="explorer.exe",
                Arguments=Directory.GetCurrentDirectory() + "\\minecraft"
            };
            Process.Start(procStartInf);
        }

        private void advChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                javaPathBox.Visible = true;
                JavaArgBox.Visible = true;
                MinRamBox.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Visible = true;
            }
            else
            {
                javaPathBox.Visible = false;
                JavaArgBox.Visible = false;
                MinRamBox.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }

        }

        private void UpdateMinRam(object sender, EventArgs e)
        {
            int parsed;
            if(int.TryParse(MaxRamBox.Text,out parsed))
            {
                MinRamBox.Text = (parsed / 2).ToString();
            }
            else
            {
                MinRamBox.Text = "";
            }
        }

        private void UnFlash(object sender, EventArgs e)
        {
            isFlashing = false;
        }

        private void javaPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
