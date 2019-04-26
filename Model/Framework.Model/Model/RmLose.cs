

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房报损单 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmLose : BaseModel
    {   
		
		
		
		private string _billNo;  //单据流水号
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private string _operid;  //操作员ID,BsUser.Id
		
		private bool _isSign;  //是否审核
		
		private DateTime _signDate;  //审核时间
		
		private string _signOperId;  //审核人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private DateTime _signTime;  //行心云: 
		
		private int _HospitalID;  //

        public RmLose() { }

       
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		public DateTime SignDate
		{
			get { return _signDate;}
			set { _signDate = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云: 
		/// </summary>
		public DateTime SignTime
		{
			get { return _signTime;}
			set { _signTime = value;}
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


