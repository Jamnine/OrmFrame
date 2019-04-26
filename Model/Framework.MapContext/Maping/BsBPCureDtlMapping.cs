

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的治疗方案明细表(具体使用哪些项目) - 实体类
	/// </summary>
	public partial class BsBPCureDtlMapping: ClassMap<BsBPCureDtl>
	{   
		/// <summary>
		/// BP的治疗方案明细表(具体使用哪些项目) - 实体类
		/// </summary>
		public BsBPCureDtlMapping()
		{
			this.TableName("BSBPCUREDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CureId).ColumnName("CUREID");
			  
			this.Column(p =>p.BPItemId).ColumnName("BPITEMID");
			  
			this.Column(p =>p.TypeCode).ColumnName("TYPECODE");
			  
			this.Column(p =>p.RelationCode).ColumnName("RELATIONCODE");
			  
			this.Column(p =>p.WayCode).ColumnName("WAYCODE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

