

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验附加项目 - 实体类
	/// </summary>
	public partial class BsLabSourceItemMapping: ClassMap<BsLabSourceItem>
	{   
		/// <summary>
		/// 检验附加项目 - 实体类
		/// </summary>
		public BsLabSourceItemMapping()
		{
			this.TableName("BSLABSOURCEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.SourceId).ColumnName("SOURCEID");
			  
			this.Column(p =>p.TubeTypeId).ColumnName("TUBETYPEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.LsUseArea).ColumnName("LSUSEAREA");
			  
			this.Column(p =>p.IsOnlyUseOne).ColumnName("ISONLYUSEONE");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE"); 

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

