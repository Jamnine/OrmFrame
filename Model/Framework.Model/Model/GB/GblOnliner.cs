

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 客户端在线列表 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblOnliner : BaseModel
    {   
		
		
		
		private int _userId;  //在线用户
		
		private string _workStationName;  //HostName
		
		private string _lockIp;  //客户端IP
		
		private DateTime _loginTime;  //最新时间
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 在线用户
		/// </summary>
		public int UserId
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
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


