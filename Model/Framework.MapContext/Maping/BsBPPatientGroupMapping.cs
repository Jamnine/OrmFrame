
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// BP的患者分组表(二级) - 实体类
    /// </summary>
    public partial class BsBPPatientGroupMapping: ClassMap<BsBPPatientGroup>
	{   
		/// <summary>
		/// BP的患者分组表(二级) - 实体类
		/// </summary>
		public BsBPPatientGroupMapping()
		{
			this.TableName("BSBPPATIENTGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatientGroup).ColumnName("PATIENTGROUP");
			  
			this.Column(p =>p.BPIllId).ColumnName("BPILLID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

