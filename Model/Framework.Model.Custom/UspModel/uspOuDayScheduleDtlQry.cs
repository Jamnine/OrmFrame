using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 日排班明细就诊统计
    /// </summary>
    [Serializable]
    public class uspOuDayScheduleDtlQry
    {
        private DateTime _scheduleDate;
        private string _doctorId;
        private string _regTypeId;
        private string _timeSpanId;
        private string _timeSpanSubName;
        private string _locationId;
        private string _diagRoomID;
        private int _totalNum;
        private bool _isStop;
        private int _bookLimitNum;
        private int _bookedNum;
        private int _leavingNum;
        private string _timeSpanName;
        private string _doctorName;
        private string _locationName;
        private string _diagRoomName;
        private string _scheduleDtlId;
        private string _scheduleId;
        private string _userCode;

        public uspOuDayScheduleDtlQry()
        {
        }


        /// <summary>  
        /// 出诊日期  
        /// </summary>  
        public DateTime ScheduleDate
        {
            get { return this._scheduleDate; }
            set { this._scheduleDate = value; }
        } 

        /// <summary>  
        ///  医生ID
        /// </summary>  
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        /// <summary>  
        ///   门诊类别ID
        /// </summary>  
        public string RegTypeId
        {
            get { return this._regTypeId; }
            set { this._regTypeId = value; }
        }

        /// <summary>  
        ///   班次ID
        /// </summary>  
        public string TimeSpanId
        {
            get { return this._timeSpanId; }
            set { this._timeSpanId = value; }
        }

        /// <summary>  
        ///  预约时段ID
        /// </summary>  
        public string TimeSpanSubId
        {
            get { return this._timeSpanId; }
            set { this._timeSpanId = value; }
        }

        /// <summary>  
        ///  预约时段名称（如：上午 08：00~09：00）
        /// </summary>  
        public string TimeSpanSubName
        {
            get { return this._timeSpanSubName; }
            set { this._timeSpanSubName = value; }
        }

        /// <summary>  
        ///   诊所ID
        /// </summary>  
        public string LocationId
        {
            get { return this._locationId; }
            set { this._locationId = value; }
        }

        /// <summary>  
        /// 诊室ID
        /// </summary>  
        public string DiagRoomID
        {
            get { return this._diagRoomID; }
            set { this._diagRoomID = value; }
        }

        /// <summary>  
        /// 总号数 （包括可预约总号数）
        /// </summary>  
        public int TotalNum
        {
            get { return this._totalNum; }
            set { this._totalNum = value; }
        }

        /// <summary>  
        /// 可预约总号数  
        /// </summary>  
        public int BookLimitNum
        {
            get { return this._bookLimitNum; }
            set { this._bookLimitNum = value; }
        } 

        /// <summary>  
        ///  是否停诊
        /// </summary>  
        public bool IsStop
        {
            get { return this._isStop; }
            set { this._isStop = value; }
        } 
        /// <summary>
        /// 已预约数
        /// </summary>
        public int BookedNum
        {
            get { return this._bookedNum; }
            set { this._bookedNum = value; }
        }
        /// <summary>
        /// 剩余号数
        /// </summary>
        public int LeavingNum
        {
            get { return this._leavingNum; }
            set { this._leavingNum = value; }
        }
        /// <summary>
        /// 班次名称
        /// </summary>
        public string TimeSpanName
        {
            get { return this._timeSpanName; }
            set { this._timeSpanName = value; }
        }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }
        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        /// <summary>
        /// 诊室名称
        /// </summary>
        public string DiagRoomName
        {
            get { return this._diagRoomName; }
            set { this._diagRoomName = value; }
        }

        /// <summary>
        /// 预约明细时段的ID
        /// </summary>
        public string ScheduleDtlId
        {
            get { return this._scheduleDtlId; }
            set { this._scheduleDtlId = value; }
        }

        /// <summary>
        /// 预约排班ID
        /// </summary>
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        /// <summary>
        /// 医生的Code
        /// </summary>
        public string UserCode
        {
            get { return this._userCode; }
            set { this._userCode = value; }
        }
    }
}
