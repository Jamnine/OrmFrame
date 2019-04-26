

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历修改记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class EmrReCords:BaseModel
	{    
		
		private DateTime _inTime;  //入院时间
		
		private DateTime _outTime;  //出院时间
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private DateTime _modifyTime;  //修改时间
		
		private string _recContent;  //修改内容
		
		private DateTime _firstReTime;  //原始书写时间
		
		private string _inEmrId;  //电子病历ID,InEmr.Id
		
		private bool _isActive;  //是否有效标识
		
		private bool _isModify;  //是否修改
		
		private string _locationId;  //科室
		
		private string _patientName;  //病人名字
		
		private string _inPatNo;  //住院号
		
		private DateTime _operTime;  //记录时间
		
		private DateTime _noteTime;  //病历节点时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public EmrReCords() { }
                
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
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModifyTime
		{
			get { return _modifyTime;}
			set { _modifyTime = value;}
		}                                    
		
		/// <summary>
		/// 修改内容
		/// </summary>
		public string RecContent
		{
			get { return _recContent;}
			set { _recContent = value;}
		}                                    
		
		/// <summary>
		/// 原始书写时间
		/// </summary>
		public DateTime FirstReTime
		{
			get { return _firstReTime;}
			set { _firstReTime = value;}
		}                                    
		
		/// <summary>
		/// 电子病历ID,InEmr.Id
		/// </summary>
		public string InEmrId
		{
			get { return _inEmrId;}
			set { _inEmrId = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 是否修改
		/// </summary>
		public bool IsModify
		{
			get { return _isModify;}
			set { _isModify = value;}
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
		/// 病人名字
		/// </summary>
		public string PatientName
		{
			get { return _patientName;}
			set { _patientName = value;}
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
		/// 记录时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 病历节点时间
		/// </summary>
		public DateTime NoteTime
		{
			get { return _noteTime;}
			set { _noteTime = value;}
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


