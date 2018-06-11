using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Util
{
    public class DBBase
    {
        public string hostName = null;
        public string baseName = null;
        public string loginName = null;
        public string passWord = null;

        public DBBase()
        {

        }
    }

    public class DBConnectioin : DBBase
    {
        private INI ini;
        public static string conStr = null;

        public DBConnectioin()
        {
            ini = new INI();
        }

        private void Read()
        {
            ini.GetPara();

            this.hostName = ini.hostName;
            this.baseName = ini.baseName;
            this.loginName = ini.loginName;
            this.passWord = ini.passWord;
        }

        public void Write()
        {
            ini.hostName = this.hostName;
            ini.baseName = this.baseName;
            ini.loginName = this.loginName;
            ini.passWord = this.passWord;
            ini.SetPara();
        }

        public void GetConString()
        {
            this.Read();
            conStr = "workstation id=" + this.hostName + ";data source=" + this.hostName + ";initial catalog=" + this.baseName + ";user id=" + this.loginName + ";password=" + this.passWord;
        }

    }

    public class INI : DBBase
    {
        protected string path = null;
        protected string fileName = "Config.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public INI()
        {
            this.path = Directory.GetCurrentDirectory();
        }

        private bool Write(string section, string key, string value)
        {
            try
            {
                WritePrivateProfileString(section, key, value, this.path + "\\" + this.fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string Read(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path + "\\" + this.fileName);
            return temp.ToString();
        }

        public void GetPara()
        {
            this.hostName = Read("Info", "HostName");
            this.baseName = Read("Info", "baseName");
            this.loginName = Read("Info", "LoginName");
            this.passWord = Read("Info", "PassWord");
        }

        public void SetPara()
        {
            Write("Info", "HostName", this.hostName);
            Write("Info", "baseName", this.baseName);
            Write("Info", "LoginName", this.loginName);
            Write("Info", "PassWord", this.passWord);
        }

    }
}
