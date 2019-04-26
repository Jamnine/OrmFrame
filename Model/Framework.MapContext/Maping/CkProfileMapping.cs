

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验套餐表 - 实体类
	/// </summary>
	public partial class CkProfileMapping: ClassMap<CkProfile>
	{   
		/// <summary>
		/// 检验套餐表 - 实体类
		/// </summary>
		public CkProfileMapping()
		{
			this.TableName("CKPROFILE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ProfileId).ColumnName("PROFILEID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.SourceId).ColumnName("SOURCEID");
			  
			this.Column(p =>p.TubeTypeId).ColumnName("TUBETYPEID");
			  
			this.Column(p =>p.ItemCode).ColumnName("ITEMCODE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

