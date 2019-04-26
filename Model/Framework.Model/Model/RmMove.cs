

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房调拨单 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmMove : BaseModel
    {   
		
		
		
		private string _billNo;  //单据流水号
		
		private string _roomIdI;  //调入药房，BsRoom.Id
		
		private string _roomIdO;  //调出药房，BsRoom.Id
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private string _operid;  //操作员ID,BsUser.Id
		
		private bool _isSign;  //是否审核
		
		private DateTime _signTime;  //审核时间
		
		private string _signOperId;  //审核人
		
		private bool _isSignRev;  //是否接收
		
		private DateTime _signTimeRev;  //接收时间
		
		private string _signOperIdRev;  //接收人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmMove() { }
                           
		
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 调入药房，BsRoom.Id
		/// </summary>
		public string RoomIdI
		{
			get { return _roomIdI;}
			set { _roomIdI = value;}
		}                                    
		
		/// <summary>
		/// 调出药房，BsRoom.Id
		/// </summary>
		public string RoomIdO
		{
			get { return _roomIdO;}
			set { _roomIdO = value;}
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
		public string Operid
		{
			get { return _operid;}
			set { _operid = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime SignTime
		{
			get { return _signTime;}
			set { _signTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string SignOperId
		{
			get { return _signOperId;}
			set { _signOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否接收
		/// </summary>
		public bool IsSignRev
		{
			get { return _isSignRev;}
			set { _isSignRev = value;}
		}                                    
		
		/// <summary>
		/// 接收时间
		/// </summary>
		public DateTime SignTimeRev
		{
			get { return _signTimeRev;}
			set { _signTimeRev = value;}
		}                                    
		
		/// <summary>
		/// 接收人
		/// </summary>
		public string SignOperIdRev
		{
			get { return _signOperIdRev;}
			set { _signOperIdRev = value;}
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
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


