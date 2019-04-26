

using System;
namespace Orm.Model
{
	/// <summary>
	/// 排班班次表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRegTimeSpan:BaseModel
	{   
		 
		private string _code;  //ID
		
		private string _name;  //班次
		
		private string _timeBegin;  //开始时间
		
		private string _timeEnd;  //结束时间
		
		private bool _isActive;  //是否有效
		
		private int _iconIndex;  //图标类型
		
		private bool _isNotlimit;  //是否允许班次时间段外挂号
		
		private string _modioperID;  //行心云:最后修改人
		
		private DateTime _moditime;  //行心云:最后修改时间
		
		private bool _isspanday;  //行心云:F1是否跨天
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 班次
        /// </summary>
        [Collumn(HeaderName = "班次", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 开始时间
        /// </summary>
        [Collumn(HeaderName = "开始时间", RelatedTableType = null)]
        public string TimeBegin
		{
			get { return _timeBegin;}
			set { _timeBegin = value;}
		}

        /// <summary>
        /// 结束时间
        /// </summary>
        [Collumn(HeaderName = "结束时间", RelatedTableType = null)]
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
		/// 是否允许班次时间段外挂号
		/// </summary>
		public bool IsNotlimit
		{
			get { return _isNotlimit;}
			set { _isNotlimit = value;}
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

        /// <summary>
        /// 行心云:F1是否跨天
        /// </summary>
        [Collumn(HeaderName = "是否跨天", RelatedTableType = null)]
        public bool Isspanday
		{
			get { return _isspanday;}
			set { _isspanday = value;}
		}                                    
		
	                                   
		        
	}  
}           


