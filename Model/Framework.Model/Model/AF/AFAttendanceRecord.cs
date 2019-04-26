// ===================================================================   
// Model  
// ===================================================================   
// File: AFAttendanceRecord.cs  
//   
// Copyright   
// History:  
// 2014/12/18 9:01:46: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  考勤记录
    /// </summary> 
    [Serializable]
    public partial class AFAttendanceRecord : BaseModel
    {
        private int _sequenceNo;
        private DateTime _operTime;
        private string _operId;
        private string _employeeId;
        private string _notes = String.Empty;
        private string _memo = String.Empty;
        private int _attendanceMonth;
        private int _everyDay;
        private int _late;
        private int _sickLeave;
        private int _casualLeave;
        private int _overTime;
        private int _stay;
        private int _leaveEarly;
        private int _other;

        public AFAttendanceRecord()
        {
        }


        /// <summary>  
        ///   序号
        /// </summary>  
        public int SequenceNo
        {
            get { return this._sequenceNo; }
            set { this._sequenceNo = value; }
        }

        /// <summary>  
        ///   录入日期
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 录入人
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 员工ID  
        /// </summary>  
        public string EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }

        /// <summary>  
        /// 说明  
        /// </summary>  
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        /// <summary>  
        /// 备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>  
        /// 考勤月份(201412)  
        /// </summary>  
        public int AttendanceMonth
        {
            get { return this._attendanceMonth; }
            set { this._attendanceMonth = value; }
        }

        /// <summary>  
        /// 全勤  
        /// </summary>  
        public int EveryDay
        {
            get { return this._everyDay; }
            set { this._everyDay = value; }
        }

        /// <summary>  
        /// 迟到  
        /// </summary>  
        public int Late
        {
            get { return this._late; }
            set { this._late = value; }
        }

        /// <summary>  
        /// 病假  
        /// </summary>  
        public int SickLeave
        {
            get { return this._sickLeave; }
            set { this._sickLeave = value; }
        }

        /// <summary>  
        /// 事假  
        /// </summary>  
        public int CasualLeave
        {
            get { return this._casualLeave; }
            set { this._casualLeave = value; }
        }

        /// <summary>  
        /// 加班  
        /// </summary>  
        public int OverTime
        {
            get { return this._overTime; }
            set { this._overTime = value; }
        }

        /// <summary>  
        /// 住宿  
        /// </summary>  
        public int Stay
        {
            get { return this._stay; }
            set { this._stay = value; }
        }

        /// <summary>  
        /// 早退  
        /// </summary>  
        public int LeaveEarly
        {
            get { return this._leaveEarly; }
            set { this._leaveEarly = value; }
        }

        /// <summary>  
        ///   其它
        /// </summary>  
        public int Other
        {
            get { return this._other; }
            set { this._other = value; }
        }

    }
}
