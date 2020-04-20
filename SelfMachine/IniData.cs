using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfMachine
{
    public class IniData
    {
        public string Database { get; set; }
        public string ServerName { get; set; }
        public string LogId { get; set; }
        public string LogPassword { get; set; }
        /// <summary>
        /// 存储过程名字
        /// </summary>
        public  string StoredProcedureName { get; set; }


}
}