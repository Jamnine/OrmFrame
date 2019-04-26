

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class List_ExampleMapping: ClassMap<List_Example>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public List_ExampleMapping()
		{
			this.TableName("LIST_EXAMPLE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Dname).ColumnName("DNAME");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

