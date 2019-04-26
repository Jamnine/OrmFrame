

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadPat : BaseModel
    {    
		private string _hospId;  //
		
		private string _roadId;  //
		
		private string _operId;  //
		
		private DateTime _operTime;  //
		
		private bool _isChk;  //
		
		private DateTime _chkOperTime;  //入径时间
		
		private string _chkOperId;  //
		
		private string _memo;  //
		
		private string _changeReason;  //
		
		private string _roadLocName;  //F1入径科室
		
		private string _roadDocName;  //F2入径管床医生
		
		private bool _isExit;  //
		
		private string _exitDoctorId;  //
		
		private DateTime _exitOperTime;  //
		
		private DateTime _signNurseUsertTime;  //
		
		private int _lsTimeType;  //
		
		private int _curRstage;  //当前阶段
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsChk
		{
			get { return _isChk;}
			set { _isChk = value;}
		}                                    
		
		/// <summary>
		/// 入径时间
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ChkOperId
		{
			get { return _chkOperId;}
			set { _chkOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ChangeReason
		{
			get { return _changeReason;}
			set { _changeReason = value;}
		}                                    
		
		/// <summary>
		/// F1入径科室
		/// </summary>
		public string RoadLocName
		{
			get { return _roadLocName;}
			set { _roadLocName = value;}
		}                                    
		
		/// <summary>
		/// F2入径管床医生
		/// </summary>
		public string RoadDocName
		{
			get { return _roadDocName;}
			set { _roadDocName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsExit
		{
			get { return _isExit;}
			set { _isExit = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ExitDoctorId
		{
			get { return _exitDoctorId;}
			set { _exitDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExitOperTime
		{
			get { return _exitOperTime;}
			set { _exitOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime SignNurseUsertTime
		{
			get { return _signNurseUsertTime;}
			set { _signNurseUsertTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsTimeType
		{
			get { return _lsTimeType;}
			set { _lsTimeType = value;}
		}                                    
		
		/// <summary>
		/// 当前阶段
		/// </summary>
		public int CurRstage
		{
			get { return _curRstage;}
			set { _curRstage = value;}
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


