

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院领药申请单 - 实体类
	/// </summary>
	[Serializable]
	public partial class InDrugReq : BaseModel
    {   
		 
		private string _requestNo;  //申请单号
		
		private string _locationId;  //申请科室
		
		private string _operID;  //申请人
		
		private DateTime _operTime;  //申请时间
		
		private string _roomId;  //药房
		
		private int _lsSendStatus;  //发药状态：1-已发；2-未发；3-部分发
		
		private bool _isPrint;  //是否已打印
		
		private string _confirmOperID;  //确认发药
		
		private DateTime _confirmDate;  //确认发药时间
		
		private bool _isAllLocation;  //全区标识
		
		private bool _isUrgent;  //紧急用药
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDrugReq() { }
                                     
		
		/// <summary>
		/// 申请单号
		/// </summary>
		public string RequestNo
		{
			get { return _requestNo;}
			set { _requestNo = value;}
		}                                    
		
		/// <summary>
		/// 申请科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 药房
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 发药状态：1-已发；2-未发；3-部分发
		/// </summary>
		public int LsSendStatus
		{
			get { return _lsSendStatus;}
			set { _lsSendStatus = value;}
		}                                    
		
		/// <summary>
		/// 是否已打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 确认发药
		/// </summary>
		public string ConfirmOperID
		{
			get { return _confirmOperID;}
			set { _confirmOperID = value;}
		}                                    
		
		/// <summary>
		/// 确认发药时间
		/// </summary>
		public DateTime ConfirmDate
		{
			get { return _confirmDate;}
			set { _confirmDate = value;}
		}                                    
		
		/// <summary>
		/// 全区标识
		/// </summary>
		public bool IsAllLocation
		{
			get { return _isAllLocation;}
			set { _isAllLocation = value;}
		}                                    
		
		/// <summary>
		/// 紧急用药
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


