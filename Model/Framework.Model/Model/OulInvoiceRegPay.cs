

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊挂号支付方式表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OulInvoiceRegPay : BaseModel
	{   
		 
		private string _invoId;  //OulInvoiceReg.Id
		
		private string _payWayId;  //BsPayWay.Id
		
		private double _amount;  //金额
		
		private string _cancelPayWayId;  //作废方式，BsPayWay.Id
		
		private string _bankId;  //BsBank.GUID终端号ID
		
		private int _orderBy;  //排序
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

	
		/// <summary>
		/// OulInvoiceReg.Id
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// BsPayWay.Id
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
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
		/// 作废方式，BsPayWay.Id
		/// </summary>
		public string CancelPayWayId
		{
			get { return _cancelPayWayId;}
			set { _cancelPayWayId = value;}
		}                                    
		
		/// <summary>
		/// BsBank.GUID终端号ID
		/// </summary>
		public string BankId
		{
			get { return _bankId;}
			set { _bankId = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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


