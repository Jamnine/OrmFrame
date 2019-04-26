

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:健康顾问日排班表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuAdviserSchedule:BaseModel
	{    
		private DateTime _scheduledate;  //出诊日期
		
		private string _adviserId;  //顾问ID
		
		private int _sortno;  //排班序号
		
		private int _booktotal;  //挂号总次数
		
		private DateTime _bookLastTime;  //上一次挂号时间
		
		private string _operId;  //登记人
		
		private DateTime _operTime;  //登记时间
		
		private string _stopOperID;  //停诊人
		
		private string _deleteOperID;  //删除人
		
		private DateTime _deleteTime;  //删除时间
		
		private bool _isStop;  //是否停诊
		
		private bool _isActive;  //是否可用
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 出诊日期
		/// </summary>
		public DateTime ScheduleDate
		{
			get { return _scheduledate;}
			set { _scheduledate = value;}
		}                                    
		
		/// <summary>
		/// 顾问ID
		/// </summary>
		public string AdviserId
		{
			get { return _adviserId;}
			set { _adviserId = value;}
		}                                    
		
		/// <summary>
		/// 排班序号
		/// </summary>
		public int SortNo
		{
			get { return _sortno;}
			set { _sortno = value;}
		}                                    
		
		/// <summary>
		/// 挂号总次数
		/// </summary>
		public int BookTotal
		{
			get { return _booktotal;}
			set { _booktotal = value;}
		}                                    
		
		/// <summary>
		/// 上一次挂号时间
		/// </summary>
		public DateTime BookLastTime
		{
			get { return _bookLastTime;}
			set { _bookLastTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 停诊人
		/// </summary>
		public string StopOperID
		{
			get { return _stopOperID;}
			set { _stopOperID = value;}
		}                                    
		
		/// <summary>
		/// 删除人
		/// </summary>
		public string DeleteOperID
		{
			get { return _deleteOperID;}
			set { _deleteOperID = value;}
		}                                    
		
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime DeleteTime
		{
			get { return _deleteTime;}
			set { _deleteTime = value;}
		}                                    
		
		/// <summary>
		/// 是否停诊
		/// </summary>
		public bool IsStop
		{
			get { return _isStop;}
			set { _isStop = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		                                
		        
	}  
}           


