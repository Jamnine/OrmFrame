

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的治疗方案及小字说明表(三级) - 实体类
	/// </summary>
	public partial class BsBPCureMapping: ClassMap<BsBPCure>
	{   
		/// <summary>
		/// BP的治疗方案及小字说明表(三级) - 实体类
		/// </summary>
		public BsBPCureMapping()
		{
			this.TableName("BSBPCURE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CureRuleName).ColumnName("CURERULENAME");
			  
			this.Column(p =>p.CureRuleDesc).ColumnName("CURERULEDESC");
			  
			this.Column(p =>p.BPIllId).ColumnName("BPILLID");
			  
			this.Column(p =>p.BPGroupId).ColumnName("BPGROUPID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

