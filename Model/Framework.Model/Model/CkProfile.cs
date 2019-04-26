

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验套餐表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkProfile:BaseModel
	{   
		 
		private string _profileId = string.Empty;  //套餐ID,对应CkItem.Id
		
		private string _testId=string.Empty;  //明细ID,对应CkItem.Id
		
		private string _itemId = string.Empty;  //收费项目ID
		
		private string _sourceId = string.Empty;  //标本类型
		
		private string _tubeTypeId = string.Empty;  //容器类型
		
		private string _itemCode = string.Empty;  //CkItem.Code
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 套餐ID,对应CkItem.Id
		/// </summary>
		public string ProfileId
		{
			get { return _profileId;}
			set { _profileId = value;}
		}                                    
		
		/// <summary>
		/// 明细ID,对应CkItem.Id
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 收费项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 标本类型
		/// </summary>
		public string SourceId
		{
			get { return _sourceId;}
			set { _sourceId = value;}
		}                                    
		
		/// <summary>
		/// 容器类型
		/// </summary>
		public string TubeTypeId
		{
			get { return _tubeTypeId;}
			set { _tubeTypeId = value;}
		}                                    
		
		/// <summary>
		/// CkItem.Code
		/// </summary>
		public string ItemCode
		{
			get { return _itemCode;}
			set { _itemCode = value;}
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


