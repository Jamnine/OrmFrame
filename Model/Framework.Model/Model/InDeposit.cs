

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院按金单 - 实体类
	/// </summary>
	[Serializable]
	public partial class InDeposit : BaseModel
	{    
		private string _billNo;  //发票号 
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private DateTime? _operTime;  //交款时间
		
		private string _operID;  //操作员
		
		private double _amount;  //金额
		
		private double _remain;  //余额
		
		private bool _isFirst;  //是否为预交押金
		
		private string _remark;  //备注
		
		private bool _isCancel;  //是否退款
		
		private int? _lsCancelType;  //注销类别：1-结算；2-退款；3-作废
		
		private DateTime? _cancelOperTime;  //退款日期
		
		private string _cancelOperId;  //退款人
		
		private string _invoId;  //相关结算ID
		
		private int _HospitalID;  //院区Id,BsHospital.Id
		
		private DateTime? _checkTime;  //交款时间
		
		private DateTime? _cancelCheckTime;  //发票作废后的交款时间
		
		private string _payWayName;  //支付方式名称
		
		private bool? _isSelect;  //F4对用户选择打上勾的项目进行操作
		
		private bool _isAuthed;  //已经封存，不可改删

        public InDeposit() { }
         
		/// <summary>
		/// 发票号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
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
		/// 交款时间
		/// </summary>
		public DateTime? OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
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
		/// 余额
		/// </summary>
		public double Remain
		{
			get { return _remain;}
			set { _remain = value;}
		}                                    
		
		/// <summary>
		/// 是否为预交押金
		/// </summary>
		public bool IsFirst
		{
			get { return _isFirst;}
			set { _isFirst = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 是否退款
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 注销类别：1-结算；2-退款；3-作废
		/// </summary>
		public int? LsCancelType
		{
			get { return _lsCancelType;}
			set { _lsCancelType = value;}
		}                                    
		
		/// <summary>
		/// 退款日期
		/// </summary>
		public DateTime? CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 退款人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 相关结算ID
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 院区Id,BsHospital.Id
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		
		/// <summary>
		/// 交款时间
		/// </summary>
		public DateTime? CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 发票作废后的交款时间
		/// </summary>
		public DateTime? CancelCheckTime
		{
			get { return _cancelCheckTime;}
			set { _cancelCheckTime = value;}
		}                                    
		
		/// <summary>
		/// 支付方式名称
		/// </summary>
		public string PayWayName
		{
			get { return _payWayName;}
			set { _payWayName = value;}
		}                                    
		
		/// <summary>
		/// F4对用户选择打上勾的项目进行操作
		/// </summary>
		public bool? IsSelect
		{
			get { return _isSelect;}
			set { _isSelect = value;}
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


