

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaDocReader : BaseModel
    {   
		 
		private string _docId;  //OaDocument.Id
		
		private string _allowOperId;  //可阅读人
		
		private DateTime _expireTime;  //失效时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
		
		/// <summary>
		/// OaDocument.Id
		/// </summary>
		public string DocId
		{
			get { return _docId;}
			set { _docId = value;}
		}                                    
		
		/// <summary>
		/// 可阅读人
		/// </summary>
		public string AllowOperId
		{
			get { return _allowOperId;}
			set { _allowOperId = value;}
		}                                    
		
		/// <summary>
		/// 失效时间
		/// </summary>
		public DateTime ExpireTime
		{
			get { return _expireTime;}
			set { _expireTime = value;}
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


