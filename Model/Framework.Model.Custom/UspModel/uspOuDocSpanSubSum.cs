using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    
    public class uspOuDocSpanSubSum
    {
        /// <summary>
        /// 职称
        /// </summary>
        public virtual String DocName { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public virtual String SpanSubName { get; set; }

        /// <summary>
        /// 星期一
        /// </summary>

        public virtual String Monday { get; set; }

        /// <summary>
        /// 星期二
        /// </summary>

        public virtual String Tuesday { get; set; }

        /// <summary>
        /// 星期三
        /// </summary>

        public virtual String Wednesday { get; set; }
        /// <summary>
        /// 星期四
        /// </summary>

        public virtual String Thursday { get; set; }
        /// <summary>
        /// 星期五
        /// </summary>

        public virtual String Friday { get; set; }
        /// <summary>
        /// 星期六
        /// </summary>

        public virtual String Saturday { get; set; }
        /// <summary>
        /// 星期日
        /// </summary>

        public virtual String Sunday { get; set; }
    }
}
