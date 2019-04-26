

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史住院领药申请 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistInDrugReqdtl : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		 
		private string _requestId;  //申请单Id,InDrugReq.Id
		
		private int _listNum;  //
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private DateTime _forDate;  //申请时间
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _adviceId;  //医嘱ID
		
		private int _groupNum;  //组号
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private double _dosage;  //每次量
		
		private int _unitReq;  //药房单位
		
		private int _unitTake;  //使用单位
		
		private double _totality;  //数量
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private bool _isPrint;  //是否打印
		
		private bool _isIssued;  //是否发药
		
		private bool _isConfirm;  //是否审核
		
		private string _confirmOperId;  //审核人
		
		private DateTime _confirmOperTime;  //审核时间
		
		private string _detailId;  //费用时间ID,InInvoicedtl.Id
		
		private string _executeId;  //执行ID
		
		private string _regDate;  //使用时间
		
		private int _lsSecMarkType;  //
		
		private string _bedName;  //床号
		
		private bool _refusal;  //
		
		private int _isArrearage;  //0-正常1-欠费2-删除
		
		private string _doctorID;  //医生Id,BsDoctor.Id
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private double _priceIn;  //住院项目单价
		
		private bool _lsArrearage;  //是否欠费
		
		private string _doctorName;  //医生名称
		
		private bool _isOutDrug;  //是否出院带药
		
		private string _usageMemo;  //用法备注
		
		private DateTime _useTime;  //使用时间
		
		private string _useTimeEnd;  //使用结束时间
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
		}                                    
		 
		/// <summary>
		/// 申请单Id,InDrugReq.Id
		/// </summary>
		public string RequestId
		{
			get { return _requestId;}
			set { _requestId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime ForDate
		{
			get { return _forDate;}
			set { _forDate = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
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
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 每次量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 药房单位
		/// </summary>
		public int UnitReq
		{
			get { return _unitReq;}
			set { _unitReq = value;}
		}                                    
		
		/// <summary>
		/// 使用单位
		/// </summary>
		public int UnitTake
		{
			get { return _unitTake;}
			set { _unitTake = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 是否打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 是否发药
		/// </summary>
		public bool IsIssued
		{
			get { return _isIssued;}
			set { _isIssued = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsConfirm
		{
			get { return _isConfirm;}
			set { _isConfirm = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string ConfirmOperId
		{
			get { return _confirmOperId;}
			set { _confirmOperId = value;}
		}                                    
		
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime ConfirmOperTime
		{
			get { return _confirmOperTime;}
			set { _confirmOperTime = value;}
		}                                    
		
		/// <summary>
		/// 费用时间ID,InInvoicedtl.Id
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 使用时间
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
		public int IsArrearage
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
		/// 医生名称
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
		}                                    
		
		/// <summary>
		/// 是否出院带药
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
		/// 使用时间
		/// </summary>
		public DateTime UseTime
		{
			get { return _useTime;}
			set { _useTime = value;}
		}                                    
		
		/// <summary>
		/// 使用结束时间
		/// </summary>
		public string UseTimeEnd
		{
			get { return _useTimeEnd;}
			set { _useTimeEnd = value;}
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
		                                 
		        
	}  
}           


