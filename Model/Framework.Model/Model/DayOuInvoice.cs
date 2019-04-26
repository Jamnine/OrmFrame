

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOuInvoice : BaseModel
    {   
		
		private string _code;  //主键
		
		private DateTime _operTime;  //时间
		
		private string _locationId;  //科室
		
		private string _doctorId;  //医生
		
		private string _operId;  //挂号员
		
		private int _HospitalID;  //分院
		
		private string _patTypeId;  //病人类别
		
		private double _beprice;  //应结算金额（总金额）
		
		private double _insurance;  //医保/公医记帐金额
		
		private double _amountPay;  //应交金额
		
		private double _addFee;  //凑整费
		
		private int _invoS;  //发票数
		
		private int _rc;  //人次
		 

		
		/// <summary>
		/// 主键
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 挂号员
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
	                                  
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 应结算金额（总金额）
		/// </summary>
		public double Beprice
		{
			get { return _beprice;}
			set { _beprice = value;}
		}                                    
		
		/// <summary>
		/// 医保/公医记帐金额
		/// </summary>
		public double Insurance
		{
			get { return _insurance;}
			set { _insurance = value;}
		}                                    
		
		/// <summary>
		/// 应交金额
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
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


