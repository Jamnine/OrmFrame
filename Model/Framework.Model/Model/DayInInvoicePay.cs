

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayInInvoicePay : BaseModel
    {   
		
		private string _code;  //
		
		private string _paywayId;  //支付方式
		
		private double _amount;  //金额
		
		private string _bankId;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PaywayId
		{
			get { return _paywayId;}
			set { _paywayId = value;}
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
		/// 
		/// </summary>
		public string BankId
		{
			get { return _bankId;}
			set { _bankId = value;}
		}                                    
		
                                  
		        
	}  
}           


