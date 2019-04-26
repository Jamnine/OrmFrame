

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验仪器结果主表 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineResult : BaseModel
	{    
		private string _labID;  //标本Id,CkLab.Id
		
		private string _sampleNum;  //
		
		private DateTime _testDate;  //
		
		private string _machineID;  //检验仪器CKMachine.GUID
		
		private string _testTypeID;  //体检分类,CkTestType.Id
		
		private string _batchNo;  //
		
		private bool _isUse;  //
		
		private DateTime _createDate;  //
		
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
		public DateTime TestDate
		{
			get { return _testDate;}
			set { _testDate = value;}
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
		/// 体检分类,CkTestType.Id
		/// </summary>
		public string TestTypeID
		{
			get { return _testTypeID;}
			set { _testTypeID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BatchNo
		{
			get { return _batchNo;}
			set { _batchNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsUse
		{
			get { return _isUse;}
			set { _isUse = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
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


