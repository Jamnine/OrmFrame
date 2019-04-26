using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 加工统计表
    /// </summary>
    [Serializable]
    public class UspWorksheetStatistics : BaseModel
    {
        public UspWorksheetStatistics() { }

        /// <summary>
        /// 加工商
        /// </summary>
        public string ProcessingFactory { get; set; }

        /// <summary>
        /// 患者
        /// </summary>
        public string Patient { get; set; }

        /// <summary>
        /// 档案编号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 应收,消费金额
        /// </summary>
        public double Receivables { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary> 
        public double CurrentPay { get; set; }

        /// <summary>
        /// 牙位
        /// </summary>
        public string ToothPosition { get; set; }

        /// <summary>
        /// 加工数量
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 加工单价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 加工费用
        /// </summary>
        public double PriceIn { get; set; }
        /// <summary>
        /// 送件日期
        /// </summary>
        public DateTime SendTime { get; set; }
        /// <summary>
        /// 取件日期
        /// </summary>
        public DateTime GetOuTime { get; set; }
        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 保修期
        /// </summary>
        public int RepairType { get; set; }

    }
}
