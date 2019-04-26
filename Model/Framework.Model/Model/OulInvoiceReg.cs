

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊挂号发票表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OulInvoiceReg : BaseModel
	{   
		
		private string _invoNo;  //发票号码
		
		private string _mzRegId;  //门诊流水号
		
		private DateTime _invoTime;  //发票打印时间
		
		private double _regFee;  //挂号费
		
		private double _diagnoFee;  //诊金
		
		private double _tallyDiag;  //报销金额
		
		private double _zyFee;  //病历工本费
		
		private double _otherFee1;  //门诊病历工本费
		
		private double _otherFee2;  //诊疗卡费
		
		private string _payWayId;  //支付方式对应BkPayWay.Id
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //收费操作员
		
		private bool _isCancel;  //是否注销
		
		private DateTime _cancelTime;  //注销日期
		
		private string _cancelOperId;  //注销人
		
		private string _invoLastId;  //退费的原发票
		
		private int _HospitalID;  //院区Id,BsHospital.Id
		
		private string _regTypeId;  //挂号类别Id,BsRegType.Id
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _patTypeId;  //病人类别,BsPatType.Id
		
		private string _locationId;  //科室ID,BsLocation.Id
		
		private DateTime _checkTime;  //交款时间
		
		private DateTime _cancelCheckTime;  //作废交款时间
		
		private string _docLocId;  //医生所嘱科室(BsDoctor.Locationid)
		
		private string _orderWXID;  //
		
		private bool _isRegDoctorTemp;  //是否医生临挂
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _bHOSName;  //行心云:机器名
		 

		
		
		/// <summary>
		/// 发票号码
		/// </summary>
		public string InvoNo
		{
			get { return _invoNo;}
			set { _invoNo = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 发票打印时间
		/// </summary>
		public DateTime InvoTime
		{
			get { return _invoTime;}
			set { _invoTime = value;}
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
		/// 支付方式对应BkPayWay.Id
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 收费操作员
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否注销
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 注销日期
		/// </summary>
		public DateTime CancelTime
		{
			get { return _cancelTime;}
			set { _cancelTime = value;}
		}                                    
		
		/// <summary>
		/// 注销人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 退费的原发票
		/// </summary>
		public string InvoLastId
		{
			get { return _invoLastId;}
			set { _invoLastId = value;}
		}                                    
		                                
		
		/// <summary>
		/// 挂号类别Id,BsRegType.Id
		/// </summary>
		public string RegTypeId
		{
			get { return _regTypeId;}
			set { _regTypeId = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 病人类别,BsPatType.Id
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 交款时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 作废交款时间
		/// </summary>
		public DateTime CancelCheckTime
		{
			get { return _cancelCheckTime;}
			set { _cancelCheckTime = value;}
		}                                    
		
		/// <summary>
		/// 医生所嘱科室(BsDoctor.Locationid)
		/// </summary>
		public string DocLocId
		{
			get { return _docLocId;}
			set { _docLocId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OrderWXID
		{
			get { return _orderWXID;}
			set { _orderWXID = value;}
		}                                    
		
		/// <summary>
		/// 是否医生临挂
		/// </summary>
		public bool IsRegDoctorTemp
		{
			get { return _isRegDoctorTemp;}
			set { _isRegDoctorTemp = value;}
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
		/// 行心云:机器名
		/// </summary>
		public string BHOSName
		{
			get { return _bHOSName;}
			set { _bHOSName = value;}
		}                                    
	}  
}           


