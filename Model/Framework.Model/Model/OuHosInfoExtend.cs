

using System;
namespace Orm.Model
{
    /// <summary>
    /// 门诊病人挂号信息表 - 实体类
    /// </summary> 
    public partial class OuHosInfo
    {
        private string _timeBegin; 
        private bool _iSInputBYRegMAN; // 冗余是否网上预约
        private string _consultDetail; // 患者描述
        private string _mainInform = string.Empty;
        private DateTime _endMenstruationTime;
        private string _deptmentId;
        private string _participants;//参与人员

        private string _nurseName;  //护士名称

        /// <summary>
        /// 护士名称
        /// </summary>
        public string NurseName
        {
            get { return _nurseName; }
            set { _nurseName = value; }
        }
        /// <summary>
        /// 参与人员
        /// </summary>
        public string Participants
        {
            get
            {
                return this._participants;
            }
            set
            {
                this._participants = value;
            }
        }


        /// <summary>
        /// 开始时段
        /// </summary>
        public string TimeBegin
        {
            get
            {
                return this._timeBegin;
            }
            set
            {
                this._timeBegin = value;
            }
        }

        /// <summary>
        /// F8预约挂号时间.
        /// </summary>
        public DateTime PRERegTime
        {
            get;set;
        }

        /// <summary>
        ///由网站导入预约信息 (原：F1是否挂号处录入.)
        /// </summary>
        public bool ISInputBYRegMAN
        {
            get
            {
                return this._iSInputBYRegMAN;
            }
            set
            {
                this._iSInputBYRegMAN = value;
            }
        }

        /// <summary>
        /// 结束时段
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        ///  患者描述
        /// </summary>
        public string ConsultDetail
        {
            get
            {
                return this._consultDetail;
            }
            set
            {
                this._consultDetail = value;
            }
        }

        /// <summary>
        /// 病情记录
        /// </summary>
        public string Pathography
        {
            get;
            set;
        }


        /// <summary>
        /// 治疗建议ID
        /// </summary>
        public string TreatmentAdvise
        {
            get;
            set;
        }

        /// <summary>
        /// 是否理疗
        /// </summary>
        public bool IsLL { get; set; }


        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform
        {
            get
            {
                return this._mainInform;
            }
            set
            {
                this._mainInform = value;
            }
        }

        /// <summary>
        /// 末次月经
        /// </summary>
        public DateTime EndMenstruationTime
        {
            get { return this._endMenstruationTime == DateTime.MinValue ? DateTime.Now : this._endMenstruationTime; }
            set { this._endMenstruationTime = value; }
        }

        /// <summary>
        /// 挂号科室id
        /// </summary>
        public string DepartmentId
        {
            get { return _deptmentId; }
            set  { _deptmentId = value; }
        }

        private string _bookingpurpose;
        /// <summary>
        /// 就诊目的（编码，格式如1|2|3）
        /// </summary>
        public string BookingPurpose
        {
            get
            {
                return this._bookingpurpose;
            }
            set
            {
                this._bookingpurpose = value;
            }
        }

        private string _patTypeName;
        /// <summary>
        /// 病人类别.
        /// </summary>
        public string PatTypeName
        {
            get
            {
                return this._patTypeName;
            }
            set
            {
                this._patTypeName = value;
            }
        }

        /// <summary>
        /// 预约时间段名称
        /// </summary>
        public string TimeSpanSubName { get; set; }

        bool _isHideIllness;
        /// <summary>
        /// 是否重点关注病人
        /// </summary>
        public bool IsHideIllness
        {
            get
            {
                return _isHideIllness;
            }
            set
            {
                _isHideIllness = value;
            }
        }

  
        /// <summary>
        /// 挂号科室
        /// </summary>
        public string LocationName { set; get; }
     
        /// <summary>
        /// 病人类型
        /// </summary>
        public string RegTypeName { set; get; }
        /// <summary>
        /// 药物过敏史
        /// </summary>
        public string Sensitive { set; get; }
        /// <summary>
        /// 病人名称 
        /// </summary>
        public string PatientName { set; get; }
        /// <summary>
        /// 病人类型ID
        /// </summary>
        public int TallyTypeId { set; get; }
        /// <summary>
        /// 病人类型
        /// </summary>
        public string TallyTypeName { set; get; }
        /// <summary>
        /// 病人类型ID
        /// </summary>
        public int TallyGroupId { set; get; }
        /// <summary>
        /// 病人类型
        /// </summary>
        public int TallyGroupName { set; get; }
        /// <summary>
        /// 就诊状态(0:未诊,1:已诊)
        /// </summary>
        public int IsDiagnosed { set; get; }
        /// <summary>
        /// 就诊状态
        /// </summary>
        public string DiagStatus { set; get; }

        #region  行心云挂号冗余字段
        /// <summary>
        /// 诊断类别：1-初诊；2-复诊;3-疑诊；4-急性发作
        /// </summary>
        public int PatientStatus { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int SortNo { get; set; }
        #endregion
    }
}


