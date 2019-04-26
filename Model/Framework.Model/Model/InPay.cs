

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院支付方式 - 实体类
	/// </summary>
	[Serializable]
	public partial class InPay : BaseModel
    {   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _invoId;  //出入院结算时的发票号码
		
		private string _depositId;  //单据号
		
		private int _lsChargeType;  //付款类别：1-按金结算支出；2-按金收入；3-结算收入；4-按金退款支出；5-结算退款支出；6-按金作废支出
		
		private double _amount;  //发生金额
		
		private string _payWayId;  //交付方式
		
		private string _memo;  //备注
		
		private double _remain;  //按金余额
		
		private DateTime? _operTime;  //登记日期时间
		
		private string _operID;  //申请人
		
		private string _cancelPaywayId;  //退费方式(用什么方式退费)
		
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
		/// 出入院结算时的发票号码
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 单据号
		/// </summary>
		public string DepositId
		{
			get { return _depositId;}
			set { _depositId = value;}
		}                                    
		
		/// <summary>
		/// 付款类别：1-按金结算支出；2-按金收入；3-结算收入；4-按金退款支出；5-结算退款支出；6-按金作废支出
		/// </summary>
		public int LsChargeType
		{
			get { return _lsChargeType;}
			set { _lsChargeType = value;}
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
		/// 交付方式
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
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
		/// 按金余额
		/// </summary>
		public double Remain
		{
			get { return _remain;}
			set { _remain = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime? OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 退费方式(用什么方式退费)
		/// </summary>
		public string CancelPaywayId
		{
			get { return _cancelPaywayId;}
			set { _cancelPaywayId = value;}
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


