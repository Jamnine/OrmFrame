// ===================================================================   
// Model  
// ===================================================================   
// File: OuDaySchedule.cs  
//   
// Copyright   
// History:  
// 2015/5/26 17:18:41: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  日排班主表  数据库不存在此表
    /// </summary>  
    [Serializable]
    public partial class OuDaySchedule : BaseModel
    {
        private DateTime _scheduleDate;
        private string _weekPlanID;
        private string _doctorId;
        private string _regTypeId;
        private string _timeSpanId;
        private string _locationId;
        private string _diagRoomID;
        private int _totalNum;
        private DateTime _operTime;
        private string _operId;
        private string _stopOperID;
        private string _deletedOperID;
        private DateTime _deleteTime;
        private bool _isStop;
        private bool _isActive = true;
        private int _bookLimitNum;
        private int _isDoctor = 1;

        /// <summary>
        /// 默认构造方法
        /// </summary>
        public OuDaySchedule()
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
        /// 对应周排班模板的ID  
        /// </summary>  
        public string WeekPlanID
        {
            get { return this._weekPlanID; }
            set { this._weekPlanID = value; }
        }

        /// <summary>  
        /// 医生ID
        /// </summary>  
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        /// <summary>  
        /// 挂号类别ID
        /// </summary>  
        public string RegTypeId
        {
            get { return this._regTypeId; }
            set { this._regTypeId = value; }
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
        /// 诊室  
        /// </summary>  
        public string DiagRoomID
        {
            get { return this._diagRoomID; }
            set { this._diagRoomID = value; }
        }

        /// <summary>  
        /// 总号数  
        /// </summary>  
        public int TotalNum
        {
            get { return this._totalNum; }
            set { this._totalNum = value; }
        }

        /// <summary>  
        /// 预约总号数  
        /// </summary>  
        public int BookLimitNum
        {
            get { return this._bookLimitNum; }
            set { this._bookLimitNum = value; }
        }

        /// <summary>  
        /// 登记时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 登记人
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 停诊人  
        /// </summary>  
        public string StopOperID
        {
            get { return this._stopOperID; }
            set { this._stopOperID = value; }
        }

        /// <summary>  
        /// 删除人  
        /// </summary>  
        public string DeletedOperID
        {
            get { return this._deletedOperID; }
            set { this._deletedOperID = value; }
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

        /// <summary>  
        /// 是否是医生
        /// </summary>  
        public int IsDoctor
        {
            get { return this._isDoctor; }
            set { this._isDoctor = value; }
        }
    }
}

