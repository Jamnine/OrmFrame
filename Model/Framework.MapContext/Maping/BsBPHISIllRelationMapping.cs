

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的诊断跟HIS诊断的对应关系表 - 实体类
	/// </summary>
	public partial class BsBPHISIllRelationMapping: ClassMap<BsBPHISIllRelation>
	{   
		/// <summary>
		/// BP的诊断跟HIS诊断的对应关系表 - 实体类
		/// </summary>
		public BsBPHISIllRelationMapping()
		{
			this.TableName("BSBPHISILLRELATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BPIllId).ColumnName("BPILLID");
			  
			this.Column(p =>p.HISIllId).ColumnName("HISILLID");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

