

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsSubjectMapping: ClassMap<BsSubject>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsSubjectMapping()
		{
			this.TableName("BSSUBJECT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

