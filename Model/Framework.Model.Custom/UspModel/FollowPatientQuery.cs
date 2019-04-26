using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 报表 回访类
    /// </summary>
    [Serializable]
    public class FollowPatientQuery : BaseModel
    {
        public FollowPatientQuery() { }
        private string _timeQuantum = string.Empty;
        private string _locationID;
        private string _doctorID;
        private int _followStatus;
        /// <summary>
        /// 回访日期
        /// </summary>
        public DateTime FollowDate { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }
        public string DoctorID
        {
            get { return this._doctorID; }
            set { this._doctorID = value; }
        }
        /// <summary>  
        /// 时间段  
        /// </summary>  
        public string TimeQuantum
        {
            get { return this._timeQuantum; }
            set { this._timeQuantum = value; }
        }

        public string LocationID
        {
            get { return this._locationID; }
            set
            {
                this._locationID = value;
            }
        }

        /// <summary>
        /// 病历号
        /// </summary>
        public string RecordNumber { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 治疗医生
        /// </summary>
        public string DocName { get; set; }
        /// <summary>
        /// 病情分类
        /// </summary>
        public string DocType { get; set; }
        /// <summary>
        /// 回访内容
        public string FollowContent { get; set; }
        /// <summary>
        /// 服务质量
        /// </summary>
        public int AppraiseType { get; set; }
        /// <summary>
        /// 意见
        /// </summary>
        public string FeedBackContent { get; set; }
        /// <summary>
        /// 是否已回访
        /// </summary>
        public int FollowStatus
        {
            get { return this._followStatus; }
            set
            {
                this._followStatus = value;
            }
        }
        public string FollowStatusName { get; set; }
        /// <summary>
        /// 回访人员
        /// </summary>
        public string FollowName { get; set; }
    }
}
