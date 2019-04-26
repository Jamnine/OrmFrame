

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkTogether : BaseModel
	{    
		private string _testId1;  //项目代码
		
		private string _testId2;  //项目代码
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 项目代码
		/// </summary>
		public string TestId1
		{
			get { return _testId1;}
			set { _testId1 = value;}
		}                                    
		
		/// <summary>
		/// 项目代码
		/// </summary>
		public string TestId2
		{
			get { return _testId2;}
			set { _testId2 = value;}
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


