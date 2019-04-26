

using System;
namespace Orm.Model
{
	/// <summary>
	/// 民族 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsNation:BaseModel
	{   
		 
		private string _code;  //民族ID
		
		private string _name;  //民族
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型

        private int _HospitalID;//医院ID 
        private DateTime _moditime;  //最后修改时间 
        private string _yBCode;
        private string _upCode; 
        private string _modioperId;  //最后修改人
         
		/// <summary>
		/// 民族ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 民族
        /// </summary>
        [Collumn(HeaderName = "民族", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
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
        /// 最后修改时间
        /// </summary>
        public DateTime Moditime
        {
            get { return _moditime; }
            set { _moditime = value; }
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modioperId; }
            set { _modioperId = value; }
        }

        /// <summary>
        /// 行心云:医保码
        /// </summary>
        public string YbCode
        {
            get { return _yBCode; }
            set { _yBCode = value; }
        }
        /// <summary>
        /// 行心云:上报码
        /// </summary>
        public string UpCode
        {
            get { return _upCode; }
            set { _upCode = value; }
        }


    }
}           


