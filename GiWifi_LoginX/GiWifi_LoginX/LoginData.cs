using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiWifi_LoginX
{
    public partial class LoginData : CCWin.Skin_VS
    {
        public LoginData()
        {
            InitializeComponent();
        }

        private void LoginData_Load(object sender, EventArgs e)
        {

        }

        private void ERRMessage()
        {
            MessageBox.Show("你的手机号码输入不合法,请重新输入。");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            INIFile op = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");

            try
            {
                long F = long.Parse(textBox1.Text);
                if (textBox1.Text.Length != 11)
                {
                    ERRMessage();
                    return;
                }
            }
            catch (Exception)
            {
                ERRMessage();
                return;
            }

            op.IniWriteValue("AutoLoginServer", "UserAccount", textBox1.Text);
            op.IniWriteValue("AutoLoginServer", "UserAccountPassWord", checkBox1.Checked == false?"":textBox2.Text); // 写密码文件
            string msr = "已经储存账户" + (checkBox1.Checked == false? "" : "和密码");
            MessageBox.Show(msr,"账户输入",MessageBoxButtons.OK,MessageBoxIcon.Information);

            LoginInternet.loginUser = textBox1.Text;
            try { LoginInternet.UserPassword = textBox2.Text; } catch (Exception) { } // 防止密码出现问题
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }
    }
}
