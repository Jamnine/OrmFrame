

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费方式 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuInvoicePay :  BaseModel  
	{  

		private string _invoId;  //发票号码
		
		private string _paywayId;  //支付方式
		
		private double _amount;  //金额
		
		private string _cancelPaywayId;  //作废方式Code
		
		private string _bankId;  //终端号Id,BsBank.id
		
		private int _orderBy;  //排序
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _sheetNO;  //行心云: F4小票号
		
		private string _orderNO;  //行心云: F3序号
		
		private int _HospitalID;  //
		                                 
		
		/// <summary>
		/// 发票号码
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
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
		/// 作废方式
		/// </summary>
		public string CancelPaywayId
		{
			get { return _cancelPaywayId;}
			set { _cancelPaywayId = value;}
		}                                    
		
		/// <summary>
		/// 终端号Id,BsBank.id
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
		
		/// <summary>
		/// 行心云: F4小票号
		/// </summary>
		public string SheetNO
		{
			get { return _sheetNO;}
			set { _sheetNO = value;}
		}                                    
		
		/// <summary>
		/// 行心云: F3序号
		/// </summary>
		public string OrderNO
		{
			get { return _orderNO;}
			set { _orderNO = value;}
		}                                    
		                                   
		        
	}  
}           


