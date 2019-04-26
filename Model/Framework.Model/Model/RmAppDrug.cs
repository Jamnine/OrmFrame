

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房领药申请 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmAppDrug : BaseModel
	{   
		
		
		
		private string _billNo;  //单据流水号
		
		private string _houseId;  //药库Id,BsHouse.Id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isAffirm;  //药库是否导入
		
		private DateTime _affirmTime;  //导入时间
		
		private string _affirmOperid;  //导入人
		
		private bool _isAuth;  //科室是否审核
		
		private string _authOperId;  //查对护士
		
		private DateTime _authOperTime;  //查对时间
		
		private string _memo;  //备注
		
		private string _userId;  //使用人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _pageNumber;  //行心云:F1????
		
		private int _HospitalID;  //
		 
        public RmAppDrug() { }

                                   
		
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
		/// 药库是否导入
		/// </summary>
		public bool IsAffirm
		{
			get { return _isAffirm;}
			set { _isAffirm = value;}
		}                                    
		
		/// <summary>
		/// 导入时间
		/// </summary>
		public DateTime AffirmTime
		{
			get { return _affirmTime;}
			set { _affirmTime = value;}
		}                                    
		
		/// <summary>
		/// 导入人
		/// </summary>
		public string AffirmOperid
		{
			get { return _affirmOperid;}
			set { _affirmOperid = value;}
		}                                    
		
		/// <summary>
		/// 科室是否审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 查对护士
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 查对时间
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
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
		/// 使用人
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
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


