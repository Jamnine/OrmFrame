

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊医生日排班 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDocRegType : BaseModel
	{   
		 
		private DateTime _regDate;  //星期几
		
		private string _weekPlanId;  //对应周计划的ID
		
		private string _doctorId;  //医生代码
		
		private string _regTypeId;  //挂号类别
		
		private string _timeSpanId;  //班次ID,BsRegTimeSpan
		
		private string _locationId;  //所属科室
		
		private string _diagRoomId;  //诊间
		
		private int _limitNum;  //限号
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private bool _isCancel;  //是否作废
		
		private int _lastLimitNum;  //
		
		private int _regNum;  //挂号数
		
		private int _resNum;  //预约号数
		
		private bool _isSpecial;  //是否日排班
		
		private string _cancelOperId;  //停诊人
		
		private DateTime _cancelOperTime;  //停诊时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        private string _deletedOperID; // 删除人iD

        private DateTime _deleteTime; // 删除时间

        private bool _isStop; // 是否停用

        private int _isDoctor; // 



        /// <summary>
        /// 星期几
        /// </summary>
        public DateTime RegDate
		{
			get { return _regDate;}
			set { _regDate = value;}
		}                                    
		
		/// <summary>
		/// 对应周计划的ID
		/// </summary>
		public string WeekPlanId
		{
			get { return _weekPlanId;}
			set { _weekPlanId = value;}
		}                                    
		
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
		/// 班次ID,BsRegTimeSpan
		/// </summary>
		public string TimeSpanId
		{
			get { return _timeSpanId;}
			set { _timeSpanId = value;}
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
		/// 诊间
		/// </summary>
		public string DiagRoomId
		{
			get { return _diagRoomId;}
			set { _diagRoomId = value;}
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
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LastLimitNum
		{
			get { return _lastLimitNum;}
			set { _lastLimitNum = value;}
		}                                    
		
		/// <summary>
		/// 挂号数
		/// </summary>
		public int RegNum
		{
			get { return _regNum;}
			set { _regNum = value;}
		}                                    
		
		/// <summary>
		/// 预约号数
		/// </summary>
		public int ResNum
		{
			get { return _resNum;}
			set { _resNum = value;}
		}                                    
		
		/// <summary>
		/// 是否日排班
		/// </summary>
		public bool IsSpecial
		{
			get { return _isSpecial;}
			set { _isSpecial = value;}
		}                                    
		
		/// <summary>
		/// 停诊人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 停诊时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                 
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                   
		

        // 删除人ID
        public string DeletedOperId
        {
           get { return _deletedOperID;}
           set { _deletedOperID = value;}
        }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DeleteTime
        {
            get { return _deleteTime; }
            set { _deleteTime = value; }
        }

        /// <summary>
        /// 是否停诊
        /// </summary>
        public bool IsStop
        {
            get { return this._isStop; }
            set { this._isStop = value; }
        }

        /// <summary>
        /// 是否医生
        /// </summary>
         public int IsDoctor
        {
            get { return this._isDoctor; }
            set { this._isDoctor = value; }
        }
    }  
}           


