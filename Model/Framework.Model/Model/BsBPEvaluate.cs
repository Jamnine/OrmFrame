

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的评估选择表(门诊就诊左下的评估选择) - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPEvaluate:BaseModel
	{    
		private string _evaluateId;  //
		
		private string _evaluateName;  //
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private string _shortName;  //简称

        private int _hospitalId;//医院ID

         
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
		public string EvaluateName
		{
			get { return _evaluateName;}
			set { _evaluateName = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 简称
		/// </summary>
		public string ShortName
		{
			get { return _shortName;}
			set { _shortName = value;}
		}


    }  
}           


