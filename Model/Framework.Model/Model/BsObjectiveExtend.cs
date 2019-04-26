using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 行心云：复诊目的 - 拓展实体类
    /// </summary>
    public partial class BsObjective : BaseModel
    {
        /// <summary>
        /// 确认的就诊目的 
        /// </summary>
        public bool IsConfirm { get; set; }
    }
}
