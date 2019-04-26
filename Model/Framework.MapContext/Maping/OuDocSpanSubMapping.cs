

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊医生日排班时间段 - 实体类
	/// </summary>
	public partial class OuDocSpanSubMapping: ClassMap<OuDocSpanSub>
	{   
		/// <summary>
		/// 门诊医生日排班时间段 - 实体类
		/// </summary>
		public OuDocSpanSubMapping()
		{
			this.TableName("OUDOCSPANSUB").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.WeekPlanId).ColumnName("WEEKPLANID");
			  
			this.Column(p =>p.SpanLimitNum).ColumnName("SPANLIMITNUM");
			  
			this.Column(p =>p.SubLimitNum).ColumnName("SUBLIMITNUM");
			  
			this.Column(p =>p.TimeSpanSubId).ColumnName("TIMESPANSUBID");
			  
			this.Column(p =>p.DayPlanId).ColumnName("DAYPLANID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

