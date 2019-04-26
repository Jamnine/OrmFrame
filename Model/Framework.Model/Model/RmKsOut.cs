

using System;
namespace Orm.Model
{
	/// <summary>
	/// 科室领药单 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmKsOut : BaseModel
    {    
		private string _billNo;  //单据流水号
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _locationId;  //领用科室
		
		private DateTime _operTime;  //操作时间
		
		private string _operid;  //操作员ID,BsUser.Id
		
		private bool _isSign;  //是否审核
		
		private DateTime _signTime;  //审核时间
		
		private string _signOperId;  //审核人
		
		private string _ksGetMan;  //
		
		private int _lsInOut;  //1-门诊导入;2-住院导入
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmKsOut() { }
                          
		
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
		/// 领用科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// 
		/// </summary>
		public string KsGetMan
		{
			get { return _ksGetMan;}
			set { _ksGetMan = value;}
		}                                    
		
		/// <summary>
		/// 1-门诊导入;2-住院导入
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
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
        private bool _isOutPatient = false;
        public bool u_IsOutPatient
        {
            get
            {
                if (LsInOut == (int)EnumDefine.EnumUsageUseArea.OutPatient)
                {
                    _isOutPatient = true;
                }
                return _isOutPatient;
            }
            set { _isOutPatient = value; }
        }
        private bool _isInPatient = false;
        public bool u_IsInPatient
        {
            get
            {
                if (LsInOut == (int)EnumDefine.EnumUsageUseArea.InPatient)
                {
                    _isInPatient = true;
                }
                return _isInPatient;
            }
            set { _isInPatient = value; }
        }
    }  
}           


