using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 病人组合查询信息
    /// </summary>
    [Serializable]
    public class PMPatientQuery : BaseModel
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }


        private string _name = string.Empty;

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _AgeString = string.Empty;
        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString
        {
            get { return _AgeString; }
            set { _AgeString = value; }
        }

        private string _cardNo = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        private string _phone = string.Empty;
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _cnbookingPurpose = string.Empty;
        /// <summary>
        ///  就诊目的中文（格式如：洁牙，拔牙，种植）
        /// </summary>
        public string CnBookingPurpose
        {
            get { return _cnbookingPurpose; }
            set { _cnbookingPurpose = value; }
        }

        private string _doctorId;
        /// <summary>
        /// 就诊医生
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        private string _tjLocationId;
        /// <summary>
        /// 诊所ID
        /// </summary>
        public string TjLocationId
        {
            get { return _tjLocationId; }
            set { _tjLocationId = value; }
        }

        private string _sex = "";
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private int _startAge = 0;
        /// <summary>
        /// 开始岁数
        /// </summary>
        public int StartAge
        {
            get { return _startAge; }
            set { _startAge = value; }
        }

        private int _endAge = 0;
        /// <summary>
        /// 结束岁数
        /// </summary>
        public int EndAge
        {
            get { return _endAge; }
            set { _endAge = value; }
        }

        private DateTime _startBirthDate = DateTime.MinValue;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime StartBirthDate
        {
            get
            {
                if (EndAge > 0)
                    _startBirthDate = DateTime.Now.AddYears(-EndAge).Date;
                if (EndAge == 0 || EndAge < StartAge)
                    _startBirthDate = DateTime.MinValue.Date;
                return _startBirthDate;
            }
            set { _startBirthDate = value; }
        }

        private DateTime _endBirthDate = DateTime.MinValue;
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndBirthDate
        {
            get
            {
                if (StartAge >= 0)
                    _endBirthDate = DateTime.Now.AddYears(-StartAge).Date;
                if (StartAge < 0)
                    _endBirthDate = DateTime.Now.Date;
                return _endBirthDate;
            }
            set { _endBirthDate = value; }
        }

        private string _locationId;
        /// <summary>
        /// 所属科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        private int _HospitalID;
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }
        private int _visitStatus = 0;
        /// <summary>
        /// 就诊状态1初诊、2复诊
        /// </summary>
        public int VisitStatus
        {
            get { return _visitStatus; }
            set { _visitStatus = value; }
        }

        private int _followStatus = -1;
        /// <summary>
        /// 回访状态
        /// </summary>
        public int FollowStatus
        {
            get { return _followStatus; }
            set { _followStatus = value; }
        }

        private string _recordNumber = string.Empty;
        /// <summary>
        /// 病例编号
        /// </summary>
        public string RecordNumber
        {
            get { return _recordNumber; }
            set { _recordNumber = value; }
        }

        private string _AdviserId;
        /// <summary>
        /// 健康顾问ID
        /// </summary>
        public string AdviserId
        {
            get { return _AdviserId; }
            set { _AdviserId = value; }
        }

        private string _vIPCardNo = string.Empty;
        /// <summary>
        /// 卡号
        /// </summary>
        public string VIPCardNo
        {
            get { return _vIPCardNo; }
            set { _vIPCardNo = value; }
        }

        private string _vIPCardID;
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public string VIPCardID
        {
            get { return _vIPCardID; }
            set { _vIPCardID = value; }
        }

        private int _preRegType = 2;
        /// <summary>
        /// 0.未预约 1.已预约  2.全部
        /// </summary>
        public int PreRegType
        {
            get { return _preRegType; }
            set { _preRegType = value; }
        }

        private string _itemName = string.Empty;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        private int _selectedAttachType = 2;
        /// <summary>
        /// 0.未执行 1.已执行  2.全部
        /// </summary>
        public int SelectedAttachType
        {
            get { return _selectedAttachType; }
            set { _selectedAttachType = value; }
        }

        private string _levelID;
        /// <summary>
        /// 等级ID
        /// </summary>
        public string LevelID
        {
            get { return _levelID; }
            set { _levelID = value; }
        }

        private string _patientSource = string.Empty;
        /// <summary>
        /// 病人来源
        /// </summary>
        public string PatientSource
        {
            get { return _patientSource; }
            set { _patientSource = value; }
        }

        private int _operType = 0;
        /// <summary>
        /// 操作类型
        /// </summary>
        public int OperType
        {
            get { return _operType; }
            set { _operType = value; }
        }
    }
}
