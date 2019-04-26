using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人基本信息
    /// </summary>
    [Serializable]
    public partial class uspBsPatientQry : BaseModel
    {
        private double _vipScore;
        /// <summary>
        /// 会员积分
        /// </summary>
        public double VipScore
        {
            get { return _vipScore; }
            set { _vipScore = value; }
        }

        private double _vipScoreToMoney;
        /// <summary>
        /// 会员积分转换为钱
        /// </summary>
        public double VipScoreToMoney
        {
            get { return _vipScoreToMoney; }
            set { _vipScoreToMoney = value; }
        }


        private string _cardNo = string.Empty;
        /// <summary>
        /// 病人编号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        private string _name = string.Empty;
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _sex = string.Empty;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _mobile = string.Empty;
        /// <summary>
        /// 电话
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        private string _phone = string.Empty;
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private DateTime _birthDate;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        private string _personHistory = string.Empty;
        /// <summary>
        /// 既往史  
        /// </summary>
        public string PersonHistory
        {
            get { return _personHistory; }
            set { _personHistory = value; }
        }
        private string _sensitive = string.Empty;
        /// <summary>
        /// 过敏药物 
        /// </summary>
        public string Sensitive
        {
            get { return _sensitive; }
            set { _sensitive = value; }
        }
        private string _addressHome = string.Empty;
        /// <summary>
        /// 家庭地址
        /// </summary>
        public string AddressHome
        {
            get { return _addressHome; }
            set { _addressHome = value; }
        }
        private DateTime _perTime;
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _perTime; }
            set { _perTime = value; }
        }
        private string _operID;
        /// <summary>
        /// 操作人ID
        /// </summary>
        public string OperID
        {
            get { return _operID; }
            set { _operID = value; }
        }
        public string _operName = string.Empty;
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        private int _hospItalId = 0;
        /// <summary>
        /// 诊所ID
        /// </summary>
        public int HospItalId
        {
            get { return _hospItalId; }
            set { _hospItalId = value; }
        }

        private string _doctorId;
        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        private string _doctorName = string.Empty;
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
        private string _vipLevel = string.Empty;
        /// <summary>
        /// 会员等级
        /// </summary>
        public string VipLevel
        {
            get { return _vipLevel; }
            set { _vipLevel = value; }
        }

        private string _vipCardNo = string.Empty;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCardNo
        {
            get { return _vipCardNo; }
            set { _vipCardNo = value; }
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
        /// 建管师姓名
        /// </summary>

        public string AdviserName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }
    }
}
