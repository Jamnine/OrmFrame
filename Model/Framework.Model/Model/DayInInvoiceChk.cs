

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayInInvoiceChk : BaseModel
    {   
		
		private string _code;  //
		
		private DateTime _operTime;  //
		
		private string _operId;  //
		
		private string _HospitalID;  //
		
		private string _patTypeId;  //
		
		private double _beprice;  //
		
		private double _insurance;  //
		
		private double _amountPay;  //
		
		private double _addFee;  //
		
		private double _deposit;  //支按金(已预收)
		
		private double _complement;  //补/退款
		
		private int _invoS;  //发票数
		
		private int _rc;  //人次
		 

		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
	                                   
		
		/// <summary>
		/// 
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Beprice
		{
			get { return _beprice;}
			set { _beprice = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double AddFee
		{
			get { return _addFee;}
			set { _addFee = value;}
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
		/// 发票数
		/// </summary>
		public int InvoS
		{
			get { return _invoS;}
			set { _invoS = value;}
		}                                    
		
		/// <summary>
		/// 人次
		/// </summary>
		public int Rc
		{
			get { return _rc;}
			set { _rc = value;}
		}                                    
		        
	}  
}           


