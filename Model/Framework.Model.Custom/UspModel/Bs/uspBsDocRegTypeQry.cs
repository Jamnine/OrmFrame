using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生排班信息
    /// </summary>
    [Serializable]
    public class uspBsDocRegTypeQry : BaseModel
    {
        private string _doctorId;
        private string _regTypeId;
        private string _locationId;
        private int _limitNum;
        private DateTime _lastLimitDate;
        private int _lastLimitNum;
        private int _weekDay;
        private string _timeSpanId;
        private string _operId;
        private DateTime _operTime;
        private string _dIAGRoomID;
        private bool _isActive;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;
        private string _locationName;
        private string _doctorName;
        private string _timeSpanName;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public uspBsDocRegTypeQry()
        {
        }

        /// <summary>
        /// 医生代码.
        /// </summary>
        public string DoctorId
        {
            get
            {
                return this._doctorId;
            }
            set
            {
                this._doctorId = value;
            }
        }

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;
            }
        }

        /// <summary>
        /// 挂号类别.
        /// </summary>
        public string RegTypeId
        {
            get
            {
                return this._regTypeId;
            }
            set
            {
                this._regTypeId = value;
            }
        }

        /// <summary>
        /// 所属科室.
        /// </summary>
        public string LocationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string LocationName
        {
            get
            {
                return this._locationName;
            }
            set
            {
                this._locationName = value;
            }
        }

        /// <summary>
        /// 限号.
        /// </summary>
        public int LimitNum
        {
            get
            {
                return this._limitNum;
            }
            set
            {
                this._limitNum = value;
            }
        }

        /// <summary>
        /// 最后限号日期.
        /// </summary>
        public DateTime LastLimitDate
        {
            get
            {
                return this._lastLimitDate;
            }
            set
            {
                this._lastLimitDate = value;
            }
        }

        /// <summary>
        /// 最后限号数.
        /// </summary>
        public int LastLimitNum
        {
            get
            {
                return this._lastLimitNum;
            }
            set
            {
                this._lastLimitNum = value;
            }
        }

        /// <summary>
        /// 星期几.
        /// </summary>
        public int WeekDay
        {
            get
            {
                return this._weekDay;
            }
            set
            {
                this._weekDay = value;
            }
        }

        /// <summary>
        /// 班次ID.
        /// </summary>
        public string TimeSpanId
        {
            get
            {
                return this._timeSpanId;
            }
            set
            {
                this._timeSpanId = value;
            }
        }

        /// <summary>
        /// 班次
        /// </summary>
        public string TimeSpanName
        {
            get
            {
                return this._timeSpanName;
            }
            set
            {
                this._timeSpanName = value;
            }
        }

        /// <summary>
        /// 登记人.
        /// </summary>
        public string OperId
        {
            get
            {
                return this._operId;
            }
            set
            {
                this._operId = value;
            }
        }

        /// <summary>
        /// 登记时间.
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return this._operTime;
            }
            set
            {
                this._operTime = value;
            }
        }

        /// <summary>
        /// 诊室.
        /// </summary>
        public string DIAGRoomID
        {
            get
            {
                return this._dIAGRoomID;
            }
            set
            {
                this._dIAGRoomID = value;
            }
        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }

        /// <summary>
        /// 最后修改人.
        /// </summary>
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }

        /// <summary>
        /// 医保码.
        /// </summary>
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode = value;
            }
        }

        /// <summary>
        /// 上报码.
        /// </summary>
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode = value;
            }
        }
        /// <summary>
        /// 诊所id
        /// </summary>
        public int HospitalId { get; set; }
    }
}
