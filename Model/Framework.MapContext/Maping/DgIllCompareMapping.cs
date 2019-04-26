

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgIllCompareMapping: ClassMap<DgIllCompare>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgIllCompareMapping()
		{
			this.TableName("DGILLCOMPARE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IcdId1).ColumnName("ICDID1");
			  
			this.Column(p =>p.IcdId2).ColumnName("ICDID2");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

