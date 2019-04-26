

using System;
namespace Orm.Model
{
	/// <summary>
	/// 标本对应用血 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLabBood : BaseModel
	{   
		 
		private string _labId;  //标本Id,CkLab.Id
		
		private string _bdBankId;  //血库Id,CkBdBank.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 标本Id,CkLab.Id
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 血库Id,CkBdBank.Id
		/// </summary>
		public string BdBankId
		{
			get { return _bdBankId;}
			set { _bdBankId = value;}
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


