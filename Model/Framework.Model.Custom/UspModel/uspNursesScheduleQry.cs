using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 护士排班信息
    /// </summary>
    [Serializable]
    public class uspNursesScheduleQry : BaseModel
    {
        private string _nurseName;
        private string _nurseId;
        private string _timeSpanId;
        private string _timeSpanName;
        private string _locationId;
        private string _locationName;
        private DateTime _scheduleDate;
        private DateTime _operTime;
        private string _operId;
        private string _stopOperId;
        private string _deletedOperId;
        private DateTime _deleteTime;
        private bool _isStop;
        private bool _isActive = true;

        public uspNursesScheduleQry()
        {
        }

        /// <summary>
        /// 出诊日期
        /// </summary>
        public DateTime ScheduleDate
        {
            get { return this._scheduleDate; }
            set { this._scheduleDate = value; }
        }

        /// <summary>
        /// 护士姓名
        /// </summary>
        public string NurseName
        {
            get { return this._nurseName; }
            set { this._nurseName = value; }
        }

        /// <summary>
        /// 护士ID
        /// </summary>
        public string NurseId
        {
            get { return this._nurseId; }
            set { this._nurseId = value; }
        }

        /// <summary>
        /// 班次ID
        /// </summary>
        public string TimeSpanId
        {
            get { return this._timeSpanId; }
            set { this._timeSpanId = value; }
        }

        /// <summary>
        /// 班次
        /// </summary>
        public string TimeSpanName
        {
            get { return this._timeSpanName; }
            set { this._timeSpanName = value; }
        }

        /// <summary>
        /// 科室ID
        /// </summary>
        public string LocationId
        {
            get { return this._locationId; }
            set { this._locationId = value; }
        }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>
        /// 停诊人ID
        /// </summary>
        public string StopOperId
        {
            get { return this._stopOperId; }
            set { this._stopOperId = value; }
        }

        /// <summary>
        /// 删除人ID
        /// </summary>
        public string DeletedOperId
        {
            get { return this._deletedOperId; }
            set { this._deletedOperId = value; }
        }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DeleteTime
        {
            get { return this._deleteTime; }
            set { this._deleteTime = value; }
        }

        /// <summary>
        /// 是否停诊
        /// </summary>
        public bool IsStop
        {
            get { return this._isStop; }
            set { this._isStop = value; }
        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }
    }
}
