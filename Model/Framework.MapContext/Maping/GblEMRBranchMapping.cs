

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 电子病历模版路径 - 实体类
	/// </summary>
	public partial class GblEMRBranchMapping: ClassMap<GblEMRBranch>
	{   
		/// <summary>
		/// 电子病历模版路径 - 实体类
		/// </summary>
		public GblEMRBranchMapping()
		{
			this.TableName("GBLEMRBRANCH").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BranchId).ColumnName("BRANCHID");
			  
			this.Column(p =>p.CatalogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.XSDFile).ColumnName("XSDFILE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

