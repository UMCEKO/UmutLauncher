
namespace UmutLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopBarIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DragHandle = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SuvariButton = new System.Windows.Forms.Button();
            this.KnightcraftButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.News = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.DragHandle.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_00011;
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
            // buttonMin
            // 
            this.buttonMin.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_0001;
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
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Location = new System.Drawing.Point(10, 10);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(238, 36);
            this.ButtonPlay.TabIndex = 5;
            this.ButtonPlay.Text = "Başlat";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.RunMC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.panel1.Size = new System.Drawing.Size(720, 70);
            this.panel1.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(10, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // DragHandle
            // 
            this.DragHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DragHandle.Controls.Add(this.panel11);
            this.DragHandle.Controls.Add(this.panel10);
            this.DragHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragHandle.Location = new System.Drawing.Point(0, 0);
            this.DragHandle.Name = "DragHandle";
            this.DragHandle.Padding = new System.Windows.Forms.Padding(3);
            this.DragHandle.Size = new System.Drawing.Size(720, 35);
            this.DragHandle.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonExit);
            this.panel11.Controls.Add(this.button5);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.buttonMin);
            this.panel11.Controls.Add(this.button6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(598, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(122, 29);
            this.panel11.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_00011;
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
            // button6
            // 
            this.button6.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_0001;
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
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.button3);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.button4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(595, 29);
            this.panel10.TabIndex = 10;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rose Knight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UmutLauncher";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_00011;
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
            this.button4.BackgroundImage = global::UmutLauncher.Properties.Resources.Sprite_0001;
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
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 375);
            this.panel3.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.webBrowser1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(462, 273);
            this.panel9.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SuvariButton);
            this.panel8.Controls.Add(this.KnightcraftButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(462, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(258, 273);
            this.panel8.TabIndex = 8;
            // 
            // SuvariButton
            // 
            this.SuvariButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SuvariButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SuvariButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuvariButton.Location = new System.Drawing.Point(10, 132);
            this.SuvariButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.SuvariButton.Name = "SuvariButton";
            this.SuvariButton.Size = new System.Drawing.Size(238, 131);
            this.SuvariButton.TabIndex = 10;
            this.SuvariButton.Text = "Install Game";
            this.SuvariButton.UseVisualStyleBackColor = false;
            // 
            // KnightcraftButton
            // 
            this.KnightcraftButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KnightcraftButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KnightcraftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnightcraftButton.Location = new System.Drawing.Point(10, 10);
            this.KnightcraftButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.KnightcraftButton.Name = "KnightcraftButton";
            this.KnightcraftButton.Size = new System.Drawing.Size(238, 131);
            this.KnightcraftButton.TabIndex = 9;
            this.KnightcraftButton.Text = "Install Game";
            this.KnightcraftButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 102);
            this.panel4.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.News);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(462, 102);
            this.panel7.TabIndex = 1;
            // 
            // News
            // 
            this.News.Dock = System.Windows.Forms.DockStyle.Fill;
            this.News.Location = new System.Drawing.Point(10, 10);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(442, 82);
            this.News.TabIndex = 0;
            this.News.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ButtonPlay);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(462, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(258, 102);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 37);
            this.panel6.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ayarlar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(129, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(10, 10);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(442, 253);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DragHandle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
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
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ImageList TopBarIcons;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragHandle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button SuvariButton;
        private System.Windows.Forms.Button KnightcraftButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RichTextBox News;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

