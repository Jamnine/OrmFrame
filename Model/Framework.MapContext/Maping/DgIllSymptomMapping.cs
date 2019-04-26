

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgIllSymptomMapping: ClassMap<DgIllSymptom>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgIllSymptomMapping()
		{
			this.TableName("DGILLSYMPTOM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.Symptom).ColumnName("SYMPTOM");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsWomen).ColumnName("ISWOMEN");
			  
			this.Column(p =>p.IsMen).ColumnName("ISMEN");
			  
			this.Column(p =>p.IsOlder).ColumnName("ISOLDER");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

