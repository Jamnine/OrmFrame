

using System;
namespace Orm.Model
{
	/// <summary>
	/// 问题库 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsQuestion : BaseModel
	{    
		private string _question;  //题目
		
		private string _answer;  //答案
		
		private string _optionA;  //选项A
		
		private string _optionB;  //选项B
		
		private string _optionC;  //选项C
		
		private string _optionD;  //选项D
		
		private string _subjectId;  //科目
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 题目
		/// </summary>
		public string Question
		{
			get { return _question;}
			set { _question = value;}
		}                                    
		
		/// <summary>
		/// 答案
		/// </summary>
		public string Answer
		{
			get { return _answer;}
			set { _answer = value;}
		}                                    
		
		/// <summary>
		/// 选项A
		/// </summary>
		public string OptionA
		{
			get { return _optionA;}
			set { _optionA = value;}
		}                                    
		
		/// <summary>
		/// 选项B
		/// </summary>
		public string OptionB
		{
			get { return _optionB;}
			set { _optionB = value;}
		}                                    
		
		/// <summary>
		/// 选项C
		/// </summary>
		public string OptionC
		{
			get { return _optionC;}
			set { _optionC = value;}
		}                                    
		
		/// <summary>
		/// 选项D
		/// </summary>
		public string OptionD
		{
			get { return _optionD;}
			set { _optionD = value;}
		}                                    
		
		/// <summary>
		/// 科目
		/// </summary>
		public string SubjectId
		{
			get { return _subjectId;}
			set { _subjectId = value;}
		}                                    
		
	                                 
		        
	}  
}           


