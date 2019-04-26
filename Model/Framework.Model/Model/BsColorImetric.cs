

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:比色 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsColorImetric : BaseModel
    {   
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private DateTime _moditime;  //最后修改时间
		
		private string _modioperId;  //最后修改人
		
		private int _HospitalID;  //医院ID
		  
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
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 最后修改时间
		/// </summary>
		public DateTime Moditime
		{
			get { return _moditime;}
			set { _moditime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
		}                                    
		
	                                    
		        
	}  
}           


