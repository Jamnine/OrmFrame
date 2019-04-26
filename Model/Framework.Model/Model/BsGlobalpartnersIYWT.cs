using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 全球医疗合作伙伴信息_医务通APP接口 - 实体类
    /// </summary>
    [Serializable]
    public class BsGlobalpartnersIYWT : BaseModel
    {
        /// <summary>
        /// 合作伙伴编码
        /// </summary>
        public string Partner_sn { get; set; }
        /// <summary>
        /// 合作伙伴
        /// </summary>
        public string Partner { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string LAT { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string LNG { get; set; }
    }
}
