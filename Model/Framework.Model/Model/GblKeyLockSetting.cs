

using System;
namespace Orm.Model
{
	/// <summary>
	/// 锁信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblKeyLockSetting : BaseModel
    {    
		private string _keyTypeId;  //锁类型：1-门诊流水号；2-住院中药处方号；3-住院流水号；4-领药单号；5-检验标本号；6-门诊发药
		
		private string _keyValue;  //键值
		
		private string _workStationName;  //机器名
		
		private string _userId;  //用户Id,对应BsUser.Id
		
		private string _userName;  //用户名
		
		private string _lockIp;  //ID地址
		
		private DateTime _lockTime;  //锁定时间
		
		private string _spID;  //锁定时的SPID
		
		private DateTime _loginTime;  //登陆时间
		
		private int _HospitalID;  //
		 
                                    
		
		/// <summary>
		/// 锁类型：1-门诊流水号；2-住院中药处方号；3-住院流水号；4-领药单号；5-检验标本号；6-门诊发药
		/// </summary>
		public string KeyTypeId
		{
			get { return _keyTypeId;}
			set { _keyTypeId = value;}
		}                                    
		
		/// <summary>
		/// 键值
		/// </summary>
		public string KeyValue
		{
			get { return _keyValue;}
			set { _keyValue = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string WorkStationName
		{
			get { return _workStationName;}
			set { _workStationName = value;}
		}                                    
		
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			get { return _userName;}
			set { _userName = value;}
		}                                    
		
		/// <summary>
		/// ID地址
		/// </summary>
		public string LockIp
		{
			get { return _lockIp;}
			set { _lockIp = value;}
		}                                    
		
		/// <summary>
		/// 锁定时间
		/// </summary>
		public DateTime LockTime
		{
			get { return _lockTime;}
			set { _lockTime = value;}
		}                                    
		
		/// <summary>
		/// 锁定时的SPID
		/// </summary>
		public string SpID
		{
			get { return _spID;}
			set { _spID = value;}
		}                                    
		
		/// <summary>
		/// 登陆时间
		/// </summary>
		public DateTime LoginTime
		{
			get { return _loginTime;}
			set { _loginTime = value;}
		}                                    
		                                
		        
	}  
}           


