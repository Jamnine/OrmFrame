

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院领药申请单明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class InDrugReqDtl : BaseModel
    {   
		 
		private string _requestId;  //申请单
		
		private int _listNum;  //序号
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private DateTime _forDate;  //需要的时间
		
		private string _itemId;  //药品ID
		
		private string _adviceId;  //医嘱号，对应医嘱表
		
		private int _groupNum;  //组号
		
		private int _lsMarkType;  //医嘱类别：1-长期；2-临时；3-其他
		
		private double _dosage;  //用量
		
		private string _unitReq;  //申请单位
		
		private string _unitTake;  //服用单位
		
		private double _totality;  //总量
		
		private string _frequencyId;  //服用频率
		
		private string _usageId;  //服用方法
		
		private bool _isPrint;  //是否已打印
		
		private bool _isIssued;  //是否已发？
		
		private bool _isConfirm;  //是否确认
		
		private string _confirmOperId;  //确认人
		
		private DateTime _confirmOperTime;  //确认时间
		
		private string _detailId;  //记帐表的费用ID
		
		private string _executeId;  //执行单ID
		
		private string _regDate;  //使用日期
		
		private int _lsSecMarkType;  //
		
		private string _bedName;  //床号
		
		private bool _refusal;  //
		
		private bool _isArrearage;  //0-正常1-欠费2-删除
		
		private string _doctorID;  //医生Id,BsDoctor.Id
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private double _priceIn;  //住院项目单价
		
		private bool _lsArrearage;  //是否欠费
		
		private string _doctorName;  //开单医生名称
		
		private bool _isOutDrug;  //是在院用药：1：在院用药.0:出院带药
		
		private string _usageMemo;  //用法备注
		
		private DateTime _useTime;  //用药时间
		
		private DateTime _useTimeEnd;  //用药结束时间
		
		private string _roomId;  //药房ID
		
		private string _locationId;  //科室
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDrugReqDtl() { }
         
		/// <summary>
		/// 申请单
		/// </summary>
		public string RequestId
		{
			get { return _requestId;}
			set { _requestId = value;}
		}
        private bool _IsHospId;
        public bool IsHospId
        {
            get { return _IsHospId; }
            set { _IsHospId = value; }
        }
        /// <summary>
        /// 序号
        /// </summary>
        public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 需要的时间
		/// </summary>
		public DateTime ForDate
		{
			get { return _forDate;}
			set { _forDate = value;}
		}                                    
		
		/// <summary>
		/// 药品ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱号，对应医嘱表
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别：1-长期；2-临时；3-其他
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 申请单位
		/// </summary>
		public string UnitReq
		{
			get { return _unitReq;}
			set { _unitReq = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTake
		{
			get { return _unitTake;}
			set { _unitTake = value;}
		}                                    
		
		/// <summary>
		/// 总量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 服用频率
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 服用方法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
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
		/// 是否已发？
		/// </summary>
		public bool IsIssued
		{
			get { return _isIssued;}
			set { _isIssued = value;}
		}                                    
		
		/// <summary>
		/// 是否确认
		/// </summary>
		public bool IsConfirm
		{
			get { return _isConfirm;}
			set { _isConfirm = value;}
		}                                    
		
		/// <summary>
		/// 确认人
		/// </summary>
		public string ConfirmOperId
		{
			get { return _confirmOperId;}
			set { _confirmOperId = value;}
		}                                    
		
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime ConfirmOperTime
		{
			get { return _confirmOperTime;}
			set { _confirmOperTime = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 执行单ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 使用日期
		/// </summary>
		public string RegDate
		{
			get { return _regDate;}
			set { _regDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsSecMarkType
		{
			get { return _lsSecMarkType;}
			set { _lsSecMarkType = value;}
		}                                    
		
		/// <summary>
		/// 床号
		/// </summary>
		public string BedName
		{
			get { return _bedName;}
			set { _bedName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool Refusal
		{
			get { return _refusal;}
			set { _refusal = value;}
		}                                    
		
		/// <summary>
		/// 0-正常1-欠费2-删除
		/// </summary>
		public bool IsArrearage
		{
			get { return _isArrearage;}
			set { _isArrearage = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorID
		{
			get { return _doctorID;}
			set { _doctorID = value;}
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
		/// 住院项目单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 是否欠费
		/// </summary>
		public bool LsArrearage
		{
			get { return _lsArrearage;}
			set { _lsArrearage = value;}
		}                                    
		
		/// <summary>
		/// 开单医生名称
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 是在院用药：1：在院用药.0:出院带药
		/// </summary>
		public bool IsOutDrug
		{
			get { return _isOutDrug;}
			set { _isOutDrug = value;}
		}                                    
		
		/// <summary>
		/// 用法备注
		/// </summary>
		public string UsageMemo
		{
			get { return _usageMemo;}
			set { _usageMemo = value;}
		}                                    
		
		/// <summary>
		/// 用药时间
		/// </summary>
		public DateTime UseTime
		{
			get { return _useTime;}
			set { _useTime = value;}
		}                                    
		
		/// <summary>
		/// 用药结束时间
		/// </summary>
		public DateTime UseTimeEnd
		{
			get { return _useTimeEnd;}
			set { _useTimeEnd = value;}
		}                                    
		
		/// <summary>
		/// 药房ID
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 儿童价格
		/// </summary>
		public double ChildPrice
		{
			get { return _childPrice;}
			set { _childPrice = value;}
		}                                    
		
		/// <summary>
		/// 折扣价格
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
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


