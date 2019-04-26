

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineNoPassage : BaseModel
	{   
		 
		private string _machineID;  //检验仪器CKMachine.GUID
		
		private string _passAgeNum;  //
		
		private string _testResuslt;  //
		
		private DateTime _resultDate;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 检验仪器CKMachine.GUID
		/// </summary>
		public string MachineID
		{
			get { return _machineID;}
			set { _machineID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PassAgeNum
		{
			get { return _passAgeNum;}
			set { _passAgeNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TestResuslt
		{
			get { return _testResuslt;}
			set { _testResuslt = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime ResultDate
		{
			get { return _resultDate;}
			set { _resultDate = value;}
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


