

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 单位体检人员名单 - 实体类
	/// </summary>
	public partial class CkCompanyManMapping: ClassMap<CkCompanyMan>
	{   
		/// <summary>
		/// 单位体检人员名单 - 实体类
		/// </summary>
		public CkCompanyManMapping()
		{
			this.TableName("CKCOMPANYMAN").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.CompanyGroupId).ColumnName("COMPANYGROUPID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

