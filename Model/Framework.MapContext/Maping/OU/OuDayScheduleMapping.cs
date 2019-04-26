using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  日排班主表 
    /// </summary>  
    public partial class OuDayScheduleMapping : ClassMap<OuDaySchedule>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public OuDayScheduleMapping()
        {
            this.TableName("OUDAYSCHEDULE").Schema("orm");
            this.Column(p => p.ScheduleDate).ColumnName("ScheduleDate");
            this.Column(p => p.WeekPlanID).ColumnName("WeekPlanID");
            this.Column(p => p.DoctorId).ColumnName("DoctorId");
            this.Column(p => p.RegTypeId).ColumnName("RegTypeId");
            this.Column(p => p.TimeSpanId).ColumnName("TimeSpanId");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.DiagRoomID).ColumnName("DiagRoomID");
            this.Column(p => p.TotalNum).ColumnName("TotalNum");
            this.Column(p => p.BookLimitNum).ColumnName("BookLimitNum");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.StopOperID).ColumnName("StopOperID");
            this.Column(p => p.DeletedOperID).ColumnName("DeletedOperID");
            this.Column(p => p.DeleteTime).ColumnName("DeleteTime");
            this.Column(p => p.IsStop).ColumnName("IsStop");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.IsDoctor).ColumnName("IsDoctor");


             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}  
  
  

