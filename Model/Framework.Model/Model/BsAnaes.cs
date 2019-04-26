

using System;
namespace Orm.Model
{
	/// <summary>
	/// 麻醉方法表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsAnaes : BaseModel
    {   
		
		private string _code;  //麻醉编码
		
		private string _name;  //麻醉方法
		
		private string _functionM;  //功能及适应症
		
		private string _effect;  //麻醉效果
		
		private string _tabu;  //禁忌症
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private int _hoSpitalId;  //

        public BsAnaes() { }

		/// <summary>
		/// 麻醉编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 麻醉方法
        /// </summary>
        [Collumn(HeaderName = "麻醉方法", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 功能及适应症
        /// </summary>
        [Collumn(HeaderName = "功能及适应症", RelatedTableType = null)]
        public string FunctionM
		{
			get { return _functionM;}
			set { _functionM = value;}
		}

        /// <summary>
        /// 麻醉效果
        /// </summary>
        [Collumn(HeaderName = "麻醉效果", RelatedTableType = null)]
        public string Effect
		{
			get { return _effect;}
			set { _effect = value;}
		}

        /// <summary>
        /// 禁忌症
        /// </summary>
        [Collumn(HeaderName = "禁忌症", RelatedTableType = null)]
        public string Tabu
		{
			get { return _tabu;}
			set { _tabu = value;}
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
		
	

         private string _memo;
        /// <summary>
        /// 备注
        /// </summary>
        [Collumn(HeaderName = "备注", RelatedTableType = null)]
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
    }  
}           


