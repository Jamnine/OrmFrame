using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 充值卡统计报表
    /// </summary>
    [Serializable]
    public class uspPrepaidCardStatistics
    {
        public uspPrepaidCardStatistics() { }
        /// <summary>
        /// 病人姓名
        /// </summary>
        private string name;
        public string Name { get; set; }
        /// <summary>
        ///  卡号
        /// </summary>
        private string cardNo;
        public string CardNo { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>
        private DateTime operTime;
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 充值方式
        /// </summary>
        private string payWay;
        public string Payway { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public double inCome;
        public double InCome { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        private double payOut;
        public double PayOut { get; set; }
        /// <summary>
        /// 卡余额 
        /// </summary>
        private double balance;
        public double Balance { get; set; }

    }
}
