

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊病人病历 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuClinicFirst:BaseModel
	{ 
		private string _mzRegId;  //门诊流水号
		
		private string _mainInform;  //主诉（社区：主观资料）
		
		private string _sickHist;  //现病史（社区：问题评估）
		
		private double _examT;  //体温
		
		private double _examP;  //
		
		private double _examR;  //
		
		private double _examBp;  //
		
		private double _examBp2;  //
		
		private string _checkUp;  //体格检查
		
		private string _checkCT;  //辅助检查
		
		private string _disposal;  //处理及建议
		
		private string _impression;  //望诊印象
		
		private string _analys;  //治疗原则
		
		private string _others;  //其他
		
		private string _tongue;  //舌象
		
		private string _pulse;  //脉象
		
		private string _moss;  //苔象
		
		private byte[] _xMLCancer;  //
		
		private byte[] _xMLSex;  //
		
		private byte[] _xMLTuberculosis;  //
		
		private byte[] _xMLContagion;  //
		
		private double _examSugar;  //血糖
		
		private string _firstDate;  //发病日期
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _thromboticDiseases;  //血栓性疾病
		
		private string _throughDay;  //行经天数
		
		private string _diagnosis;  //诊断
		
		private string _allErgy;  //过敏史
		
		private string _contraceptionWay;  //避孕方式
		
		private string _wine;  //酒
		
		private string _intervalTime;  //间隔时间
		
		private string _vagina;  //阴道
		
		private string _attachment;  //附件
		
		private string _naturalBirth;  //顺产
		
		private bool _rubella;  //风疹
		
		private bool _hypertension;  //高血压
		
		private string _usDrugCase;  //
		
		private string _physicalCheck;  //
		
		private string _specialistID;  //云端专家ID
		
		private string _abortion;  //人工流产
		
		private string _infectionHistory;  //传染病史
		
		private string _immunizationHistory;  //免疫接种史
		
		private string _familyHistoryOther;  //其他家族病史
		
		private string _otherHistory;  //其他病史
		
		private string _medicalHistory;  //内科疾病史
		
		private string _isChildBirthCp;  //分娩并发症
		
		private string _operId;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private DateTime _menarcheTime;  //初潮时间
		
		private string _menarche;  //初潮
		
		private string _curettAge;  //刮宫
		
		private string _cesareanSection;  //剖宫产
		
		private string _doctorID;  //医生id
		
		private string _breasts;  //双乳
		
		private bool _asthma;  //哮喘
		
		private string _pet;  //喂养宠物
		
		private string _surgeryHistory;  //外科手术史
		
		private string _vulva;  //外阴
		
		private string _us;  //妇科彩超
		
		private bool _marriageStatus;  //婚姻情况
		
		private string _uterus;  //子宫
		
		private string _patID;  //客人id
		
		private string _cervical;  //宫颈
		
		private string _ecTopicPregnancy;  //异位妊娠
		
		private string _inDuced;  //引产
		
		private string _cardIopulMonary;  //心肺
		
		private bool _cardiopathy;  //心脏病
		
		private string _sexUalFrequency;  //性生活频次
		
		private bool _isSeparation;  //是否分居
		
		private bool _isDyspareunia;  //是否性交痛
		
		private bool _isDysmenorrhea;  //是否痛经
		
		private bool _isContraception;  //是否避孕
		
		private string _hair;  //毛发
		
		private bool _chickenPox;  //水痘
		
		private string _treatment;  //治疗建议
		
		private bool _theFlu;  //流感
		
		private string _smoke;  //烟
		
		private string _biocheMicalpregnancy;  //生化妊娠
		
		private string _thyroid;  //甲状腺
		
		private bool _thyroidDisease;  //甲状腺疾病
		
		private string _leucorrHeaAnalysis;  //白带分析
		
		private bool _diabetes;  //糖尿病
		
		private string _liveRandKidney;  //肝肾
		
		private int _waist;  //腰围
		
		private int _abdominal;  //腹围
		
		private string _miscarriage;  //自然流产
		
		private int _HospitalID;  //

        private string _bMI = "0";

        private bool _hPV;
         
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}

        /// <summary>
        /// 主诉（社区：主观资料）Complaint MainInform
        /// </summary>
        public string MainInform
        {
			get { return _mainInform;}
			set { _mainInform = value;}
		}

        /// <summary>
        /// 现病史（社区：问题评估）PresentHistory SickHist
        /// </summary>
        public string SickHist
        {
			get { return _sickHist;}
			set { _sickHist = value;}
		}                                    
		
		/// <summary>
		/// 体温
		/// </summary>
		public double ExamT
		{
			get { return _examT;}
			set { _examT = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamP
		{
			get { return _examP;}
			set { _examP = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamR
		{
			get { return _examR;}
			set { _examR = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamBp
		{
			get { return _examBp;}
			set { _examBp = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double ExamBp2
		{
			get { return _examBp2;}
			set { _examBp2 = value;}
		}                                    
		
		/// <summary>
		/// 体格检查
		/// </summary>
		public string CheckUp
		{
			get { return _checkUp;}
			set { _checkUp = value;}
		}                                    
		
		/// <summary>
		/// 辅助检查
		/// </summary>
		public string CheckCT
		{
			get { return _checkCT;}
			set { _checkCT = value;}
		}                                    
		
		/// <summary>
		/// 处理及建议
		/// </summary>
		public string Disposal
		{
			get { return _disposal;}
			set { _disposal = value;}
		}                                    
		
		/// <summary>
		/// 望诊印象
		/// </summary>
		public string Impression
		{
			get { return _impression;}
			set { _impression = value;}
		}                                    
		
		/// <summary>
		/// 治疗原则
		/// </summary>
		public string Analys
		{
			get { return _analys;}
			set { _analys = value;}
		}                                    
		
		/// <summary>
		/// 其他
		/// </summary>
		public string Others
		{
			get { return _others;}
			set { _others = value;}
		}                                    
		
		/// <summary>
		/// 舌象
		/// </summary>
		public string Tongue
		{
			get { return _tongue;}
			set { _tongue = value;}
		}                                    
		
		/// <summary>
		/// 脉象
		/// </summary>
		public string Pulse
		{
			get { return _pulse;}
			set { _pulse = value;}
		}                                    
		
		/// <summary>
		/// 苔象
		/// </summary>
		public string Moss
		{
			get { return _moss;}
			set { _moss = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] XMLCancer
		{
			get { return _xMLCancer;}
			set { _xMLCancer = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] XMLSex
		{
			get { return _xMLSex;}
			set { _xMLSex = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] XMLTuberculosis
		{
			get { return _xMLTuberculosis;}
			set { _xMLTuberculosis = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] XMLContagion
		{
			get { return _xMLContagion;}
			set { _xMLContagion = value;}
		}                                    
		
		/// <summary>
		/// 血糖
		/// </summary>
		public double ExamSugar
		{
			get { return _examSugar;}
			set { _examSugar = value;}
		}                                    
		
		/// <summary>
		/// 发病日期
		/// </summary>
		public string FirstDate
		{
			get { return _firstDate;}
			set { _firstDate = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 血栓性疾病
		/// </summary>
		public bool ThromboticDiseases
		{
			get { return _thromboticDiseases;}
			set { _thromboticDiseases = value;}
		}                                    
		
		/// <summary>
		/// 行经天数
		/// </summary>
		public string ThroughDay
		{
			get { return _throughDay;}
			set { _throughDay = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string Diagnosis
		{
			get { return _diagnosis;}
			set { _diagnosis = value;}
		}                                    
		
		/// <summary>
		/// 过敏史
		/// </summary>
		public string AllErgy
		{
			get { return _allErgy;}
			set { _allErgy = value;}
		}                                    
		
		/// <summary>
		/// 避孕方式
		/// </summary>
		public string ContraceptionWay
		{
			get { return _contraceptionWay;}
			set { _contraceptionWay = value;}
		}                                    
		
		/// <summary>
		/// 酒
		/// </summary>
		public string Wine
		{
			get { return _wine;}
			set { _wine = value;}
		}                                    
		
		/// <summary>
		/// 间隔时间
		/// </summary>
		public string IntervalTime
		{
			get { return _intervalTime;}
			set { _intervalTime = value;}
		}                                    
		
		/// <summary>
		/// 阴道
		/// </summary>
		public string Vagina
		{
			get { return _vagina;}
			set { _vagina = value;}
		}                                    
		
		/// <summary>
		/// 附件
		/// </summary>
		public string Attachment
		{
			get { return _attachment;}
			set { _attachment = value;}
		}                                    
		
		/// <summary>
		/// 顺产
		/// </summary>
		public string NaturalBirth
		{
			get { return _naturalBirth;}
			set { _naturalBirth = value;}
		}                                    
		
		/// <summary>
		/// 风疹
		/// </summary>
		public bool Rubella
		{
			get { return _rubella;}
			set { _rubella = value;}
		}                                    
		
		/// <summary>
		/// 高血压
		/// </summary>
		public bool Hypertension
		{
			get { return _hypertension;}
			set { _hypertension = value;}
		}

        /// <summary>
        /// 使用其他药物情况
        /// </summary>
        public string UsDrugCase
		{
			get { return _usDrugCase;}
			set { _usDrugCase = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string PhysicalCheck
		{
			get { return _physicalCheck;}
			set { _physicalCheck = value;}
		}                                    
		
		/// <summary>
		/// 云端专家ID
		/// </summary>
		public string SpecialistID
		{
			get { return _specialistID;}
			set { _specialistID = value;}
		}                                    
		
		/// <summary>
		/// 人工流产
		/// </summary>
		public string Abortion
		{
			get { return _abortion;}
			set { _abortion = value;}
		}                                    
		
		/// <summary>
		/// 传染病史
		/// </summary>
		public string InfectionHistory
		{
			get { return _infectionHistory;}
			set { _infectionHistory = value;}
		}                                    
		
		/// <summary>
		/// 免疫接种史
		/// </summary>
		public string ImmunizationHistory
		{
			get { return _immunizationHistory;}
			set { _immunizationHistory = value;}
		}                                    
		
		/// <summary>
		/// 其他家族病史
		/// </summary>
		public string FamilyHistoryOther
		{
			get { return _familyHistoryOther;}
			set { _familyHistoryOther = value;}
		}                                    
		
		/// <summary>
		/// 其他病史
		/// </summary>
		public string OtherHistory
		{
			get { return _otherHistory;}
			set { _otherHistory = value;}
		}                                    
		
		/// <summary>
		/// 内科疾病史
		/// </summary>
		public string MedicalHistory
		{
			get { return _medicalHistory;}
			set { _medicalHistory = value;}
		}                                    
		
		/// <summary>
		/// 分娩并发症
		/// </summary>
		public string IsChildBirthCp
		{
			get { return _isChildBirthCp;}
			set { _isChildBirthCp = value;}
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
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 初潮时间
		/// </summary>
		public DateTime MenarcheTime
		{
			get { return _menarcheTime;}
			set { _menarcheTime = value;}
		}                                    
		
		/// <summary>
		/// 初潮
		/// </summary>
		public string Menarche
		{
			get { return _menarche;}
			set { _menarche = value;}
		}                                    
		
		/// <summary>
		/// 刮宫
		/// </summary>
		public string CurettAge
		{
			get { return _curettAge;}
			set { _curettAge = value;}
		}                                    
		
		/// <summary>
		/// 剖宫产
		/// </summary>
		public string CesareanSection
		{
			get { return _cesareanSection;}
			set { _cesareanSection = value;}
		}                                    
		
		/// <summary>
		/// 医生id
		/// </summary>
		public string DoctorID
		{
			get { return _doctorID;}
			set { _doctorID = value;}
		}                                    
		
		/// <summary>
		/// 双乳
		/// </summary>
		public string Breasts
		{
			get { return _breasts;}
			set { _breasts = value;}
		}                                    
		
		/// <summary>
		/// 哮喘
		/// </summary>
		public bool Asthma
		{
			get { return _asthma;}
			set { _asthma = value;}
		}                                    
		
		/// <summary>
		/// 喂养宠物
		/// </summary>
		public string Pet
		{
			get { return _pet;}
			set { _pet = value;}
		}                                    
		
		/// <summary>
		/// 外科手术史
		/// </summary>
		public string SurgeryHistory
		{
			get { return _surgeryHistory;}
			set { _surgeryHistory = value;}
		}                                    
		
		/// <summary>
		/// 外阴
		/// </summary>
		public string Vulva
		{
			get { return _vulva;}
			set { _vulva = value;}
		}                                    
		
		/// <summary>
		/// 妇科彩超
		/// </summary>
		public string Us
		{
			get { return _us;}
			set { _us = value;}
		}                                    
		
		/// <summary>
		/// 婚姻情况
		/// </summary>
		public bool MarriageStatus
		{
			get { return _marriageStatus;}
			set { _marriageStatus = value;}
		}                                    
		
		/// <summary>
		/// 子宫
		/// </summary>
		public string Uterus
		{
			get { return _uterus;}
			set { _uterus = value;}
		}                                    
		
		/// <summary>
		/// 客人id
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 宫颈
		/// </summary>
		public string Cervical
		{
			get { return _cervical;}
			set { _cervical = value;}
		}                                    
		
		/// <summary>
		/// 异位妊娠
		/// </summary>
		public string EcTopicPregnancy
		{
			get { return _ecTopicPregnancy;}
			set { _ecTopicPregnancy = value;}
		}                                    
		
		/// <summary>
		/// 引产
		/// </summary>
		public string InDuced
		{
			get { return _inDuced;}
			set { _inDuced = value;}
		}                                    
		
		/// <summary>
		/// 心肺
		/// </summary>
		public string CardIopulMonary
		{
			get { return _cardIopulMonary;}
			set { _cardIopulMonary = value;}
		}                                    
		
		/// <summary>
		/// 心脏病
		/// </summary>
		public bool Cardiopathy
		{
			get { return _cardiopathy;}
			set { _cardiopathy = value;}
		}                                    
		
		/// <summary>
		/// 性生活频次
		/// </summary>
		public string SexUalFrequency
		{
			get { return _sexUalFrequency;}
			set { _sexUalFrequency = value;}
		}                                    
		
		/// <summary>
		/// 是否分居
		/// </summary>
		public bool IsSeparation
		{
			get { return _isSeparation;}
			set { _isSeparation = value;}
		}                                    
		
		/// <summary>
		/// 是否性交痛
		/// </summary>
		public bool IsDyspareunia
		{
			get { return _isDyspareunia;}
			set { _isDyspareunia = value;}
		}                                    
		
		/// <summary>
		/// 是否痛经
		/// </summary>
		public bool IsDysmenorrhea
		{
			get { return _isDysmenorrhea;}
			set { _isDysmenorrhea = value;}
		}                                    
		
		/// <summary>
		/// 是否避孕
		/// </summary>
		public bool IsContraception
		{
			get { return _isContraception;}
			set { _isContraception = value;}
		}                                    
		
		/// <summary>
		/// 毛发
		/// </summary>
		public string Hair
		{
			get { return _hair;}
			set { _hair = value;}
		}                                    
		
		/// <summary>
		/// 水痘
		/// </summary>
		public bool ChickenPox
		{
			get { return _chickenPox;}
			set { _chickenPox = value;}
		}                                    
		
		/// <summary>
		/// 治疗建议
		/// </summary>
		public string Treatment
		{
			get { return _treatment;}
			set { _treatment = value;}
		}                                    
		
		/// <summary>
		/// 流感
		/// </summary>
		public bool TheFlu
		{
			get { return _theFlu;}
			set { _theFlu = value;}
		}                                    
		
		/// <summary>
		/// 烟
		/// </summary>
		public string Smoke
		{
			get { return _smoke;}
			set { _smoke = value;}
		}                                    
		
		/// <summary>
		/// 生化妊娠
		/// </summary>
		public string BiocheMicalpregnancy
		{
			get { return _biocheMicalpregnancy;}
			set { _biocheMicalpregnancy = value;}
		}                                    
		
		/// <summary>
		/// 甲状腺
		/// </summary>
		public string Thyroid
		{
			get { return _thyroid;}
			set { _thyroid = value;}
		}                                    
		
		/// <summary>
		/// 甲状腺疾病
		/// </summary>
		public bool ThyroidDisease
		{
			get { return _thyroidDisease;}
			set { _thyroidDisease = value;}
		}                                    
		
		/// <summary>
		/// 白带分析
		/// </summary>
		public string LeucorrHeaAnalysis
		{
			get { return _leucorrHeaAnalysis;}
			set { _leucorrHeaAnalysis = value;}
		}                                    
		
		/// <summary>
		/// 糖尿病
		/// </summary>
		public bool Diabetes
		{
			get { return _diabetes;}
			set { _diabetes = value;}
		}                                    
		
		/// <summary>
		/// 肝肾
		/// </summary>
		public string LiveRandKidney
		{
			get { return _liveRandKidney;}
			set { _liveRandKidney = value;}
		}                                    
		
		/// <summary>
		/// 腰围
		/// </summary>
		public int Waist
		{
			get { return _waist;}
			set { _waist = value;}
		}                                    
		
		/// <summary>
		/// 腹围
		/// </summary>
		public int Abdominal
		{
			get { return _abdominal;}
			set { _abdominal = value;}
		}                                    
		
		/// <summary>
		/// 自然流产
		/// </summary>
		public string Miscarriage
		{
			get { return _miscarriage;}
			set { _miscarriage = value;}
		}                                    
		

        /// <summary>
        /// HPV
        /// </summary>
        public bool HPV
        {
            get { return this._hPV; }
            set { this._hPV = value; }
        }


        /// <summary>  
        /// BMI  
        /// </summary>  
        public string BMI
        {
            get { return this._bMI; }
            set { this._bMI = value; }
        }

        public string  LocationId { get; set; }
    }
}           


