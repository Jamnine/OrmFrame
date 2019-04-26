using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class ApiDrugInfo
    {
        /// <summary>
        /// 票据号码
        /// </summary>
        public string order_id { get; set; }

        /// <summary>
        /// 状态 =send 标识已发
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public string creater { get; set; }

        /// <summary>
        /// 发药时间
        /// </summary>
        public DateTime? createtime { get; set; }
    }
}
