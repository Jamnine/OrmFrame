

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验操作日志表 - 实体类
	/// </summary>
	[Serializable]
	public partial class TrCkActionlog:BaseModel
	{   
		
	 
		
		private string _button;  //操作按钮
		
		private string _operId;  //操作人
		
		private DateTime _operTime;  //操作时间
		
		private string _hostName;  //客户端主机名
		
		private string _error;  //错误提示.
		
		private int _patSource;  //条码来源：1门诊2住院3体验4其它医院
		
		private string _labId;  //标本ID，CkLab.Id
		
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
		/// 条码来源：1门诊2住院3体验4其它医院
		/// </summary>
		public int PatSource
		{
			get { return _patSource;}
			set { _patSource = value;}
		}                                    
		
		/// <summary>
		/// 标本ID，CkLab.Id
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
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


