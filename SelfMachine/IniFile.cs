using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace SelfMachine
{
    public class IniFile
    {
        public string path;

        public IniFile(string inIPath)
        {
            path = inIPath;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        [DllImport("kernel32")]

        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }


        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);

            return temp.ToString();

        }

        /// <summary>
        /// 获取xml标头
        /// </summary>
        /// <returns></returns>
        public IniData GetIni()
        {
            var result = new IniData();

            IniFile myFile = new IniFile(path);
            var fileUserId = myFile.IniReadValue("Info", "UserId");
            var xmlHead = myFile.IniReadValue("Info", "XMLHead");
            result.Database = myFile.IniReadValue("Info", "Database");
            result.ServerName = myFile.IniReadValue("Info", "ServerName");
            result.LogId = myFile.IniReadValue("Info", "LogId");
            result.LogPassword = myFile.IniReadValue("Info", "LogPassword");
            result.StoredProcedureName = myFile.IniReadValue("Info", "StoredProcedureName");
            

            return result;
        }
    }
}