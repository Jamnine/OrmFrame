

using System;
namespace Orm.Model
{
	/// <summary>
	/// 职称 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsDocLevel : BaseModel
    {   

		private string _code;  //ID
		
		private string _name;  //等级描述
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示次序
		
		private bool _isActive;  //是否有效
		
		private int _iconIndex;  //图标类型

	    private long _recipeLevel; //行心云：医生处方项目级别.

        private string _upCode;  //行心云:上报码

        private string _yBCode;  //行心云:医保码

        private string _modiOperId;  //行心云:最后修改人

        private DateTime _modiTime;  //行心云:最后修改时间

        private int _HospitalID;  //医联体id

        private int iagnosisMoney;
        private int _diagnosismoney;




        /// <summary>
        /// ID
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 等级描述
        /// </summary>
        [Collumn(HeaderName = "医生职称", RelatedTableType = null)]
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
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 行心云:上报码
		/// </summary>
		public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string YBCode
		{
			get { return _yBCode;}
			set { _yBCode = value;}
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

        [Collumn(HeaderName = "诊金", RelatedTableType = null, Length = 10)]
        public int DiagnosisMoney
        {
            get
            {
                return this._diagnosismoney;
            }
            set
            {
                this._diagnosismoney = value;
            }
        }

    }  
}           


