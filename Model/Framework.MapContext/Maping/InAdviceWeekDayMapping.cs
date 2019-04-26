

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院医嘱周计划表 - 实体类
	/// </summary>
	public partial class InAdviceWeekDayMapping: ClassMap<InAdviceWeekDay>
	{   
		/// <summary>
		/// 住院医嘱周计划表 - 实体类
		/// </summary>
		public InAdviceWeekDayMapping()
		{
			this.TableName("INADVICEWEEKDAY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.WeekDay).ColumnName("WEEKDAY");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

