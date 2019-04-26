

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 手术项目 - 实体类
	/// </summary>
	public partial class BsOpsItemMapping: ClassMap<BsOpsItem>
	{   
		/// <summary>
		/// 手术项目 - 实体类
		/// </summary>
		public BsOpsItemMapping()
		{
			this.TableName("BSOPSITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OpsItem).ColumnName("OPSITEM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

