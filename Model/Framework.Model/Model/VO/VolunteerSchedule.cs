using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 志愿者时间管理表
    /// </summary>
    [Serializable]
    public partial class VolunteerSchedule : BaseModel
    {
        /// <summary>
        /// 志愿者
        /// </summary>
        public string Userid { get; set; }
        /// <summary>
        /// 志愿者类别
        /// </summary>
        public string TypeID { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 是否订餐
        /// </summary>
        public int Isbookdinner { get; set; }
        /// <summary>
        /// 志愿时段
        /// </summary>
        public string VolunTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
        public string OperID { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string AuditoperID { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
