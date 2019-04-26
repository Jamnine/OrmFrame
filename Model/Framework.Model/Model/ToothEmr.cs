

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云：电子病历主表信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class ToothEmr : BaseModel
    {
         
        private string _mainInform;  //主诉

        private string _sickHist;  //现病史

        private string _adviceNotice;  //医嘱

        private string _mome;  //备注

        private DateTime _operTime;  //操作时间

        private string _recordNumber;  //病历编号

        private string _doctorAssistant;  //医生助理

        private string _guId;  //

        private string _doctorId;  //医生id

        private string _operId;  //操作人id

        private string _patID;  //病人id

        private string _mzRegId;  //挂号id

        private string _ouPatientGroup;  //诊断

        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform
        {
            get { return _mainInform; }
            set { _mainInform = value; }
        }
        /// <summary>
        /// 诊断
        /// </summary>
        public string OuPatientGroup
        {
            get { return _ouPatientGroup; }
            set { _ouPatientGroup = value; }
        }
        /// <summary>
        /// 现病史
        /// </summary>
        public string SickHist
        {
            get { return _sickHist; }
            set { _sickHist = value; }
        }

        /// <summary>
        /// 医嘱
        /// </summary>
        public string AdviceNotice
        {
            get { return _adviceNotice; }
            set { _adviceNotice = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Mome
        {
            get { return _mome; }
            set { _mome = value; }
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
        /// 病历编号
        /// </summary>
        public string RecordNumber
        {
            get { return _recordNumber; }
            set { _recordNumber = value; }
        }

        /// <summary>
        /// 医生助理
        /// </summary>
        public string DoctorAssistant
        {
            get { return _doctorAssistant; }
            set { _doctorAssistant = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string GuId
        {
            get { return _guId; }
            set { _guId = value; }
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
        /// 操作人id
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 病人id
        /// </summary>
        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }

        /// <summary>
        /// 挂号id
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }
    }  
}           


