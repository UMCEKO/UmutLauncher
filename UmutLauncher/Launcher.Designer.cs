using System.Windows.Forms;

namespace UmutLauncher
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.TopBarIcons = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DragHandle = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KCButton = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.SuvariButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DragHandle.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarIcons
            // 
            this.TopBarIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TopBarIcons.ImageStream")));
            this.TopBarIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TopBarIcons.Images.SetKeyName(0, "CloseIdle.png");
            this.TopBarIcons.Images.SetKeyName(1, "MinimizeIdle.png");
            this.TopBarIcons.Images.SetKeyName(2, "CloseHover.png");
            this.TopBarIcons.Images.SetKeyName(3, "MinimizeHover.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(960, 70);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "  ";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(10, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(940, 30);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // DragHandle
            // 
            this.DragHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DragHandle.Controls.Add(this.panel11);
            this.DragHandle.Controls.Add(this.panel10);
            this.DragHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragHandle.Location = new System.Drawing.Point(0, 0);
            this.DragHandle.Name = "DragHandle";
            this.DragHandle.Padding = new System.Windows.Forms.Padding(3);
            this.DragHandle.Size = new System.Drawing.Size(960, 35);
            this.DragHandle.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonExit);
            this.panel11.Controls.Add(this.button5);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.buttonMin);
            this.panel11.Controls.Add(this.button6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(835, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(122, 29);
            this.panel11.TabIndex = 11;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::UmutLauncher.Properties.resources.Sprite_00011;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(61, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 29);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_Hover);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_UnHover);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(265, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 29);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImage = global::UmutLauncher.Properties.resources.Sprite_0001;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(3, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(55, 29);
            this.buttonMin.TabIndex = 1;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            this.buttonMin.MouseEnter += new System.EventHandler(this.buttonMin_Hover);
            this.buttonMin.MouseLeave += new System.EventHandler(this.buttonMin_UnHover);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(193, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 29);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.button3);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.button4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(954, 29);
            this.panel10.TabIndex = 10;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rose Knight", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "UmutLauncher";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseUp);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(265, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 29);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(193, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 29);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 495);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.chromiumWebBrowser1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 495);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(736, 495);
            this.chromiumWebBrowser1.TabIndex = 1;
            this.chromiumWebBrowser1.LoadUrlAsync("https://www.google.com");
            this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 495);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10);
            this.panel13.Size = new System.Drawing.Size(10, 495);
            this.panel13.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(746, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(214, 495);
            this.panel8.TabIndex = 8;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.ButtonPlay);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 418);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(214, 78);
            this.panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Image = global::UmutLauncher.Properties.resources.interaction_social_media_discord_communication_chat_icon_230306;
            this.label5.Location = new System.Drawing.Point(142, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 57);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.discordJoin);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(146, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(136, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 58);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 58);
            this.panel7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::UmutLauncher.Properties.resources.Icons8_Ios7_Very_Basic_Settings_Filled_48;
            this.button1.Location = new System.Drawing.Point(78, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AyarBtn_Clck);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(68, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 58);
            this.panel9.TabIndex = 13;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Image = global::UmutLauncher.Properties.resources.Pictogrammers_Material_Play_48;
            this.ButtonPlay.Location = new System.Drawing.Point(10, 10);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(58, 58);
            this.ButtonPlay.TabIndex = 9;
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.RunMC_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.KCButton);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.SuvariButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(214, 418);
            this.panel2.TabIndex = 9;
            // 
            // KCButton
            // 
            this.KCButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KCButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KCButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.KCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KCButton.Image = global::UmutLauncher.Properties.resources.KC;
            this.KCButton.Location = new System.Drawing.Point(10, 214);
            this.KCButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.KCButton.Name = "KCButton";
            this.KCButton.Size = new System.Drawing.Size(194, 194);
            this.KCButton.TabIndex = 10;
            this.KCButton.UseVisualStyleBackColor = false;
            this.KCButton.Click += new System.EventHandler(this.KC_Click);
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(10, 204);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(194, 10);
            this.panel12.TabIndex = 14;
            // 
            // SuvariButton
            // 
            this.SuvariButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SuvariButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuvariButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SuvariButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuvariButton.Image = global::UmutLauncher.Properties.resources.Suvari;
            this.SuvariButton.Location = new System.Drawing.Point(10, 10);
            this.SuvariButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.SuvariButton.Name = "SuvariButton";
            this.SuvariButton.Size = new System.Drawing.Size(194, 194);
            this.SuvariButton.TabIndex = 9;
            this.SuvariButton.UseVisualStyleBackColor = false;
            this.SuvariButton.Click += new System.EventHandler(this.Suvari_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::UmutLauncher.Properties.resources.rsz_3intro_2;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DragHandle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DragHandle.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ImageList TopBarIcons;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragHandle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button KCButton;
        private System.Windows.Forms.Button SuvariButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label4;
        private PictureBox pictureBox1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }

}

