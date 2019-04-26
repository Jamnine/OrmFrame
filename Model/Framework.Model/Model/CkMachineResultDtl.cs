

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验仪器结果明细表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineResultDtl : BaseModel
	{    
		private string _resultID;  //CKMachineResult.GUID
		
		private string _testID;  //检验项目ID,对应CkItem.Id
		
		private string _result;  //结果
		
		private string _bench;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// CKMachineResult.GUID
		/// </summary>
		public string ResultID
		{
			get { return _resultID;}
			set { _resultID = value;}
		}                                    
		
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestID
		{
			get { return _testID;}
			set { _testID = value;}
		}                                    
		
		/// <summary>
		/// 结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string bench
		{
			get { return _bench;}
			set { _bench = value;}
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


