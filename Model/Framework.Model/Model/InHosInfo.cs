

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院病人信息表 - 实体类
	/// </summary>
	[Serializable]
    public partial class InHosInfo : BaseModel
    {

        private string _hospNo;  //住院号（相当于门诊的流水号）,用户不可见

        private string _patID;  //病人ID

        private string _inPatNo;  //病人号(对一个病人唯一),不可见

        private string _cardNo;  //卡号

        private string _name;  //病人姓名

        private string _sex;  //病人性别：F-女；M-男；O-其他

        private int _nTime;  //第几次住院

        private DateTime _inTime;  //入院日期

        private DateTime _outTime;  //出院日期

        private int _lsMarriage;  //婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他

        private string _bloodGroup;  //血型

        private string _xNo;  //X光号

        private string _countryId;  //国家

        private string _residence;  //户口地址

        private string _city;  //城市

        private string _province;  //省

        private bool _isOversea;  //是否外籍人士

        private DateTime _passTime;  //入境时间

        private string _idCardNo;  //身份证号

        private string _company;  //工作单位

        private string _occupation;  //职位

        private string _worktypeId;  //工种

        private string _patTypeId;  //病人类别

        private string _certificateId;  //证件ID

        private int _lsInType;  //入院方式：1-门诊；2-急诊；3-转院；4-其他

        private string _lsInWay;  //门诊科室

        private int _lsInIllness;  //入院病情：1-危；2-急；3-一般；4-重

        private string _docMz;  //门诊医生

        private string _doctorId;  //住院医生

        private string _locIn;  //入院科室

        private string _locationId;  //当前科室

        private string _bedId;  //当前床位

        private string _outBedName;  //出院床位

        private bool _isYbMt;  //是否门特病人

        private string _ybRegNo;  //医保就医登记号

        private double _arrearAmount;  //欠费多少就限制录入费用

        private bool _isBaby;  //是否婴儿

        private int _ageDay;  //婴儿天数

        private double _height;  //身高

        private double _weight;  //体重

        private string _phoneHome;  //家庭的电话

        private string _addressHome;  //家庭地址

        private string _postCodeHome;  //家庭的邮政编码

        private string _areaCodeHome;  //工作单位地区号

        private string _phoneWork;  //工作单位的电话

        private string _addressWork;  //工作单位地址

        private string _postCodeWork;  //工作单位的邮政编码

        private string _areaCodeWork;  //家庭地区号

        private string _linkmanName;  //联系人姓名

        private string _relationId;  //联系人关系

        private string _linkmanPhone;  //联系人电话

        private string _linkmanAddress;  //联系人地址

        private string _linkmanPost;  //联系人邮政编码

        private string _linkmanArea;  //介绍医生

        private int _lsInStatus;  //住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院

        private DateTime _leaveTime;  //请假日期

        private string _status;  //住院病情

        private DateTime _operTime;  //登记日期

        private string _operID;  //登记人

        private bool _isEndChg;  //结束收费标志

        private string _endChgOperID;  //结束收费人

        private DateTime _endchgoperTime;  //结束收费时间

        private string _memo;  //备注

        private string _motherHospId;  //母亲住院号

        private string _fromHospitalId;  //其他来源医院

        private string _mzRegId;  //门诊流水号

        private int _locOut;  //门诊科室

        private string _tipsNurse;  //提示护士

        private string _tipsBalance;  //提示结算

        private string _tipsOther;  //提示其他角色

        private string _otherRoles;  //其他角色ID

        private bool _isIllegal;  //

        private double _unLines;  //起伏线

        private double _scale;  //报销比例

        private string _fromHospital;  //其他来源医院。外键，引用BsFromHospital.GUID

        private int _number1;  //补充险:0未定1是2否

        private int _number2;

        private int _number3;  //病案接口:1-已导,0-未导

        private int _number4;  //

        private string _yBBZCode;  //医保病种编码

        private bool _amountAuth;  //

        private string _author;  //

        private string _ageStr;  //字符串年龄

        private int _age;  //数值年龄

        private string _illDesc;  //诊断名称

        private string _ybPatType;  //参保人医别：职工，居民

        private string _newBabyId;  //

        private bool _isAuthed;  //已经封存，不可改删

        private int _hospitalID;  //

        

        private int _lsYbDiff;


        /// <summary>
        /// 住院号（相当于门诊的流水号）,用户不可见
        /// </summary>
        public string HospNo
        {
            get { return _hospNo; }
            set { _hospNo = value; }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }

        /// <summary>
        /// 病人号(对一个病人唯一),不可见
        /// </summary>
        public string InPatNo
        {
            get { return _inPatNo; }
            set { _inPatNo = value; }
        }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 病人性别：F-女；M-男；O-其他
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 第几次住院
        /// </summary>
        public int NTime
        {
            get { return _nTime; }
            set { _nTime = value; }
        }

        /// <summary>
        /// 入院日期
        /// </summary>
        public DateTime InTime
        {
            get { return _inTime; }
            set { _inTime = value; }
        }

        /// <summary>
        /// 出院日期
        /// </summary>
        public DateTime OutTime
        {
            get { return _outTime; }
            set { _outTime = value; }
        }

        /// <summary>
        /// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
        /// </summary>
        public int LsMarriage
        {
            get { return _lsMarriage; }
            set { _lsMarriage = value; }
        }

        /// <summary>
        /// 血型
        /// </summary>
        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }

        /// <summary>
        /// X光号
        /// </summary>
        public string XNo
        {
            get { return _xNo; }
            set { _xNo = value; }
        }

        /// <summary>
        /// 国家
        /// </summary>
        public string CountryId
        {
            get { return _countryId; }
            set { _countryId = value; }
        }

        /// <summary>
        /// 户口地址
        /// </summary>
        public string Residence
        {
            get { return _residence; }
            set { _residence = value; }
        }

        /// <summary>
        /// 城市
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        /// <summary>
        /// 省
        /// </summary>
        public string Province
        {
            get { return _province; }
            set { _province = value; }
        }

        /// <summary>
        /// 是否外籍人士
        /// </summary>
        public bool IsOversea
        {
            get { return _isOversea; }
            set { _isOversea = value; }
        }

        /// <summary>
        /// 入境时间
        /// </summary>
        public DateTime PassTime
        {
            get { return _passTime; }
            set { _passTime = value; }
        }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }

        /// <summary>
        /// 工作单位
        /// </summary>
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        /// <summary>
        /// 职位
        /// </summary>
        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }

        /// <summary>
        /// 工种
        /// </summary>
        public string WorktypeId
        {
            get { return _worktypeId; }
            set { _worktypeId = value; }
        }

        /// <summary>
        /// 病人类别
        /// </summary>
        public string PatTypeId
        {
            get { return _patTypeId; }
            set { _patTypeId = value; }
        }

        /// <summary>
        /// 证件ID
        /// </summary>
        public string CertificateId
        {
            get { return _certificateId; }
            set { _certificateId = value; }
        }

        /// <summary>
        /// 入院方式：1-门诊；2-急诊；3-转院；4-其他
        /// </summary>
        public int LsInType
        {
            get { return _lsInType; }
            set { _lsInType = value; }
        }

        /// <summary>
        /// 门诊科室
        /// </summary>
        public string  LsInWay
        {
            get { return _lsInWay; }
            set { _lsInWay = value; }
        }

        /// <summary>
        /// 入院病情：1-危；2-急；3-一般；4-重
        /// </summary>
        public int LsInIllness
        {
            get { return _lsInIllness; }
            set { _lsInIllness = value; }
        }

        /// <summary>
        /// 门诊医生
        /// </summary>
        public string  DocMz
        {
            get { return _docMz; }
            set { _docMz = value; }
        }

        /// <summary>
        /// 住院医生
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 入院科室
        /// </summary>
        public string LocIn
        {
            get { return _locIn; }
            set { _locIn = value; }
        }

        /// <summary>
        /// 当前科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 当前床位
        /// </summary>
        public string BedId
        {
            get { return _bedId; }
            set { _bedId = value; }
        }

        /// <summary>
        /// 出院床位
        /// </summary>
        public string OutBedName
        {
            get { return _outBedName; }
            set { _outBedName = value; }
        }

        /// <summary>
        /// 是否门特病人
        /// </summary>
        public bool IsYbMt
        {
            get { return _isYbMt; }
            set { _isYbMt = value; }
        }

        /// <summary>
        /// 医保就医登记号
        /// </summary>
        public string YbRegNo
        {
            get { return _ybRegNo; }
            set { _ybRegNo = value; }
        }

        /// <summary>
        /// 欠费多少就限制录入费用
        /// </summary>
        public double ArrearAmount
        {
            get { return _arrearAmount; }
            set { _arrearAmount = value; }
        }

        /// <summary>
        /// 是否婴儿
        /// </summary>
        public bool IsBaby
        {
            get { return _isBaby; }
            set { _isBaby = value; }
        }

        /// <summary>
        /// 婴儿天数
        /// </summary>
        public int AgeDay
        {
            get { return _ageDay; }
            set { _ageDay = value; }
        }

        /// <summary>
        /// 身高
        /// </summary>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 体重
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        /// <summary>
        /// 家庭的电话
        /// </summary>
        public string PhoneHome
        {
            get { return _phoneHome; }
            set { _phoneHome = value; }
        }

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string AddressHome
        {
            get { return _addressHome; }
            set { _addressHome = value; }
        }

        /// <summary>
        /// 家庭的邮政编码
        /// </summary>
        public string PostCodeHome
        {
            get { return _postCodeHome; }
            set { _postCodeHome = value; }
        }

        /// <summary>
        /// 工作单位地区号
        /// </summary>
        public string AreaCodeHome
        {
            get { return _areaCodeHome; }
            set { _areaCodeHome = value; }
        }

        /// <summary>
        /// 工作单位的电话
        /// </summary>
        public string PhoneWork
        {
            get { return _phoneWork; }
            set { _phoneWork = value; }
        }

        /// <summary>
        /// 工作单位地址
        /// </summary>
        public string AddressWork
        {
            get { return _addressWork; }
            set { _addressWork = value; }
        }

        /// <summary>
        /// 工作单位的邮政编码
        /// </summary>
        public string PostCodeWork
        {
            get { return _postCodeWork; }
            set { _postCodeWork = value; }
        }

        /// <summary>
        /// 家庭地区号
        /// </summary>
        public string AreaCodeWork
        {
            get { return _areaCodeWork; }
            set { _areaCodeWork = value; }
        }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string LinkmanName
        {
            get { return _linkmanName; }
            set { _linkmanName = value; }
        }

        /// <summary>
        /// 联系人关系
        /// </summary>
        public string RelationId
        {
            get { return _relationId; }
            set { _relationId = value; }
        }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string LinkmanPhone
        {
            get { return _linkmanPhone; }
            set { _linkmanPhone = value; }
        }

        /// <summary>
        /// 联系人地址
        /// </summary>
        public string LinkmanAddress
        {
            get { return _linkmanAddress; }
            set { _linkmanAddress = value; }
        }

        /// <summary>
        /// 联系人邮政编码
        /// </summary>
        public string LinkmanPost
        {
            get { return _linkmanPost; }
            set { _linkmanPost = value; }
        }

        /// <summary>
        /// 介绍医生
        /// </summary>
        public string LinkmanArea
        {
            get { return _linkmanArea; }
            set { _linkmanArea = value; }
        }

        /// <summary>
        /// 住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院
        /// </summary>
        public int LsInStatus
        {
            get { return _lsInStatus; }
            set { _lsInStatus = value; }
        }

        /// <summary>
        /// 请假日期
        /// </summary>
        public DateTime LeaveTime
        {
            get { return _leaveTime; }
            set { _leaveTime = value; }
        }

        /// <summary>
        /// 住院病情
        /// </summary>
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 登记日期
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 登记人
        /// </summary>
        public string OperID
        {
            get { return _operID; }
            set { _operID = value; }
        }

        /// <summary>
        /// 结束收费标志
        /// </summary>
        public bool IsEndChg
        {
            get { return _isEndChg; }
            set { _isEndChg = value; }
        }

        /// <summary>
        /// 结束收费人
        /// </summary>
        public string EndChgOperID
        {
            get { return _endChgOperID; }
            set { _endChgOperID = value; }
        }

        /// <summary>
        /// 结束收费时间
        /// </summary>
        public DateTime EndchgoperTime
        {
            get { return _endchgoperTime; }
            set { _endchgoperTime = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 母亲住院号
        /// </summary>
        public string MotherHospId
        {
            get { return _motherHospId; }
            set { _motherHospId = value; }
        }

        /// <summary>
        /// 其他来源医院
        /// </summary>
        public string FromHospitalId
        {
            get { return _fromHospitalId; }
            set { _fromHospitalId = value; }
        }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 门诊科室
        /// </summary>
        public int LocOut
        {
            get { return _locOut; }
            set { _locOut = value; }
        }

        /// <summary>
        /// 提示护士
        /// </summary>
        public string TipsNurse
        {
            get { return _tipsNurse; }
            set { _tipsNurse = value; }
        }

        /// <summary>
        /// 提示结算
        /// </summary>
        public string TipsBalance
        {
            get { return _tipsBalance; }
            set { _tipsBalance = value; }
        }

        /// <summary>
        /// 提示其他角色
        /// </summary>
        public string TipsOther
        {
            get { return _tipsOther; }
            set { _tipsOther = value; }
        }

        /// <summary>
        /// 其他角色ID
        /// </summary>
        public string OtherRoles
        {
            get { return _otherRoles; }
            set { _otherRoles = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsIllegal
        {
            get { return _isIllegal; }
            set { _isIllegal = value; }
        }

        /// <summary>
        /// 起伏线
        /// </summary>
        public double UnLines
        {
            get { return _unLines; }
            set { _unLines = value; }
        }

        /// <summary>
        /// 报销比例
        /// </summary>
        public double Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        /// <summary>
        /// 其他来源医院。外键，引用BsFromHospital.GUID
        /// </summary>
        public string FromHospital
        {
            get { return _fromHospital; }
            set { _fromHospital = value; }
        }

        /// <summary>
        /// 补充险:0未定1是2否
        /// </summary>
        public int Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }

        public int NUMBER2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        /// <summary>
        /// 病案接口:1-已导,0-未导
        /// </summary>
        public int Number3
        {
            get { return _number3; }
            set { _number3 = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Number4
        {
            get { return _number4; }
            set { _number4 = value; }
        }

        /// <summary>
        /// 医保病种编码
        /// </summary>
        public string YBBZCode
        {
            get { return _yBBZCode; }
            set { _yBBZCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AmountAuth
        {
            get { return _amountAuth; }
            set { _amountAuth = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        /// <summary>
        /// 字符串年龄
        /// </summary>
        public string AgeStr
        {
            get { return _ageStr; }
            set { _ageStr = value; }
        }

        /// <summary>
        /// 数值年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 诊断名称
        /// </summary>
        public string IllDesc
        {
            get { return _illDesc; }
            set { _illDesc = value; }
        }

        /// <summary>
        /// 参保人医别：职工，居民
        /// </summary>
        public string YbPatType
        {
            get { return _ybPatType; }
            set { _ybPatType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NewBabyId
        {
            get { return _newBabyId; }
            set { _newBabyId = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _hospitalID; }
            set { _hospitalID = value; }
        }

       

        public int LsYbDiff
        {
            get { return _lsYbDiff; }
            set { _lsYbDiff = value; }
        }
        private bool _isBedId = false;
        public bool u_IsBedId
        {
            get
            {
                if (string.IsNullOrWhiteSpace(BedId))
                {
                    _isBedId = true;
                }
                return _isBedId;
            }
            set { _isBedId = value; }
        }
    }
}           


