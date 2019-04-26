using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VolunteerSchedule
    {
        /// <summary>
        /// 志愿者名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 志愿者类别名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 志愿时段名称
        /// </summary>
        public string VolunTimeName { get; set; }

        /// <summary>
        /// 添加人名称
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 审核人名称
        /// </summary>
        public string AuditoperName { get; set; }
    }
}
