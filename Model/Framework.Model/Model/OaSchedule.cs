

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaSchedule : BaseModel
    {   
		 
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //日程所有人
		
		private string _subject;  //主题
		
		private string _location;  //地点
		
		private DateTime _startTime;  //开始时间
		
		private DateTime _endTime;  //结束时间
		
		private string _description;  //日程描述
		
		private string _labelId;  //图标
		
		private DateTime _reminder;  //提醒时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 日程所有人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 主题
		/// </summary>
		public string Subject
		{
			get { return _subject;}
			set { _subject = value;}
		}                                    
		
		/// <summary>
		/// 地点
		/// </summary>
		public string Location
		{
			get { return _location;}
			set { _location = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime
		{
			get { return _startTime;}
			set { _startTime = value;}
		}                                    
		
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		
		/// <summary>
		/// 日程描述
		/// </summary>
		public string Description
		{
			get { return _description;}
			set { _description = value;}
		}                                    
		
		/// <summary>
		/// 图标
		/// </summary>
		public string LabelId
		{
			get { return _labelId;}
			set { _labelId = value;}
		}                                    
		
		/// <summary>
		/// 提醒时间
		/// </summary>
		public DateTime Reminder
		{
			get { return _reminder;}
			set { _reminder = value;}
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


