using System;

namespace Orm.Model
{
    /// <summary>
    /// 诊断意见表
    /// </summary>
    [Serializable]
    public class OuDiagnosis : BaseModel
    {
        private string _medicalRecordId;
        private string _tjSuggestionId ;
        private string _diseaseName = string.Empty;
        private string _diseaseCode = string.Empty;

        /// <summary>
        /// 默认构造方法
        /// </summary>
        public OuDiagnosis()
        {
        }

        /// <summary>
        /// 门诊病历ID
        /// </summary>
        public string MedicalRecordId
        {
            get { return _medicalRecordId; }
            set { _medicalRecordId = value; }
        }

        /// <summary>
        /// 诊断意见模板ID
        /// </summary>
        public string TJSuggestionId
        {
            get { return _tjSuggestionId; }
            set { _tjSuggestionId = value; }
        }

        /// <summary>
        /// 疾病名称
        /// </summary>
        public string DiseaseName
        {
            get { return _diseaseName; }
            set { _diseaseName = value; }
        }

        /// <summary>
        /// 疾病编号
        /// </summary>
        public string DiseaseCode
        {
            get { return _diseaseCode; }
            set { _diseaseCode = value; }
        }
    }
}
