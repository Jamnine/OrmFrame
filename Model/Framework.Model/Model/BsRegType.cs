

using System;
namespace Orm.Model
{
	/// <summary>
	/// 挂号类别 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRegType:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //挂号类别名称
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效
		
		private int _iconIndex;  //图标类型
		
		private string _specdiagfeeitemID;  //行心云:收哪个费用ID
		
		private double _price;  //行心云:单价
		
		private bool _isupdateinchrage;  //行心云:F2是否收费还可修改信息
		
		private string _modioperID;  //行心云:最后修改人
		
		private DateTime _moditime;  //行心云:最后修改时间
		
		private bool _isdefault;  //行心云:F1默认这个类别
		
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
        /// 挂号类别名称
        /// </summary>
        [Collumn(HeaderName = "挂号类别", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 排序
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
		/// 行心云:收哪个费用ID
		/// </summary>
		public string SpecdiagfeeitemID
		{
			get { return _specdiagfeeitemID;}
			set { _specdiagfeeitemID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F2是否收费还可修改信息
		/// </summary>
		public bool Isupdateinchrage
		{
			get { return _isupdateinchrage;}
			set { _isupdateinchrage = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperID
		{
			get { return _modioperID;}
			set { _modioperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime Moditime
		{
			get { return _moditime;}
			set { _moditime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1默认这个类别
		/// </summary>
		public bool Isdefault
		{
			get { return _isdefault;}
			set { _isdefault = value;}
		}                                    
		
	                                 
		        
	}  
}           


