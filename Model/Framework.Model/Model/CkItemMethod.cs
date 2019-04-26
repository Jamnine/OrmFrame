

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkItemMethod : BaseModel
	{   
		
		private string _testId;  //项目代码
		
		private string _method;  //检验方法名称
		
		private int _orderby;  //排序
		
		private bool _isAuthed;  //已经封存，不可改删
		 
		
		/// <summary>
		/// 项目代码
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 检验方法名称
		/// </summary>
		public string Method
		{
			get { return _method;}
			set { _method = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int Orderby
		{
			get { return _orderby;}
			set { _orderby = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		        
	}  
}           


