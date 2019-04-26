

using System;
namespace Orm.Model
{
	/// <summary>
	/// 周排班 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsDocRegType : BaseModel
    {   

		private string _doctorId;  //医生代码
		
		private string _regTypeId;  //挂号类别
		
		private string _locationId;  //所属科室
		
		private int _limitNum;  //限号
		
		private DateTime _lastLimitDate;  //最后限号日期
		
		private int _lastLimitNum;  //最后限号数
		
		private bool _isActive;  //是否有效标识
		
		private int _weekDay;  //星期几
		
		private string _timeSpanId;  //班次ID
		
		private string _roomNo;  //诊室
		
		private string _diagroomid;  //诊室对应BsDiagRoom.id
		
		private string _operId;  //操作员Id
		
		private DateTime _operTime;  //登记时间

        private string _upCode;  //行心云:上报码

        private string _yBCode;  //行心云:医保码

        private string _modiOperId;  //行心云:最后修改人

        private DateTime _modiTime;  //行心云:最后修改时间

        private int _HospitalID;  //

        
        /// <summary>
        /// 医生代码
        /// </summary>
        public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 挂号类别
		/// </summary>
		public string RegTypeId
		{
			get { return _regTypeId;}
			set { _regTypeId = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 限号
		/// </summary>
		public int LimitNum
		{
			get { return _limitNum;}
			set { _limitNum = value;}
		}                                    
		
		/// <summary>
		/// 最后限号日期
		/// </summary>
		public DateTime LastLimitDate
		{
			get { return _lastLimitDate;}
			set { _lastLimitDate = value;}
		}                                    
		
		/// <summary>
		/// 最后限号数
		/// </summary>
		public int LastLimitNum
		{
			get { return _lastLimitNum;}
			set { _lastLimitNum = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 星期几
		/// </summary>
		public int WeekDay
		{
			get { return _weekDay;}
			set { _weekDay = value;}
		}                                    
		
		/// <summary>
		/// 班次ID
		/// </summary>
		public string TimeSpanId
		{
			get { return _timeSpanId;}
			set { _timeSpanId = value;}
		}                                    
		
		/// <summary>
		/// 诊室
		/// </summary>
		public string RoomNo
		{
			get { return _roomNo;}
			set { _roomNo = value;}
		}

        /// <summary>
        /// 诊室对应BsDiagRoom.id  DiagRoomId DIAGRoomID
        /// </summary>
        public string DiagRoomId
        {
			get { return _diagroomid;}
			set { _diagroomid = value;}
		}                                    
		
		/// <summary>
		/// 操作员Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}

        /// <summary>
        /// 行心云:上报码
        /// </summary>
        public string UpCode
        {
            get { return _upCode; }
            set { _upCode = value; }
        }

        /// <summary>
        /// 行心云:医保码
        /// </summary>
        public string YBCode
        {
            get { return _yBCode; }
            set { _yBCode = value; }
        }

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        public string ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }




    }
}           


