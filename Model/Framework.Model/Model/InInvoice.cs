

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票 - 实体类
	/// </summary>
	[Serializable]
	public partial class InInvoice : BaseModel
    {    
		private string _invoNo;  //单据号
		
		private int _lsPayType;  //结算类型：1-中途结算；2-出院结算；3-出院补结
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _patTypeId;  //参照pub_pat_type
		
		private DateTime _fromDate;  //结算至日期
		
		private DateTime _toDate;  //结算至日期
		
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
		
		private DateTime _operTime;  //发票时间
		
		private string _operId;  //经手人（结算员）
		
		private bool _isCancel;  //作废标记
		
		private DateTime _cancelOperTime;  //作废日期
		
		private string _cancelOperID;  //作废人
		
		private string _cancelMemo;  //退款备注
		
		private string _invoLastId;  //原来的发票号
		
		private string _ybIllId;  //医保诊断Id
		
		private string _HospitalID;  //院区Id,BsHospital.Id
		
		private DateTime _checkTime;  //交款时间
		
		private DateTime _cancelCheckTime;  //作废交款时间
		
		private double _reAmount;  //
		
		private DateTime _reAmountDate;  //
		
		private string _reAmountMemo;  //
		
		private string _depositBillNo;  //按金发票号
		
		private int _cancelHospital;  //作废发票的分院名称
		
		private string _ybRegNo;  //医保结算号
		
		private string _balanceNum;  //结算编号
		
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
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 参照pub_pat_type
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 结算至日期
		/// </summary>
		public DateTime FromDate
		{
			get { return _fromDate;}
			set { _fromDate = value;}
		}                                    
		
		/// <summary>
		/// 结算至日期
		/// </summary>
		public DateTime ToDate
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
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 经手人（结算员）
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
		/// 作废人
		/// </summary>
		public string CancelOperID
		{
			get { return _cancelOperID;}
			set { _cancelOperID = value;}
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
		/// 原来的发票号
		/// </summary>
		public string InvoLastId
		{
			get { return _invoLastId;}
			set { _invoLastId = value;}
		}                                    
		
		/// <summary>
		/// 医保诊断Id
		/// </summary>
		public string YbIllId
		{
			get { return _ybIllId;}
			set { _ybIllId = value;}
		}                                    
		                                 
		
		/// <summary>
		/// 交款时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 作废交款时间
		/// </summary>
		public DateTime CancelCheckTime
		{
			get { return _cancelCheckTime;}
			set { _cancelCheckTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ReAmount
		{
			get { return _reAmount;}
			set { _reAmount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReAmountDate
		{
			get { return _reAmountDate;}
			set { _reAmountDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ReAmountMemo
		{
			get { return _reAmountMemo;}
			set { _reAmountMemo = value;}
		}                                    
		
		/// <summary>
		/// 按金发票号
		/// </summary>
		public string DepositBillNo
		{
			get { return _depositBillNo;}
			set { _depositBillNo = value;}
		}                                    
		
		/// <summary>
		/// 作废发票的分院名称
		/// </summary>
		public int CancelHospital
		{
			get { return _cancelHospital;}
			set { _cancelHospital = value;}
		}                                    
		
		/// <summary>
		/// 医保结算号
		/// </summary>
		public string YbRegNo
		{
			get { return _ybRegNo;}
			set { _ybRegNo = value;}
		}                                    
		
		/// <summary>
		/// 结算编号
		/// </summary>
		public string BalanceNum
		{
			get { return _balanceNum;}
			set { _balanceNum = value;}
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


