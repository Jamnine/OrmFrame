

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病人退血 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBloodBack : BaseModel
	{   
		
		private string _recNo;  //申请单号
		
		private string _labId;  //标本号
		
		private string _bloodId;  //血袋ID
		
		private DateTime _backTime;  //发出时间
		
		private string _backOperId;  //发出人
		
		private string _backReason;  //退血原因
		
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
		/// 发出时间
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
		}                                    
		
		/// <summary>
		/// 发出人
		/// </summary>
		public string BackOperId
		{
			get { return _backOperId;}
			set { _backOperId = value;}
		}                                    
		
		/// <summary>
		/// 退血原因
		/// </summary>
		public string BackReason
		{
			get { return _backReason;}
			set { _backReason = value;}
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


