

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 护理工作量项目 - 实体类
	/// </summary>
	public partial class BsReportNurseItemMapping: ClassMap<BsReportNurseItem>
	{   
		/// <summary>
		/// 护理工作量项目 - 实体类
		/// </summary>
		public BsReportNurseItemMapping()
		{
			this.TableName("BSREPORTNURSEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FeeName).ColumnName("FEENAME");
			  
			this.Column(p =>p.code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.spec).ColumnName("SPEC");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.IsOuInAll).ColumnName("ISOUINALL");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

