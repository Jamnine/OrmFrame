


using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
	/// <summary>
	/// 疾病维护 - 实体类
	/// </summary>
	public partial class BsEducationMapping: ClassMap<BsEducation>
	{   
		/// <summary>
		/// 疾病维护 - 实体类
		/// </summary>
		public BsEducationMapping()
		{
			this.TableName("BSEDUCATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.GroupMain).ColumnName("GROUPMAIN");
			  
			this.Column(p =>p.GroupSub).ColumnName("GROUPSUB");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

