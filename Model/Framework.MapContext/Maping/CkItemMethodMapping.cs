

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkItemMethodMapping: ClassMap<CkItemMethod>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkItemMethodMapping()
		{
			this.TableName("CKITEMMETHOD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.Method).ColumnName("METHOD");
			  
			this.Column(p =>p.Orderby).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

