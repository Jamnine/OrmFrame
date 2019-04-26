using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 医生排班信息类
    /// </summary>
    [Serializable]
    
    public class uspGetDocRegTypeQry : BaseModel
    {
         
        private int _hasDiagNum;
        private int _waitDiagNum;
        private string _name = String.Empty;
        private string _sex = String.Empty;
        private string _locationName = String.Empty;
        private string _regType = String.Empty;
        private string _timeSpanId;
        private string _timeSpanName = String.Empty;
        private string _weekTime = String.Empty;
        private int _weekDay;
        private bool _isActive;
        private int _limitNum;
        private DateTime _lastLimitDate;
        private int _lastLimitNum;
        private string _doctorId;
        private string _locationId;
        private string _regTypeId;
        private string _memo = String.Empty;
        private string _timeBegin = String.Empty;
        private string _timeEnd = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _f1 = String.Empty;
        private string _f4 = String.Empty;
        private string _roomNo = String.Empty;
        private string _diagRoomId;
        private string _operId;
        private DateTime _operTime;
        private string _MDInfo = String.Empty;
        private string _TDInfo = String.Empty;
        private string _WDInfo = String.Empty;
        private string _TUDInfo = String.Empty;
        private string _FDInfo = String.Empty;
        private string _STDInfo = String.Empty;
        private string _SUDInfo = String.Empty;
        private string _doctorName = String.Empty;

        public uspGetDocRegTypeQry()
        {
        }



        #region Public Properties

        /// <summary>
        /// 已诊人数
        /// </summary>
        public int HasDiagNum
        {
            get { return _hasDiagNum; }
            set { _hasDiagNum = value; }
        }

        /// <summary>
        /// 候诊人数
        /// </summary>
        public int WaitDiagNum
        {
            get { return _waitDiagNum; }
            set { _waitDiagNum = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 诊所
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        /// <summary>
        /// 挂号类别
        /// </summary>
        public string RegType
        {
            get { return _regType; }
            set { _regType = value; }
        }

        /// <summary>
        /// 班次id
        /// </summary>
        public string   TimeSpanId
        {
            get { return _timeSpanId; }
            set { _timeSpanId = value; }
        }

        /// <summary>
        /// 班次名称
        /// </summary>
        public string TimeSpanName
        {
            get { return _timeSpanName; }
            set { _timeSpanName = value; }
        }

        /// <summary>
        /// 周时间
        /// </summary>
        public string WeekTime
        {
            get { return _weekTime; }
            set { _weekTime = value; }
        }

        /// <summary>
        /// 星期几
        /// </summary>
        public int WeekDay
        {
            get { return _weekDay; }
            set { _weekDay = value; }
        }

        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 限制数量
        /// </summary>
        public int LimitNum
        {
            get { return _limitNum; }
            set { _limitNum = value; }
        }

        /// <summary>
        /// 上次限制日期
        /// </summary>
        public DateTime LastLimitDate
        {
            get { return _lastLimitDate; }
            set { _lastLimitDate = value; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 上次限制数量
        /// </summary>
        public int LastLimitNum
        {
            get { return _lastLimitNum; }
            set { _lastLimitNum = value; }
        }

        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
        /// <summary>
        /// 挂号类型
        /// </summary>
        public string RegTypeId
        {
            get { return _regTypeId; }
            set { _regTypeId = value; }
        }
        /// <summary>
        /// 就诊科室id
        /// </summary>

        public string DiagRoomId
        {
            get { return _diagRoomId; }
            set { _diagRoomId = value; }
        }
        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string TimeBegin
        {
            get { return _timeBegin; }
            set { _timeBegin = value; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string TimeEnd
        {
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }

      

        /// <summary>
        /// 医生名称+挂号数量(星期一)
        /// </summary>

        public string MDInfo
        {
            get { return _MDInfo; }
            set { _MDInfo = value; }
        }

        /// <summary>
        /// 医生名称+挂号数量(星期二)
        /// </summary>

        public string TDInfo
        {
            get { return _TDInfo; }
            set { _TDInfo = value; }
        }
        /// <summary>
        /// 医生名称+挂号数量(星期三)
        /// </summary> 
        public string WDInfo
        {
            get { return _WDInfo; }
            set { _WDInfo = value; }
        }

        /// <summary>
        /// 医生名称+挂号数量(星期四)
        /// </summary>

        public string TUDInfo
        {
            get { return _TUDInfo; }
            set { _TUDInfo = value; }
        }

        /// <summary>
        /// 医生名称+挂号数量(星期五)
        /// </summary>

        public string FDInfo
        {
            get { return _FDInfo; }
            set { _FDInfo = value; }
        }

        /// <summary>
        /// 医生名称+挂号数量(星期六)
        /// </summary>

        public string STDInfo
        {
            get { return _STDInfo; }
            set { _STDInfo = value; }
        }

        /// <summary>
        /// 医生名称+挂号数量(星期天)
        /// </summary>

        public string SUDInfo
        {
            get { return _SUDInfo; }
            set { _SUDInfo = value; }
        }

        #endregion
    }
  
}







