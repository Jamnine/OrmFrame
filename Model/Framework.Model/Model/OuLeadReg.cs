

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OuLeadReg :  BaseModel  
	{   
		 
		private string _patId;  //病人ID
		
		private string _mzRegId;  //对应挂号后的门诊流水号
		
		private string _regTypeId;  //门诊类别
		
		private bool _isPriority;  //优先级：1-优先；0-普通
		
		private bool _isElder;  //是否老人
		
		private string _locationId;  //挂号科室
		
		private string _doctorId;  //挂号医生
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private string _memo;  //登记备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

	                                  
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 对应挂号后的门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 门诊类别
		/// </summary>
		public string RegTypeId
		{
			get { return _regTypeId;}
			set { _regTypeId = value;}
		}                                    
		
		/// <summary>
		/// 优先级：1-优先；0-普通
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 是否老人
		/// </summary>
		public bool IsElder
		{
			get { return _isElder;}
			set { _isElder = value;}
		}                                    
		
		/// <summary>
		/// 挂号科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 挂号医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
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
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 登记备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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


