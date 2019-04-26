using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspBsLocation
    {
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string  GuId { get; set; }
        /// <summary>
        /// 诊所名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        public string EngDesc { get; set; }
        /// <summary>
        /// 省ID
        /// </summary>
        public string ProvinceID { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 市/县ID
        /// </summary>
        public string RegionID { get; set; }
        /// <summary>
        /// 市/县
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 区/县ID
        /// </summary>
        public string AreaID { get; set; }
        /// <summary>
        /// 区/县
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 是否可用.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
