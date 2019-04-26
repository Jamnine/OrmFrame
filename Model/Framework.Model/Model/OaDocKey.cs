

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaDocKey : BaseModel
    {   
		 
		private string _docId;  //医生Id,BsDoctor.Id
		
		private string _wordKey;  //文档Key
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DocId
		{
			get { return _docId;}
			set { _docId = value;}
		}                                    
		
		/// <summary>
		/// 文档Key
		/// </summary>
		public string WordKey
		{
			get { return _wordKey;}
			set { _wordKey = value;}
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


