

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:医生日常事务表 - 实体类
	/// </summary>
	[Serializable]
	public partial class MyafFairs : BaseModel
	{   
		  
		private string _operId;  //操作人ID
		
		private string _content;  //相关事务
		
		private DateTime _affairTime;  //事务时间
		
		private DateTime _lastUpdateTime;  //最后修改时间
		
		private string _remindUserId;  //提醒人ID
		
		private string _remindUserName;  //提醒人姓名
		
		private int _lsState;  //状态 0:初始状态 1:以读状态
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 操作人ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 相关事务
		/// </summary>
		public string Content
		{
			get { return _content;}
			set { _content = value;}
		}                                    
		
		/// <summary>
		/// 事务时间
		/// </summary>
		public DateTime AffairTime
		{
			get { return _affairTime;}
			set { _affairTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime LastUpdateTime
		{
			get { return _lastUpdateTime;}
			set { _lastUpdateTime = value;}
		}                                    
		
		/// <summary>
		/// 提醒人ID
		/// </summary>
		public string RemindUserId
		{
			get { return _remindUserId;}
			set { _remindUserId = value;}
		}                                    
		
		/// <summary>
		/// 提醒人姓名
		/// </summary>
		public string RemindUserName
		{
			get { return _remindUserName;}
			set { _remindUserName = value;}
		}                                    
		
		/// <summary>
		/// 状态 0:初始状态 1:以读状态
		/// </summary>
		public int LsState
		{
			get { return _lsState;}
			set { _lsState = value;}
		}                                    
		                                 
		        
	}  
}           


