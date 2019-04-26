

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class InHosUsageItemMapping: ClassMap<InHosUsageItem>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public InHosUsageItemMapping()
		{
			this.TableName("INHOSUSAGEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.UsageMemo).ColumnName("USAGEMEMO");
			  
			this.Column(p =>p.AdviceMemo).ColumnName("ADVICEMEMO");
			  
			this.Column(p =>p.UsageItemId).ColumnName("USAGEITEMID");
			  
			this.Column(p =>p.Times).ColumnName("TIMES");
			  
			this.Column(p =>p.AdviceTime).ColumnName("ADVICETIME");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.ChargeTime).ColumnName("CHARGETIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

