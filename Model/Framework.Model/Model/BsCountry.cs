

using System;
namespace Orm.Model
{
	/// <summary>
	/// 国家 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsCountry : BaseModel
	{   
		
        private string _code;

        private string _name;  //国家名字
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _upCode;  //行心云:上报码
		
		private string _yBCode;  //行心云:医保码
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //医联体id
		 


        /// <summary>
        /// 国家.
        /// </summary>
        [Collumn(HeaderName = "国家", RelatedTableType = null, Length = 20)]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// 国家名字
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
		
	

        private int _hisType;//HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有

        /// <summary>
        /// HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有
        /// </summary>
        public int HisType
        {
            get
            {
                return this._hisType;
            }
            set
            {
                this._hisType = value;
            }
        }

    }  
}           


