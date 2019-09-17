using System;
using System.Runtime.InteropServices;
using System.Text;

public class INIFile
    {
        public string path;

        public INIFile(string INIPath)
        {
            path = INIPath;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,string key,string def, StringBuilder retVal,int size,string filePath);

    
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);


        public void IniWriteValue(string Section,string Key,string Value)
        {
            WritePrivateProfileString(Section,Key,Value,this.path);
        }

        public string IniReadValue(string Section,string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section,Key,"",temp, 255, this.path);
            return temp.ToString();
        }
        public byte[] IniReadValues(string section, string key)
        {
            byte[] temp = new byte[255];
            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path);
            return temp;

        }
        public void ClearAllSection()
        {
            IniWriteValue(null,null,null);
        }
        public void ClearSection(string Section)
        {
            IniWriteValue(Section,null,null);
        }

    public static void InitThisDatas() //## 初始化INI数据
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

}