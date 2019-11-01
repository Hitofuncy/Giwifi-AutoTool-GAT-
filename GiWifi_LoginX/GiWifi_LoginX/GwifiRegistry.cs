using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GiWifi_LoginX
{
    
    class GiwifiReg
    {//HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\NlaSvc\Parameters\Internet\EnableActiveProbing
        [DllImport(@"wininet",
        SetLastError = true,
        CharSet = CharSet.Auto,
        EntryPoint = "InternetSetOption",
        CallingConvention = CallingConvention.StdCall)]

        public static extern bool InternetSetOption
        (
        int hInternet,
        int dmOption,
        IntPtr lpBuffer,
        int dwBufferLength
        );
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
                try
                {
                    software.SetValue(partin, value);
                }
                catch
                {

                }
            }
           
        }
        public struct Struct_INTERNET_PROXY_INFO
        {
            public int dwAccessType;
            public IntPtr proxy;
            public IntPtr proxyBypass;
        };

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);
        public static bool RefreshIESettings(string strProxy)
        {
            const int INTERNET_OPTION_PROXY = 38;
            const int INTERNET_OPEN_TYPE_PROXY = 3;
            const int INTERNET_OPEN_TYPE_DIRECT = 1;
            Struct_INTERNET_PROXY_INFO struct_IPI;
            // Filling in structure
            if (string.IsNullOrEmpty(strProxy))
            {
                struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_DIRECT;
            }
            else
            {
                struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
            }
            struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy);
            struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local");
            // Allocating memory
            IntPtr intptrStruct = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI));
            // Converting structure to IntPtr
            Marshal.StructureToPtr(struct_IPI, intptrStruct, true);
            bool iReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, Marshal.SizeOf(struct_IPI));

            return iReturn;
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
