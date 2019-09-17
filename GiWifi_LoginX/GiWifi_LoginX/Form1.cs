using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

// Giwifi 模拟连接软件 Preview1.0

namespace GiWifi_LoginX
{
    public partial class Form1 : CCWin.Skin_DevExpress
    {
        public Form1()//##构造方法
        {
            this.XTheme = new CCWin.Skin_DevExpress();
            InitializeComponent();
            InitData();
        }

        private void Test()// ##测试数据
        {
            try
            {
                long i = long.Parse(LoginInternet.loginUser);
                if (LoginInternet.loginUser.Length != 11)
                {
                    skinComboBox1.Text = "关闭循环检测";
                    SkinButton3_Click(null, null);
                    MessageBox.Show("检测到用户名位数不正确","登录组件",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    skinComboBox1.Text = "关闭循环检测";
                    SkinButton3_Click(null, null);
                    return;
                }
                if (LoginInternet.UserPassword.Length == 0)
                {
                    skinComboBox1.Text = "关闭循环检测";
                    SkinButton3_Click(null, null);
                    MessageBox.Show("密码不可以为0位", "登录组件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    skinComboBox1.Text = "关闭循环检测";
                    SkinButton3_Click(null, null);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("检测到登录名非法");
                return;
            }
            LoginBW.Navigate(new Uri("http://login.gwifi.com.cn/cmps/admin.php/api/login"));
            
            timeOut(1500);
            HtmlElement username = LoginBW.Document.GetElementById("first_name");
            HtmlElement password = LoginBW.Document.GetElementById("first_password");
            HtmlElement login = LoginBW.Document.GetElementById("first_button");

            if (username != null && password != null && login != null)
            {
                username.SetAttribute("value", LoginInternet.loginUser);
                password.SetAttribute("value", LoginInternet.UserPassword);
                login.InvokeMember("click");
            }
            else
            {
                MessageBox.Show("系统检测到你可能未连接Giwifi认证网络，或不处于Giwifi网络环境之下。");
            }
        }

        private void InternetLight() // ## 主页的连接灯  绿色代表已经连接上   红色代表无法连接   仅有在无法连接的条件下才能执行连接按钮。
        {
            if (LoginInternet.checkInternetLink())
            {
                label3.BackColor = Color.Green;
                label4.ForeColor = Color.Green;
                label4.Text = "连接成功";
            }
            else
            {
                label3.BackColor = Color.Red;
                label4.ForeColor = Color.Red;
                label4.Text = "未连接";
            }
        }

        public void InitData() //## 初始化INI数据
        {
            bool isFile = System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            if (isFile == true) return;
            INIFile op = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            op.IniWriteValue("MainWindows", "AutoLogin", "false");
            op.IniWriteValue("MainWindows", "CheckInternetMethod", "1");
            op.IniWriteValue("AutoLoginServer", "Delay", "-1");
            op.IniWriteValue("AutoLoginServer", "AutoLoginSwitch", "自动连接开关");
            op.IniWriteValue("AutoLoginServer", "UserAccount", "88888888889");
            op.IniWriteValue("AutoLoginServer", "UserAccountPassWord", "");

        }

        private void SettingNowLoading()//##启动程序后加载配置文件。
        {
            bool isFile = System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            if (isFile == false) return; // 配置文件不存在 不进行加载。

            INIFile op = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            try
            {
                String UserName = op.IniReadValue("AutoLoginServer", "UserAccount"); // 登入用户名
                String Password = op.IniReadValue("AutoLoginServer", "UserAccountPassWord");//登入密码
                String AutoLoginSwitch = op.IniReadValue("AutoLoginServer", "AutoLoginSwitch");
                String Delay = op.IniReadValue("AutoLoginServer", "Delay");// 延时

                //String AutoLogin = op.IniReadValue("MainWindows", "AutoLogin");// 是否是自动登录  封杀此功能
                String CheckInternetMethod = op.IniReadValue("MainWindows", "CheckInternetMethod");//判断网路方法

                try
                {

                    long f = long.Parse(UserName);
                    LoginInternet.loginUser = UserName;
                    textBox1.Text = UserName;
                    LoginInternet.UserPassword = Password;
                    LoginInternet.InternetMethod = int.Parse(CheckInternetMethod);
                    if(LoginInternet.InternetMethod == 1)
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else if(LoginInternet.InternetMethod == 2)
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                    }
                    if (AutoLoginSwitch.Equals("执行循环检测") || AutoLoginSwitch.Equals("关闭循环检测"))
                    {
                        skinComboBox1.Text = AutoLoginSwitch;
                    }

                    int de = int.Parse(Delay); // 注意 这里如果超过整数型数据的范围 会直接异常处理
                    label8.Text = de.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("读取配置文件发生错误！程式将会删除错误文件，请重新配置程式。","严重错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    InitData();
                }
            }
            catch (Exception)//## 加载错误的情况，比如空值引发
            {
                MessageBox.Show("配置文件读取失败，请检查文件的完整性！本程序默认将不符合规定的配置文件进行重置操作，信息框关闭后才执行操作。");
                InitData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginBW.Visible = false; // 显示/关闭 浏览器
            LoginBW.ScriptErrorsSuppressed = true;
            InternetLight();
            SettingNowLoading();
        }

        private void SkinButton2_Click(object sender, EventArgs e)
        {
            InternetLight();
        }

        private void timeOut(int se)//## 延迟函数，程序正常运行
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < se)//毫秒
            {
                Application.DoEvents();
            }
        }

        private void SkinButton1_Click(object sender, EventArgs e)//## 执行连接的按钮
        {
            if (LoginInternet.checkInternetLink()) { return; } //## 检查连接情况
            
            Test(); // 调用测试方法
            LoginLongCheck.Enabled = true; // 执行时钟扫描 防止误报连接情况
            SettingNowLoading();
            
        }

        private void SkinButton3_Click(object sender, EventArgs e) //## 循环检测的开关
        {
            INIFile ope = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            if (skinComboBox1.Text == "执行循环检测")
            {
                label8.Text = ope.IniReadValue("AutoLoginServer", "Delay");
                if (int.Parse(label8.Text) < 0)
                {
                    MessageBox.Show("警告！你未设置时延信息。","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                label7.Text = "是";
                label7.ForeColor = Color.Green;
                ope.IniWriteValue("AutoLoginServer", "AutoLoginSwitch", "执行循环检测");
                Loop.Interval = int.Parse(label8.Text);
                Loop.Enabled = true;
            }
            else if(skinComboBox1.Text == "关闭循环检测")
            {
                label7.Text = "否";
                label7.ForeColor = Color.Red;
                ope.IniWriteValue("AutoLoginServer", "AutoLoginSwitch", "关闭循环检测");
                Loop.Enabled = false;
            }
        }
        private int Xtime = 5;
        private void SkinButton4_Click(object sender, EventArgs e) //## 断开连接函数
        {
            
            if (!LoginInternet.checkInternetLink()) { return; }
            //LoginBW.Navigate(new Uri("http://down.gwifi.com.cn/",System.UriKind.Absolute)); // http://down.gwifi.com.cn/

            //HtmlDocument doc = LoginBW.Document;
            //LoginBW.Document.InvokeScript("loginout");
            MessageBox.Show("此功能因为官方限制无法在此版本运行。下一版本添加");
        }

        private void LoginLongCheck_Tick(object sender, EventArgs e) //## 延时缓冲判断连接成功函数  解决误判 无法连接。
        {
            if (--Xtime <= 0)
            {
                Xtime = 5;
                LoginLongCheck.Enabled = false;
                return;
            }
            if (LoginInternet.checkInternetLink())
            {
                InternetLight();
                LoginLongCheck.Enabled = false;
            }
        }

        private void 设置登入信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new LoginData().Show();
        }

        private void 设置自动检测处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Setting_OverTime().ShowDialog();
        }

        private void 初始化程序配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            InitData();
            SettingNowLoading();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            INIFile ope = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");

            if (radioButton1.Checked == true)
            {
                LoginInternet.InternetMethod = 1;
                ope.IniWriteValue("MainWindows", "CheckInternetMethod", "1");
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            INIFile ope = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            if (radioButton2.Checked == true)
            {
                LoginInternet.InternetMethod = 2;
                ope.IniWriteValue("MainWindows", "CheckInternetMethod", "2");
            }
        }

        private void SkinButton5_Click(object sender, EventArgs e)
        {
            SettingNowLoading();
        }

        private void 关于制作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            SkinButton1_Click(null, null);
        }
    }
}
