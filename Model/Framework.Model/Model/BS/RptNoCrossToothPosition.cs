using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public partial class RptNoCrossToothPosition : BaseModel{
        /// <summary>
        /// 牙位
        /// </summary>
        public string ToothPosition { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 来源 如检查、诊断
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 是否洗牙
        /// </summary>
        public bool IsClearTooths { get; set; }
    }
}
