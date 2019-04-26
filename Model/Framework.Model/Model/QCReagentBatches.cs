

using System;
namespace Orm.Model
{
	/// <summary>
	/// QC试剂批号 - 实体类
	/// </summary>
	[Serializable]
	public partial class QCReagentBatches:BaseModel
	{    
		private string _qCNum;  //质控流水号
		
		private string _qCstandId;  //标准样品id
		
		private string _cKMId;  //仪器id
		
		private DateTime _dueTime;  //到期时间
		
		private string _qCReagentlot;  //试剂批号
		
		private string _qCReagentName;  //试剂名称
		
		private string _qCqualityName;  //质控名称
		
		private DateTime _enablingTime;  //启用日期
		  
		
		/// <summary>
		/// 质控流水号
		/// </summary>
		public string QCNum
		{
			get { return _qCNum;}
			set { _qCNum = value;}
		}                                    
		
		/// <summary>
		/// 标准样品id
		/// </summary>
		public string QCstandId
		{
			get { return _qCstandId;}
			set { _qCstandId = value;}
		}                                    
		
		/// <summary>
		/// 仪器id
		/// </summary>
		public string CKMId
		{
			get { return _cKMId;}
			set { _cKMId = value;}
		}                                    
		
		/// <summary>
		/// 到期时间
		/// </summary>
		public DateTime DueTime
		{
			get { return _dueTime;}
			set { _dueTime = value;}
		}                                    
		
		/// <summary>
		/// 试剂批号
		/// </summary>
		public string QCReagentlot
		{
			get { return _qCReagentlot;}
			set { _qCReagentlot = value;}
		}                                    
		
		/// <summary>
		/// 试剂名称
		/// </summary>
		public string QCReagentName
		{
			get { return _qCReagentName;}
			set { _qCReagentName = value;}
		}                                    
		
		/// <summary>
		/// 质控名称
		/// </summary>
		public string QCqualityName
		{
			get { return _qCqualityName;}
			set { _qCqualityName = value;}
		}                                    
		
		/// <summary>
		/// 启用日期
		/// </summary>
		public DateTime EnablingTime
		{
			get { return _enablingTime;}
			set { _enablingTime = value;}
		}                                    
		        
	}  
}           


