using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 志愿者文件表
    /// </summary>
    [Serializable]
    public class VolunteerFiles : BaseModel
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Route { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 志愿时间表的guid
        /// </summary>
        public string TeerTimeid { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get; set; }
    }
}
