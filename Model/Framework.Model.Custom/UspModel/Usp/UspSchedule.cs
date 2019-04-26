using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 排班
    /// </summary>
    [Serializable]

    public class UspSchedule
    {
        /// <summary>
        /// 日排班主表
        /// </summary>
        public OuDocRegType Schedule { get; set; }

        /// <summary>
        /// 日排班明细
        /// </summary>
        public List<OuDocSpanSub> ScheduleDtl { get; set; }
    }
}
