

using System;
namespace Orm.Model
{
	/// <summary>
	/// 考试答题表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsScore : BaseModel
	{    
		private string _userID;  //考试人ID
		
		private string _testPaperId;  //试卷
		
		private int _score;  //成绩
		
		private string _answer;  //答案
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 考试人ID
		/// </summary>
		public string UserID
		{
			get { return _userID;}
			set { _userID = value;}
		}                                    
		
		/// <summary>
		/// 试卷
		/// </summary>
		public string TestPaperId
		{
			get { return _testPaperId;}
			set { _testPaperId = value;}
		}                                    
		
		/// <summary>
		/// 成绩
		/// </summary>
		public int Score
		{
			get { return _score;}
			set { _score = value;}
		}                                    
		
		/// <summary>
		/// 答案
		/// </summary>
		public string Answer
		{
			get { return _answer;}
			set { _answer = value;}
		}                                    
		
                                 
		        
	}  
}           


