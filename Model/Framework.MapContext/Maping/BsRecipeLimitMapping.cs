

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:处方限制规则表 - 实体类
	/// </summary>
	public partial class BsRecipeLimitMapping: ClassMap<BsRecipeLimit>
	{   
		/// <summary>
		/// 行心云:处方限制规则表 - 实体类
		/// </summary>
		public BsRecipeLimitMapping()
		{
			this.TableName("BSRECIPELIMIT").Schema("orm");

            this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.LimitName).ColumnName("LIMITNAME");
			  
			this.Column(p =>p.LimitContent).ColumnName("LIMITCONTENT");
			  
			this.Column(p =>p.LimitType).ColumnName("LIMITTYPE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

