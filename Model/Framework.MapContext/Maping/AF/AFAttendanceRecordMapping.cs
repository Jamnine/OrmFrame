using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 考勤
    /// AFAttendanceRecord.  Mapping  
    /// </summary>  
    public partial class AFAttendanceRecordMapping : ClassMap<AFAttendanceRecord>
    {
        /// <summary>  
        /// 考勤
        /// Stru  
        /// </summary>  
        public AFAttendanceRecordMapping()
        {
            this.TableName("AFATTENDANCERECORD").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.SequenceNo).ColumnName("SequenceNo");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.EmployeeId).ColumnName("EmployeeId");
            this.Column(p => p.Notes).ColumnName("Notes");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.AttendanceMonth).ColumnName("AttendanceMonth");
            this.Column(p => p.EveryDay).ColumnName("EveryDay");
            this.Column(p => p.Late).ColumnName("Late");
            this.Column(p => p.SickLeave).ColumnName("SickLeave");
            this.Column(p => p.CasualLeave).ColumnName("CasualLeave");
            this.Column(p => p.OverTime).ColumnName("OverTime");
            this.Column(p => p.Stay).ColumnName("Stay");
            this.Column(p => p.LeaveEarly).ColumnName("LeaveEarly");
            this.Column(p => p.Other).ColumnName("Other");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


