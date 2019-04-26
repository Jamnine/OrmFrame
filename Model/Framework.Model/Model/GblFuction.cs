

using System;
namespace Orm.Model
{
	/// <summary>
	/// 菜单功能表 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblFuction : BaseModel
    {    
		private string _menuId;  //窗口
		
		private string _title;  //标题
		
		private string _content;  //功能描述
		
		private string _memo;  //备注
		
		private bool _isTest;  //是否需要测试
		
		private int _lsClass;  //严重等级
		
		private int _orderBy;  //优先级
		
		private string _code;  //编码
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 窗口
		/// </summary>
		public string MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
		}                                    
		
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			get { return _title;}
			set { _title = value;}
		}                                    
		
		/// <summary>
		/// 功能描述
		/// </summary>
		public string Content
		{
			get { return _content;}
			set { _content = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否需要测试
		/// </summary>
		public bool IsTest
		{
			get { return _isTest;}
			set { _isTest = value;}
		}                                    
		
		/// <summary>
		/// 严重等级
		/// </summary>
		public int LsClass
		{
			get { return _lsClass;}
			set { _lsClass = value;}
		}                                    
		
		/// <summary>
		/// 优先级
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
                                 
		        
	}  
}           


