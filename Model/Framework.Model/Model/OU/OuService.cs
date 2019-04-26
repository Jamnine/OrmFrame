using System;

namespace Orm.Model
{
    /// <summary>  
    /// 服务信息 居家养老 生活服务
    /// </summary> 
    [Serializable]
    public partial class OuService : BaseModel
    {
        private string _ouHosInfoId;
        /// <summary>
        /// 门诊id
        /// </summary>
        public string OuHosInfoId
        {
            get { return _ouHosInfoId; }
            set { _ouHosInfoId = value; }
        }

        private int _serviceType;
        /// <summary>
        /// 服务类型
        /// </summary>
        public int ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        private DateTime _createDate;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        private string _patientId;
        /// <summary>
        /// 病人id
        /// </summary>
        public string PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        private string _userId;
        /// <summary>
        /// 操作人id
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
    }
}

