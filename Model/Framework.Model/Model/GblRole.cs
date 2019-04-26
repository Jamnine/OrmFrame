

using System;
namespace Orm.Model
{
	/// <summary>
	/// 角色 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblRole : BaseModel
    {   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private bool _isActive;  //是否有效标识
		
		private int _orderBy;  //排序
		
		private int _iconIndex;  //图标类型
		
		private string _groupName;  //一级分组
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //
		 
                                  
		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "角色", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 排序
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
		/// 一级分组
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		


        private int _hisType;
        /// <summary>
        /// 系统产品类型 0 公共，1 his， 2 行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }
        
    }  
}           


