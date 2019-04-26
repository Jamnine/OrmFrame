using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 会员充值
    /// </summary>
    [Serializable]
    public class uspOuRechargeQry : BaseModel
    {
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

 

        /// <summary>
        /// 充值总额
        /// </summary>
        public double RechargeAmount { get; set; }

        /// <summary>
        /// 总支出
        /// </summary>
        public double AE { get; set; }

        /// <summary>
        /// 总余额
        /// </summary>
        public double TotalBalance { get; set; }

        /// <summary>
        /// 总积分
        /// </summary>
        public double TotalIntegral { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        public string VIPCardName { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VIPCardNo { get; set; }

        /// <summary>
        /// 开卡时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否持卡人
        /// </summary>
        public bool IsCardHolder { get; set; }
        /// <summary>
        /// 特殊病人
        /// </summary>
        public bool IsHideIllness { get; set; }
    }
}
