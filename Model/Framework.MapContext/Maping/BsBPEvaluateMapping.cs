

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的评估选择表(门诊就诊左下的评估选择) - 实体类
	/// </summary>
	public partial class BsBPEvaluateMapping: ClassMap<BsBPEvaluate>
	{   
		/// <summary>
		/// BP的评估选择表(门诊就诊左下的评估选择) - 实体类
		/// </summary>
		public BsBPEvaluateMapping()
		{
			this.TableName("BSBPEVALUATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EvaluateId).ColumnName("EVALUATEID");
			  
			this.Column(p =>p.EvaluateName).ColumnName("EVALUATENAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.ShortName).ColumnName("SHORTNAME");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

