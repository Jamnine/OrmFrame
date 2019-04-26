using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 西药记录 数据库不存在此表
    /// </summary>
    [Serializable]
    public class OuMedicalRecord : BaseModel
    {
        private string _mzRegId;
        private DateTime _onsetDate = DateTime.MinValue;
        private string _mainInform = "";
        private string _pathography = "";
        private string _physicalExam = "";
        private string _otherCheck = "";
        private string _treatmentAdvise = "";
        private string _comments = "";
        public OuMedicalRecord() { }

        /// <summary>
        /// 门诊ID
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 发病时间
        /// </summary>
        public DateTime OnsetDate
        {
            get { return _onsetDate; }
            set { _onsetDate = value; }
        }

        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform
        {
            get { return _mainInform; }
            set { _mainInform = value; }
        }

        /// <summary>
        /// 现病史
        /// </summary>
        public string Pathography
        {
            get { return _pathography; }
            set { _pathography = value; }
        }

        /// <summary>
        /// 体格检查
        /// </summary>
        public string PhysicalExam
        {
            get { return _physicalExam; }
            set { _physicalExam = value; }
        }

        /// <summary>
        /// 实验室及辅助检查
        /// </summary>
        public string OtherCheck
        {
            get { return _otherCheck; }
            set { _otherCheck = value; }
        }

        /// <summary>
        /// 治疗意见
        /// </summary>
        public string TreatmentAdvise
        {
            get { return _treatmentAdvise; }
            set { _treatmentAdvise = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
    }
}
