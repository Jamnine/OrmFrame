

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票对应发票分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class InInvoiceInvItemSum:BaseModel
	{   
		 
		private string _invoId;  //单据号
		
		private string _invItemId;  //发票项目ID
		
		private double _amount;  //金额
		
		private double _amountFact;  //金额
		
		private double _amountSelf;  //金额
		
		private double _amountTally;  //金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private double _mzAmount;  //门诊金额
		
		private double _insurance;  //统筹金额
		
		private double _addFee;  //凑整费
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 单据号
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
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
		/// 金额
		/// </summary>
		public double AmountFact
		{
			get { return _amountFact;}
			set { _amountFact = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double AmountSelf
		{
			get { return _amountSelf;}
			set { _amountSelf = value;}
		}                                    
		
		/// <summary>
		/// 金额
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
		/// 门诊金额
		/// </summary>
		public double MzAmount
		{
			get { return _mzAmount;}
			set { _mzAmount = value;}
		}                                    
		
		/// <summary>
		/// 统筹金额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
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


