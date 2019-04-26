

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库操作日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrHuActionlog:BaseModel
	{   
		
	 
		
		private string _button;  //操作按钮
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private string _hostName;  //客户端主机名
		
		private string _error;  //错误提示.
		
		private string _houseId;  //仓库
		
		private string _inBatchId;  //库存表HuStores.GUID
		
		private string _tableName;  //关键主表名,比如采购入表，库存表。
		
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
		/// 仓库
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 库存表HuStores.GUID
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
		}                                    
		
		/// <summary>
		/// 关键主表名,比如采购入表，库存表。
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


