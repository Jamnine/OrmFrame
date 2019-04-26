

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 功能权限修改记录 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblFunTrace : BaseModel
    {   
		
		private int _id;  //
		
		private int _debugMode;  //
		
		private int _funtionId;  //功能
		
		private DateTime _operTime;  //
		
		private int _userID;  //
		
		private string _memo;  //
		
		private int _menuId;  //GblSystemMenu.id
		
		private string _title;  //描述
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
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
		public int FuntionId
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
		public int UserID
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
		public int MenuId
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
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


