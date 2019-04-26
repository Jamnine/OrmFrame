using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    public partial class OuDocRegType:BaseModel
    {
        private DateTime _scheduleDate;
         

        /// <summary>
        /// 出诊日期
        /// </summary>
        public DateTime ScheduleDate
        {
            get { return _scheduleDate; }
            set { this._scheduleDate = value; }
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive
        {
            get;set;
        }
    }
}
