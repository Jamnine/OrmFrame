using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生日排班信息
    /// </summary>
    [Serializable]
    public class uspOuDayScheduleQry : BaseModel
    {
        private DateTime _scheduleDate;
        private string _weekPlanID;
        private string _doctorId;
        private string _regTypeId;
        private string _timeSpanId;
        private string _locationId;
        private string _diagRoomID;
        private int _totalNum;
        private DateTime _operTime;
        private string _operId;
        private string _stopOperID;
        private string _deletedOperID;
        private DateTime _deleteTime;
        private bool _isStop;
        private bool _isActive = true;
        private int _bookLimitNum;
        private int _bookedNum;
        private int _leavingbookedNum;

        private int _limitNum;
        private int _resNum;

        private int _leavingNum;
        private string _timeSpanName;
        private string _doctorName;
        private string _locationName;
        private string _diagRoomName;
        private bool _isDoctor;
        private string _doctorLevel;
        private string _beginTime;
        private string _endTime;
        private double _registrationFee;

        public uspOuDayScheduleQry()
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
        /// 对应周排班模板的ID  
        /// </summary>  
        public string WeekPlanID
        {
            get { return this._weekPlanID; }
            set { this._weekPlanID = value; }
        }

        /// <summary>  
        ///   医生ID
        /// </summary>  
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        /// <summary>  
        ///   挂号类别
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
        ///诊所ID
        /// </summary>  
        public string LocationId
        {
            get { return this._locationId; }
            set { this._locationId = value; }
        }

        /// <summary>  
        /// 诊室id
        /// </summary>  
        public string DiagRoomID
        {
            get { return this._diagRoomID; }
            set { this._diagRoomID = value; }
        }

        /// <summary>  
        /// 总号数  
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
        ///   操作时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        ///   操作人ID
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 停诊人  
        /// </summary>  
        public string StopOperID
        {
            get { return this._stopOperID; }
            set { this._stopOperID = value; }
        }

        /// <summary>  
        /// 删除人  
        /// </summary>  
        public string DeletedOperID
        {
            get { return this._deletedOperID; }
            set { this._deletedOperID = value; }
        }

        /// <summary>  
        /// 删除时间  
        /// </summary>  
        public DateTime DeleteTime
        {
            get { return this._deleteTime; }
            set { this._deleteTime = value; }
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
        ///   是否可用
        /// </summary>  
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
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
        /// 已预约数
        /// </summary>
        public int RegistrationNumber
        {
            get { return this._bookedNum; }
            set { this._bookedNum = value; }
        }


        /// <summary>
        ///剩余预约号数
        /// </summary>
        public int LeavingNum
        {
            get { return this._leavingNum; }
            set { this._leavingNum = value; }
        }


        /// <summary>
        ///  剩余号数
        /// </summary>
        public int LeavingbookedNum
        {
            get { return this._leavingbookedNum; }
            set { this._leavingbookedNum = value; }
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
		/// 预约号数
		/// </summary>
		public int ResNum
        {
            get { return _resNum; }
            set { _resNum = value; }
        }



        /// <summary>
        /// 限号
        /// </summary>
        public int LimitNum
        {
            get { return _limitNum; }
            set { _limitNum = value; }
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
        /// 是否医生
        /// </summary>
        public bool IsDoctor
        {
            get { return this._isDoctor; }
            set { this._isDoctor = value; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime
        {
            get { return this._beginTime; }
            set { this._beginTime = value; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        /// <summary>
        ///挂号费
        /// </summary>
        public double RegistrationFee
        {
            get { return this._registrationFee; }
            set { this._registrationFee = value; }
        }

        /// <summary>
        /// 医生等级
        /// </summary>
        public string DoctorLevel
        {
            get { return this._doctorLevel; }
            set { this._doctorLevel = value; }
        }
    }
}
