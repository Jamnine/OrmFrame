

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊病人欠费库 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuFeeArrears : BaseModel  
	{    

		private string _patId;  //病人ID,对应BsPatient.Id
		
		private string _mzRegId;  //门诊病人ID,Ouhosinfo.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _amount;  //金额
		
		private bool _isPay;  //是否结算
		
		private DateTime _payTime;  //支付时间
		
		private string _ouInvoicePayId;  //对应收款类别ID
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
                                
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
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
		/// 是否结算
		/// </summary>
		public bool IsPay
		{
			get { return _isPay;}
			set { _isPay = value;}
		}                                    
		
		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime PayTime
		{
			get { return _payTime;}
			set { _payTime = value;}
		}                                    
		
		/// <summary>
		/// 对应收款类别ID
		/// </summary>
		public string OuInvoicePayId
		{
			get { return _ouInvoicePayId;}
			set { _ouInvoicePayId = value;}
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


