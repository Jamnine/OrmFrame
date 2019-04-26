

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的诊断表(一级) - 实体类
	/// </summary>
	public partial class BsBPIllListMapping: ClassMap<BsBPIllList>
	{   
		/// <summary>
		/// BP的诊断表(一级) - 实体类
		/// </summary>
		public BsBPIllListMapping()
		{
			this.TableName("BSBPILLLIST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BPIllId).ColumnName("BPILLID");
			  
			this.Column(p =>p.BPIllName).ColumnName("BPILLNAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.ICD).ColumnName("ICD");

            this.Column(p => p.ICDName).ColumnName("ICDNAME");

            this.Column(p => p.ExistBP).ColumnName("ExistBP");

            this.Column(p => p.ExistChinaMed).ColumnName("ExistChinaMed");

            this.Column(p => p.ExistPatentMed).ColumnName("ExistPatentMed");
            



            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

