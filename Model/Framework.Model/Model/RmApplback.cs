

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房退药申请 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmApplback : BaseModel
	{   
		 
		private string _billNo;  //单据流水号
		
		private string  _houseId;  //药库Id,BsHouse.Id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private DateTime _operTime;  //操作时间
		
		private string  _operId;  //操作员ID,BsUser.Id
		
		private bool _isAffirm;  //药库是否确认
		
		private DateTime _affirmTime;  //确认时间
		
		private string _affirmOperid;  //确认人
		
		private bool _isSign;  //药房是否审核
		
		private DateTime _signTime;  //审核时间
		
		private string _signOperId;  //审核人
		
		private string _ckBillNo;  //出库单号
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _pageNumber;  //行心云:F1????
		
		private int _HospitalID;  //
		 
        public RmApplback() { }

                                    
		
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库Id,BsHouse.Id
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
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
		/// 药库是否确认
		/// </summary>
		public bool IsAffirm
		{
			get { return _isAffirm;}
			set { _isAffirm = value;}
		}                                    
		
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime AffirmTime
		{
			get { return _affirmTime;}
			set { _affirmTime = value;}
		}                                    
		
		/// <summary>
		/// 确认人
		/// </summary>
		public string AffirmOperid
		{
			get { return _affirmOperid;}
			set { _affirmOperid = value;}
		}                                    
		
		/// <summary>
		/// 药房是否审核
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
		/// 出库单号
		/// </summary>
		public string CkBillNo
		{
			get { return _ckBillNo;}
			set { _ckBillNo = value;}
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
		/// 行心云:F1????
		/// </summary>
		public int PageNumber
		{
			get { return _pageNumber;}
			set { _pageNumber = value;}
		}                                    
		                                    
		        
	}  
}           


