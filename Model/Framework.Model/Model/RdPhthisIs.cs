

using System;
namespace Orm.Model
{
	/// <summary>
	/// 肺结核及疑似肺结核病人转诊单 - 实体类
	/// </summary>
	[Serializable]
	public partial class RdPhthisIs : BaseModel
    {   
		 
		
		private string _patId;  //
		
		private string _operTime;  //
		
		private string _operId;  //
		
		private string _code;  //
		
		private DateTime _diagDate;  //
		
		private string _diagUnit;  //
		
		private bool _isWrite;  //
		
		private string _mzRegId;  //
		
		private string _chkOperId;  //
		
		private string _hospId;  //
		
		private DateTime _chkOperTime;  //
		
		private int _fristDiage;  //初步诊断
		
		private string _bsCommitteeRoad;  //街道/村
		
		private string _cancelOperId;  //退卡人
		
		private DateTime _cancelOperTime;  //
		
		private string _cancelMemo;  //
		
		private string _illNameId;  //报告卡名称，为1
		
		private string _locId;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
        public RdPhthisIs() { }
                          
		
		/// <summary>
		/// 
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime DiagDate
		{
			get { return _diagDate;}
			set { _diagDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DiagUnit
		{
			get { return _diagUnit;}
			set { _diagUnit = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsWrite
		{
			get { return _isWrite;}
			set { _isWrite = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
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
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ChkOperTime
		{
			get { return _chkOperTime;}
			set { _chkOperTime = value;}
		}                                    
		
		/// <summary>
		/// 初步诊断
		/// </summary>
		public int FristDiage
		{
			get { return _fristDiage;}
			set { _fristDiage = value;}
		}                                    
		
		/// <summary>
		/// 街道/村
		/// </summary>
		public string BsCommitteeRoad
		{
			get { return _bsCommitteeRoad;}
			set { _bsCommitteeRoad = value;}
		}                                    
		
		/// <summary>
		/// 退卡人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CancelMemo
		{
			get { return _cancelMemo;}
			set { _cancelMemo = value;}
		}                                    
		
		/// <summary>
		/// 报告卡名称，为1
		/// </summary>
		public string IllNameId
		{
			get { return _illNameId;}
			set { _illNameId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LocId
		{
			get { return _locId;}
			set { _locId = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


