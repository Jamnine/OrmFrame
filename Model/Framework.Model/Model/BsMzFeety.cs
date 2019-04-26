

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊基础分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsMzFeety:BaseModel
	{   
		 
		private string _code;  //门诊基础分类ID
		
		private string _name;  //门诊基础分类
		
		private string _invItemId;  //发票项目ID
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private string _locationId;  //默认执行科室
		
		private bool _isActive;  //有效标志
		
		private int _orderBy;  //显示顺序
		
		private int _iconIndex;  //图标类型
		
		private string _checkType;  //核算分类
		
		private int _checkOrderby;  //核算分类显示顺序
		
		private string _checkGroup;  //核算分类分组

        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;

        private int _HospitalID;

        /// <summary>
        /// 门诊基础分类ID
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 门诊基础分类
        /// </summary>
        [Collumn(HeaderName = "收费分类", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 发票项目ID
        /// </summary>
        [Collumn(HeaderName = "发票项目", RelatedTableType = typeof(BsInvMzItem))]
        public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 默认执行科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 核算分类
		/// </summary>
		public string CheckType
		{
			get { return _checkType;}
			set { _checkType = value;}
		}                                    
		
		/// <summary>
		/// 核算分类显示顺序
		/// </summary>
		public int CheckOrderby
		{
			get { return _checkOrderby;}
			set { _checkOrderby = value;}
		}                                    
		
		/// <summary>
		/// 核算分类分组
		/// </summary>
		public string CheckGroup
		{
			get { return _checkGroup;}
			set { _checkGroup = value;}
		}
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Moditime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
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


