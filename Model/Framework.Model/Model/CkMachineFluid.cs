

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineFluid : BaseModel
	{   
		 
		private string _machineID;  //检验仪器CKMachine.GUID
		
		private string _bodyFluidId;  //
		
		private string _machineFluidCode;  //
		
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
		public string BodyFluidId
		{
			get { return _bodyFluidId;}
			set { _bodyFluidId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MachineFluidCode
		{
			get { return _machineFluidCode;}
			set { _machineFluidCode = value;}
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


