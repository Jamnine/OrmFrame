using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 挂号时 需要的参数
    /// </summary>
    [Serializable]
    public class PMRegistration
    {

        /// <summary>
        /// 医生诊金
        /// </summary>
        public int DiagnosisMoney { get; set; }

        /// <summary>
        /// 收费明细
        /// </summary>
        public OuInvoiceDtl ouInvoiceDtl = new OuInvoiceDtl();

        /// <summary>
        /// 收费 
        /// </summary>
        public OuInvoice ouInvoice = new OuInvoice();

        /// <summary>
        /// 病人信息
        /// </summary>
        public BsPatient bsPatient = new BsPatient();

        /// <summary>
        /// 挂号信息
        /// </summary>
        public OuHosInfo ouHosInfo = new OuHosInfo();

        /// <summary>
        /// 客户电脑名称
        /// </summary>
        public string HostName { get; set; }             //客户电脑名称

        /// <summary>
        /// 客户电脑GUID
        /// </summary>
        public string ClientComputerGuid { get; set; }       //客户电脑GUID

        /// <summary>
        /// 是否收取门诊专家挂号费用 /并进行打印
        /// </summary>
        public bool IsDiagnosisOf { get; set; }

        /// <summary>
        /// 挂号ID
        /// </summary>
        public int OuHosInfoID { get; set; }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo { get; set; }
    }
}
