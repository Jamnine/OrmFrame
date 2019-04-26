

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验结果选择 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkItemResult : BaseModel
	{    
		private string _testId;  //项目代码
		
		private string _result;  //结果
		
		private bool _isBold;  //打印黑体
		
		private bool _isPass;  //是否合格
		
		private string _summary;  //体检小结
		
		private string _doctorAdvice;  //医生建议
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 项目代码
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
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
		/// 打印黑体
		/// </summary>
		public bool IsBold
		{
			get { return _isBold;}
			set { _isBold = value;}
		}                                    
		
		/// <summary>
		/// 是否合格
		/// </summary>
		public bool IsPass
		{
			get { return _isPass;}
			set { _isPass = value;}
		}                                    
		
		/// <summary>
		/// 体检小结
		/// </summary>
		public string Summary
		{
			get { return _summary;}
			set { _summary = value;}
		}                                    
		
		/// <summary>
		/// 医生建议
		/// </summary>
		public string DoctorAdvice
		{
			get { return _doctorAdvice;}
			set { _doctorAdvice = value;}
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


