

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOuInvoiceDtl : BaseModel
    {   
		
		private string _code;  //对应DayOuInvoiceDtl.Code
		
		private string _itemId;  //收费项目
		
		private double _totality;  //总用量
		
		private double _price;  //单价
		
		private double _amount;  //金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的
		
		private string _execLocId;  //执行科室
		
		private string _invItemId;  //门诊发票项目ID
		
		private string _feeId;  //门诊收费类别，参照Pub_Med_Feet
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 对应DayOuInvoiceDtl.Code
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 收费项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 总用量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
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
		/// 实际应交金额（乘以DiscSelf后的
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 门诊发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 门诊收费类别，参照Pub_Med_Feet
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
                                  
		        
	}  
}           


