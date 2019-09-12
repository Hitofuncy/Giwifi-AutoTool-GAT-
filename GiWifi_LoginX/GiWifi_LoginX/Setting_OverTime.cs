using System;
using System.Windows.Forms;

namespace GiWifi_LoginX
{
    public partial class Setting_OverTime : Form
    {
        public Setting_OverTime()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            INIFile op = new INIFile(System.IO.Directory.GetCurrentDirectory() + "\\Setting.ini");
            try
            {
                int f = int.Parse(textBox1.Text);
                if (textBox1.Text.Length > 8)
                {
                    MessageBox.Show("警告:数字过大，为了防止超越整数型范围引发问题，禁止在此输入。你可以尝试修改配置文件，" +
                        "所造成无法登录等问题自行解决。", "配置时延模块", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                op.IniWriteValue("AutoLoginServer", "Delay", f.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("检测到输入非数字字符","配置时延模块",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
