

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 单位体检组 - 实体类
	/// </summary>
	public partial class CkCompanyGroupMapping: ClassMap<CkCompanyGroup>
	{   
		/// <summary>
		/// 单位体检组 - 实体类
		/// </summary>
		public CkCompanyGroupMapping()
		{
			this.TableName("CKCOMPANYGROUP").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.CompanyId).ColumnName("COMPANYID");
			  
			this.Column(p =>p.GroupId).ColumnName("GROUPID");
			  
			this.Column(p =>p.GroupDepartmentId).ColumnName("GROUPDEPARTMENTID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

