

using System;
namespace Orm.Model
{
	/// <summary>
	/// 科室核算费用分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsHsFeety : BaseModel
    {   
		
		
		
		private string _code;  //核算收据类别
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private string _name;  //科室核算类别
		
		private string _locationId;  //默认的执行科室
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private bool _isDrug;  //是否药品
		
		private int _HospitalID;  //
		 

		
	                               
		
		/// <summary>
		/// 核算收据类别
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
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
		/// 科室核算类别
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 默认的执行科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// 是否药品
		/// </summary>
		public bool IsDrug
		{
			get { return _isDrug;}
			set { _isDrug = value;}
		}                                    
		
	

        private int _hisType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public int HisType
        {
            get
            {
                return _hisType;
            }

            set
            {
                _hisType = value;
            }
        }
        private DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }
    }  
}           


