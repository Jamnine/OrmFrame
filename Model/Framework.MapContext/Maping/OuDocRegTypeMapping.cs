

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊医生日排班 - 实体类
	/// </summary>
	public partial class OuDocRegTypeMapping: ClassMap<OuDocRegType>
	{   
		/// <summary>
		/// 门诊医生日排班 - 实体类
		/// </summary>
		public OuDocRegTypeMapping()
		{
			this.TableName("OUDOCREGTYPE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.WeekPlanId).ColumnName("WEEKPLANID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.TimeSpanId).ColumnName("TIMESPANID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DiagRoomId).ColumnName("DIAGROOMID");
			  
			this.Column(p =>p.LimitNum).ColumnName("LIMITNUM");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.LastLimitNum).ColumnName("LASTLIMITNUM");
			  
			this.Column(p =>p.RegNum).ColumnName("REGNUM");
			  
			this.Column(p =>p.ResNum).ColumnName("RESNUM");
			  
			this.Column(p =>p.IsSpecial).ColumnName("ISSPECIAL");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID"); 

            this.Column(p => p.ScheduleDate).ColumnName("SCHEDULEDATE"); 

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.DeletedOperId).ColumnName("DeletedOperID");

            this.Column(p => p.DeleteTime).ColumnName("DeleteTime");

            this.Column(p => p.IsStop).ColumnName("IsStop");

            this.Column(p => p.IsDoctor).ColumnName("IsDoctor");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

