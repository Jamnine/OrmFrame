

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户对应科室 - 实体类
	/// </summary>
	public partial class BsUserLocationMapping: ClassMap<BsUserLocation>
	{   
		/// <summary>
		/// 用户对应科室 - 实体类
		/// </summary>
		public BsUserLocationMapping()
		{
			this.TableName("BSUSERLOCATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID"); 
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.LocationId).ColumnName("LOCATIONID");
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.ModiTime).ColumnName("MODITIME");
            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID"); 
            this.Column(p => p.IsNoInRecipe).ColumnName("ISNOINRECIPE");
            this.Column(p => p.IsNoOutRecipe).ColumnName("ISNOOUTRECIPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");





            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

