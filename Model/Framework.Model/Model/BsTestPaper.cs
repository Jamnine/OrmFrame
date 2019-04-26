

using System;
namespace Orm.Model
{
	/// <summary>
	/// 考试问题分配表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsTestPaper:BaseModel
	{   
		 
		private string _name;  //试卷名
		
		private string _userId;  //出卷人
		
		private DateTime _generateTime;  //出卷人
		
		private string _questionId;  //试题
		
		private string _usersId;  //考试人id
		
		private int _minute;  //考试时间单位分钟

        private string _modioperId;//行心云:最后修改人

        private DateTime _moditime;//行心云:最后修改时间

        private int _HospitalID;//医院ID

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modioperId; }
            set { _modioperId = value; }
        }

        /// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime Moditime
        {
            get { return _moditime; }
            set { _moditime = value; }
        }


    
         
		/// <summary>
		/// 试卷名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 出卷人
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 出卷时间
		/// </summary>
		public DateTime GenerateTime
		{
			get { return _generateTime;}
			set { _generateTime = value;}
		}                                    
		
		/// <summary>
		/// 试题
		/// </summary>
		public string QuestionId
		{
			get { return _questionId;}
			set { _questionId = value;}
		}                                    
		
		/// <summary>
		/// 考试人id
		/// </summary>
		public string UsersId
		{
			get { return _usersId;}
			set { _usersId = value;}
		}                                    
		
		/// <summary>
		/// 考试时间单位分钟
		/// </summary>
		public int Minute
		{
			get { return _minute;}
			set { _minute = value;}
		}                                    
		        
	}  
}           


