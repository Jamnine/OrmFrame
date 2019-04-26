

using System;
namespace Orm.Model
{
	/// <summary>
	/// 健康档案控件类名 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblElClass:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //控件类名
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
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
		/// 控件类名
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
		
                                
		        
	}  
}           


