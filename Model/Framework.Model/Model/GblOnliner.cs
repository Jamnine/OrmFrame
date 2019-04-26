

using System;
namespace Orm.Model
{
	/// <summary>
	/// 客户端在线列表 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblOnliner : BaseModel
    {    
		private string _userId;  //在线用户
		
		private string _workStationName;  //HostName
		
		private string _lockIp;  //客户端IP
		
		private DateTime _loginTime;  //最新时间
		
		private int _HospitalID;  //
		 
                                
		
		/// <summary>
		/// 在线用户
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// HostName
		/// </summary>
		public string WorkStationName
		{
			get { return _workStationName;}
			set { _workStationName = value;}
		}                                    
		
		/// <summary>
		/// 客户端IP
		/// </summary>
		public string LockIp
		{
			get { return _lockIp;}
			set { _lockIp = value;}
		}                                    
		
		/// <summary>
		/// 最新时间
		/// </summary>
		public DateTime LoginTime
		{
			get { return _loginTime;}
			set { _loginTime = value;}
		}                                    
		                                  
		        
	}  
}           


