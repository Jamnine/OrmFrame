

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:质控组 - 实体类
	/// </summary>
	public partial class BcQcGroupMapping: ClassMap<BcQcGroup>
	{   
		/// <summary>
		/// 行心云:质控组 - 实体类
		/// </summary>
		public BcQcGroupMapping()
		{
			this.TableName("BCQCGROUP").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.QcGroupName).ColumnName("QCGROUPNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			   
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

