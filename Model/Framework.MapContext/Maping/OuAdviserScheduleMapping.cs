

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:健康顾问日排班表 - 实体类
	/// </summary>
	public partial class OuAdviserScheduleMapping: ClassMap<OuAdviserSchedule>
	{   
		/// <summary>
		/// 行心云:健康顾问日排班表 - 实体类
		/// </summary>
		public OuAdviserScheduleMapping()
		{
			this.TableName("OUADVISERSCHEDULE").Schema("orm");

            this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p =>p.ScheduleDate).ColumnName("SCHEDULEDATE");
			  
			this.Column(p =>p.AdviserId).ColumnName("ADVISERID");
			  
			this.Column(p =>p.SortNo).ColumnName("SORTNO");
			  
			this.Column(p =>p.BookTotal).ColumnName("BOOKTOTAL");
			  
			this.Column(p =>p.BookLastTime).ColumnName("BOOKLASTTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.StopOperID).ColumnName("STOPOPERID");
			  
			this.Column(p =>p.DeleteOperID).ColumnName("DELETEOPERID");
			  
			this.Column(p =>p.DeleteTime).ColumnName("DELETETIME");
			  
			this.Column(p =>p.IsStop).ColumnName("ISSTOP");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

