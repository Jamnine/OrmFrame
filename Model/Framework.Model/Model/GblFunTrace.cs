

using System;
namespace Orm.Model
{
	/// <summary>
	/// 功能权限修改记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblFunTrace : BaseModel
    {    
		private int _debugMode;  //
		
		private string _funtionId;  //功能
		
		private DateTime _operTime;  //
		
		private string _userID;  //
		
		private string _memo;  //
		
		private string _menuId;  //GblSystemMenu.id
		
		private string _title;  //描述
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 
		/// </summary>
		public int DebugMode
		{
			get { return _debugMode;}
			set { _debugMode = value;}
		}                                    
		
		/// <summary>
		/// 功能
		/// </summary>
		public string FuntionId
		{
			get { return _funtionId;}
			set { _funtionId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			get { return _userID;}
			set { _userID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// GblSystemMenu.id
		/// </summary>
		public string MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
		}                                    
		
		/// <summary>
		/// 描述
		/// </summary>
		public string Title
		{
			get { return _title;}
			set { _title = value;}
		}                                    
		
                                  
		        
	}  
}           


