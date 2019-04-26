

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 质控标准 - 实体类
	/// </summary>
	public partial class CkQcControlMapping: ClassMap<CkQcControl>
	{   
		/// <summary>
		/// 质控标准 - 实体类
		/// </summary>
		public CkQcControlMapping()
		{
			this.TableName("CKQCCONTROL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

