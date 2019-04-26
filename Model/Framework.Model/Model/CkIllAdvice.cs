

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkIllAdvice : BaseModel
	{   
		
		
		private string _testTypeId;  //检验类别CkTestType.Id
		
		private string _code;  //编码
		
		private string _illDesc;  //诊断
		
		private string _orderBy;  //排序
		
		private string _advice;  //医嘱

        private int _HospitalID;  //
                               
		
		/// <summary>
		/// 检验类别CkTestType.Id
		/// </summary>
		public string TestTypeId
		{
			get { return _testTypeId;}
			set { _testTypeId = value;}
		}                                    
		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public string OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 医嘱
		/// </summary>
		public string Advice
		{
			get { return _advice;}
			set { _advice = value;}
		}

   

    }  
}           


