

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 报表内容分组 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblReportGroup : BaseModel
    {   
		
		
		
		private int _reportId;  //GblReport.ID
		
		private string _name;  //名称
		
		private int _orderBy;  //排序
		
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
		/// GblReport.ID
		/// </summary>
		public int ReportId
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


