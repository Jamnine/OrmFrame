

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会诊申请表 - 实体类
	/// </summary>
	[Serializable]
	public partial class PsDiagMeeting : BaseModel
	{   
		
		private string _applyNo;  //申请号
		
		private DateTime _applyTime;  //申请时间
		
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _locationId;  //申请科室ID
		
		private string _doctorId;  //申请医生
		
		private string _diagnose;  //初步诊断意见
		
		private DateTime _operTime;  //递手术通知时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _clinic;  //病历摘要
		
		private bool _isUrgent;  //紧急
		
		private string _memo;  //备注
		
		private string _inAdviceTempId;  //生成临嘱返回的ID
		
		private string _patientName;  //住院病人姓名
		
		private string _inPatNo;  //住院病人号
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		/// <summary>
		/// 申请号
		/// </summary>
		public string ApplyNo
		{
			get { return _applyNo;}
			set { _applyNo = value;}
		}                                    
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime ApplyTime
		{
			get { return _applyTime;}
			set { _applyTime = value;}
		}                                    
		
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 申请科室ID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 申请医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 初步诊断意见
		/// </summary>
		public string Diagnose
		{
			get { return _diagnose;}
			set { _diagnose = value;}
		}                                    
		
		/// <summary>
		/// 递手术通知时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 病历摘要
		/// </summary>
		public string Clinic
		{
			get { return _clinic;}
			set { _clinic = value;}
		}                                    
		
		/// <summary>
		/// 紧急
		/// </summary>
		public bool IsUrgent
		{
			get { return _isUrgent;}
			set { _isUrgent = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 生成临嘱返回的ID
		/// </summary>
		public string InAdviceTempId
		{
			get { return _inAdviceTempId;}
			set { _inAdviceTempId = value;}
		}                                    
		
		/// <summary>
		/// 住院病人姓名
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
		}                                    
		
		/// <summary>
		/// 住院病人号
		/// </summary>
		public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
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


