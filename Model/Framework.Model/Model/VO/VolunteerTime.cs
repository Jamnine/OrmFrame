using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 志愿时段表
    /// </summary>
    [Serializable]
    public class VolunteerTime : BaseModel
    {
        /// <summary>
        /// 是否有效标识
        /// </summary>
        public int Isactive { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 志愿时段名称
        /// </summary>
        public string Name { get; set; }
    }
}
