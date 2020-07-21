using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SelfMachine
{ 
    /// <summary>
    /// YiBinSelfMachineService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class YiBinSelfMachineService : System.Web.Services.WebService
    {


        [WebMethod(Description = "6.1.1.1.HIS患者档案信息查询")]
        public string QueryPatient(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryPatient", param);
            return data;
        }
        [WebMethod(Description = "6.1.1.2.HIS病人建档")]
        public string CreateCardAddPosit(string param)
        {
            string data = SqlHelp.ExecutingSql("CreateCardAddPosit", param);
            return data;

        }
        [WebMethod(Description = " 6.1.1.3.HIS病人基本信息修改")]
        public string ModifyPatient(string param)
        {
            string data = SqlHelp.ExecutingSql("ModifyPatient", param);
            return data;

        }
        [WebMethod(Description = "6.1.2.1.HIS待缴费概要信息查询")]
        public string QueryCostSummary(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostSummary", param);
            return data;
        }
        [WebMethod(Description = "6.1.2.2.HIS已缴费概要信息查询")]
        public string QueryFeeRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryFeeRecord", param);
            return data;
        }
        [WebMethod(Description = "6.1.2.3.HIS缴费信息批量查询(分页)")]
        public string BatchQueryCostSummary(string param)
        {
            string data = SqlHelp.ExecutingSql("BatchQueryCostSummary", param);
            return data;
        }
        [WebMethod(Description = "6.1.2.4.HIS缴费明细查询")]
        public string QueryCostDetail(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostDetail", param);
            return data;
        }
        [WebMethod(Description = "6.1.2.5HIS缴费预结算(可选)")]
        public string PreOpPay(string param)
        {
            string data = SqlHelp.ExecutingSql("PreOpPay", param);
            return data;
        }
        [WebMethod(Description = " 6.1.2.6.HIS缴费结算")]
        public string OpPay(string param)
        {
            string data = SqlHelp.ExecutingSql("OpPay", param);
            return data;
        }
        [WebMethod(Description = " 6.1.2.7.HIS取消缴费")]
        public string CancelOpPay(string param)
        {
            string data = SqlHelp.ExecutingSql("CancelOpPay", param);
            return data;
        }

        [WebMethod(Description = "6.1.3.1.HIS科室信息查询")]
        public string QueryAllDept(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryAllDept", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.2.HIS诊室查询")]
        public string QueryDiagnoseRoom(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryDiagnoseRoom", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.3.HIS医生信息查询")]
        public string QueryDoct(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryDoct", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.4.HIS排班收费条目信息查询")]
        public string QueryScheduleItemFee(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryScheduleItemFee", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.5.HIS预约/当日挂号费用预处理")]
        public string PatientPreferential(string param)
        {
            string data = SqlHelp.ExecutingSql("PatientPreferential", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.6.HIS预约/当日挂号")]
        public string AppointReg(string param)
        {
            string data = SqlHelp.ExecutingSql("AppointReg", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.7.HIS锁号")]
        public string RegLock(string param)
        {
            string data = SqlHelp.ExecutingSql("RegLock", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.8.HIS解除锁号")]
        public string RegUnLock(string param)
        {
            string data = SqlHelp.ExecutingSql("RegUnLock", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.9.HIS取消预约/挂号")]
        public string CancelAppointOrRegister(string param)
        {
            string data = SqlHelp.ExecutingSql("CancelAppointOrRegister", param);
            return data;
        }

        [WebMethod(Description = "6.1.3.10.HIS退号")]
        public string BackRegistration(string param)
        {
            string data = SqlHelp.ExecutingSql("BackRegistration", param);
            return data;
        }

        [WebMethod(Description = "6.1.3.11.HIS接收修改后的排班结果数据")]
        public string UpdateScheduleInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("UpdateScheduleInfo", param);
            return data;
        }
        [WebMethod(Description = "6.1.3.12.HIS全量预约挂号记录查询")]
        public string QueryAppointRegInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryAppointRegInfo", param);
            return data;
        }


        [WebMethod(Description = "6.1.4.1.HIS医保科室对照信息查询")]
        public string QuerySICompareDept(string param)
        {
            string data = SqlHelp.ExecutingSql("QuerySICompareDept", param);
            return data;
        }
        [WebMethod(Description = "6.1.4.2.HIS收费项目查询")]
        public string QueryCostInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryCostInfo", param);
            return data;
        }
        [WebMethod(Description = "6.1.4.3.HIS药品项目查询")]
        public string QueryMedicinesInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryMedicinesInfo", param);
            return data;
        }
        //[WebMethod(Description = "6.1.4.4HIS取消预约&取消挂号")]
        //public string CancelAppointOrRegister(string param)
        //{
        //    string data = SqlHelp.ExecutingSql("CancelAppointOrRegister", param);
        //    return data;
        //}
        [WebMethod(Description = "6.1.5.1.HIS交易记录查询")]
        public string QueryOrderRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryOrderRecord", param);
            return data;
        }
        [WebMethod(Description = "6.1.5.2.HIS交易状态查询")]
        public string QueryOrderStatus(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryOrderStatus", param);
            return data;
        }
      
        [WebMethod(Description = "6.1.5.3.HIS上传退费流水")]
        public string UploadBackRegistrationFeeRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("UploadBackRegistrationFeeRecord", param);
            return data;
        }
        [WebMethod(Description = "6.1.6.1.叫号记录查询")]
        public string QueryJhRegRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryJhRegRecord", param);
            return data;
        }
        [WebMethod(Description = "6.1.6.2.获取待取药病人信息")]
        public string TakeMedicinePatient(string param)
        {
            string data = SqlHelp.ExecutingSql("takeMedicinePatient", param);
            return data;
        }
        [WebMethod(Description = "6.1.7.1.住院患者信息查询")]
        public string ZYQueryPatientInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYQueryPatientInfo", param);
            return data;
        }
        [WebMethod(Description = "6.1.7.2.住院费用明细查询")]
        public string ZYQueryBillDetail(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYQueryBillDetail", param);
            return data;
        }
        [WebMethod(Description = "6.1.7.3.住院预缴金充值")]
        public string ZYAddDeposit(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYAddDeposit", param);
            return data;
        }
        [WebMethod(Description = "6.1.7.4.住院预缴金充值记录查询")]
        public string ZYQueryAddBalanceRecord(string param)
        {
            string data = SqlHelp.ExecutingSql("ZYQueryAddBalanceRecord", param);
            return data;
        }

        [WebMethod(Description = "6.1.8.1.LIS检验报告查询")]
        public string QueryLisBaseInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryLisBaseInfo", param);
            return data;
        }
        [WebMethod(Description = "6.1.8.2.LIS检验报告文件")]
        public string QueryLisPicture(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryLisPicture", param);
            return data;
        }
        [WebMethod(Description = "6.1.8.3.LIS检验报告打印通知")]
        public string PrintPatientLisReport(string param)
        {
            string data = SqlHelp.ExecutingSql("PrintPatientLisReport", param);
            return data;
        }

        [WebMethod(Description = "6.1.9.1.PACS检查报告查询")]
        public string QueryPacsInfo(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryPacsInfo", param);
            return data;
        }
        [WebMethod(Description = "6.1.9.2.PACS检查报告单图片查询")]
        public string QueryPacsPicture(string param)
        {
            string data = SqlHelp.ExecutingSql("QueryPacsPicture", param);
            return data;
        }
        [WebMethod(Description = "6.1.9.3.PACS检查报告打印通知")]
        public string PrintPatientPacsReport(string param)
        {
            string data = SqlHelp.ExecutingSql("PrintPatientPacsReport", param);
            return data;
        }
    }
}
