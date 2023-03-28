
namespace UmutLauncher
{
    partial class ConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.javaPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxRamBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinRamBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.JavaArgBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KCPassBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuncu Adı";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNameBox.Location = new System.Drawing.Point(10, 28);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(297, 20);
            this.playerNameBox.TabIndex = 1;
            // 
            // javaPathBox
            // 
            this.javaPathBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.javaPathBox.Location = new System.Drawing.Point(10, 243);
            this.javaPathBox.Name = "javaPathBox";
            this.javaPathBox.Size = new System.Drawing.Size(297, 20);
            this.javaPathBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 220);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Java Path";
            // 
            // MaxRamBox
            // 
            this.MaxRamBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxRamBox.Location = new System.Drawing.Point(10, 114);
            this.MaxRamBox.Name = "MaxRamBox";
            this.MaxRamBox.Size = new System.Drawing.Size(297, 20);
            this.MaxRamBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oyuna Vereceğiniz RAM (MB türünden)";
            // 
            // MinRamBox
            // 
            this.MinRamBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinRamBox.Location = new System.Drawing.Point(10, 157);
            this.MinRamBox.Name = "MinRamBox";
            this.MinRamBox.Size = new System.Drawing.Size(297, 20);
            this.MinRamBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oyunun kullanacağı minimum RAM  (MB türünden)";
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(51, 414);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(87, 23);
            this.KaydetButton.TabIndex = 8;
            this.KaydetButton.Text = "Kaydet";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.SaveButt);
            // 
            // JavaArgBox
            // 
            this.JavaArgBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.JavaArgBox.Location = new System.Drawing.Point(10, 200);
            this.JavaArgBox.Name = "JavaArgBox";
            this.JavaArgBox.Size = new System.Drawing.Size(297, 20);
            this.JavaArgBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 177);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Java Argümanları";
            // 
            // KCPassBox
            // 
            this.KCPassBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.KCPassBox.Location = new System.Drawing.Point(10, 71);
            this.KCPassBox.Name = "KCPassBox";
            this.KCPassBox.Size = new System.Drawing.Size(297, 20);
            this.KCPassBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "KnightCraft Şifreniz";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Snow;
            this.checkBox1.Location = new System.Drawing.Point(10, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Oyun Klasörü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.oyunklasoru);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.javaPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JavaArgBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.MinRamBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxRamBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KCPassBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ConfigForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fc);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragHandle_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.TextBox javaPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxRamBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinRamBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KaydetButton;
        private System.Windows.Forms.TextBox JavaArgBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KCPassBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}