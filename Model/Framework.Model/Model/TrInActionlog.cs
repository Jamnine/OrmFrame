

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院操作日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrInActionlog:BaseModel
	{   
		
	 
		
		private string _button;  //操作按钮
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private string _hostName;  //客户端主机名
		
		private string _error;  //错误提示.
		
		private string _locationId;  //科室
		
		private string _hospId;  //病人ID
		
		private string _tableName;  //关键主表名,比如医嘱表，查对表。
		
		private string _pkId;  //关键主表ID
		
		private string _actionDesc;  //动作描述
		
		private int _HospitalID;  //
		 

		
		                          
		
		/// <summary>
		/// 操作按钮
		/// </summary>
		public string Button
		{
			get { return _button;}
			set { _button = value;}
		}                                    
		
		/// <summary>
		/// 操作人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 客户端主机名
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
		}                                    
		
		/// <summary>
		/// 错误提示.
		/// </summary>
		public string Error
		{
			get { return _error;}
			set { _error = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 关键主表名,比如医嘱表，查对表。
		/// </summary>
		public string TableName
		{
			get { return _tableName;}
			set { _tableName = value;}
		}                                    
		
		/// <summary>
		/// 关键主表ID
		/// </summary>
		public string PkId
		{
			get { return _pkId;}
			set { _pkId = value;}
		}                                    
		
		/// <summary>
		/// 动作描述
		/// </summary>
		public string ActionDesc
		{
			get { return _actionDesc;}
			set { _actionDesc = value;}
		}                                    
		                                
		        
	}  
}           


