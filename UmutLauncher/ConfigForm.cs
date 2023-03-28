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
    public partial class ConfigForm : Form
    {
        static private bool isFirstTime;
        static private Form1 form1;
        public ConfigForm(Form1 passedForm ,bool IsFirstTime = false)
        {
            form1 = passedForm;
            isFirstTime = IsFirstTime;
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            form1.Invoke(new Action(() => form1.Hide()));
            Console.WriteLine(isFirstTime);
            if (isFirstTime)
            {
                javaPathBox.Text = Minecrafto.GetJavaInstallationPath();
                MaxRamBox.Text = "2048";
                MinRamBox.Text = "1024";
            }
            else
            {
                var ConfXML = new XmlDocument();
                ConfXML.Load(@"Config.xml");
                playerNameBox.Text = ConfXML.SelectSingleNode("/config").Attributes.Item(0).Value;
                MaxRamBox.Text = ConfXML.SelectSingleNode("/config").Attributes.Item(1).Value;
                MinRamBox.Text = ConfXML.SelectSingleNode("/config").Attributes.Item(2).Value;
                javaPathBox.Text = ConfXML.SelectSingleNode("/config").Attributes.Item(3).Value;
                JavaArgBox.Text = ConfXML.SelectSingleNode("/config").Attributes.Item(4).Value;
            }
        }

        private void SaveButt(object sender, EventArgs e)
        {
            if (savefunc())
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

        private async void flashJavaArg()
        {
            await Task.Run(() =>
            {
                label5.ForeColor = Color.Red;
                Thread.Sleep(300);
                label5.ForeColor = Color.White;
                Thread.Sleep(300);
                label5.ForeColor = Color.Red;
                Thread.Sleep(300);
                label5.ForeColor = Color.White;
                Thread.Sleep(300);
                label5.ForeColor = Color.Red;
                Thread.Sleep(300);
                label5.ForeColor = Color.White;
            });
            


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
                if (isFirstTime)
                {
                    File.Delete(@"Config.xml");
                    string XMLContent = "<config \n" +
                        "Name = \"" + playerNameBox.Text + "\" \n" +
                        "MaxRam = \"" + MaxRamBox.Text + "\" \n" +
                        "MinRam = \"" + MinRamBox.Text + "\" \n" +
                        "JavaLoc = \"" + javaPathBox.Text + "\\bin\\javaw.exe\" \n" +
                        "JavaArgs = \"" + JavaArgBox.Text + "\"" +
                        "/> ";
                    File.AppendAllText(@"Config.xml", XMLContent);
                }
                else
                {
                    var ConfXML = new XmlDocument();
                    ConfXML.Load(@"Config.xml");
                    ConfXML.SelectSingleNode("/config").Attributes.Item(0).Value = playerNameBox.Text;
                    ConfXML.SelectSingleNode("/config").Attributes.Item(1).Value = MaxRamBox.Text;
                    ConfXML.SelectSingleNode("/config").Attributes.Item(2).Value = MinRamBox.Text;
                    ConfXML.SelectSingleNode("/config").Attributes.Item(3).Value = javaPathBox.Text;
                    ConfXML.SelectSingleNode("/config").Attributes.Item(4).Value = JavaArgBox.Text;
                    ConfXML.Save(@"Config.xml");
                }
                return true;
            }
            return false;
        }

        private void oyunklasoru(object sender, EventArgs e)
        {
            var procStartInf = new ProcessStartInfo
            {
                FileName="explorer.exe",
                Arguments=Directory.GetCurrentDirectory() + "\\instances"
            };
            Process.Start(procStartInf);
        }
    }
}
