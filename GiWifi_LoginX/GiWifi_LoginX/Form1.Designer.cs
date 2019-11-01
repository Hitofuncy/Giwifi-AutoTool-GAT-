namespace GiWifi_LoginX
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBW = new System.Windows.Forms.WebBrowser();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.设置登入信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置登入信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置自动检测处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化程序配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于制作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.LoginLongCheck = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.skinMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(47, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "作者：107 软件工程专业";
            // 
            // LoginBW
            // 
            this.LoginBW.Location = new System.Drawing.Point(14, 282);
            this.LoginBW.MinimumSize = new System.Drawing.Size(20, 20);
            this.LoginBW.Name = "LoginBW";
            this.LoginBW.ScrollBarsEnabled = false;
            this.LoginBW.Size = new System.Drawing.Size(439, 20);
            this.LoginBW.TabIndex = 2;
            this.LoginBW.WebBrowserShortcutsEnabled = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.SystemColors.WindowText;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.skinButton1.Location = new System.Drawing.Point(335, 153);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(84, 64);
            this.skinButton1.TabIndex = 3;
            this.skinButton1.Text = "登入";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置登入信息ToolStripMenuItem,
            this.关于制作ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 34);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(452, 25);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 4;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 设置登入信息ToolStripMenuItem
            // 
            this.设置登入信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置登入信息ToolStripMenuItem1,
            this.设置自动检测处理ToolStripMenuItem,
            this.初始化程序配置ToolStripMenuItem});
            this.设置登入信息ToolStripMenuItem.Name = "设置登入信息ToolStripMenuItem";
            this.设置登入信息ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置登入信息ToolStripMenuItem.Text = "设置";
            // 
            // 设置登入信息ToolStripMenuItem1
            // 
            this.设置登入信息ToolStripMenuItem1.Name = "设置登入信息ToolStripMenuItem1";
            this.设置登入信息ToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.设置登入信息ToolStripMenuItem1.Text = "设置登入信息";
            this.设置登入信息ToolStripMenuItem1.Click += new System.EventHandler(this.设置登入信息ToolStripMenuItem1_Click);
            // 
            // 设置自动检测处理ToolStripMenuItem
            // 
            this.设置自动检测处理ToolStripMenuItem.Name = "设置自动检测处理ToolStripMenuItem";
            this.设置自动检测处理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置自动检测处理ToolStripMenuItem.Text = "自动检测时延设置";
            this.设置自动检测处理ToolStripMenuItem.Click += new System.EventHandler(this.设置自动检测处理ToolStripMenuItem_Click);
            // 
            // 初始化程序配置ToolStripMenuItem
            // 
            this.初始化程序配置ToolStripMenuItem.Name = "初始化程序配置ToolStripMenuItem";
            this.初始化程序配置ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.初始化程序配置ToolStripMenuItem.Text = "初始化程序配置";
            this.初始化程序配置ToolStripMenuItem.Click += new System.EventHandler(this.初始化程序配置ToolStripMenuItem_Click);
            // 
            // 关于制作ToolStripMenuItem
            // 
            this.关于制作ToolStripMenuItem.Name = "关于制作ToolStripMenuItem";
            this.关于制作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于制作ToolStripMenuItem.Text = "关于制作";
            this.关于制作ToolStripMenuItem.Click += new System.EventHandler(this.关于制作ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(246, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "连接状态";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(425, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 155);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(325, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "无数据";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(246, 122);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(83, 25);
            this.skinButton2.TabIndex = 3;
            this.skinButton2.Text = "重新检查网络";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 82);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(41, 44);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "88888888889";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "-1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(120, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "否";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "账户";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "自动登录检测时延";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "自动登录是否开启";
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinComboBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Items.AddRange(new object[] {
            "执行循环检测",
            "关闭循环检测"});
            this.skinComboBox1.Location = new System.Drawing.Point(7, 153);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(115, 24);
            this.skinComboBox1.TabIndex = 7;
            this.skinComboBox1.Text = "自动连接开关";
            this.skinComboBox1.WaterText = "";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(128, 153);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(112, 24);
            this.skinButton3.TabIndex = 8;
            this.skinButton3.Text = "应用";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.SkinButton3_Click);
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BaseColor = System.Drawing.Color.Tan;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Font = new System.Drawing.Font("幼圆", 12F);
            this.skinButton4.Location = new System.Drawing.Point(246, 153);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(83, 64);
            this.skinButton4.TabIndex = 3;
            this.skinButton4.Text = "登出";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.SkinButton4_Click);
            // 
            // LoginLongCheck
            // 
            this.LoginLongCheck.Interval = 1000;
            this.LoginLongCheck.Tick += new System.EventHandler(this.LoginLongCheck_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(246, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 37);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ping检查法";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(328, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 35);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "WinAPI检查法";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = null;
            this.skinButton5.Location = new System.Drawing.Point(335, 122);
            this.skinButton5.MouseBack = null;
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = null;
            this.skinButton5.Size = new System.Drawing.Size(84, 25);
            this.skinButton5.TabIndex = 3;
            this.skinButton5.Text = "更新页面";
            this.skinButton5.UseVisualStyleBackColor = false;
            this.skinButton5.Click += new System.EventHandler(this.SkinButton5_Click);
            // 
            // Loop
            // 
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginBW);
            this.Controls.Add(this.skinButton5);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinComboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giwifi Login in/out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser LoginBW;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置登入信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于制作ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton skinButton2;
        private System.Windows.Forms.ToolStripMenuItem 设置登入信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置自动检测处理ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinButton skinButton4;
        private System.Windows.Forms.Timer LoginLongCheck;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem 初始化程序配置ToolStripMenuItem;
        private CCWin.SkinControl.SkinButton skinButton5;
        private System.Windows.Forms.Timer Loop;
        private System.Windows.Forms.Button button1;
    }
}

