

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaDocAuth : BaseModel
    {   
		 
		private string _docId;  //OaDocument.Id
		
		private string _authOperId;  //送审核人
		
		private int _orderBy;  //显示次序
		
		private bool _isAuth;  //是否审核
		
		private DateTime _authOperTime;  //审核日期
		
		private bool _isReject;  //是否拒绝审核
		
		private string _rejectReason;  //拒绝理由
		
		private int _lsReadClass;  //审阅类别
		
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
		/// 送审核人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 是否拒绝审核
		/// </summary>
		public bool IsReject
		{
			get { return _isReject;}
			set { _isReject = value;}
		}                                    
		
		/// <summary>
		/// 拒绝理由
		/// </summary>
		public string RejectReason
		{
			get { return _rejectReason;}
			set { _rejectReason = value;}
		}                                    
		
		/// <summary>
		/// 审阅类别
		/// </summary>
		public int LsReadClass
		{
			get { return _lsReadClass;}
			set { _lsReadClass = value;}
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


