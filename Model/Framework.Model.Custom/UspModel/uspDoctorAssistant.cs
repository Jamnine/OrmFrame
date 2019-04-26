using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生助理
    /// </summary>
    [Serializable]
    public class uspDoctorAssistant
    {
        /// <summary>
        /// 患者名称
        /// </summary>
        public string PatName { get; set; }

        /// <summary>
        /// 病历号
        /// </summary>
        public string CardNo { get; set; }



        /// <summary>
        /// 收费方式
        /// </summary>
        public string ChargeMode { get; set; }

        /// <summary>
        /// 医生助理
        /// </summary>
        public string DoctorAssistant { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// 结算时间
        /// </summary>
        public string PayTime { get; set; }
    }
}
