

using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgIllXdrpMapping: ClassMap<DgIllXdrp>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgIllXdrpMapping()
		{
			this.TableName("DGILLXDRP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IllId).ColumnName("ILLID");
			  
			this.Column(p =>p.XdrpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

