

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 整散比 - 实体类
	/// </summary>
	public partial class BsUnitRatioMapping: ClassMap<BsUnitRatio>
	{   
		/// <summary>
		/// 整散比 - 实体类
		/// </summary>
		public BsUnitRatioMapping()
		{
			this.TableName("BSUNITRATIO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p => p.ItemId).ColumnName("ITEMID");
            this.Column(p => p.UnitId1).ColumnName("UNITID1");
            this.Column(p => p.UnitId2).ColumnName("UNITID2");
            this.Column(p => p.DrugRatio).ColumnName("DRUGRATIO");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.ModiTime).ColumnName("MODITIME");
            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID"); 
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

