using System;
using System.Net;
using System.Runtime.InteropServices;

namespace GiWifi_LoginX
{
    class LoginInternet
    {
        public static string loginUser = "no", UserPassword="no";
        public static int InternetMethod = 1;

        private static bool checkInternetMethod_01()
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            try
            {
                System.Net.NetworkInformation.PingReply pingStatus =
                    ping.Send(IPAddress.Parse("208.69.34.231"), 1000);
                if (pingStatus.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int connDescription, int ReservedValue);
        private static bool checkInternetMethod_02()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static bool checkInternetLink()
        {
            if (InternetMethod == 1)
            {
                return checkInternetMethod_01();
            }else if (InternetMethod == 2)
            {
                return checkInternetMethod_02();
            }
            return false;
        }
    }
}
