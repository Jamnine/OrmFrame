

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊医生日排班时间段 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDocSpanSub:BaseModel
	{   
		 
		private string _weekPlanId;  //周排班Id,BsDocRegType.id
		
		private int _spanLimitNum;  //班次号源数
		
		private int _subLimitNum;  //时间段号源数
		
		private string _timeSpanSubId;  //时间段ID
		
		private string _dayPlanId;  //日排班ID
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
        /// <summary>
        /// 周排班Id,BsDocRegType.id WEEKPlanID WeekPlanId
        /// </summary>
        public string WeekPlanId
        {
			get { return _weekPlanId;}
			set { _weekPlanId = value;}
		}

        /// <summary>
        /// 班次号源数
        /// </summary>
        public int SpanLimitNum
		{
			get { return _spanLimitNum;}
			set { _spanLimitNum = value;}
		}                                    
		
		/// <summary>
		/// 时间段号源数
		/// </summary>
		public int SubLimitNum
		{
			get { return _subLimitNum;}
			set { _subLimitNum = value;}
		}

        /// <summary>
        /// 时间段ID TimeSPANSubID TimeSpanSubId
        /// </summary>
        public string TimeSpanSubId
        {
			get { return _timeSpanSubId;}
			set { _timeSpanSubId = value;}
		}                                    
		
		/// <summary>
		/// 日排班ID
		/// </summary>
		public string DayPlanId
		{
			get { return _dayPlanId;}
			set { _dayPlanId = value;}
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


