

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrFirstPage : BaseModel
    {    
		private DateTime _operTime;  //创建时间
		
		private string _operId;  //创建人
		
		private bool _isRealease;  //是否提交
		
		private DateTime _realeaseTime;  //提交日期
		
		private string _realeaseOperId;  //提交人
		
		private bool _isAuth;  //是否审核
		
		private DateTime _authOperTime;  //审核日期
		
		private string _authOperId;  //审核人
		
		private bool _isClosed;  //是否归档
		
		private DateTime _closedTime;  //归档日期
		
		private string _closedOperId;  //归档人
		
		private int _modifyOperTime;  //修改时间
		
		private string _modifyOperID;  //操作员
		
		private bool _isCheck;  //是否上级医生审核
		
		private string _hospitalName;  //医疗机构
		
		private string _hospitalCode;  //卫生机构组织代码
		
		private string _payWayName;  //医疗付费方式
		
		private string _cardNo;  //健康卡号
		
		private int _ntime;  //第几次住院
		
		private string _inPatNo;  //病案号
		
		private string _hospId;  //inhosinfo.id
		
		private string _name;  //病人姓名
		
		private string _sex;  //性别
		
		private DateTime _birthDate;  //出生日期
		
		private string _ageStr;  //年龄
		
		private string _ageMonth;  //年龄月
		
		private double _birthWeight;  //新生儿出生体重(克)
		
		private double _weight;  //新生儿入院体重(克)
		
		private string _country;  //国籍
		
		private string _addressBirth;  //出生地
		
		private string _native;  //籍贯地址
		
		private string _nationName;  //民族
		
		private string _idCardNo;  //身份证
		
		private string _workType;  //职业
		
		private int _lsMarriage;  //婚姻状况：1-未婚；2-已婚；3-丧偶；4-离异；9-其他
		
		private string _nowAddress;  //现住址
		
		private string _nowAddressPostCode;  //现住址邮编
		
		private string _residence;  //户口地址
		
		private string _residencePostCode;  //户口地址邮编
		
		private string _addressCompany;  //工作单位及地址
		
		private string _phoneWork;  //单位电话
		
		private string _postCodeWork;  //单位邮编
		
		private string _linkmanName;  //联系人
		
		private string _relation;  //与联系人关系
		
		private string _linkmanAddress;  //联系地址
		
		private string _linkmanPhone;  //联系人的电话
		
		private int _lsInType;  //入院途径：1-急诊；2-门诊；3-其他医疗机构转入；9-其他
		
		private DateTime _inTime;  //入院时间
		
		private string _locInName;  //入院科室
		
		private string _locInRoom;  //入院科室病房
		
		private string _inOutLocName;  //转科科别
		
		private DateTime _outtime;  //出院时间
		
		private string _locOutName;  //出院科室
		
		private string _locOutRoom;  //出院病房
		
		private int _days;  //住院天数
		
		private string _illDescMz;  //门(急)诊诊断
		
		private string _illCodeMz;  //门(急)诊诊断编码
		
		private string _caseClass;  //病例分型:A一般B急C疑难D危重
		
		private bool _isDgClass;  //临床路径病例。1是2否
		
		private int _rescueTimes;  //抢救次数
		
		private int _successTimes;  //成功次数
		
		private string _damagePoison;  //损伤、中毒的外部原因
		
		private string _damagePoisonIllCode;  //损伤、中毒疾病编码
		
		private string _pathology;  //病理诊断
		
		private string _pathologyNo;  //病理号
		
		private string _pathologyIllCode;  //病理诊断疾病编码
		
		private int _lsAllergy;  //是否药物过敏:1无2有
		
		private string _allergyDrugs;  //过敏药物
		
		private bool _isAutopsy;  //死亡患者尸检1.是2.否
		
		private int _lsBloodGroup;  //血型1.A2.B3.○4.AB5.不详6.未查
		
		private int _lsRh;  //Rh1.阴2.阳3.不详4.未查
		
		private string _locDirector;  //科主任
		
		private string _docDirector;  //主任（副主任）医师
		
		private string _maindoctor;  //主治医师
		
		private string _zyDoctor;  //住院医师
		
		private string _zrNurse;  //责任护士
		
		private string _studyDoctor;  //进修医师
		
		private string _sxDoctor;  //实习医师
		
		private string _codeOper;  //编码员
		
		private int _lsEmrQc;  //1.甲2.乙3.丙
		
		private string _emrQcDoctor;  //质控医师
		
		private string _emrQcNurse;  //质控护士
		
		private DateTime _emrQcDate;  //质控日期
		
		private int _lsOutWay;  //离院方式:1.医嘱离院,2.医嘱转院,拟接收医疗机构名称,3.医嘱转社区卫生服务机构/乡镇卫生院,拟接收医疗机构名称,4.非医嘱离院5.死亡9.其他,
		
		private string _outWay2;  //医嘱转院,拟接收医疗机构名称
		
		private string _outWay3;  //医嘱转社区卫生服务机构/乡镇卫生院,拟接收医疗机构名称
		
		private int _lsInPlan;  //是否有出院31天内再住院计划1.无。2.有
		
		private string _inPlanMemo;  //再住院计划目的。
		
		private int _beforBrainComaDay;  //颅脑损伤患者昏迷时间入院前几天
		
		private int _beforBrainComaHour;  //颅脑损伤患者昏迷时间入院前几小时
		
		private int _beforBrainComaMinute;  //-颅脑损伤患者昏迷时间入院前几分钟
		
		private int _alterBrainComaDay;  //颅脑损伤患者昏迷时间入院后几天
		
		private int _alterBrainComaHour;  //颅脑损伤患者昏迷时间入院后几小时
		
		private int _alterBrainComaMinute;  //颅脑损伤患者昏迷时间入院后几分钟
		
		private double _amount;  //住院费用（元）：总费用
		
		private double _amountPay;  //住院费用（元）：自付金额
		
		private int _HospitalID;  //

        public InEmrFirstPage() { }
         
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 创建人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否提交
		/// </summary>
		public bool IsRealease
		{
			get { return _isRealease;}
			set { _isRealease = value;}
		}                                    
		
		/// <summary>
		/// 提交日期
		/// </summary>
		public DateTime RealeaseTime
		{
			get { return _realeaseTime;}
			set { _realeaseTime = value;}
		}                                    
		
		/// <summary>
		/// 提交人
		/// </summary>
		public string RealeaseOperId
		{
			get { return _realeaseOperId;}
			set { _realeaseOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsAuth
		{
			get { return _isAuth;}
			set { _isAuth = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime AuthOperTime
		{
			get { return _authOperTime;}
			set { _authOperTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否归档
		/// </summary>
		public bool IsClosed
		{
			get { return _isClosed;}
			set { _isClosed = value;}
		}                                    
		
		/// <summary>
		/// 归档日期
		/// </summary>
		public DateTime ClosedTime
		{
			get { return _closedTime;}
			set { _closedTime = value;}
		}                                    
		
		/// <summary>
		/// 归档人
		/// </summary>
		public string ClosedOperId
		{
			get { return _closedOperId;}
			set { _closedOperId = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public int ModifyOperTime
		{
			get { return _modifyOperTime;}
			set { _modifyOperTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string ModifyOperID
		{
			get { return _modifyOperID;}
			set { _modifyOperID = value;}
		}                                    
		
		/// <summary>
		/// 是否上级医生审核
		/// </summary>
		public bool IsCheck
		{
			get { return _isCheck;}
			set { _isCheck = value;}
		}                                    
		
		/// <summary>
		/// 医疗机构
		/// </summary>
		public string HospitalName
		{
			get { return _hospitalName;}
			set { _hospitalName = value;}
		}                                    
		
		/// <summary>
		/// 卫生机构组织代码
		/// </summary>
		public string HospitalCode
		{
			get { return _hospitalCode;}
			set { _hospitalCode = value;}
		}                                    
		
		/// <summary>
		/// 医疗付费方式
		/// </summary>
		public string PayWayName
		{
			get { return _payWayName;}
			set { _payWayName = value;}
		}                                    
		
		/// <summary>
		/// 健康卡号
		/// </summary>
		public string CardNo
		{
			get { return _cardNo;}
			set { _cardNo = value;}
		}                                    
		
		/// <summary>
		/// 第几次住院
		/// </summary>
		public int Ntime
		{
			get { return _ntime;}
			set { _ntime = value;}
		}                                    
		
		/// <summary>
		/// 病案号
		/// </summary>
		public string InPatNo
		{
			get { return _inPatNo;}
			set { _inPatNo = value;}
		}                                    
		
		/// <summary>
		/// inhosinfo.id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
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
		/// 性别
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 出生日期
		/// </summary>
		public DateTime BirthDate
		{
			get { return _birthDate;}
			set { _birthDate = value;}
		}                                    
		
		/// <summary>
		/// 年龄
		/// </summary>
		public string AgeStr
		{
			get { return _ageStr;}
			set { _ageStr = value;}
		}                                    
		
		/// <summary>
		/// 年龄月
		/// </summary>
		public string AgeMonth
		{
			get { return _ageMonth;}
			set { _ageMonth = value;}
		}                                    
		
		/// <summary>
		/// 新生儿出生体重(克)
		/// </summary>
		public double BirthWeight
		{
			get { return _birthWeight;}
			set { _birthWeight = value;}
		}                                    
		
		/// <summary>
		/// 新生儿入院体重(克)
		/// </summary>
		public double Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		/// 国籍
		/// </summary>
		public string Country
		{
			get { return _country;}
			set { _country = value;}
		}                                    
		
		/// <summary>
		/// 出生地
		/// </summary>
		public string AddressBirth
		{
			get { return _addressBirth;}
			set { _addressBirth = value;}
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
		/// 民族
		/// </summary>
		public string NationName
		{
			get { return _nationName;}
			set { _nationName = value;}
		}                                    
		
		/// <summary>
		/// 身份证
		/// </summary>
		public string IdCardNo
		{
			get { return _idCardNo;}
			set { _idCardNo = value;}
		}                                    
		
		/// <summary>
		/// 职业
		/// </summary>
		public string WorkType
		{
			get { return _workType;}
			set { _workType = value;}
		}                                    
		
		/// <summary>
		/// 婚姻状况：1-未婚；2-已婚；3-丧偶；4-离异；9-其他
		/// </summary>
		public int LsMarriage
		{
			get { return _lsMarriage;}
			set { _lsMarriage = value;}
		}                                    
		
		/// <summary>
		/// 现住址
		/// </summary>
		public string NowAddress
		{
			get { return _nowAddress;}
			set { _nowAddress = value;}
		}                                    
		
		/// <summary>
		/// 现住址邮编
		/// </summary>
		public string NowAddressPostCode
		{
			get { return _nowAddressPostCode;}
			set { _nowAddressPostCode = value;}
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
		/// 户口地址邮编
		/// </summary>
		public string ResidencePostCode
		{
			get { return _residencePostCode;}
			set { _residencePostCode = value;}
		}                                    
		
		/// <summary>
		/// 工作单位及地址
		/// </summary>
		public string AddressCompany
		{
			get { return _addressCompany;}
			set { _addressCompany = value;}
		}                                    
		
		/// <summary>
		/// 单位电话
		/// </summary>
		public string PhoneWork
		{
			get { return _phoneWork;}
			set { _phoneWork = value;}
		}                                    
		
		/// <summary>
		/// 单位邮编
		/// </summary>
		public string PostCodeWork
		{
			get { return _postCodeWork;}
			set { _postCodeWork = value;}
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
		public string Relation
		{
			get { return _relation;}
			set { _relation = value;}
		}                                    
		
		/// <summary>
		/// 联系地址
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
		/// 入院途径：1-急诊；2-门诊；3-其他医疗机构转入；9-其他
		/// </summary>
		public int LsInType
		{
			get { return _lsInType;}
			set { _lsInType = value;}
		}                                    
		
		/// <summary>
		/// 入院时间
		/// </summary>
		public DateTime InTime
		{
			get { return _inTime;}
			set { _inTime = value;}
		}                                    
		
		/// <summary>
		/// 入院科室
		/// </summary>
		public string LocInName
		{
			get { return _locInName;}
			set { _locInName = value;}
		}                                    
		
		/// <summary>
		/// 入院科室病房
		/// </summary>
		public string LocInRoom
		{
			get { return _locInRoom;}
			set { _locInRoom = value;}
		}                                    
		
		/// <summary>
		/// 转科科别
		/// </summary>
		public string InOutLocName
		{
			get { return _inOutLocName;}
			set { _inOutLocName = value;}
		}                                    
		
		/// <summary>
		/// 出院时间
		/// </summary>
		public DateTime Outtime
		{
			get { return _outtime;}
			set { _outtime = value;}
		}                                    
		
		/// <summary>
		/// 出院科室
		/// </summary>
		public string LocOutName
		{
			get { return _locOutName;}
			set { _locOutName = value;}
		}                                    
		
		/// <summary>
		/// 出院病房
		/// </summary>
		public string LocOutRoom
		{
			get { return _locOutRoom;}
			set { _locOutRoom = value;}
		}                                    
		
		/// <summary>
		/// 住院天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 门(急)诊诊断
		/// </summary>
		public string IllDescMz
		{
			get { return _illDescMz;}
			set { _illDescMz = value;}
		}                                    
		
		/// <summary>
		/// 门(急)诊诊断编码
		/// </summary>
		public string IllCodeMz
		{
			get { return _illCodeMz;}
			set { _illCodeMz = value;}
		}                                    
		
		/// <summary>
		/// 病例分型:A一般B急C疑难D危重
		/// </summary>
		public string CaseClass
		{
			get { return _caseClass;}
			set { _caseClass = value;}
		}                                    
		
		/// <summary>
		/// 临床路径病例。1是2否
		/// </summary>
		public bool IsDgClass
		{
			get { return _isDgClass;}
			set { _isDgClass = value;}
		}                                    
		
		/// <summary>
		/// 抢救次数
		/// </summary>
		public int RescueTimes
		{
			get { return _rescueTimes;}
			set { _rescueTimes = value;}
		}                                    
		
		/// <summary>
		/// 成功次数
		/// </summary>
		public int SuccessTimes
		{
			get { return _successTimes;}
			set { _successTimes = value;}
		}                                    
		
		/// <summary>
		/// 损伤、中毒的外部原因
		/// </summary>
		public string DamagePoison
		{
			get { return _damagePoison;}
			set { _damagePoison = value;}
		}                                    
		
		/// <summary>
		/// 损伤、中毒疾病编码
		/// </summary>
		public string DamagePoisonIllCode
		{
			get { return _damagePoisonIllCode;}
			set { _damagePoisonIllCode = value;}
		}                                    
		
		/// <summary>
		/// 病理诊断
		/// </summary>
		public string Pathology
		{
			get { return _pathology;}
			set { _pathology = value;}
		}                                    
		
		/// <summary>
		/// 病理号
		/// </summary>
		public string PathologyNo
		{
			get { return _pathologyNo;}
			set { _pathologyNo = value;}
		}                                    
		
		/// <summary>
		/// 病理诊断疾病编码
		/// </summary>
		public string PathologyIllCode
		{
			get { return _pathologyIllCode;}
			set { _pathologyIllCode = value;}
		}                                    
		
		/// <summary>
		/// 是否药物过敏:1无2有
		/// </summary>
		public int LsAllergy
		{
			get { return _lsAllergy;}
			set { _lsAllergy = value;}
		}                                    
		
		/// <summary>
		/// 过敏药物
		/// </summary>
		public string AllergyDrugs
		{
			get { return _allergyDrugs;}
			set { _allergyDrugs = value;}
		}                                    
		
		/// <summary>
		/// 死亡患者尸检1.是2.否
		/// </summary>
		public bool IsAutopsy
		{
			get { return _isAutopsy;}
			set { _isAutopsy = value;}
		}                                    
		
		/// <summary>
		/// 血型1.A2.B3.○4.AB5.不详6.未查
		/// </summary>
		public int LsBloodGroup
		{
			get { return _lsBloodGroup;}
			set { _lsBloodGroup = value;}
		}                                    
		
		/// <summary>
		/// Rh1.阴2.阳3.不详4.未查
		/// </summary>
		public int LsRh
		{
			get { return _lsRh;}
			set { _lsRh = value;}
		}                                    
		
		/// <summary>
		/// 科主任
		/// </summary>
		public string LocDirector
		{
			get { return _locDirector;}
			set { _locDirector = value;}
		}                                    
		
		/// <summary>
		/// 主任（副主任）医师
		/// </summary>
		public string DocDirector
		{
			get { return _docDirector;}
			set { _docDirector = value;}
		}                                    
		
		/// <summary>
		/// 主治医师
		/// </summary>
		public string Maindoctor
		{
			get { return _maindoctor;}
			set { _maindoctor = value;}
		}                                    
		
		/// <summary>
		/// 住院医师
		/// </summary>
		public string ZyDoctor
		{
			get { return _zyDoctor;}
			set { _zyDoctor = value;}
		}                                    
		
		/// <summary>
		/// 责任护士
		/// </summary>
		public string ZrNurse
		{
			get { return _zrNurse;}
			set { _zrNurse = value;}
		}                                    
		
		/// <summary>
		/// 进修医师
		/// </summary>
		public string StudyDoctor
		{
			get { return _studyDoctor;}
			set { _studyDoctor = value;}
		}                                    
		
		/// <summary>
		/// 实习医师
		/// </summary>
		public string SxDoctor
		{
			get { return _sxDoctor;}
			set { _sxDoctor = value;}
		}                                    
		
		/// <summary>
		/// 编码员
		/// </summary>
		public string CodeOper
		{
			get { return _codeOper;}
			set { _codeOper = value;}
		}                                    
		
		/// <summary>
		/// 1.甲2.乙3.丙
		/// </summary>
		public int LsEmrQc
		{
			get { return _lsEmrQc;}
			set { _lsEmrQc = value;}
		}                                    
		
		/// <summary>
		/// 质控医师
		/// </summary>
		public string EmrQcDoctor
		{
			get { return _emrQcDoctor;}
			set { _emrQcDoctor = value;}
		}                                    
		
		/// <summary>
		/// 质控护士
		/// </summary>
		public string EmrQcNurse
		{
			get { return _emrQcNurse;}
			set { _emrQcNurse = value;}
		}                                    
		
		/// <summary>
		/// 质控日期
		/// </summary>
		public DateTime EmrQcDate
		{
			get { return _emrQcDate;}
			set { _emrQcDate = value;}
		}                                    
		
		/// <summary>
		/// 离院方式:1.医嘱离院,2.医嘱转院,拟接收医疗机构名称,3.医嘱转社区卫生服务机构/乡镇卫生院,拟接收医疗机构名称,4.非医嘱离院5.死亡9.其他,
		/// </summary>
		public int LsOutWay
		{
			get { return _lsOutWay;}
			set { _lsOutWay = value;}
		}                                    
		
		/// <summary>
		/// 医嘱转院,拟接收医疗机构名称
		/// </summary>
		public string OutWay2
		{
			get { return _outWay2;}
			set { _outWay2 = value;}
		}                                    
		
		/// <summary>
		/// 医嘱转社区卫生服务机构/乡镇卫生院,拟接收医疗机构名称
		/// </summary>
		public string OutWay3
		{
			get { return _outWay3;}
			set { _outWay3 = value;}
		}                                    
		
		/// <summary>
		/// 是否有出院31天内再住院计划1.无。2.有
		/// </summary>
		public int LsInPlan
		{
			get { return _lsInPlan;}
			set { _lsInPlan = value;}
		}                                    
		
		/// <summary>
		/// 再住院计划目的。
		/// </summary>
		public string InPlanMemo
		{
			get { return _inPlanMemo;}
			set { _inPlanMemo = value;}
		}                                    
		
		/// <summary>
		/// 颅脑损伤患者昏迷时间入院前几天
		/// </summary>
		public int BeforBrainComaDay
		{
			get { return _beforBrainComaDay;}
			set { _beforBrainComaDay = value;}
		}                                    
		
		/// <summary>
		/// 颅脑损伤患者昏迷时间入院前几小时
		/// </summary>
		public int BeforBrainComaHour
		{
			get { return _beforBrainComaHour;}
			set { _beforBrainComaHour = value;}
		}                                    
		
		/// <summary>
		/// -颅脑损伤患者昏迷时间入院前几分钟
		/// </summary>
		public int BeforBrainComaMinute
		{
			get { return _beforBrainComaMinute;}
			set { _beforBrainComaMinute = value;}
		}                                    
		
		/// <summary>
		/// 颅脑损伤患者昏迷时间入院后几天
		/// </summary>
		public int AlterBrainComaDay
		{
			get { return _alterBrainComaDay;}
			set { _alterBrainComaDay = value;}
		}                                    
		
		/// <summary>
		/// 颅脑损伤患者昏迷时间入院后几小时
		/// </summary>
		public int AlterBrainComaHour
		{
			get { return _alterBrainComaHour;}
			set { _alterBrainComaHour = value;}
		}                                    
		
		/// <summary>
		/// 颅脑损伤患者昏迷时间入院后几分钟
		/// </summary>
		public int AlterBrainComaMinute
		{
			get { return _alterBrainComaMinute;}
			set { _alterBrainComaMinute = value;}
		}                                    
		
		/// <summary>
		/// 住院费用（元）：总费用
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 住院费用（元）：自付金额
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


