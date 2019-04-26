

using System;
namespace Orm.Model
{
	/// <summary>
	/// 换床记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class InChangeBed:BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _lsLocal;  //换床类别：1-本科换床；2-转科换床
		
		private DateTime _chgTime;  //换床时间
		
		private int _preBed;  //换床前床位
		
		private int _postBed;  //换床后床位
		
		private string _reason;  //换床原因
		
		private string _doctorId;  //批准医生
		
		private DateTime _operTime;  //记录时间
		
		private string _operId;  //记录人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InChangeBed() { }
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 换床类别：1-本科换床；2-转科换床
		/// </summary>
		public int LsLocal
		{
			get { return _lsLocal;}
			set { _lsLocal = value;}
		}                                    
		
		/// <summary>
		/// 换床时间
		/// </summary>
		public DateTime ChgTime
		{
			get { return _chgTime;}
			set { _chgTime = value;}
		}                                    
		
		/// <summary>
		/// 换床前床位
		/// </summary>
		public int PreBed
		{
			get { return _preBed;}
			set { _preBed = value;}
		}                                    
		
		/// <summary>
		/// 换床后床位
		/// </summary>
		public int PostBed
		{
			get { return _postBed;}
			set { _postBed = value;}
		}                                    
		
		/// <summary>
		/// 换床原因
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 批准医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 记录人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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


