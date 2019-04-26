

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 报表内容分组 - 实体类
	/// </summary>
	public partial class GblReportGroupMapping: ClassMap<GblReportGroup>
	{   
		/// <summary>
		/// 报表内容分组 - 实体类
		/// </summary>
		public GblReportGroupMapping()
		{
			this.TableName("GBLREPORTGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ReportId).ColumnName("REPORTID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

