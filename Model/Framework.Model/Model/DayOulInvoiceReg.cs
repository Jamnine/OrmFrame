

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOulInvoiceReg : BaseModel
    {   
		
		private DateTime _operTime;  //时间
		
		private string _locationId;  //科室
		
		private string _doctorId;  //医生
		
		private string _operId;  //挂号员
		
		private double _regFee;  //挂号费
		
		private double _diagnoFee;  //诊金
		
		private double _tallyDiag;  //报销金额
		
		private double _zyFee;  //病历工本费
		
		private double _otherFee1;  //门诊病历工本费
		
		private double _otherFee2;  //诊疗卡费
		
		private double _otherFee3;  //其它费
		
		private bool _isRegDoctorTemp;  //是否临挂
		
		private string _bHosName;  //机器名
		
		private string _payWayId;  //支付方式，对应BkPayWay.Id
		
		private string _patTypeId;  //病人类别
		
		private string _regTypeId;  //挂号类别
		
		private int _invoS;  //发票数
		
		private int _rc;  //人次
		
		private int _HospitalID;  //
		 

		
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
		/// 挂号费
		/// </summary>
		public double RegFee
		{
			get { return _regFee;}
			set { _regFee = value;}
		}                                    
		
		/// <summary>
		/// 诊金
		/// </summary>
		public double DiagnoFee
		{
			get { return _diagnoFee;}
			set { _diagnoFee = value;}
		}                                    
		
		/// <summary>
		/// 报销金额
		/// </summary>
		public double TallyDiag
		{
			get { return _tallyDiag;}
			set { _tallyDiag = value;}
		}                                    
		
		/// <summary>
		/// 病历工本费
		/// </summary>
		public double ZyFee
		{
			get { return _zyFee;}
			set { _zyFee = value;}
		}                                    
		
		/// <summary>
		/// 门诊病历工本费
		/// </summary>
		public double OtherFee1
		{
			get { return _otherFee1;}
			set { _otherFee1 = value;}
		}                                    
		
		/// <summary>
		/// 诊疗卡费
		/// </summary>
		public double OtherFee2
		{
			get { return _otherFee2;}
			set { _otherFee2 = value;}
		}                                    
		
		/// <summary>
		/// 其它费
		/// </summary>
		public double OtherFee3
		{
			get { return _otherFee3;}
			set { _otherFee3 = value;}
		}                                    
		
		/// <summary>
		/// 是否临挂
		/// </summary>
		public bool IsRegDoctorTemp
		{
			get { return _isRegDoctorTemp;}
			set { _isRegDoctorTemp = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string BHosName
		{
			get { return _bHosName;}
			set { _bHosName = value;}
		}                                    
		
		/// <summary>
		/// 支付方式，对应BkPayWay.Id
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
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
		/// 挂号类别
		/// </summary>
		public string RegTypeId
		{
			get { return _regTypeId;}
			set { _regTypeId = value;}
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


