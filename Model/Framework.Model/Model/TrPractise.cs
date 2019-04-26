

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class TrPractise:BaseModel
	{    
		
		private string _hospital;  //所属医院
		
		private string _oriId;  //客户端GblFunTrace的ID
		
		private DateTime _operTime;  //上传时间
		
		private DateTime _practiseTime;  //练习时间
		
		private int _debugMode;  //模式
		
		private string _funtion;  //功能
		
		private string _userName;  //操作员名字
		
		private string _roleName;  //角色
		
		private string _locationName;  //所属科室
		
		private string _memo;  //备注
		
		private int _HospitalID;  //
		 

		
		                          
		
		/// <summary>
		/// 所属医院
		/// </summary>
		public string Hospital
		{
			get { return _hospital;}
			set { _hospital = value;}
		}                                    
		
		/// <summary>
		/// 客户端GblFunTrace的ID
		/// </summary>
		public string OriId
		{
			get { return _oriId;}
			set { _oriId = value;}
		}                                    
		
		/// <summary>
		/// 上传时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 练习时间
		/// </summary>
		public DateTime PractiseTime
		{
			get { return _practiseTime;}
			set { _practiseTime = value;}
		}                                    
		
		/// <summary>
		/// 模式
		/// </summary>
		public int DebugMode
		{
			get { return _debugMode;}
			set { _debugMode = value;}
		}                                    
		
		/// <summary>
		/// 功能
		/// </summary>
		public string Funtion
		{
			get { return _funtion;}
			set { _funtion = value;}
		}                                    
		
		/// <summary>
		/// 操作员名字
		/// </summary>
		public string UserName
		{
			get { return _userName;}
			set { _userName = value;}
		}                                    
		
		/// <summary>
		/// 角色
		/// </summary>
		public string RoleName
		{
			get { return _roleName;}
			set { _roleName = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationName
		{
			get { return _locationName;}
			set { _locationName = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		                                   
		        
	}  
}           


