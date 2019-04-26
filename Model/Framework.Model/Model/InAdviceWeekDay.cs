

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院医嘱周计划表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InAdviceWeekDay:BaseModel
	{    
		private string _adviceId;  //医嘱号，对应医嘱表
		
		private int _weekDay;  //星期几
		
		private DateTime _operTime;  //保存的时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InAdviceWeekDay() { }
                                       
		
		/// <summary>
		/// 医嘱号，对应医嘱表
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 星期几
		/// </summary>
		public int WeekDay
		{
			get { return _weekDay;}
			set { _weekDay = value;}
		}                                    
		
		/// <summary>
		/// 保存的时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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


