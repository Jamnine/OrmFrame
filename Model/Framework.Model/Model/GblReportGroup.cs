

using System;
namespace Orm.Model
{
	/// <summary>
	/// 报表内容分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblReportGroup : BaseModel
    {    
		private string _reportId;  //GblReport.GUID
		
		private string _name;  //名称
		
		private int _orderBy;  //排序
		
		private int _HospitalID;  //
		 

		                              
		
		/// <summary>
		/// GblReport.GUID
		/// </summary>
		public string ReportId
		{
			get { return _reportId;}
			set { _reportId = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		                                  
		        
	}  
}           


