

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目三级分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsGroupSub2 : BaseModel
    {   
		 
		private string _subId;  //对应的大类ID
		
		private string _code;  //项目子类
		
		private string _name;  //项目子类名称
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 对应的大类ID
		/// </summary>
		public string SubId
		{
			get { return _subId;}
			set { _subId = value;}
		}                                    
		
		/// <summary>
		/// 项目子类
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 项目子类名称
		/// </summary>
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
		
                                 
		        
	}  
}           


