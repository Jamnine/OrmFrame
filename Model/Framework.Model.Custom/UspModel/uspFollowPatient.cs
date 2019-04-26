using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 回访病人信息
    /// </summary>
    [Serializable]
    public class uspFollowPatient : BaseModel
    {
        private DateTime _followTime;
        private string _timeQuantum = String.Empty;
        private string _operID;
        private DateTime _operTime;
        private int _followType;
        private string _followContent = String.Empty;
        private bool _isFeedBack;
        private string _patID;
        private string _mzRegID;
        private string _feedBackContent = String.Empty;
        private int _appRaiseType;
        private bool _isDeleted;
        private string _patentname;
        private int _followtotal;
        private string _doctorID;
        private string _doctorName;
        private string _locationID;
        private string _locationName;
        private string _dietitianContent = String.Empty;
        private string _sportsDocContent = String.Empty;
        private string _tCMDocContent = String.Empty;
        private string _psyDocContent = String.Empty;
        private string _dietitianResult = String.Empty;
        private string _sportsDocResult = String.Empty;
        private string _tCMDocResult = String.Empty;
        private string _psyDocResult = String.Empty;
        public uspFollowPatient() { }

        public string ID { get; set; }

        /// <summary>
        /// 门诊机构ID
        /// </summary>
        public string LocationID
        {
            get { return this._locationID; }
            set
            {
                this._locationID = value;
            }
        }

        /// <summary>
        /// 门诊机构名称
        /// </summary>
        public string LocationName
        {
            get { return this._locationName; }
            set
            {
                this._locationName = value;
            }
        }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID
        {
            get { return this._doctorID; }
            set { this._doctorID = value; }
        }

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatentName
        {
            get { return this._patentname; }
            set { this._patentname = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int FollowTotal
        {
            get { return this._followtotal; }
            set { this._followtotal = value; }
        }

        /// <summary>  
        /// 回访时间  
        /// </summary>  
        public DateTime FollowTime
        {
            get { return this._followTime; }
            set { this._followTime = value; }
        }

        /// <summary>  
        /// 时间段  
        /// </summary>  
        public string TimeQuantum
        {
            get { return this._timeQuantum; }
            set { this._timeQuantum = value; }
        }

        /// <summary>  
        /// 操作人  
        /// </summary>  
        public string OperID
        {
            get { return this._operID; }
            set { this._operID = value; }
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
        /// 回访类别  回访类别 3;复诊提醒,4:健康教育,5:诊后关怀,6:病情跟踪,7:满意度调查,8:用药提示
        /// </summary>  
        public int FollowType
        {
            get { return this._followType; }
            set { this._followType = value; }
        }

        /// <summary>  
        /// 回访内容  
        /// </summary>  
        public string FollowContent
        {
            get { return this._followContent; }
            set { this._followContent = value; }
        }

        /// <summary>  
        /// 是否需要反馈  
        /// </summary>  
        public bool IsFeedBack
        {
            get { return this._isFeedBack; }
            set { this._isFeedBack = value; }
        }

        /// <summary>  
        /// 病人ID  
        /// </summary>  
        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }

        /// <summary>  
        /// 就诊ID  
        /// </summary>  
        public string MzRegID
        {
            get { return this._mzRegID; }
            set { this._mzRegID = value; }
        }

        /// <summary>  
        /// 反馈内容  
        /// </summary>  
        public string FeedBackContent
        {
            get { return this._feedBackContent; }
            set { this._feedBackContent = value; }
        }
        /// <summary>
        /// 病历ID
        /// </summary>
        public string ToothCaseID { get; set; }
        /// <summary>
        /// 评价类别
        /// </summary>
        public int AppRaiseType
        {
            get { return this._appRaiseType; }
            set { this._appRaiseType = value; }
        }
        /// <summary>
        /// 是否自动创建
        /// </summary>
        public bool IsAutoCreate { get; set; }

        /// <summary>
        /// 回访状态：0未回访 1已回访 2待跟进
        /// </summary>
        public int FollowStatus { get; set; }

        /// <summary>
        /// 回访方式：0 手机APP 1短信 2电话 10其他
        /// </summary>
        public int FollowWay { get; set; }

        public string PatientName { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted
        {
            get { return this._isDeleted; }
            set { this._isDeleted = value; }
        }

        /// <summary>
        /// 诊断
        /// </summary>
        public string ClincDiag { get; set; }

        /// <summary>
        /// 就诊目的
        /// </summary>
        public string CnBookingPurpose { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString { get; set; }

        /// <summary>
        /// 回访人员（操作员）
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 是否异常
        /// </summary>
        public bool IsAbnormal { get; set; }

        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

        /// <summary>  
        /// 营养师回访内容  
        /// </summary>  
        public string DietitianContent
        {
            get { return this._dietitianContent; }
            set { this._dietitianContent = value; }
        }

        /// <summary>  
        /// 运动师回访内容  
        /// </summary>  
        public string SportsDocContent
        {
            get { return this._sportsDocContent; }
            set { this._sportsDocContent = value; }
        }

        /// <summary>  
        /// 中医师回访内容  
        /// </summary>  
        public string TCMDocContent
        {
            get { return this._tCMDocContent; }
            set { this._tCMDocContent = value; }
        }

        /// <summary>  
        /// 心理医生回访内容  
        /// </summary>  
        public string PsyDocContent
        {
            get { return this._psyDocContent; }
            set { this._psyDocContent = value; }
        }

        /// <summary>  
        /// 营养师回访结果  
        /// </summary>  
        public string DietitianResult
        {
            get { return this._dietitianResult; }
            set { this._dietitianResult = value; }
        }

        /// <summary>  
        /// 运动师回访结果  
        /// </summary>  
        public string SportsDocResult
        {
            get { return this._sportsDocResult; }
            set { this._sportsDocResult = value; }
        }

        /// <summary>  
        /// 中医师回访结果  
        /// </summary>  
        public string TCMDocResult
        {
            get { return this._tCMDocResult; }
            set { this._tCMDocResult = value; }
        }

        /// <summary>  
        /// 心理医生回访结果  
        /// </summary>  
        public string PsyDocResult
        {
            get { return this._psyDocResult; }
            set { this._psyDocResult = value; }
        }
        #region 昆山
        /// <summary>
        /// 是否回访病人
        /// </summary>
        public bool IsReturnPat { get; set; }
        #endregion

        #region 博厚
        /// <summary>
        /// 医生等级id
        /// </summary>
        public int DocLevelID { get; set; }
        /// <summary>
        /// 回访内容
        /// </summary>
        public string ReturnContent { get; set; }
        #endregion
    }
}
