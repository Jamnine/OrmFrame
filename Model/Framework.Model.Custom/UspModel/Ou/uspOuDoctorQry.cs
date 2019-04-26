//by lwl
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生扩展类
    /// </summary>
    [Serializable]
    public class uspOuDoctorQry : BaseModel  
    {
       
        /// <summary>
        /// 科室id
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }
         
        /// <summary>
        /// 挂号类别
        /// </summary>
        public string RegTypeId
        {
            get;
            set;
        } 
        
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string  LocationId
        {
            get;
            set;
        } 
        
        /// <summary>
        /// 班次ID
        /// </summary>
        public string TimeSpanId
        {
            get;
            set;
        }

        public int HospitalId { get; set; }   
        /// <summary>
        /// 停诊标志（取消）
        /// </summary>
        public bool IsCancel { get; set; }


        private DateTime _scheduleDate;
        /// <summary>
        /// 出诊日期
        /// </summary>
        public DateTime ScheduleDate
        {
            get { return _scheduleDate; }
            set { this._scheduleDate = value; }
        }

        private string _timeBegin;  //开始时间

        private string _timeEnd;  //结束时间

        /// <summary>
        /// 开始时间
        /// </summary>
        public string TimeBegin
        {
            get { return _timeBegin; }
            set { _timeBegin = value; }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string TimeEnd
        {
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }
 
        /// <summary>
        /// 班次ID
        /// </summary>
        public string OuDocRegTypeGUID
    {
            get;
            set;
        }

        /// <summary>
        /// 周排班计划ID
        /// </summary>
        public string WeekPlanID { get; set; }
        public string RoleId { get; set; }
    }
}

