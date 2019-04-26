

using System;
namespace Orm.Model
{
	/// <summary>
	/// 实时记录病人费用情况 - 实体类
	/// </summary>
	[Serializable]
	public partial class InPatFeesList : BaseModel
    {   
		 
		private string _hospId;  //病人ID
		
		private string _name;  //病人姓名
		
		private string _bedID;  //床位
		
		private DateTime _inTime;  //入院时间
		
		private DateTime _outTime;  //出院时间
		
		private string _patTypeID;  //病人类别ID
		
		private string _locationID;  //当前科室
		
		private String _locIn;  //入院科室
		
		private string _doctorID;  //主诊医生
		
		private double _amount;  //总费用
		
		private double _amountPay;  //应交金额
		
		private double _deposit;  //按金
		
		private double _notPay;  //应结未结
		
		private double _hasPay;  //应结已结
		
		private double _remain;  //按金余额
		
		private DateTime _operTime;  //操作时间
		
		private string _inPatNo;  //住院号
		
		private double _amountNoPay;  //未结算费用
		
		private double _amountPayNoPay;  //未结算支付金额
		
		private double _depositNoPay;  //未冲账按金
		
		private double _depositMz;  //内转
		
		private double _factGet;  //部份自费
		
		private double _allFactGet;  //全自费
		
		private double _yPAmount;  //药品金额
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 病人ID
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 床位
		/// </summary>
		public string BedID
		{
			get { return _bedID;}
			set { _bedID = value;}
		}                                    
		
		/// <summary>
		/// 入院时间
		/// </summary>
		public DateTime InTime
		{
			get { return _inTime;}
			set { _inTime = value;}
		}                                    
		
		/// <summary>
		/// 出院时间
		/// </summary>
		public DateTime OutTime
		{
			get { return _outTime;}
			set { _outTime = value;}
		}                                    
		
		/// <summary>
		/// 病人类别ID
		/// </summary>
		public string PatTypeID
		{
			get { return _patTypeID;}
			set { _patTypeID = value;}
		}                                    
		
		/// <summary>
		/// 当前科室
		/// </summary>
		public string LocationID
		{
			get { return _locationID;}
			set { _locationID = value;}
		}                                    
		
		/// <summary>
		/// 入院科室
		/// </summary>
		public string LocIn
		{
			get { return _locIn;}
			set { _locIn = value;}
		}                                    
		
		/// <summary>
		/// 主诊医生
		/// </summary>
		public string DoctorID
		{
			get { return _doctorID;}
			set { _doctorID = value;}
		}                                    
		
		/// <summary>
		/// 总费用
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
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
		/// 按金
		/// </summary>
		public double Deposit
		{
			get { return _deposit;}
			set { _deposit = value;}
		}                                    
		
		/// <summary>
		/// 应结未结
		/// </summary>
		public double NotPay
		{
			get { return _notPay;}
			set { _notPay = value;}
		}                                    
		
		/// <summary>
		/// 应结已结
		/// </summary>
		public double HasPay
		{
			get { return _hasPay;}
			set { _hasPay = value;}
		}                                    
		
		/// <summary>
		/// 按金余额
		/// </summary>
		public double Remain
		{
			get { return _remain;}
			set { _remain = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 住院号
		/// </summary>
		public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
		}                                    
		
		/// <summary>
		/// 未结算费用
		/// </summary>
		public double AmountNoPay
		{
			get { return _amountNoPay;}
			set { _amountNoPay = value;}
		}                                    
		
		/// <summary>
		/// 未结算支付金额
		/// </summary>
		public double AmountPayNoPay
		{
			get { return _amountPayNoPay;}
			set { _amountPayNoPay = value;}
		}                                    
		
		/// <summary>
		/// 未冲账按金
		/// </summary>
		public double DepositNoPay
		{
			get { return _depositNoPay;}
			set { _depositNoPay = value;}
		}                                    
		
		/// <summary>
		/// 内转
		/// </summary>
		public double DepositMz
		{
			get { return _depositMz;}
			set { _depositMz = value;}
		}                                    
		
		/// <summary>
		/// 部份自费
		/// </summary>
		public double FactGet
		{
			get { return _factGet;}
			set { _factGet = value;}
		}                                    
		
		/// <summary>
		/// 全自费
		/// </summary>
		public double AllFactGet
		{
			get { return _allFactGet;}
			set { _allFactGet = value;}
		}                                    
		
		/// <summary>
		/// 药品金额
		/// </summary>
		public double YPAmount
		{
			get { return _yPAmount;}
			set { _yPAmount = value;}
		}                                    
		                                 
		        
	}  
}           


