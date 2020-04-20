using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SelfMachine
{
    public static class SqlHelp
    {
        public static string ExecutingSql(string method, string param)
        {
            var result = "";

            string iniFile = HttpRuntime.AppDomainAppPath + "HospitalSevice.ini";
            IniFile myIni = new IniFile(iniFile);
            var ini = myIni.GetIni();
            string strsql = null;//usp_webHealth_NJS_self_all
            strsql = $@"execute {ini.StoredProcedureName}  {method},'{param}'" ;

              SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=" + ini.ServerName + ";database=" + ini.Database + ";uid=" + ini.LogId + ";pwd=" + ini.LogPassword + "";
           
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;

                com.CommandText = strsql;
                DataTable dt = new DataTable();
                SqlDataReader dr = com.ExecuteReader();//执行SQL语句
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    var xmlData = dt.Rows[0][0].ToString();
                    result = xmlData;
                }
                dr.Close();//关闭执行
                con.Close();//关闭数据库
                con.Dispose();//释放资源

            }
            catch (Exception ex)
            {
             
                con.Close();//关闭数据库
                con.Dispose();//释放资源
                result = ex.Message;

            }
            
           


            return result;
        }
    }
}