

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPEvaluateTest:BaseModel
	{   
	 
		private string _bPItemId;  //
		
		private string _evaluateId;  //
		
		private bool _isCommon;  //
		
		private string _bPIllId;  //
		
		private int _testType;  //

        private int _HospitalID;//医院ID

         
		/// <summary>
		/// 
		/// </summary>
		public string BPItemId
		{
			get { return _bPItemId;}
			set { _bPItemId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EvaluateId
		{
			get { return _evaluateId;}
			set { _evaluateId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsCommon
		{
			get { return _isCommon;}
			set { _isCommon = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BPIllId
		{
			get { return _bPIllId;}
			set { _bPIllId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int TestType
		{
			get { return _testType;}
			set { _testType = value;}
		}
   
    }  
}           


