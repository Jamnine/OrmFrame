

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class InInvoiceDtl:BaseModel 
	{   	 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _itemId;  //Pub_Med_Item价项目表
		
		private DateTime _regOperTime;  //登记日期时间
		
		private string _regOperId;  //申请人
		
		private string _locationId;  //申请科室Req_Loc
		
		private string _adviceId;  //医嘱id号
		
		private int _lsMarkType;  //费用来源：1-长期；2-临时；3-其他；4-床位；5-出院带药；6-医技；7-每天的执行项目记账；8-手术插帐；9-麻醉插帐；10-检验；11-中药
		
		private double _totality;  //发生数量Used_Num
		
		private double _priceIn;  //单价
		
		private string _unitId;  //发生单位
		
		private bool _isPay;  //结帐?
		
		private double _discIn;  //打折
		
		private double _discSelf;  //自费部分的打折比例
		
		private double _amount;  //发生金额
		
		private double _amountFact;  //自付金额，等于(自负金额+自费金额)Pay_Amou
		
		private double _amountSelf;  //自负金额
		
		private double _amountTally;  //可记帐金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private string _invoId;  //结帐单据号Bill_ID
		
		private int _lsPerform;  //执行类别：1-收费；2-退费
		
		private bool _isModiDisc;  //是否修改自付比例
		
		private string _limitGroupId;  //所属住院限额
		
		private double _limitFee;  //住院限额
		
		private string _doctorId;  //批准医生Auth_man
		
		private string _execOperId;  //执行人
		
		private string _execLocId;  //执行科室
		
		private string _invItemId;  //住院发票项目ID
		
		private string _feeId;  //住院基础分类ID
		
		private string _feeHsId;  //核算收据类别
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //登记日期时间
		
		private string _operId;  //申请人
		
		private bool _isCancel;  //是否已退费
		
		private string _cancelId;  //退费时对应原费用ID
		
		private bool _isManual;  //是否手工输入
		
		private string _hostName;  //登记工作站
		
		private string _executeId;  //对应执行ID
		
		private string _regDate;  //日期
		
		private string _groupItemId;  //组BsItemId
		
		private string _xDRpId;  //协定处方ID
		
		private string _adviceName;  //医嘱内容
		
		private string _mainDoctorId;  //主诊医生
		
		private string _ouInvoId;  //门诊发票ID
		
		private string _urgent;  //紧急
		
		private string _reservedField;  //
		
		private string _reservedField2;  //
		
		private double _priceIn1;  //住院项目单价1
		
		private double _priceIn2;  //住院项目单价2
		
		private int _lsPriceState;  //
		
		private string _docLocId;  //医生所嘱科室(BsDoctor.Locationid)
		
		private string _execDoctorId;  //执行医生
		
		private bool _isYbxj;  //是否医保限制
		
		private string _usagememo;  //用法备注
		
		private string _usageid;  //用法对应BsUsage.Id
		
		private string _formid;  //剂型对应BsFormDrug.id
		
		private string _frequencyid;  //频率对应BsFrequency.Id
		
		private bool _isAutoCharged;  //是否自动收
		
		private bool _isYbCharged;  //是否进行了医保结算
		
		private string _notAuthMemo;  //拒绝审核原因
		
		private string _backMemo;  //病区反馈信息
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		                                 
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// Pub_Med_Item价项目表
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
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
		/// 申请科室Req_Loc
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱id号
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 费用来源：1-长期；2-临时；3-其他；4-床位；5-出院带药；6-医技；7-每天的执行项目记账；8-手术插帐；9-麻醉插帐；10-检验；11-中药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 发生数量Used_Num
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 发生单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 结帐?
		/// </summary>
		public bool IsPay
		{
			get { return _isPay;}
			set { _isPay = value;}
		}                                    
		
		/// <summary>
		/// 打折
		/// </summary>
		public double DiscIn
		{
			get { return _discIn;}
			set { _discIn = value;}
		}                                    
		
		/// <summary>
		/// 自费部分的打折比例
		/// </summary>
		public double DiscSelf
		{
			get { return _discSelf;}
			set { _discSelf = value;}
		}                                    
		
		/// <summary>
		/// 发生金额
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
		/// 结帐单据号Bill_ID
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 执行类别：1-收费；2-退费
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
		/// 所属住院限额
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
		/// 批准医生Auth_man
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
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 住院发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 住院基础分类ID
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 核算收据类别
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
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否已退费
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 退费时对应原费用ID
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
		/// 登记工作站
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
		}                                    
		
		/// <summary>
		/// 对应执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 日期
		/// </summary>
		public string RegDate
		{
			get { return _regDate;}
			set { _regDate = value;}
		}                                    
		
		/// <summary>
		/// 组BsItemId
		/// </summary>
		public string GroupItemId
		{
			get { return _groupItemId;}
			set { _groupItemId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string XDRpId
		{
			get { return _xDRpId;}
			set { _xDRpId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱内容
		/// </summary>
		public string AdviceName
		{
			get { return _adviceName;}
			set { _adviceName = value;}
		}                                    
		
		/// <summary>
		/// 主诊医生
		/// </summary>
		public string MainDoctorId
		{
			get { return _mainDoctorId;}
			set { _mainDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 门诊发票ID
		/// </summary>
		public string OuInvoId
		{
			get { return _ouInvoId;}
			set { _ouInvoId = value;}
		}                                    
		
		/// <summary>
		/// 紧急
		/// </summary>
		public string Urgent
		{
			get { return _urgent;}
			set { _urgent = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ReservedField
		{
			get { return _reservedField;}
			set { _reservedField = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ReservedField2
		{
			get { return _reservedField2;}
			set { _reservedField2 = value;}
		}                                    
		
		/// <summary>
		/// 住院项目单价1
		/// </summary>
		public double PriceIn1
		{
			get { return _priceIn1;}
			set { _priceIn1 = value;}
		}                                    
		
		/// <summary>
		/// 住院项目单价2
		/// </summary>
		public double PriceIn2
		{
			get { return _priceIn2;}
			set { _priceIn2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsPriceState
		{
			get { return _lsPriceState;}
			set { _lsPriceState = value;}
		}                                    
		
		/// <summary>
		/// 医生所嘱科室(BsDoctor.Locationid)
		/// </summary>
		public string DocLocId
		{
			get { return _docLocId;}
			set { _docLocId = value;}
		}                                    
		
		/// <summary>
		/// 执行医生
		/// </summary>
		public string ExecDoctorId
		{
			get { return _execDoctorId;}
			set { _execDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 是否医保限制
		/// </summary>
		public bool IsYbxj
		{
			get { return _isYbxj;}
			set { _isYbxj = value;}
		}                                    
		
		/// <summary>
		/// 用法备注
		/// </summary>
		public string Usagememo
		{
			get { return _usagememo;}
			set { _usagememo = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string Usageid
		{
			get { return _usageid;}
			set { _usageid = value;}
		}                                    
		
		/// <summary>
		/// 剂型对应BsFormDrug.id
		/// </summary>
		public string Formid
		{
			get { return _formid;}
			set { _formid = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string Frequencyid
		{
			get { return _frequencyid;}
			set { _frequencyid = value;}
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
		/// 是否进行了医保结算
		/// </summary>
		public bool IsYbCharged
		{
			get { return _isYbCharged;}
			set { _isYbCharged = value;}
		}                                    
		
		/// <summary>
		/// 拒绝审核原因
		/// </summary>
		public string NotAuthMemo
		{
			get { return _notAuthMemo;}
			set { _notAuthMemo = value;}
		}                                    
		
		/// <summary>
		/// 病区反馈信息
		/// </summary>
		public string BackMemo
		{
			get { return _backMemo;}
			set { _backMemo = value;}
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


