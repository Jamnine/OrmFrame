using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 审核状态表
    /// </summary>
    [Serializable]
    public class Auditstate : BaseModel
    {
        /// <summary>
        /// 是否已审核
        /// </summary>
        public int Issign { get; set; }

        /// <summary>
        /// 是否有效标识
        /// </summary>
        public int Isactive { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public int OperTime { get; set; }

        /// <summary>
        /// 审核状态名称
        /// </summary>
        public string Name { get; set; }
    }
}
