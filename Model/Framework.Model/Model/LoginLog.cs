

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:系统登录日志 - 实体类
	/// </summary>
	[Serializable]
	public partial class LoginLog : BaseModel
	{    
		private string _hostName;  //电脑名称
		
		private string _hostGuId;  //电脑GUID
		
		private string _loginUserId;  //登录的用户ID
		
		private string _loginUserName;  //登录的用户名称
		
		private string _loginLocationId;  //登录的科室ID
		
		private string _loginLocationName;  //登录的科室名称
		
		private DateTime _loginDate;  //登录时间
		
		private DateTime _quitDate;  //退出时间
		
		private double _serviceVersIonnum;  //上传的最新版本号
		
		private double _clientVersIonnum;  //客户端的版本号
		
		private double _customerdbVersIonnum;  //客户的数据库版本号
		
		private string _operId;  //操作员ID
		
		private DateTime _operLastDate;  //最后修改时间
		
		private string _ex1;  //
		
		private string _ex2;  //
		
		private string _ex3;  //
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 电脑名称
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
		}                                    
		
		/// <summary>
		/// 电脑GUID
		/// </summary>
		public string HostGuId
		{
			get { return _hostGuId;}
			set { _hostGuId = value;}
		}                                    
		
		/// <summary>
		/// 登录的用户ID
		/// </summary>
		public string LoginUserId
		{
			get { return _loginUserId;}
			set { _loginUserId = value;}
		}                                    
		
		/// <summary>
		/// 登录的用户名称
		/// </summary>
		public string LoginUserName
		{
			get { return _loginUserName;}
			set { _loginUserName = value;}
		}                                    
		
		/// <summary>
		/// 登录的科室ID
		/// </summary>
		public string LoginLocationId
		{
			get { return _loginLocationId;}
			set { _loginLocationId = value;}
		}                                    
		
		/// <summary>
		/// 登录的科室名称
		/// </summary>
		public string LoginLocationName
		{
			get { return _loginLocationName;}
			set { _loginLocationName = value;}
		}                                    
		
		/// <summary>
		/// 登录时间
		/// </summary>
		public DateTime LoginDate
		{
			get { return _loginDate;}
			set { _loginDate = value;}
		}                                    
		
		/// <summary>
		/// 退出时间
		/// </summary>
		public DateTime QuitDate
		{
			get { return _quitDate;}
			set { _quitDate = value;}
		}                                    
		
		/// <summary>
		/// 上传的最新版本号
		/// </summary>
		public double ServiceVersIonnum
		{
			get { return _serviceVersIonnum;}
			set { _serviceVersIonnum = value;}
		}                                    
		
		/// <summary>
		/// 客户端的版本号
		/// </summary>
		public double ClientVersIonnum
		{
			get { return _clientVersIonnum;}
			set { _clientVersIonnum = value;}
		}                                    
		
		/// <summary>
		/// 客户的数据库版本号
		/// </summary>
		public double CustomerdbVersIonnum
		{
			get { return _customerdbVersIonnum;}
			set { _customerdbVersIonnum = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime OperLastDate
		{
			get { return _operLastDate;}
			set { _operLastDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Ex1
		{
			get { return _ex1;}
			set { _ex1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Ex2
		{
			get { return _ex2;}
			set { _ex2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Ex3
		{
			get { return _ex3;}
			set { _ex3 = value;}
		}                                    
		                                 
		        
	}  
}           


