using System;

namespace Orm.Model
{
    /// <summary>
    /// 病人分组
    /// </summary>
    [Serializable]
    public partial class OuPatientGroup : BaseModel
    {
        string _ouhosinfoId;
        string _illName;
        string _patientGroup;
        string _xmlId;

        /// <summary>
        /// 对应bp接口xmlid
        /// </summary>
        public string XmlId
        {
            get
            {
                return _xmlId;
            }
            set
            {
                _xmlId = value;
            }
        }

        /// <summary>
        /// 病人分组
        /// </summary>
        public string PatientGroup
        {
            get
            {
                return _patientGroup;
            }
            set
            {
                _patientGroup = value;
            }
        }

        /// <summary>
        /// 疾病名称
        /// </summary>
        public string IllName
        {
            get
            {
                return _illName;
            }
            set
            {
                _illName = value;
            }
        }

        /// <summary>
        /// 门诊id
        /// </summary>
        public string OuhosinfoId
        {
            get
            {
                return _ouhosinfoId;
            }
            set
            {
                _ouhosinfoId = value;
            }
        }

        private string _icdName;
        /// <summary>
        /// ICD疾病名称
        /// </summary>
        public string ICDName
        {
            get { return _icdName; }
            set { _icdName = value; }
        }

        private string _icd;
        /// <summary>
        /// ICD编码
        /// </summary>
        public string ICD
        {
            get { return _icd; }
            set { _icd = value; }
        }
        private string _bsDisId;
        /// <summary>
        /// 疾病表id
        /// </summary>
        public string BsDisId
        {
            get { return _bsDisId; }
            set { _bsDisId = value; }
        }
    }
}
