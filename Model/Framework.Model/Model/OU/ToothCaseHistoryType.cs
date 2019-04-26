using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 牙齿历史案例类型
    /// </summary>
    [Serializable]
    public class ToothCaseHistoryType : BaseModel
    {

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 拼音吗
        /// </summary>
        public string PyCode { get; set; }

        /// <summary>
        /// 五毛吗
        /// </summary>
        public string WbCode { get; set; }

        /// <summary>
        /// 父类ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int OrderBy { get; set; }


    }
}
