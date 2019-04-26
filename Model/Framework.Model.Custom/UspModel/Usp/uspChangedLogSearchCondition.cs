using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 修改日志查询条件
    /// </summary>
    [Serializable]
    public class uspChangedLogSearchCondition
    {
        public uspChangedLogSearchCondition(){}
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime TimeBegin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime TimeEnd { get; set; }

        /// <summary>
        /// 操作模块
        /// </summary>
        public string TableDesc { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public string OperId { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        public int HospitalId { get; set; }
    }
}
