using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 日排班信息
    /// </summary>
    [Serializable]
    public class UspOuDaySchedule
    {
        /// <summary>
        /// 主表ID
        /// </summary>
        public string InfoID { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 挂号日期
        /// </summary>
        public DateTime ScheduleDate { get; set; }

        /// <summary>  
        /// 班次ID 
        /// </summary>  
        public string TimeSpanId { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 细表ID
        /// </summary>
        public string DtlID { get; set; }

        /// <summary>  
        /// 时段ID  
        /// </summary>  
        public string TimeSpanSubID { get; set; }

        /// <summary>
        /// 剩余号数
        /// </summary>
        public int RestNum { get; set; }

        /// <summary>
        /// 是否停诊
        /// </summary>
        public bool IsStop { get; set; }

        /// <summary>
        /// 是否使用
        /// </summary>
        public bool IsActive { get; set; }
    }
}
