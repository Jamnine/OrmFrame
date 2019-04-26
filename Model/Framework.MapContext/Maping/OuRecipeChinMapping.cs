

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊中药处方用法说明 - 实体类
	/// </summary>
	public partial class OuRecipeChinMapping: ClassMap<OuRecipeChin>
	{   
		/// <summary>
		/// 门诊中药处方用法说明 - 实体类
		/// </summary>
		public OuRecipeChinMapping()
		{
			this.TableName("OURECIPECHIN").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.DecoctNum).ColumnName("DECOCTNUM");
			  
			this.Column(p =>p.LsCookSelf).ColumnName("LSCOOKSELF");
			  
			this.Column(p =>p.CookMinute).ColumnName("COOKMINUTE");
			  
			this.Column(p =>p.LsFire).ColumnName("LSFIRE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.BeforeWater).ColumnName("BEFOREWATER");
			  
			this.Column(p =>p.AfterWater).ColumnName("AFTERWATER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

