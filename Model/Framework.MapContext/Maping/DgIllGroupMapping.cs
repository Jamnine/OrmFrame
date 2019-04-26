

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgIllGroupMapping: ClassMap<DgIllGroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgIllGroupMapping()
		{
			this.TableName("DGILLGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.GroupDesc).ColumnName("GROUPDESC");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

