

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsBPEvaluateTestMapping: ClassMap<BsBPEvaluateTest>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsBPEvaluateTestMapping()
		{
			this.TableName("BSBPEVALUATETEST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BPItemId).ColumnName("BPITEMID");
			  
			this.Column(p =>p.EvaluateId).ColumnName("EVALUATEID");
			  
			this.Column(p =>p.IsCommon).ColumnName("ISCOMMON");
			  
			this.Column(p =>p.BPIllId).ColumnName("BPILLID");
			  
			this.Column(p =>p.TestType).ColumnName("TESTTYPE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

