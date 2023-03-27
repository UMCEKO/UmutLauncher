
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.install = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.buttonExit.Location = new System.Drawing.Point(662, 3);
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
            this.buttonMin.Location = new System.Drawing.Point(601, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(55, 29);
            this.buttonMin.TabIndex = 1;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            this.buttonMin.MouseEnter += new System.EventHandler(this.buttonMin_Hover);
            this.buttonMin.MouseLeave += new System.EventHandler(this.buttonMin_UnHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.Controls.Add(this.buttonMin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 360);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(720, 120);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // install
            // 
            this.install.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.install.Location = new System.Drawing.Point(46, 38);
            this.install.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(166, 309);
            this.install.TabIndex = 5;
            this.install.Text = "Install Game";
            this.install.UseVisualStyleBackColor = false;
            this.install.Click += new System.EventHandler(this.RunMC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.install);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ImageList TopBarIcons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Label label1;
    }
}

