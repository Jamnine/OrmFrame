

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医保登记表 - 实体类
	/// </summary>
	[Serializable]
	public partial class YbPatSeq : BaseModel
	{   
		private string _mzRegId;  //门诊病人ID,Ouhosinfo.Id
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _ybSeq;  //医保号
		
		private DateTime _operTime;  //操作时间
		
		private string _invoId;  //发票id
		
		private string _centreNum;  //中心编号
		
		private string _payType;  //支付类别
		
		private string _personalNum;  //个人编号
		
		private string _insuranceMethod;  //社会保险办法
		
		private string _doctorNum;  //就诊编号
		
		private string _diseaseNum;  //病种编号
		
		private string _balanceNum;  //结算编号
		
		private bool _isCancel;  //是否作废
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private string _insuranceType;  //险种类型
		
		private int _HospitalID;  //

        public YbPatSeq() { }

                           
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 医保号
		/// </summary>
		public string YbSeq
		{
			get { return _ybSeq;}
			set { _ybSeq = value;}
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
		/// 发票id
		/// </summary>
		public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 中心编号
		/// </summary>
		public string CentreNum
		{
			get { return _centreNum;}
			set { _centreNum = value;}
		}                                    
		
		/// <summary>
		/// 支付类别
		/// </summary>
		public string PayType
		{
			get { return _payType;}
			set { _payType = value;}
		}                                    
		
		/// <summary>
		/// 个人编号
		/// </summary>
		public string PersonalNum
		{
			get { return _personalNum;}
			set { _personalNum = value;}
		}                                    
		
		/// <summary>
		/// 社会保险办法
		/// </summary>
		public string InsuranceMethod
		{
			get { return _insuranceMethod;}
			set { _insuranceMethod = value;}
		}                                    
		
		/// <summary>
		/// 就诊编号
		/// </summary>
		public string DoctorNum
		{
			get { return _doctorNum;}
			set { _doctorNum = value;}
		}                                    
		
		/// <summary>
		/// 病种编号
		/// </summary>
		public string DiseaseNum
		{
			get { return _diseaseNum;}
			set { _diseaseNum = value;}
		}                                    
		
		/// <summary>
		/// 结算编号
		/// </summary>
		public string BalanceNum
		{
			get { return _balanceNum;}
			set { _balanceNum = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
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
		/// 险种类型
		/// </summary>
		public string InsuranceType
		{
			get { return _insuranceType;}
			set { _insuranceType = value;}
		}                                    
		
                                
		        
	}  
}           


