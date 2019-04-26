

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊医生病人库 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDocMyPat : BaseModel
    {   
		 
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private string _doctorId;  //关联到DOCTOR表
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private string _memo;  //备注
		
		private bool _isAlert;  //是否自动提示
		
		private int _days;  //天数
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 关联到DOCTOR表
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否自动提示
		/// </summary>
		public bool IsAlert
		{
			get { return _isAlert;}
			set { _isAlert = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
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


