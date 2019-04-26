using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 分组类
    /// </summary>
    public class ComputeSummary
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 总和
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// 平均值
        /// </summary>
        public decimal Avg { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        public decimal Max { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        public decimal Min { get; set; }

        /// <summary>
        /// 分组个数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 分组Key值
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        public string LimitGroupId { get; set; }

        public double LimitFee { get; set; }

        public string DocLevId { get; set; }

        public string GroupBy { get; set; }
    }
}
