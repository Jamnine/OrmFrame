

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayInInvoiceDtlReg : BaseModel
    {   
		
		private DateTime _operTime;  //登记日期时间
		
		private bool _isPay;  //是否结账
		
		private string _itemId;  //Pub_Med_Item价项目表
		
		private string _locationId;  //申请科室Req_Loc
		
		private double _totality;  //发生数量Used_Num
		
		private double _priceIn;  //单价
		
		private double _amount;  //发生金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的
		
		private string _doctorId;  //批准医生Auth_man
		
		private string _execOperId;  //执行人
		
		private string _execLocId;  //执行科室
		
		private string _invItemId;  //住院发票项目ID
		
		private string _feeId;  //住院基础分类ID
		
		private string _execDoctorId;  //执行医生
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否结账
		/// </summary>
		public bool IsPay
		{
			get { return _isPay;}
			set { _isPay = value;}
		}                                    
		
		/// <summary>
		/// Pub_Med_Item价项目表
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 申请科室Req_Loc
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 发生数量Used_Num
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
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
		/// 实际应交金额（乘以DiscSelf后的
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 批准医生Auth_man
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string ExecOperId
		{
			get { return _execOperId;}
			set { _execOperId = value;}
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
		/// 住院发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 住院基础分类ID
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 执行医生
		/// </summary>
		public string ExecDoctorId
		{
			get { return _execDoctorId;}
			set { _execDoctorId = value;}
		}                                    
		
                                   
		        
	}  
}           


