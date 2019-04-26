using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Model
{
    /// <summary>
    /// 行心云:患者划价表 - 实体拓展类
    /// </summary>

    public partial class PatPricereCords : BaseModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive { get; set; }
    }
}
