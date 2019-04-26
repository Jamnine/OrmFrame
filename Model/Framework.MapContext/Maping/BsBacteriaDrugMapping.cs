

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病菌对应抗菌药表 - 实体类
	/// </summary>
	public partial class BsBacteriaDrugMapping: ClassMap<BsBacteriaDrug>
	{   
		/// <summary>
		/// 病菌对应抗菌药表 - 实体类
		/// </summary>
		public BsBacteriaDrugMapping()
		{
			this.TableName("BSBACTERIADRUG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BactriaId).ColumnName("BACTRIAID");
			  
			this.Column(p =>p.DrugId).ColumnName("DRUGID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

