

using System;
namespace Orm.Model
{
	/// <summary>
	/// 单位 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUnit:BaseModel
	{   
		 
		private string _code;  //单位ID
		
		private string _name;  //单位
		
		private string _printName;  //打印/显示名
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
        private DateTime _modiTime;
        private string _modiOperId;
        private int _HospitalID;//医院ID
         
        /// <summary>
        /// 单位ID
        /// </summary>
        [Collumn(HeaderName = "单位编码", RelatedTableType = null, Length = 6)]
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}
        /// <summary>
        /// 最后修改时间.
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
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
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
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
        /// 单位
        /// </summary>
        [Collumn(HeaderName = "单位", RelatedTableType = null, Length = 50)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 打印/显示名
        /// </summary>
        [Collumn(HeaderName = "打印/显示名", RelatedTableType = null)]
        public string PrintName
		{
			get { return _printName;}
			set { _printName = value;}
		}

        /// <summary>
        /// 五笔码
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}

        /// <summary>
        /// 拼音码
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
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
		        
	}  
}           


