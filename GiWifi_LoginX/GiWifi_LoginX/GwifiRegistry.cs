using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiWifi_LoginX
{

    class GiwifiReg
    {//HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\NlaSvc\Parameters\Internet\EnableActiveProbing

        private static Stack<RegData> Backup = new Stack<RegData>();

        public static void settingregedt32(string src,string partin,object value)
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.OpenSubKey(src, true);
            Backup.Push(new RegData(src, partin, software.GetValue(partin)));
            software.SetValue(partin,value);
            
        }

        public static void unALLsettingregedt32() // 完全反向复原操作  仅存在情况
        {
            if (Backup.Count() <= 0) return;

            RegistryKey key = Registry.LocalMachine;
            foreach (RegData regData in Backup){
                string src = regData.getsrc();
                string partin = regData.getpartin();
                object value = regData.getvalue();
                RegistryKey software = key.OpenSubKey(src, true);
                software.SetValue(partin, value);
            }
        }
    }
    class RegData
    {
        private string src;
        private string partin;
        private object value;

        public RegData(string src,string partin,object value)
        {
            this.src = src;
            this.partin = partin;
            this.value = value;
        }
        public string getsrc()
        {
            return this.src;
        }
        public string getpartin()
        {
            return this.partin;
        }
        public object getvalue()
        {
            return this.value;
        }
        
    }
}
