using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 行心云：电子病历主表信息 - 实体拓展类
    /// </summary>
    public partial class ToothEmr
    {
        /// <summary>
        /// 既往史
        /// </summary>
        public string PersonHistory { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
    }
}
