

using System;
namespace Orm.Model
{
	/// <summary>
	/// 交款报表专用 - 实体类
	/// </summary>
	[Serializable]
	public partial class RtrjkReport:BaseModel
	{   
		
		
		
		private string _operid;  //收费员
		
		private DateTime _opertime;  //操作结账的时间
		
		private DateTime _cancelOperTime;  //回退结账的时间
		
		private int _iscancel;  //帐单是否有效
		
		private DateTime _begintime;  //结账时间段：开始时间
		
		private DateTime _endtime;  //结账时间段：结束时间
		
		private int _HospitalID;  //分院ID
		
		private string _lsOutIn;  //报表类别：挂号、门诊、住院、按金
		
		private int _bills;  //收费单数
		
		private int _billcancel;  //作废单数
		
		private double _amountSum;  //总金额
		
		private double _amount;  //收费总金额
		
		private double _amountCancel;  //作废总金额
		
		private double _insurance;  //记账金额
		
		private double _amountPay;  //实收金额
		
		private double _amountYF;  //优惠金额
		
		private bool _isSign;  //是否审核
		
		private DateTime _signTime;  //审核时间
		
		private string _signOperId;  //审核人
		
		private string _memo;  //备注

        public RtrjkReport() { }

                               
		
		/// <summary>
		/// 收费员
		/// </summary>
		public string Operid
		{
			get { return _operid;}
			set { _operid = value;}
		}                                    
		
		/// <summary>
		/// 操作结账的时间
		/// </summary>
		public DateTime Opertime
		{
			get { return _opertime;}
			set { _opertime = value;}
		}                                    
		
		/// <summary>
		/// 回退结账的时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 帐单是否有效
		/// </summary>
		public int Iscancel
		{
			get { return _iscancel;}
			set { _iscancel = value;}
		}                                    
		
		/// <summary>
		/// 结账时间段：开始时间
		/// </summary>
		public DateTime begintime
		{
			get { return _begintime;}
			set { _begintime = value;}
		}                                    
		
		/// <summary>
		/// 结账时间段：结束时间
		/// </summary>
		public DateTime Endtime
		{
			get { return _endtime;}
			set { _endtime = value;}
		}                                    
		                                 
		
		/// <summary>
		/// 报表类别：挂号、门诊、住院、按金
		/// </summary>
		public string LsOutIn
		{
			get { return _lsOutIn;}
			set { _lsOutIn = value;}
		}                                    
		
		/// <summary>
		/// 收费单数
		/// </summary>
		public int Bills
		{
			get { return _bills;}
			set { _bills = value;}
		}                                    
		
		/// <summary>
		/// 作废单数
		/// </summary>
		public int billcancel
		{
			get { return _billcancel;}
			set { _billcancel = value;}
		}                                    
		
		/// <summary>
		/// 总金额
		/// </summary>
		public double AmountSum
		{
			get { return _amountSum;}
			set { _amountSum = value;}
		}                                    
		
		/// <summary>
		/// 收费总金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 作废总金额
		/// </summary>
		public double AmountCancel
		{
			get { return _amountCancel;}
			set { _amountCancel = value;}
		}                                    
		
		/// <summary>
		/// 记账金额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 实收金额
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 优惠金额
		/// </summary>
		public double AmountYF
		{
			get { return _amountYF;}
			set { _amountYF = value;}
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		        
	}  
}           


