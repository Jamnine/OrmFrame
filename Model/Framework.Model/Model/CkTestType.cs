

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkTestType:BaseModel
	{   
		 
		private string _code;  //检查分类ID
		
		private string _name;  //检查分类
		
		private string _testGroupId;  //页分类
		
		private bool _isLab;  //是否检验室项目
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _groupMain;  //一级分组
		
		private string _groupSub;  //二级分组		

        private string _modioperId;//行心修改人

        private DateTime _moditime;//修改时间

        private bool _isAutomaticSummary;//是否自动小结

        /// <summary>
        /// 检查分类ID
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 检查分类
        /// </summary>
        [Collumn(HeaderName = "检验项目分类", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 检验分组
        /// </summary>
        [Collumn(HeaderName = "检验分组", RelatedTableType = typeof(CkTestGroup))]
        public string TestGroupId
		{
			get { return _testGroupId;}
			set { _testGroupId = value;}
		}

        /// <summary>
        /// 是否检验室项目
        /// </summary>
        [Collumn(HeaderName = "是否检验室项目", RelatedTableType = null)]
        public bool IsLab
		{
			get { return _isLab;}
			set { _isLab = value;}
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
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
		}                                    
		
		/// <summary>
		/// 二级分组
		/// </summary>
		public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}                                    
		
	

        /// <summary>
        /// 行心修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modioperId; }
            set { _modioperId = value; }
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Moditime
        {
            get { return _moditime; }
            set { _moditime = value; }
        }

        /// <summary>
        /// 是否自动小结
        /// </summary>
        public bool IsAutomaticSummary
        {
            get { return _isAutomaticSummary; }
            set { _isAutomaticSummary = value; }
        }


    }  
}           


