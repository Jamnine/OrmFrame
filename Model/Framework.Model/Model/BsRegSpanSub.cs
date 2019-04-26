

using System;
namespace Orm.Model
{
	/// <summary>
	/// 排班时间段类型 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRegSpanSub:BaseModel
	{    
		private string _code;  //唯一标识
		
		private string _name;  //班次
		
		private string _timeBegin;  //开始时间
		
		private string _timeEnd;  //结束时间
		
		private bool _isActive;  //是否有效
		
		private int _iconIndex;  //图标类型
		
		private string _timeSpanId;  //班次ID,对应BsRegTimeSpan.Id
		
		private int _noSource;  //时间段的号源数
		
		private string _ybcode;  //行心云:医保码
		
		private string _modioperID;  //行心云:最后修改人
		
		private DateTime _moditime;  //行心云:最后修改时间
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 唯一标识
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 班次
        /// </summary>
        [Collumn(HeaderName = "班次", RelatedTableType = null, Length = 50)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 开始时间
        /// </summary>
        [Collumn(HeaderName = "开始时间", RelatedTableType = null, Length = 5)]
        public string TimeBegin
		{
			get { return _timeBegin;}
			set { _timeBegin = value;}
		}

        /// <summary>
        /// 结束时间
        /// </summary>
        [Collumn(HeaderName = "结束时间", RelatedTableType = null, Length = 5)]
        public string TimeEnd
		{
			get { return _timeEnd;}
			set { _timeEnd = value;}
		}                                    
		
		/// <summary>
		/// 是否有效
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 班次ID,对应BsRegTimeSpan.GUID
        /// </summary>
        [Collumn(HeaderName = "时间段", RelatedTableType = typeof(BsRegTimeSpan))]
        public string TimeSpanId
		{
			get { return _timeSpanId;}
			set { _timeSpanId = value;}
		}                                    
		
		/// <summary>
		/// 时间段的号源数
		/// </summary>
		public int NoSource
		{
			get { return _noSource;}
			set { _noSource = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string Ybcode
		{
			get { return _ybcode;}
			set { _ybcode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperID
		{
			get { return _modioperID;}
			set { _modioperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime Moditime
		{
			get { return _moditime;}
			set { _moditime = value;}
		}                                    
		
	                                   
		        
	}  
}           


