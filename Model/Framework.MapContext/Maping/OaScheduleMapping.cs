

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OaScheduleMapping: ClassMap<OaSchedule>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OaScheduleMapping()
		{
			this.TableName("OASCHEDULE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Subject).ColumnName("SUBJECT");
			  
			this.Column(p =>p.Location).ColumnName("LOCATION");
			  
			this.Column(p =>p.StartTime).ColumnName("STARTTIME");
			  
			this.Column(p =>p.EndTime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.Description).ColumnName("DESCRIPTION");
			  
			this.Column(p =>p.LabelId).ColumnName("LABELID");
			  
			this.Column(p =>p.Reminder).ColumnName("REMINDER");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

