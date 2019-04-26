

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验仪器流水号匹配 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineSample : BaseModel
	{   
		 
		private string _labID;  //标本Id,CkLab.Id
		
		private string _sampleNum;  //
		
		private DateTime _matchDate;  //
		
		private bool _sendStatus;  //
		
		private string _machineID;  //检验仪器CKMachine.GUID
		
		private string _userID;  //用户Id,对应BsUser.Id
		
		private int _status;  //
		
		private string _labdeptid;  //
		
		private string _matchBy;  //
		
		private bool _isMic;  //
		
		private string _specimenHeadID;  //
		
		private string _preSeq;  //
		
		private string _barcode;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 标本Id,CkLab.Id
		/// </summary>
		public string LabID
		{
			get { return _labID;}
			set { _labID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SampleNum
		{
			get { return _sampleNum;}
			set { _sampleNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime MatchDate
		{
			get { return _matchDate;}
			set { _matchDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool SendStatus
		{
			get { return _sendStatus;}
			set { _sendStatus = value;}
		}                                    
		
		/// <summary>
		/// 检验仪器CKMachine.GUID
		/// </summary>
		public string MachineID
		{
			get { return _machineID;}
			set { _machineID = value;}
		}                                    
		
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserID
		{
			get { return _userID;}
			set { _userID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			get { return _status;}
			set { _status = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Labdeptid
		{
			get { return _labdeptid;}
			set { _labdeptid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MatchBy
		{
			get { return _matchBy;}
			set { _matchBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsMic
		{
			get { return _isMic;}
			set { _isMic = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SpecimenHeadID
		{
			get { return _specimenHeadID;}
			set { _specimenHeadID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PreSeq
		{
			get { return _preSeq;}
			set { _preSeq = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Barcode
		{
			get { return _barcode;}
			set { _barcode = value;}
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


