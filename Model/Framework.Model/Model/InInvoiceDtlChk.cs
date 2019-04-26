

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院费用审核表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InInvoiceDtlChk:BaseModel
	{   
		 
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private DateTime _regOperTime;  //费用申请时间
		
		private string _regOperId;  //申请人
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private string _adviceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private double _totality;  //数量
		
		private double _priceIn;  //住院项目单价
		
		private string _unitId;  //单位
		
		private bool _isPay;  //是否结算
		
		private double _discIn;  //住院自费比例
		
		private double _discSelf;  //医院优惠比例
		
		private double _amount;  //金额
		
		private double _amountFact;  //自付金额，等于(自负金额+自费金额)Pay_Amou
		
		private double _amountSelf;  //自负金额
		
		private double _amountTally;  //可记帐金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private string _invoId;  //发票ID
		
		private int _lsPerform;  //1为收费，2退费
		
		private bool _isModiDisc;  //是否修改自付比例
		
		private string _limitGroupId;  //所属住院限额。外键，引用BsLimitGroup.GUID
		
		private double _limitFee;  //住院限额
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _execOperId;  //执行人
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private string _invItemId;  //发票分类BsInvInItem.Id
		
		private string _feeId;  //基础分类
		
		private string _feeHsId;  //核算分类
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isCancel;  //是否作废
		
		private string _cancelId;  //作废明细ID
		
		private bool _isManual;  //是否手工输入
		
		private string _hostName;  //机器名
		
		private string _executeId;  //执行ID
		
		private string _regDate;  //
		
		private string _groupItemId;  //
		
		private string _xDRpId;  //协定处方Id,BsXdRp.Id
		
		private string _adviceName;  //医嘱名称：来源于医嘱
		
		private string _mainDoctorId;  //主管医生
		
		private string _ybCode;  //医保码
		
		private int _lsInOut;  //门诊Or住院
		
		private string _inOuInvoiceDtlId;  //发票Id
		
		private string _usageMemo;  //用法备注
		
		private string _usageId;  //用法
		
		private string _formId;  //剂型
		
		private string _frequencyId;  //频率
		
		private bool _isAutoCharged;  //是否自动收
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
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
		/// 费用申请时间
		/// </summary>
		public DateTime RegOperTime
		{
			get { return _regOperTime;}
			set { _regOperTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string RegOperId
		{
			get { return _regOperId;}
			set { _regOperId = value;}
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
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
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
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
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
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 是否结算
		/// </summary>
		public bool IsPay
		{
			get { return _isPay;}
			set { _isPay = value;}
		}                                    
		
		/// <summary>
		/// 住院自费比例
		/// </summary>
		public double DiscIn
		{
			get { return _discIn;}
			set { _discIn = value;}
		}                                    
		
		/// <summary>
		/// 医院优惠比例
		/// </summary>
		public double DiscSelf
		{
			get { return _discSelf;}
			set { _discSelf = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 自付金额，等于(自负金额+自费金额)Pay_Amou
		/// </summary>
		public double AmountFact
		{
			get { return _amountFact;}
			set { _amountFact = value;}
		}                                    
		
		/// <summary>
		/// 自负金额
		/// </summary>
		public double AmountSelf
		{
			get { return _amountSelf;}
			set { _amountSelf = value;}
		}                                    
		
		/// <summary>
		/// 可记帐金额
		/// </summary>
		public double AmountTally
		{
			get { return _amountTally;}
			set { _amountTally = value;}
		}                                    
		
		/// <summary>
		/// 实际应交金额（乘以DiscSelf后的金额）
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 发票ID
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 1为收费，2退费
		/// </summary>
		public int LsPerform
		{
			get { return _lsPerform;}
			set { _lsPerform = value;}
		}                                    
		
		/// <summary>
		/// 是否修改自付比例
		/// </summary>
		public bool IsModiDisc
		{
			get { return _isModiDisc;}
			set { _isModiDisc = value;}
		}                                    
		
		/// <summary>
		/// 所属住院限额。外键，引用BsLimitGroup.GUID
		/// </summary>
		public string LimitGroupId
		{
			get { return _limitGroupId;}
			set { _limitGroupId = value;}
		}                                    
		
		/// <summary>
		/// 住院限额
		/// </summary>
		public double LimitFee
		{
			get { return _limitFee;}
			set { _limitFee = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string ExecOperId
		{
			get { return _execOperId;}
			set { _execOperId = value;}
		}                                    
		
		/// <summary>
		/// 执行科室BsLocation.id
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 发票分类BsInvInItem.Id
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 基础分类
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 核算分类
		/// </summary>
		public string FeeHsId
		{
			get { return _feeHsId;}
			set { _feeHsId = value;}
		}                                    
		
		/// <summary>
		/// 公费报销报表费用类别
		/// </summary>
		public int LsReportType
		{
			get { return _lsReportType;}
			set { _lsReportType = value;}
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
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 作废明细ID
		/// </summary>
		public string CancelId
		{
			get { return _cancelId;}
			set { _cancelId = value;}
		}                                    
		
		/// <summary>
		/// 是否手工输入
		/// </summary>
		public bool IsManual
		{
			get { return _isManual;}
			set { _isManual = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
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
		/// 
		/// </summary>
		public string RegDate
		{
			get { return _regDate;}
			set { _regDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string GroupItemId
		{
			get { return _groupItemId;}
			set { _groupItemId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方Id,BsXdRp.Id
		/// </summary>
		public string XDRpId
		{
			get { return _xDRpId;}
			set { _xDRpId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱名称：来源于医嘱
		/// </summary>
		public string AdviceName
		{
			get { return _adviceName;}
			set { _adviceName = value;}
		}                                    
		
		/// <summary>
		/// 主管医生
		/// </summary>
		public string MainDoctorId
		{
			get { return _mainDoctorId;}
			set { _mainDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 门诊Or住院
		/// </summary>
		public int LsInOut
		{
			get { return _lsInOut;}
			set { _lsInOut = value;}
		}                                    
		
		/// <summary>
		/// 发票Id
		/// </summary>
		public string InOuInvoiceDtlId
		{
			get { return _inOuInvoiceDtlId;}
			set { _inOuInvoiceDtlId = value;}
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
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 剂型
		/// </summary>
		public string FormId
		{
			get { return _formId;}
			set { _formId = value;}
		}                                    
		
		/// <summary>
		/// 频率
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 是否自动收
		/// </summary>
		public bool IsAutoCharged
		{
			get { return _isAutoCharged;}
			set { _isAutoCharged = value;}
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


