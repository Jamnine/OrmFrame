

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房操作日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrRmActionlog:BaseModel
	{    
		private string _button;  //操作按钮
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private string _hostName;  //客户端主机名
		
		private string _error;  //错误提示.
		
		private string _roomId;  //药房
		
		private string _inBatchId;  //药房表RmStores.GUID
		
		private string _tableName;  //关键主表名,比如入房表，库存表。
		
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
		/// 药房
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 药房表RmStores.GUID
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
		}                                    
		
		/// <summary>
		/// 关键主表名,比如入房表，库存表。
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


