

using System;
using Orm.Model;

namespace Orm.Model
{
	/// <summary>
	/// 病人信息表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPatient:BaseModel
	{   
		 
		private string _inPatNo;  //住院号
		
		private string _cardNo;  //卡号
		
		private string _name;  //病人姓名
		
		private string _sex;  //病人性别：M，F，O
		
		private DateTime _birthDate;  //生日
		
		private int _lsMarriage;  //婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
		
		private string _bloodGroup;  //血型

        private string _iDCardType;  //证件类型

        private string _xNo;  //X光号
		
		private string _nationId;  //民族
		
		private string _countryId;  //国家
		
		private string _provinceId;  //省
		
		private string _regionId;  //城市
		
		private string _areaId;  //区
		
		private string _native;  //籍贯地址
		
		private string _residence;  //户口地址
		
		private bool _isOversea;  //是否外籍人士
		
		private DateTime _passTime;  //入境时间
		
		private string _company;  //工作单位
		
		private string _occupation;  //职务
		
		private string _mobile;  //手机号码
		
		private string _email;  //电子邮箱
		
		private string _phone;  //电话
		
		private string _worktypeId;  //工种
		
		private string _patTypeId;  //病人类别
		
		private string _certificateId;  //证件ID
		
		private string _sensitive;  //过敏药物
		
		private string _idCardNo;  //身份证号
		
		private bool _isBaby;  //是否婴儿
		
		private string _motherPatId;  //母亲的病人ID
		
		private string _medicareNo;  //医疗证号/医保号
		
		private string _accountNo;  //记帐帐号
		
		private string _phoneWork;  //工作单位的电话
		
		private string _addressWork;  //工作单位地址
		
		private string _postCodeWork;  //工作单位的邮政编码
		
		private string _areaCodeWork;  //工作单位地区号
		
		private string _phoneHome;  //家庭的电话
		
		private string _addressHome;  //家庭地址
		
		private string _postCodeHome;  //家庭的邮政编码
		
		private string _areaCodeHome;  //家庭地区号
		
		private string _linkmanName;  //联系人
		
		private string _relationId;  //与联系人关系
		
		private string _linkmanPost;  //联系人邮政编码
		
		private string _linkmanArea;  //联系人地区号
		
		private string _linkmanAddress;  //联系人地址
		
		private string _linkmanPhone;  //联系人的电话
		
		private string _familyId;  //所在家庭
		
		private bool _isHouseMaster;  //是否户主
		
		private string _relaMasterId;  //与户主关系
		
		private int _lsCensus;  //户籍类型:1-常住;2-暂住;3-流动
		
		private string _committeeId;  //所在居委会
		
		private string _policeStationId;  //所属派出所
		
		private string _levelId;  //学历
		
		private double _height;  //身高(CM)
		
		private double _weight;  //体重(KG)
		
		private int _circumference;  //胸围
		
		private int _waistline;  //腰围(CM)
		
		private int _sternline;  //臀围(CM)

        private string _kitchenExhaust = string.Empty;//厨房排风措施

        private string _toilet = string.Empty;//厕所

        private bool _isFixedPoint = false;

        private int _lsSport;  //体育锻炼：1-不锻炼；2-每周<3次；3-每周3次以上；4-无规律
		
		private int _lsSportTime;  //锻炼时间：1-<20分钟；2-40分钟；3-1小时以上
		
		private int _lsSportType;  //锻炼类型：1-有氧运动（慢跑、气功、太极等）；2-无氧运动（速跑、篮球、排球等）
		
		private int _lsBitHabit;  //饮食习惯：1-普通；2-嗜咸；3-嗜甜；4-喜热；5-经常吃油炸食物
		
		private int _sleepHour;  //睡眠情况(小时/天)
		
		private int _lsSleepTrouble;  //睡眠障碍：1-无；2-入睡困难；3-早醒；4-梦游
		
		private string _smokeHistory;  //吸烟史
		
		private string _drinkHistory;  //饮酒史
		
		private string _otherHabit;  //其他习惯
		
		private DateTime _operTime;  //录入时间
		
		private string _operID;  //录入人
		
		private bool _isActive;  //是否活动
		
		private string _inActiveReason;  //非活动的原因
		
		private DateTime _inActiveTime;  //非活动(迁出或死亡)时间
		
		private string _inActiveOperID;  //录入非活动的操作者
		
		private int _iconIndex;  //图标类型
		
		private string _photoFolder;  //居民相片
		
		private string _roadId;  //所在组/路/巷
		
		private string _personHistory;  //既往史
		
		private string _password;  //密码
		
		private string _healthCardNo;  //健康档案卡号
		
		private string _ageStr;  //字符串年龄
		
		private int _age;  //数值年龄
		
		private string _interfaceNo;  //接口号，做接口时保存第三方唯一标识
		
		private string _fromHospitalID;  //病人来源
		
		private double _ageDay;  //行心云: 年龄天数
		
		private double _ageMonth;  //行心云: 年龄月份
		
		private string _rhnegAtive;  //行心云:RH阴性
		
		private string _children;  //行心云:家族史（子女）
		
		private string _siblings;  //行心云:家族史（兄弟姐妹）
		
		private string _mother;  //行心云:家族史（母亲）
		
		private string _father;  //行心云:家族史（父亲）
		
		private string _disability;  //行心云:残疾情况
		
		private string _livestock;  //行心云:禽畜栏
		
		private string _drinkingWater;  //行心云:饮水
		
		private string _fuelType;  //行心云:燃料类型
		
		private string _genetic;  //行心云:遗传病史
		
		private string _exPosure;  //行心云:暴露史
		
		private bool _isResidents;  //行心云:是否户籍
		
		private bool _isSpecial;  //行心云:是否特殊病人
		
		private string _archivePath;  //行心云:归档地点
		
		private string _adviserID;  //行心云:健康顾问
		
		private string _introducerPatID;  //行心云:推荐人
		
		private string _familyHistory;  //行心云:家族史
		
		private bool _isHideIllness;  //行心云:是否特殊客人
		
		private DateTime _endMenstruationTime;  //行心云:末次月经
		
		private double _givingIntegral;  //行心云:推荐人赠送积分
		
		private string _vipLevelId;  //行心云:会员等级
		
		private double _vipScore;  //行心云:积分
		
		private DateTime _hideOperTime;  //行心云:隐藏操作时间
		
		private string _hideOperID;  //行心云:隐藏操作人ID
		
		private bool _isHide;  //行心云:是否隐藏
		
		private double _bPValue;  //行心云:血压值
		
		private string _comments;  //行心云:备注
		
		private string _patientSource;  //行心云:病人来源
		
		private string _weChatNo;  //行心云:微信号
		
		private string _hobby;  //行心云:爱好
		
		private string _familyBackGround;  //行心云:家庭背景
		
		private string _webUserCode;  //行心云:网站平台的病人唯一号
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private bool _isWebBinding;  //行心云:回访周期类型: 1:七天、2半个月、3一个月、4:三个月、5:半年、6:一年、7:两年、8:三年
		
		private string _healthCondition;  //行心云:健康状况
		
		private string _school;  //行心云:学校
		
		private string _indroducerUserid;  //行心云:内部介绍人id（市场）

        private int _HospitalID;//医院ID 

        private string _doctorId;//医生ID

        private int _hisType;//HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有

        private bool _isVip;

        private string _refErral;

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
        /// 转诊相关标志信息
        /// </summary>
        public string RefErral
        {
            get { return _refErral; }
            set { _refErral = value; }
        }
        /// <summary>
        /// 是否会员
        /// </summary>

        public bool IsVip
        {
            get { return _isVip; }
            set { _isVip = value; }
        }

        /// <summary>
        /// 住院号
        /// </summary>
        public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
		}                                    
		
		/// <summary>
		/// 卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 病人姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 病人性别：M，F，O
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime BirthDate
		{
			get { return _birthDate;}
			set { _birthDate = value;}
		}                                    
		
		/// <summary>
		/// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
		/// </summary>
		public int LsMarriage
		{
			get { return _lsMarriage;}
			set { _lsMarriage = value;}
		}                                    
		
		/// <summary>
		/// 血型
		/// </summary>
		public string BloodGroup
		{
			get { return _bloodGroup;}
			set { _bloodGroup = value;}
		}

        /// <summary>
        /// 证件类型
        /// </summary>
        public string IDCardType
        {
            get { return _iDCardType; }
            set { _iDCardType = value; }
        }


        /// <summary>
        /// X光号
        /// </summary>
        public string XNo
		{
			get { return _xNo;}
			set { _xNo = value;}
		}                                    
		
		/// <summary>
		/// 民族
		/// </summary>
		public string NationId
		{
			get { return _nationId;}
			set { _nationId = value;}
		}                                    
		
		/// <summary>
		/// 国家
		/// </summary>
		public string CountryId
		{
			get { return _countryId;}
			set { _countryId = value;}
		}                                    
		
		/// <summary>
		/// 省
		/// </summary>
		public string ProvinceId
		{
			get { return _provinceId;}
			set { _provinceId = value;}
		}                                    
		
		/// <summary>
		/// 城市
		/// </summary>
		public string RegionId
		{
			get { return _regionId;}
			set { _regionId = value;}
		}                                    
		
		/// <summary>
		/// 区
		/// </summary>
		public string AreaId
		{
			get { return _areaId;}
			set { _areaId = value;}
		}                                    
		
		/// <summary>
		/// 籍贯地址
		/// </summary>
		public string Native
		{
			get { return _native;}
			set { _native = value;}
		}                                    
		
		/// <summary>
		/// 户口地址
		/// </summary>
		public string Residence
		{
			get { return _residence;}
			set { _residence = value;}
		}                                    
		
		/// <summary>
		/// 是否外籍人士
		/// </summary>
		public bool IsOversea
		{
			get { return _isOversea;}
			set { _isOversea = value;}
		}                                    
		
		/// <summary>
		/// 入境时间
		/// </summary>
		public DateTime PassTime
		{
			get { return _passTime;}
			set { _passTime = value;}
		}                                    
		
		/// <summary>
		/// 工作单位
		/// </summary>
		public string Company
		{
			get { return _company;}
			set { _company = value;}
		}                                    
		
		/// <summary>
		/// 职务
		/// </summary>
		public string Occupation
		{
			get { return _occupation;}
			set { _occupation = value;}
		}                                    
		
		/// <summary>
		/// 手机号码
		/// </summary>
		public string Mobile
		{
			get { return _mobile;}
			set { _mobile = value;}
		}                                    
		
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string Email
		{
			get { return _email;}
			set { _email = value;}
		}                                    
		
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
		}                                    
		
		/// <summary>
		/// 工种
		/// </summary>
		public string WorktypeId
		{
			get { return _worktypeId;}
			set { _worktypeId = value;}
		}                                    
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 证件ID
		/// </summary>
		public string CertificateId
		{
			get { return _certificateId;}
			set { _certificateId = value;}
		}                                    
		
		/// <summary>
		/// 过敏药物
		/// </summary>
		public string Sensitive
		{
			get { return _sensitive;}
			set { _sensitive = value;}
		}                                    
		
		/// <summary>
		/// 身份证号
		/// </summary>
		public string IdCardNo
		{
			get { return _idCardNo;}
			set { _idCardNo = value;}
		}                                    
		
		/// <summary>
		/// 是否婴儿
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 母亲的病人ID
		/// </summary>
		public string MotherPatId
		{
			get { return _motherPatId;}
			set { _motherPatId = value;}
		}                                    
		
		/// <summary>
		/// 医疗证号/医保号
		/// </summary>
		public string MedicareNo
		{
			get { return _medicareNo;}
			set { _medicareNo = value;}
		}                                    
		
		/// <summary>
		/// 记帐帐号
		/// </summary>
		public string AccountNo
		{
			get { return _accountNo;}
			set { _accountNo = value;}
		}                                    
		
		/// <summary>
		/// 工作单位的电话
		/// </summary>
		public string PhoneWork
		{
			get { return _phoneWork;}
			set { _phoneWork = value;}
		}                                    
		
		/// <summary>
		/// 工作单位地址
		/// </summary>
		public string AddressWork
		{
			get { return _addressWork;}
			set { _addressWork = value;}
		}                                    
		
		/// <summary>
		/// 工作单位的邮政编码
		/// </summary>
		public string PostCodeWork
		{
			get { return _postCodeWork;}
			set { _postCodeWork = value;}
		}                                    
		
		/// <summary>
		/// 工作单位地区号
		/// </summary>
		public string AreaCodeWork
		{
			get { return _areaCodeWork;}
			set { _areaCodeWork = value;}
		}                                    
		
		/// <summary>
		/// 家庭的电话
		/// </summary>
		public string PhoneHome
		{
			get { return _phoneHome;}
			set { _phoneHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭地址
		/// </summary>
		public string AddressHome
		{
			get { return _addressHome;}
			set { _addressHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭的邮政编码
		/// </summary>
		public string PostCodeHome
		{
			get { return _postCodeHome;}
			set { _postCodeHome = value;}
		}                                    
		
		/// <summary>
		/// 家庭地区号
		/// </summary>
		public string AreaCodeHome
		{
			get { return _areaCodeHome;}
			set { _areaCodeHome = value;}
		}                                    
		
		/// <summary>
		/// 联系人
		/// </summary>
		public string LinkmanName
		{
			get { return _linkmanName;}
			set { _linkmanName = value;}
		}                                    
		
		/// <summary>
		/// 与联系人关系
		/// </summary>
		public string RelationId
		{
			get { return _relationId;}
			set { _relationId = value;}
		}                                    
		
		/// <summary>
		/// 联系人邮政编码
		/// </summary>
		public string LinkmanPost
		{
			get { return _linkmanPost;}
			set { _linkmanPost = value;}
		}                                    
		
		/// <summary>
		/// 联系人地区号
		/// </summary>
		public string LinkmanArea
		{
			get { return _linkmanArea;}
			set { _linkmanArea = value;}
		}                                    
		
		/// <summary>
		/// 联系人地址
		/// </summary>
		public string LinkmanAddress
		{
			get { return _linkmanAddress;}
			set { _linkmanAddress = value;}
		}                                    
		
		/// <summary>
		/// 联系人的电话
		/// </summary>
		public string LinkmanPhone
		{
			get { return _linkmanPhone;}
			set { _linkmanPhone = value;}
		}                                    
		
		/// <summary>
		/// 所在家庭
		/// </summary>
		public string FamilyId
		{
			get { return _familyId;}
			set { _familyId = value;}
		}                                    
		
		/// <summary>
		/// 是否户主
		/// </summary>
		public bool isHouseMaster
		{
			get { return _isHouseMaster;}
			set { _isHouseMaster = value;}
		}                                    
		
		/// <summary>
		/// 与户主关系
		/// </summary>
		public string RelaMasterId
		{
			get { return _relaMasterId;}
			set { _relaMasterId = value;}
		}                                    
		
		/// <summary>
		/// 户籍类型:1-常住;2-暂住;3-流动
		/// </summary>
		public int LsCensus
		{
			get { return _lsCensus;}
			set { _lsCensus = value;}
		}                                    
		
		/// <summary>
		/// 所在居委会
		/// </summary>
		public string CommitteeId
		{
			get { return _committeeId;}
			set { _committeeId = value;}
		}                                    
		
		/// <summary>
		/// 所属派出所
		/// </summary>
		public string PoliceStationId
		{
			get { return _policeStationId;}
			set { _policeStationId = value;}
		}                                    
		
		/// <summary>
		/// 学历
		/// </summary>
		public string LevelId
		{
			get { return _levelId;}
			set { _levelId = value;}
		}                                    
		
		/// <summary>
		/// 身高(CM)
		/// </summary>
		public double Height
		{
			get { return _height;}
			set { _height = value;}
		}                                    
		
		/// <summary>
		/// 体重(KG)
		/// </summary>
		public double Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		/// 胸围
		/// </summary>
		public int Circumference
		{
			get { return _circumference;}
			set { _circumference = value;}
		}                                    
		
		/// <summary>
		/// 腰围(CM)
		/// </summary>
		public int Waistline
		{
			get { return _waistline;}
			set { _waistline = value;}
		}                                    
		
		/// <summary>
		/// 臀围(CM)
		/// </summary>
		public int Sternline
		{
			get { return _sternline;}
			set { _sternline = value;}
		}                                    
		
		/// <summary>
		/// 体育锻炼：1-不锻炼；2-每周<3次；3-每周3次以上；4-无规律
		/// </summary>
		public int LsSport
		{
			get { return _lsSport;}
			set { _lsSport = value;}
		}                                    
		
		/// <summary>
		/// 锻炼时间：1-<20分钟；2-40分钟；3-1小时以上
		/// </summary>
		public int LsSportTime
		{
			get { return _lsSportTime;}
			set { _lsSportTime = value;}
		}                                    
		
		/// <summary>
		/// 锻炼类型：1-有氧运动（慢跑、气功、太极等）；2-无氧运动（速跑、篮球、排球等）
		/// </summary>
		public int LsSportType
		{
			get { return _lsSportType;}
			set { _lsSportType = value;}
		}                                    
		
		/// <summary>
		/// 饮食习惯：1-普通；2-嗜咸；3-嗜甜；4-喜热；5-经常吃油炸食物
		/// </summary>
		public int LsBitHabit
		{
			get { return _lsBitHabit;}
			set { _lsBitHabit = value;}
		}                                    
		
		/// <summary>
		/// 睡眠情况(小时/天)
		/// </summary>
		public int SleepHour
		{
			get { return _sleepHour;}
			set { _sleepHour = value;}
		}                                    
		
		/// <summary>
		/// 睡眠障碍：1-无；2-入睡困难；3-早醒；4-梦游
		/// </summary>
		public int LsSleepTrouble
		{
			get { return _lsSleepTrouble;}
			set { _lsSleepTrouble = value;}
		}                                    
		
		/// <summary>
		/// 吸烟史
		/// </summary>
		public string SmokeHistory
		{
			get { return _smokeHistory;}
			set { _smokeHistory = value;}
		}                                    
		
		/// <summary>
		/// 饮酒史
		/// </summary>
		public string DrinkHistory
		{
			get { return _drinkHistory;}
			set { _drinkHistory = value;}
		}                                    
		
		/// <summary>
		/// 其他习惯
		/// </summary>
		public string OtherHabit
		{
			get { return _otherHabit;}
			set { _otherHabit = value;}
		}                                    
		
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 录入人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 是否活动
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 非活动的原因
		/// </summary>
		public string InActiveReason
		{
			get { return _inActiveReason;}
			set { _inActiveReason = value;}
		}                                    
		
		/// <summary>
		/// 非活动(迁出或死亡)时间
		/// </summary>
		public DateTime InActiveTime
		{
			get { return _inActiveTime;}
			set { _inActiveTime = value;}
		}                                    
		
		/// <summary>
		/// 录入非活动的操作者
		/// </summary>
		public string InActiveOperID
		{
			get { return _inActiveOperID;}
			set { _inActiveOperID = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 居民相片
		/// </summary>
		public string PhotoFolder
		{
			get { return _photoFolder;}
			set { _photoFolder = value;}
		}                                    
		
		/// <summary>
		/// 所在组/路/巷
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
		}                                    
		
		/// <summary>
		/// 既往史
		/// </summary>
		public string PersonHistory
		{
			get { return _personHistory;}
			set { _personHistory = value;}
		}                                    
		
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			get { return _password;}
			set { _password = value;}
		}                                    
		
		/// <summary>
		/// 健康档案卡号
		/// </summary>
		public string HealthCardNo
		{
			get { return _healthCardNo;}
			set { _healthCardNo = value;}
		}

        /// <summary>
        /// 字符串年龄 AgeStr AgeString
        /// </summary>
        public string AgeStr
		{
			get { return _ageStr;}
			set { _ageStr = value;}
		}                                    
		
		/// <summary>
		/// 数值年龄
		/// </summary>
		public int Age
		{
			get { return _age;}
			set { _age = value;}
		}                                    
		
		/// <summary>
		/// 接口号，做接口时保存第三方唯一标识
		/// </summary>
		public string InterfaceNo
		{
			get { return _interfaceNo;}
			set { _interfaceNo = value;}
		}                                    
		
		/// <summary>
		/// 病人来源
		/// </summary>
		public string FromHospitalID
		{
			get { return _fromHospitalID;}
			set { _fromHospitalID = value;}
		}                                    
		
		/// <summary>
		/// 行心云: 年龄天数
		/// </summary>
		public double AgeDay
		{
			get { return _ageDay;}
			set { _ageDay = value;}
		}                                    
		
		/// <summary>
		/// 行心云: 年龄月份
		/// </summary>
		public double AgeMonth
		{
			get { return _ageMonth;}
			set { _ageMonth = value;}
		}                                    
		
		/// <summary>
		/// 行心云:RH阴性
		/// </summary>
		public string RhnegAtive
        {
			get { return _rhnegAtive;}
			set { _rhnegAtive = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家族史（子女）
		/// </summary>
		public string Children
		{
			get { return _children;}
			set { _children = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家族史（兄弟姐妹）
		/// </summary>
		public string Siblings
		{
			get { return _siblings;}
			set { _siblings = value;}
		}

        /// <summary>
        /// 厨房排风措施
        /// </summary>
        public string KitchenExhaust
        {
            get { return _kitchenExhaust; }
            set { _kitchenExhaust = value; }
        }

        /// <summary>
        /// 厕所
        /// </summary>
        public string Toilet
        {
            get { return _toilet; }
            set { _toilet = value; }
        }
        /// <summary>
        /// 是否定点;用于微信端接口收费判断是否医保缴费(为假时不是医保缴费)
        /// </summary>
        public bool IsFixedPoint
        {
            get { return _isFixedPoint; }
            set { _isFixedPoint = value; }
        }

        /// <summary>
        /// 行心云:家族史（母亲）
        /// </summary>
        public string Mother
		{
			get { return _mother;}
			set { _mother = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家族史（父亲）
		/// </summary>
		public string Father
		{
			get { return _father;}
			set { _father = value;}
		}                                    
		
		/// <summary>
		/// 行心云:残疾情况
		/// </summary>
		public string Disability
		{
			get { return _disability;}
			set { _disability = value;}
		}                                    
		
		/// <summary>
		/// 行心云:禽畜栏
		/// </summary>
		public string Livestock
		{
			get { return _livestock;}
			set { _livestock = value;}
		}                                    
		
		/// <summary>
		/// 行心云:饮水
		/// </summary>
		public string DrinkingWater
		{
			get { return _drinkingWater;}
			set { _drinkingWater = value;}
		}                                    
		
		/// <summary>
		/// 行心云:燃料类型
		/// </summary>
		public string FuelType
		{
			get { return _fuelType;}
			set { _fuelType = value;}
		}                                    
		
		/// <summary>
		/// 行心云:遗传病史
		/// </summary>
		public string Genetic
		{
			get { return _genetic;}
			set { _genetic = value;}
		}                                    
		
		/// <summary>
		/// 行心云:暴露史
		/// </summary>
		public string ExPosure
		{
			get { return _exPosure;}
			set { _exPosure = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否户籍
		/// </summary>
		public bool IsResidents
		{
			get { return _isResidents;}
			set { _isResidents = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否特殊病人
		/// </summary>
		public bool IsSpecial
		{
			get { return _isSpecial;}
			set { _isSpecial = value;}
		}                                    
		
		/// <summary>
		/// 行心云:归档地点
		/// </summary>
		public string ArchivePath
		{
			get { return _archivePath;}
			set { _archivePath = value;}
		}                                    
		
		/// <summary>
		/// 行心云:健康顾问
		/// </summary>
		public string AdviserID
		{
			get { return _adviserID;}
			set { _adviserID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:推荐人
		/// </summary>
		public string IntroducerPatID
		{
			get { return _introducerPatID;}
			set { _introducerPatID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家族史
		/// </summary>
		public string FamilyHistory
		{
			get { return _familyHistory;}
			set { _familyHistory = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否特殊客人
		/// </summary>
		public bool IsHideIllness
		{
			get { return _isHideIllness;}
			set { _isHideIllness = value;}
		}                                    
		
		/// <summary>
		/// 行心云:末次月经
		/// </summary>
		public DateTime EndMenstruationTime
		{
			get { return _endMenstruationTime;}
			set { _endMenstruationTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:推荐人赠送积分
		/// </summary>
		public double GivingIntegral
		{
			get { return _givingIntegral;}
			set { _givingIntegral = value;}
		}                                    
		
		/// <summary>
		/// 行心云:会员等级
		/// </summary>
		public string VipLevelId
		{
			get { return _vipLevelId;}
			set { _vipLevelId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:积分
		/// </summary>
		public double VipScore
		{
			get { return _vipScore;}
			set { _vipScore = value;}
		}                                    
		
		/// <summary>
		/// 行心云:隐藏操作时间
		/// </summary>
		public DateTime HideOperTime
		{
			get { return _hideOperTime;}
			set { _hideOperTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:隐藏操作人ID
		/// </summary>
		public string HideOperID
		{
			get { return _hideOperID;}
			set { _hideOperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否隐藏
		/// </summary>
		public bool IsHide
		{
			get { return _isHide;}
			set { _isHide = value;}
		}                                    
		
		/// <summary>
		/// 行心云:血压值
		/// </summary>
		public double BPValue
		{
			get { return _bPValue;}
			set { _bPValue = value;}
		}                                    
		
		/// <summary>
		/// 行心云:备注
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
		}                                    
		
		/// <summary>
		/// 行心云:病人来源
		/// </summary>
		public string PatientSource
		{
			get { return _patientSource;}
			set { _patientSource = value;}
		}                                    
		
		/// <summary>
		/// 行心云:微信号
		/// </summary>
		public string WeChatNo
		{
			get { return _weChatNo;}
			set { _weChatNo = value;}
		}                                    
		
		/// <summary>
		/// 行心云:爱好
		/// </summary>
		public string Hobby
		{
			get { return _hobby;}
			set { _hobby = value;}
		}                                    
		
		/// <summary>
		/// 行心云:家庭背景
		/// </summary>
		public string FamilyBackGround
		{
			get { return _familyBackGround;}
			set { _familyBackGround = value;}
		}                                    
		
		/// <summary>
		/// 行心云:网站平台的病人唯一号
		/// </summary>
		public string WebUserCode
		{
			get { return _webUserCode;}
			set { _webUserCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:回访周期类型: 1:七天、2半个月、3一个月、4:三个月、5:半年、6:一年、7:两年、8:三年
		/// </summary>
		public bool IsWebBinding
		{
			get { return _isWebBinding;}
			set { _isWebBinding = value;}
		}                                    
		
		/// <summary>
		/// 行心云:健康状况
		/// </summary>
		public string HealthCondition
		{
			get { return _healthCondition;}
			set { _healthCondition = value;}
		}                                    
		
		/// <summary>
		/// 行心云:学校
		/// </summary>
		public string School
		{
			get { return _school;}
			set { _school = value;}
		}                                    
		
		/// <summary>
		/// 行心云:内部介绍人id（市场）
		/// </summary>
		public string IndroducerUserid
		{
			get { return _indroducerUserid;}
			set { _indroducerUserid = value;}
		}

     

        /// <summary>
        /// 医生ID
        /// </summary>

        public string DoctorId
        {
            get { return _doctorId; }
            set { this._doctorId = value; }
        }
        /// <summary>
        /// 手机或电话
        /// </summary>
        public string MobileOrPhone
        {
            get
            {
                return string.IsNullOrWhiteSpace(this.Mobile) ? this.Phone : this.Mobile;
            }
        }
        /// <summary>  
        /// 腰围(CM)
        /// </summary>  
        public int WaistLine
        {
            get { return _waistline; }
            set { _waistline = value; }
        }

        /// <summary>
        /// HisType 产品类型：0 共享 1 His 2 行心云 3养老1 2 3表示某种系统独有
        /// </summary>
        public int HisType
        {
            get
            {
                return this._hisType;
            }
            set
            {
                this._hisType = value;
            }
        }
    }  
}           


