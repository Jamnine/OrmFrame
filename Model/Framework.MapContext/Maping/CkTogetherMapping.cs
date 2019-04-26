

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkTogetherMapping: ClassMap<CkTogether>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkTogetherMapping()
		{
			this.TableName("CKTOGETHER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestId1).ColumnName("TESTID1");
			  
			this.Column(p =>p.TestId2).ColumnName("TESTID2");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

