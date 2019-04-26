

using System;
namespace Orm.Model
{
	/// <summary>
	/// 发血表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBloodSend : BaseModel
	{   
		
		
		private string _recNo;  //申请单号
		
		private string _labId;  //标本号
		
		private string _bloodId;  //血袋ID
		
		private DateTime _noteTime;  //通知时间
		
		private string _noteOperId;  //通知人
		
		private bool _isSend;  //是否发出
		
		private DateTime _sendTime;  //发出时间
		
		private string _sendOperId;  //发出人
		
		private string _takeMan;  //取血者
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //



        /// <summary>
        /// 申请单号
        /// </summary>
        public string RecNo
		{
			get { return _recNo;}
			set { _recNo = value;}
		}                                    
		
		/// <summary>
		/// 标本号
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 血袋ID
		/// </summary>
		public string BloodId
		{
			get { return _bloodId;}
			set { _bloodId = value;}
		}                                    
		
		/// <summary>
		/// 通知时间
		/// </summary>
		public DateTime NoteTime
		{
			get { return _noteTime;}
			set { _noteTime = value;}
		}                                    
		
		/// <summary>
		/// 通知人
		/// </summary>
		public string NoteOperId
		{
			get { return _noteOperId;}
			set { _noteOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否发出
		/// </summary>
		public bool IsSend
		{
			get { return _isSend;}
			set { _isSend = value;}
		}                                    
		
		/// <summary>
		/// 发出时间
		/// </summary>
		public DateTime SendTime
		{
			get { return _sendTime;}
			set { _sendTime = value;}
		}                                    
		
		/// <summary>
		/// 发出人
		/// </summary>
		public string SendOperId
		{
			get { return _sendOperId;}
			set { _sendOperId = value;}
		}                                    
		
		/// <summary>
		/// 取血者
		/// </summary>
		public string TakeMan
		{
			get { return _takeMan;}
			set { _takeMan = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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


