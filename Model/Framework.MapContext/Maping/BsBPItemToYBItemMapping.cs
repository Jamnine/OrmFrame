

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsBPItemToYBItemMapping: ClassMap<BsBPItemToYBItem>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsBPItemToYBItemMapping()
		{
			this.TableName("BSBPITEMTOYBITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BPItemName).ColumnName("BPITEMNAME");
			  
			this.Column(p =>p.YBItemName).ColumnName("YBITEMNAME");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

