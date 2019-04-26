

using System;
namespace Orm.Model
{
	/// <summary>
	/// 性别 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsSex:BaseModel
	{   
		 
		private string _code;  //性别编码
		
		private string _name;  //性别名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型

        private DateTime _modiTime;//行心云:最后修改时间 

        private string _modiOperId;//行心云:最后修改人

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 性别编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 性别名称
		/// </summary>
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        public DateTime ModiTime
        {
            get{ return this._modiTime; }
            set{this._modiTime = value; }
        }

        /// <summary>
        /// 最后修改人.
        /// </summary>
         public string ModiOperId
        {
            get { return this._modiOperId; }
            set { this._modiOperId = value; }
        }

      
    }  
}           


