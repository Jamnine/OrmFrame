using System;

namespace Orm.Model.Custom
{


    /// <summary>
    /// 病人组合
    /// </summary>
    [Serializable]
    public partial class uspBsPatient:BaseModel{
        
                
        private string _cardNo = string.Empty;
        private string _name = string.Empty;
        private string _sex = string.Empty;        
        private DateTime _birthDate;        
        private string _company = string.Empty;
        private string _occupation = string.Empty;
        private string _mobile = string.Empty;
        private string _email = string.Empty;
        private string _phone = string.Empty;        
        private string _idCardNo = string.Empty;       
        private string _phoneHome = string.Empty;        
        private string _ageString = string.Empty; 
        private string _webusercode = string.Empty;
        private string _medicareNo = string.Empty;
        private string _personHistory = string.Empty;
        private string _sensitive = string.Empty;
        private string _doctorName = string.Empty;
        private string _doctorName1 = string.Empty;
        private string _linkmanName = string.Empty;
        private string _linkmanPhone = string.Empty;
        private string _hospitalizationTimes;

        /// <summary>
        /// 最近住院次数，转诊病人
        /// </summary>
        public string HospitalizationTimes
        {
            get { return _hospitalizationTimes; }
            set { _hospitalizationTimes = value; }
        }
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public uspBsPatient()
        {
            //SetStringValue();
        }        

        /// <summary>
        /// 家庭电话
        /// </summary>
        public string PhoneHome
        {
            get { return this._phoneHome; }
            set { this._phoneHome = value; }
        }
           
        
        /// <summary>
        /// 卡号.
        /// </summary>
        public string CardNo
        {
            get
            {
                return this._cardNo;
            }
            set
            {
                this._cardNo=value;
            }
        }        
        
        /// <summary>
        /// 病人姓名.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name=value;
            }
        }        
        
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Sex
        {
            get
            {
                return this._sex;
            }
            set
            {
                this._sex=value;
            }
        }        
        
        /// <summary>
        /// 生日.
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate=value;
            }
        }        
       
        
       
         
        /// <summary>
        /// 家庭地址.
        /// </summary>
        public string Address
        {
            get;
            set;
        }        
        
              
        
        /// <summary>
        /// 工作单位.
        /// </summary>
        public string Company
        {
            get
            {
                if (_company == null)
                {
                    _company = " ";
                }
                return this._company;
            }
            set
            {
                this._company=value;
            }
        }        
        
        /// <summary>
        /// 职务.
        /// </summary>
        public string Occupation
        {
            get
            {
                if (_occupation == null)
                {
                    _occupation = " ";
                }
                return this._occupation;
            }
            set
            {
                this._occupation=value;
            }
        }        
        
        /// <summary>
        /// 手机号码.
        /// </summary>
        public string Mobile
        {
            get
            {
                if (_mobile == null)
                {
                    _mobile = " ";
                }
                return this._mobile;
            }
            set
            {
                this._mobile=value;
            }
        }

        /// <summary>
        /// 电话号码.
        /// </summary>
        public string Phone
        {
            get
            {
                if (_phone == null)
                {
                    _phone = " ";
                }
                return this._phone;
            }
            set
            {
                this._phone = value;
            }
        } 
        
        /// <summary>
        /// 电子邮箱.
        /// </summary>
        public string Email
        {
            get
            {
                if (_email == null)
                {
                    _email = " ";
                }
                return this._email;
            }
            set
            {
                this._email=value;
            }
        }        
         
        
        
        
       
        
        /// <summary>
        /// 证件类型
        /// </summary>
        public string CertificateCardType
        {
            get;
            set;
        }         
        
        
        /// <summary>
        /// 身份证号.
        /// </summary>
        public string IdCardNo
        {
            get
            {
                if (_idCardNo == null)
                {
                    _idCardNo = " ";
                }
                return this._idCardNo;
            }
            set
            {
                this._idCardNo=value;
            }
        }        
        
        
        /// <summary>
        /// 医疗证号/医保号.
        /// </summary>
        public string MedicareNo
        {
            get
            {
                if (_medicareNo == null)
                {
                    _medicareNo = " ";
                }
                return this._medicareNo;
            }
            set
            {
                this._medicareNo=value;
            }
        }          
         
       
        /// <summary>
        /// 既往史.
        /// </summary>
        public string PersonHistory
        {
            get
            {
                if (_personHistory == null)
                {
                    _personHistory = " ";
                }
                return this._personHistory;
            }
            set
            {
                this._personHistory=value;
            }
        }
        /// <summary>
        /// 过敏药物
        /// </summary>
        public string Sensitive
        {
            get {
                if (_sensitive == null)
                {
                    _sensitive = " ";                    
                }
                return this._sensitive;
            }
            set { this._sensitive = value; }
        }
        /// <summary>
        /// 年龄字符串.
        /// </summary>
        public string AgeString
        {
            get
            {
                if (_ageString == null)
                {
                    _ageString = " ";
                }
                return this._ageString;
            }
            set
            {
                this._ageString=value;
            }
        }

        /// <summary>
        /// 家庭住址
        /// </summary>
        public string HomeAddress { get; set; }

        

        /// <summary>
        /// 相片
        /// </summary>
        public byte[] PatientPhoto { get; set; } 

        /// <summary>
        /// 网站平台的病人唯一号
        /// </summary>
        public string WebUserCode
        {
            get
            { 
                return this._webusercode;
            }
            set
            {
                this._webusercode = value;
            }
        }

        /// <summary>
        /// 学校
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 家庭背景
        /// </summary>
        public string FamilyBackGround { get; set; }

        /// <summary>
        /// 兴趣爱好
        /// </summary>
        public string Hobby { get; set; }

        /// <summary>
        /// 微信号
        /// </summary>
        public string WeChatNo { get; set; }

        /// <summary>
        /// 病人来源
        /// </summary>
        public string PatientSource { get; set; }

        /// <summary>
        /// 初诊医生
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;
            }
        }


        /// <summary>
        /// 转诊医生
        /// </summary>
        public string DoctorName1
        {
            get
            {
                return this._doctorName1;
            }
            set
            {
                this._doctorName1 = value;
            }
        }

        /// <summary>
        /// 健康状况
        /// </summary>
        public string HealthCondition { get; set; }

        /// <summary>
        /// 本次欠款
        /// </summary>
        public double CurrentArrears { get; set; }

        /// <summary>
        /// 手机电话
        /// </summary>
        public string MobileOrPhone { get; set; }
        /// <summary>
        /// 是否会员
        /// </summary>
        public bool IsVip { get; set; } 

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCardNo
        {
            get;
            set;
        }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string  VipCardID
        {
            get;
            set;
        }
        /// <summary>
        /// 会员等级
        /// </summary>
        public string VipLevel
        {
            get;
            set;
        }

        /// <summary>
        /// 联系人的电话.
        /// </summary>
        public string LinkmanPhone
        {
            get
            {
                if (_linkmanPhone == null)
                {
                    _linkmanPhone = " ";
                }
                return this._linkmanPhone;
            }
            set
            {
                this._linkmanPhone = value;
            }
        }

        /// <summary>
        /// 联系人.
        /// </summary>
        public string LinkmanName
        {
            get
            {
                if (_linkmanName == null)
                {
                    _linkmanName = " ";
                }
                return this._linkmanName;
            }
            set
            {
                this._linkmanName = value;
            }
        }
        /// <summary>
        /// 介绍人ID
        /// 
        /// </summary>
        public string  IntroduceUserId { get; set; }

        /// <summary>
        /// 介绍人名称
        /// </summary>
        public string IntroduceUserName { get; set; }
    }
}



