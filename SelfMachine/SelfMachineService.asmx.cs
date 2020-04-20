using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SelfMachine
{  
    /// <summary>
    /// SelfMachineService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class SelfMachineService : System.Web.Services.WebService
    {
       
        [WebMethod(Description = "4.1.1HIS患者档案信息查询")]
        public string QueryPatient(string  param)
        {
            string data = SqlHelp.ExecutingSql("QueryPatient", param);
            return data;
        }
        [WebMethod(Description = "4.1.2HIS病人建档")]
        public string CreateCardAddPosit(string param)
        {
            string data = SqlHelp.ExecutingSql("CreateCardAddPosit", param);
            return data;
            
        }
        [WebMethod(Description = " 4.1.3.HIS病人基本信息修改")]
        public string ModifyPatient(string param)
        {
            string data = SqlHelp.ExecutingSql("ModifyPatient", param);
            return data;

        }
        [WebMethod(Description = "4.2.1.HIS待缴费概要信息查询")]
        public string QueryCostSummary(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostSummary", param);
            return data;
        }
        [WebMethod(Description = "4.2.2.HIS已缴费概要信息查询")]
        public string QueryFeeRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryFeeRecord", param);
            return data;
        }
        [WebMethod(Description = "4.2.3.HIS缴费明细查询")]
        public string QueryCostDetail(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostDetail", param);
            return data;
        }
        [WebMethod(Description = "4.2.4.HIS缴费预结算(可选)")]
        public string PreOpPay(string param)
        {
            string data = SqlHelp.ExecutingSql("PreOpPay", param);
            return data;
        }
        [WebMethod(Description = " 4.2.5.HIS缴费结算")]
        public string OpPay(string param)
        {
            string data = SqlHelp.ExecutingSql("OpPay", param);
            return data;
        }
        [WebMethod(Description = "4.3.1.获取HIS时间段内预约挂号记录")]
        public string QueryAppointRegInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryAppointRegInfo", param);
            return data;
        }
        [WebMethod(Description = " 4.3.2.获取HIS时间段内排班")]
        public string QueryScheduleInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryScheduleInfo", param);
            return data;
        }
       

        
        //[WebMethod(Description = "4.3.3.HIS根据科室ID获取科室/医生排班信息")]
        //public string QuerySchedule(string param)
        //{
        //    string data = SqlHelp.ExecutingSql("QuerySchedule", param);
        //    return data;
        //}
        [WebMethod(Description = " 4.3.3. HIS预约/挂号可用号源明细查询")]
        public string QuerySourceList(string param)
        {
            string data = SqlHelp.ExecutingSql("QuerySourceList", param);
            return data;
        }
    
        [WebMethod(Description = "4.3.4.HIS挂号锁号")]
        public string RegLock(string param)
        {
            string data = SqlHelp.ExecutingSql("RegLock", param);
            return data;
        }
        [WebMethod(Description = "4.3.5.HIS挂号解除锁号")]
        public string RegUnLock(string param)
        {
            string data = SqlHelp.ExecutingSql("RegUnLock", param);
            return data;
        }
        //[WebMethod(Description = "4.3.7.HIS预约/当日挂号费用预处理(可选)")]
        //public string PatientPreferential(string param)
        //{
        //    string data = SqlHelp.ExecutingSql("PatientPreferential", param);
        //    return data;
        //}
        [WebMethod(Description = "4.3.6.HIS预约/当日挂号")]
        public string AppointReg(string param)
        {
            string data = SqlHelp.ExecutingSql("AppointReg", param);
            return data;
        }
        [WebMethod(Description = "4.3.7.HIS取消预约&取消挂号")]
        public string CancelAppointOrRegister(string param)
        {
            string data = SqlHelp.ExecutingSql("CancelAppointOrRegister", param);
            return data;
        }
        [WebMethod(Description = "4.3.8.HIS退费流水通知")]
        public string RefundOrderNotify(string param)
        {
            string data = SqlHelp.ExecutingSql("RefundOrderNotify", param);
            return data;
        }
    
        [WebMethod(Description = "4.4.1.HIS收费项目查询")]
        public string QueryCostInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostInfo", param);
            return data;
        }
        [WebMethod(Description = "4.4.2.HIS药品项目查询")]
        public string QueryMedicinesInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryMedicinesInfo", param);
            return data;
        }
        [WebMethod(Description = "4.4.3.HIS医生信息查询")]
        public string QueryDoct(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryDoct", param);
            return data;
        }
        [WebMethod(Description = "4.4.4.HIS科室信息查询")]
        public string QueryAllDept(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryAllDept", param);
            return data;
        }
        [WebMethod(Description = "4.4.5.HIS排班收费条目信息查询")]
        public string QueryScheduleItemFee(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryScheduleItemFee", param);
            return data;
        }
        [WebMethod(Description = "4.5.1.LIS检验报告查询")]
        public string QueryLisBaseInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryLisBaseInfo", param);
            return data;
        }
        [WebMethod(Description = "4.5.2.	LIS检验报告文件（QueryLisPicture）")]
        public string QueryLisPicture(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryLisPicture", param);
            return data;
        }
        [WebMethod(Description = "4.5.3.LIS检验报告打印通知")]
        public string PrintPatientLisReport(string param)
        {
            string data = SqlHelp.ExecutingSql("PrintPatientLisReport", param);
            return data;
        }
        [WebMethod(Description = "4.6.1.PACS检查报告查询")]
        public string QueryPacsInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryPacsInfo", param);
            return data;
        }
        [WebMethod(Description = "4.6.2.PACS检查报告单图片查询")]
        public string QueryPacsPicture(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryPacsPicture", param);
            return data;
        }
        [WebMethod(Description = "4.6.3.PACS检查报告打印通知")]
        public string PrintPatientPacsReport(string param)
        {
            string data = SqlHelp.ExecutingSql("PrintPatientPacsReport", param);
            return data;
        }
        [WebMethod(Description = "4.7.1.住院患者信息查询")]
        public string ZYQueryPatientInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYQueryPatientInfo", param);
            return data;
        }
        [WebMethod(Description = "4.7.2.住院预缴金充值")]
        public string ZYAddDeposit(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYAddDeposit", param);
            return data;
        }
        [WebMethod(Description = "4.7.3.住院费用明细查询")]
        public string ZYQueryBillDetail(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYQueryBillDetail", param);
            return data;
        }
        [WebMethod(Description = "4.8.1.就诊情况记录查询")]
        public string QueryAppointReg(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryAppointReg", param);
            return data;
        }
        [WebMethod(Description = "4.9.1.就诊签到")]
        public string OutPatientSign(string param)
        {
            string data = SqlHelp.ExecutingSql("OutPatientSign", param);
            return data;
        }
        [WebMethod(Description = "4.10.1.HIS交易状态查询")]
        public string QueryOrderStatus(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryOrderStatus", param);
            return data;
        }
        [WebMethod(Description = "4.10.2.HIS交易记录查询")]
        public string QueryOrderRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryOrderRecord", param);
            return data;
        }

    }
}
