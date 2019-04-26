using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 牙齿就诊历史记录
    /// </summary>
    [Serializable]
    public partial class ToothCaseHistory : BaseModel
    {


        private string _mzRegId;
        /// <summary>
        /// 门诊就诊ID
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }


        private string _patId;
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }

        private int _toothType;
        /// <summary>
        /// 1为恒牙，2为乳牙
        /// </summary>
        public int ToothType
        {
            get { return _toothType; }
            set { _toothType = value; }
        }
        private string _toothPosition = string.Empty;
        /// <summary>
        /// 牙位
        /// </summary>
        public string ToothPosition
        {
            get { return _toothPosition; }
            set { _toothPosition = value; }
        }

        private string _mainInform = string.Empty;
        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform
        {
            get { return _mainInform; }
            set { _mainInform = value; }
        }
        private string _sickHist = string.Empty;
        /// <summary>
        /// 病史
        /// </summary>
        public string SickHist
        {
            get { return _sickHist; }
            set { _sickHist = value; }
        }
        private string _checkCT = string.Empty;
        /// <summary>
        /// 检查
        /// </summary>
        public string CheckCT
        {
            get { return _checkCT; }
            set { _checkCT = value; }
        }
        private string _checkCTXRay = string.Empty;
        /// <summary>
        /// X光检查
        /// </summary>
        public string CheckCTXRay
        {
            get { return _checkCTXRay; }
            set { _checkCTXRay = value; }
        }
        private int _checkCTNo;
        /// <summary>
        /// 检查图片
        /// </summary>
        public int CheckCTNo
        {
            get { return _checkCTNo; }
            set { _checkCTNo = value; }
        }
        private string _diagnosis = string.Empty;
        /// <summary>
        /// 诊断
        /// </summary>
        public string Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; }
        }
        private string _treatmentPlan = string.Empty;
        /// <summary>
        /// 治疗方案
        /// </summary>
        public string TreatmentPlan
        {
            get { return _treatmentPlan; }
            set { _treatmentPlan = value; }
        }
        private string _treatmentProcess = string.Empty;
        /// <summary>
        /// 治疗过程
        /// </summary>
        public string TreatmentProcess
        {
            get { return _treatmentProcess; }
            set { _treatmentProcess = value; }
        }

        private string _adviceNotice = string.Empty;
        /// <summary>
        /// 医嘱 
        /// </summary>
        public string AdviceNotice
        {
            get { return _adviceNotice; }
            set { _adviceNotice = value; }
        }
        private string _operId;
        /// <summary>
        /// 操作员ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }

        private bool _isClearTooths;
        /// <summary>
        /// 是否洗牙
        /// </summary>
        public bool IsClearTooths
        {
            get { return _isClearTooths; }
            set { _isClearTooths = value; }
        }

        private string _pastHistory;
        /// <summary>
        /// 既往史
        /// </summary>
        public string PastHistory
        {
            get { return _pastHistory; }
            set { _pastHistory = value; }
        }
        //public string LocalVoicePath
        //{
        //    get;
        //    set;
        //}
        //public string ServerVoicePath
        //{
        //    get;
        //    set;
        //}
        //public string LocalVideoPath
        //{
        //    get;
        //    set;
        //}
        //public string ServerVideoPath
        //{
        //    get;
        //    set;
        //}
              
        /// <summary>
        /// 既往史
        /// </summary>
        public string PersonHistory { get; set; }

      

        private string _doctorName;
        /// <summary>
        ///  医生名称
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
    }
}
