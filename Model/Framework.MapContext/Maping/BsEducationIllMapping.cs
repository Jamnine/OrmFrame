

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 疾病对应ICD码 - 实体类
	/// </summary>
	public partial class BsEducationIllMapping: ClassMap<BsEducationIll>
	{   
		/// <summary>
		/// 疾病对应ICD码 - 实体类
		/// </summary>
		public BsEducationIllMapping()
		{
			this.TableName("BSEDUCATIONILL").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.EducationId).ColumnName("EDUCATIONID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

