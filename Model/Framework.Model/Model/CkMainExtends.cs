using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
   public partial class CkMain
    {

        /// <summary>
        /// 体检科室ID
        /// </summary>
        public string TjLocationID { get; set; }

        /// <summary>
        /// 体检科室
        /// </summary>
        public string TjLocationName { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 门诊流水号
        /// </summary>

        public string MzRegId { get; set; }

        /// <summary>
        /// 是否体检小结
        /// </summary>
        public bool IsOver { get; set; }

    }
}
