

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票医保结算表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InYBBalance : BaseModel
    {   
		 
		private string _invoNo;  //单据号
		
		private int _lsPayType;  //结算类型：1-中途结算；2-出院结算；3-出院补结
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见。外键，引用InHosInfo.GUID
		
		private string _patTypeId;  //参照pub_pat_type。外键，引用BsPatType.GUID
		
		private string _fromDate;  //结算至日期
		
		private string _toDate;  //结算至日期
		
		private int _chargeDays;  //结算天数
		
		private double _beprice;  //应结算金额（总金额）
		
		private string _tallyNo;  //公费记帐号
		
		private double _factGet;  //自付金额（乘以DiscSelf前的金额）
		
		private double _insurance;  //医保/公医记帐金额
		
		private double _paySelf;  //个人缴费金额
		
		private double _amountPay;  //应交金额（乘以DiscSelf后的金额）
		
		private double _deposit;  //支按金(已预收)
		
		private double _complement;  //补/退款
		
		private double _arrearage;  //欠款
		
		private double _addFee;  //凑整费
		
		private string _remark;  //取消
		
		private string _operTime;  //发票时间
		
		private string _operId;  //经手人（结算员）。外键，引用BsUser.GUID
		
		private bool _isCancel;  //作废标记
		
		private DateTime _cancelOperTime;  //作废日期
		
		private string _cancelOperId;  //作废人。外键，引用BsUser.GUID
		
		private string _cancelMemo;  //退款备注
		
		private string _invoLastId;  //原来的发票号。外键，引用InInvoice.GUID
		
		private int _HospitalID;  //院区Id,BsHospital.Id
		
		private string _name;  //姓名
		
		private string _inPatNo;  //病人号
		
		private double _sumFee;  //总费用
		
		private double _amountInsurance;  //记账金额
		
		private double _amountFact;  //个人支付
		
		private string _inTime;  //入院时间
		
		private string _outTime;  //出院时间
		
		private byte[] _reportContent;  //报表内容
		
		private bool _isAuthed;  //已经封存，不可改删
		                             
		
		/// <summary>
		/// 单据号
		/// </summary>
		public string InvoNo
		{
			get { return _invoNo;}
			set { _invoNo = value;}
		}                                    
		
		/// <summary>
		/// 结算类型：1-中途结算；2-出院结算；3-出院补结
		/// </summary>
		public int LsPayType
		{
			get { return _lsPayType;}
			set { _lsPayType = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见。外键，引用InHosInfo.GUID
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 参照pub_pat_type。外键，引用BsPatType.GUID
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 结算至日期
		/// </summary>
		public string FromDate
		{
			get { return _fromDate;}
			set { _fromDate = value;}
		}                                    
		
		/// <summary>
		/// 结算至日期
		/// </summary>
		public string ToDate
		{
			get { return _toDate;}
			set { _toDate = value;}
		}                                    
		
		/// <summary>
		/// 结算天数
		/// </summary>
		public int ChargeDays
		{
			get { return _chargeDays;}
			set { _chargeDays = value;}
		}                                    
		
		/// <summary>
		/// 应结算金额（总金额）
		/// </summary>
		public double Beprice
		{
			get { return _beprice;}
			set { _beprice = value;}
		}                                    
		
		/// <summary>
		/// 公费记帐号
		/// </summary>
		public string TallyNo
		{
			get { return _tallyNo;}
			set { _tallyNo = value;}
		}                                    
		
		/// <summary>
		/// 自付金额（乘以DiscSelf前的金额）
		/// </summary>
		public double FactGet
		{
			get { return _factGet;}
			set { _factGet = value;}
		}                                    
		
		/// <summary>
		/// 医保/公医记帐金额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 个人缴费金额
		/// </summary>
		public double PaySelf
		{
			get { return _paySelf;}
			set { _paySelf = value;}
		}                                    
		
		/// <summary>
		/// 应交金额（乘以DiscSelf后的金额）
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 支按金(已预收)
		/// </summary>
		public double Deposit
		{
			get { return _deposit;}
			set { _deposit = value;}
		}                                    
		
		/// <summary>
		/// 补/退款
		/// </summary>
		public double Complement
		{
			get { return _complement;}
			set { _complement = value;}
		}                                    
		
		/// <summary>
		/// 欠款
		/// </summary>
		public double Arrearage
		{
			get { return _arrearage;}
			set { _arrearage = value;}
		}                                    
		
		/// <summary>
		/// 凑整费
		/// </summary>
		public double AddFee
		{
			get { return _addFee;}
			set { _addFee = value;}
		}                                    
		
		/// <summary>
		/// 取消
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 发票时间
		/// </summary>
		public string OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 经手人（结算员）。外键，引用BsUser.GUID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 作废标记
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 作废日期
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人。外键，引用BsUser.GUID
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 退款备注
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 原来的发票号。外键，引用InInvoice.GUID
		/// </summary>
		public string InvoLastId
		{
			get { return _invoLastId;}
			set { _invoLastId = value;}
		}                                    
		                                   
		
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 病人号
		/// </summary>
		public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
		}                                    
		
		/// <summary>
		/// 总费用
		/// </summary>
		public double SumFee
		{
			get { return _sumFee;}
			set { _sumFee = value;}
		}                                    
		
		/// <summary>
		/// 记账金额
		/// </summary>
		public double AmountInsurance
		{
			get { return _amountInsurance;}
			set { _amountInsurance = value;}
		}                                    
		
		/// <summary>
		/// 个人支付
		/// </summary>
		public double AmountFact
		{
			get { return _amountFact;}
			set { _amountFact = value;}
		}                                    
		
		/// <summary>
		/// 入院时间
		/// </summary>
		public string InTime
		{
			get { return _inTime;}
			set { _inTime = value;}
		}                                    
		
		/// <summary>
		/// 出院时间
		/// </summary>
		public string OutTime
		{
			get { return _outTime;}
			set { _outTime = value;}
		}                                    
		
		/// <summary>
		/// 报表内容
		/// </summary>
		public byte[] ReportContent
		{
			get { return _reportContent;}
			set { _reportContent = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		        
	}  
}           


