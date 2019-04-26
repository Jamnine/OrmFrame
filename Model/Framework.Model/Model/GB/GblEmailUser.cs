

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 信息接收人 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEmailUser : BaseModel
    {   
		
		
		
		private int _emailId;  //信息GblEmail.ID
		
		private int _operId;  //操作员ID
		
		private bool _isRead;  //是否已阅读
		
		private DateTime _readTime;  //阅读时间
		
		private bool _isAuth;  //是否审核
		
		private int _authOperId;  //审核人
		
		private string _feedback;  //反馈意见
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 信息GblEmail.ID
		/// </summary>
		public int EmailId
		{
			get { return _emailId;}
			set { _emailId = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public int OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否已阅读
		/// </summary>
		public bool IsRead
		{
			get { return _isRead;}
			set { _isRead = value;}
		}                                    
		
		/// <summary>
		/// 阅读时间
		/// </summary>
		public DateTime ReadTime
		{
			get { return _readTime;}
			set { _readTime = value;}
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
		/// 审核人
		/// </summary>
		public int AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 反馈意见
		/// </summary>
		public string Feedback
		{
			get { return _feedback;}
			set { _feedback = value;}
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


