using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 转诊记录
    /// </summary>
    [Serializable]
    public class YlReferralRecord : BaseModel
    {
        private string _patId;
        private string _originalHospitalidId;
        private string _originaDepartmentId;
        private string _originaDoctorId;
        private string _referralHospitalId;
        private string _referralDepartmentId;
        private string _referralDoctorId;
        private DateTime _referralTimeBegin;
        private DateTime _referralTimeEnd;
        private string _remarks;
        private string _referralObjective;
        private string _operatorId;
        private DateTime _operatorTime;
        private string _preliminaryDiagnosis;
        private int _emergencyDegree;

        /// <summary>
        /// 转诊记录
        /// </summary>
        public YlReferralRecord()
        {
        }
         
        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperatorId
        {
            get
            { return this._operatorId; }
            set
            { this._operatorId = value; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperatorTime
        {
            get
            { return this._operatorTime; }
            set
            { this._operatorTime = value; }
        }
        /// <summary>
        /// 原科室ID
        /// </summary>
        public string OriginaDepartmentId
        {
            get
            { return this._originaDepartmentId; }
            set
            { this._originaDepartmentId = value; }
        }
        /// <summary>
        /// 原医生ID
        /// </summary>
        public string OriginaDoctorId
        {
            get
            { return this._originaDoctorId; }
            set
            { this._originaDoctorId = value; }
        }
        /// <summary>
        /// 原医院ID
        /// </summary>
        public string OriginalHospitalId
        {
            get
            { return this._originalHospitalidId; }
            set
            { this._originalHospitalidId = value; }
        }
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId
        {
            get
            { return this._patId; }
            set
            { this._patId = value; }
        }
        /// <summary>
        /// 转诊科室ID
        /// </summary>
        public string ReferralDepartmentId
        {
            get
            { return this._referralDepartmentId; }
            set
            { this._referralDepartmentId = value; }
        }
        /// <summary>
        /// 转诊医生ID
        /// </summary>
        public string ReferralDoctorId
        {
            get
            { return this._referralDoctorId; }
            set
            { this._referralDoctorId = value; }
        }
        /// <summary>
        /// 转诊医院ID
        /// </summary>
        public string ReferralHospitalId
        {
            get
            { return this._referralHospitalId; }
            set
            { this._referralHospitalId = value; }
        }
        /// <summary>
        /// 转诊目的
        /// </summary>
        public string ReferralObjective
        {
            get
            { return this._referralObjective; }
            set
            { this._referralObjective = value; }
        }
        /// <summary>
        /// 转诊时间开始
        /// </summary>
        public DateTime ReferralTimeBegin
        {
            get
            { return this._referralTimeBegin; }
            set
            { this._referralTimeBegin = value; }
        }
        /// <summary>
        /// 转诊时间结束
        /// </summary>
        public DateTime ReferralTimeEnd
        {
            get
            { return this._referralTimeEnd; }
            set
            { this._referralTimeEnd = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            get
            { return this._remarks; }
            set
            { this._remarks = value; }
        }

        public string PreliminaryDiagnosis
        {
            get
            { return this._preliminaryDiagnosis; }
            set
            { this._preliminaryDiagnosis = value; }
        }
        public int EmergencyDegree
        {
            get
            { return this._emergencyDegree; }
            set
            { this._emergencyDegree = value; }
        }
    }
}
