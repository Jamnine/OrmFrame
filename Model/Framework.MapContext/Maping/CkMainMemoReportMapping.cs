

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMainMemoReportMapping: ClassMap<CkMainMemoReport>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMainMemoReportMapping()
		{
			this.TableName("CKMAINMEMOREPORT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.GroupName).ColumnName("GROUPNAME");
			  
			this.Column(p =>p.GroupSubName).ColumnName("GROUPSUBNAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

