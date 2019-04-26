

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OaDocKeyMapping: ClassMap<OaDocKey>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OaDocKeyMapping()
		{
			this.TableName("OADOCKEY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DocId).ColumnName("DOCID");
			  
			this.Column(p =>p.WordKey).ColumnName("WORDKEY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

