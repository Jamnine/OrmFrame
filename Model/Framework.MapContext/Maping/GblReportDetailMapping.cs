

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 报表内容设置 - 实体类
	/// </summary>
	public partial class GblReportDetailMapping: ClassMap<GblReportDetail>
	{   
		/// <summary>
		/// 报表内容设置 - 实体类
		/// </summary>
		public GblReportDetailMapping()
		{
			this.TableName("GBLREPORTDETAIL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.GroupId).ColumnName("GROUPID");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

