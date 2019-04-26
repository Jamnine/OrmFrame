// ===================================================================   
// Model  
// ===================================================================   
// File: AdEmr.cs  
//   
// Copyright   
// History:  
// 2016/3/26 12:23:07: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///病历信息 数据库不存在此表
    /// </summary> 
    [Serializable] 
    public partial class AdEmr : BaseModel 
    {
        private string _complaint = String.Empty;
        private string _presentHistory = String.Empty;
        private string _surgeryHistory = String.Empty;
        private string _medicalHistory = String.Empty;
        private string _infectionHistory = String.Empty;
        private string _immunizationHistory = String.Empty;
        private string _otherHistory = String.Empty;
        private string _allErgy = String.Empty;
        private string _tT = String.Empty;
        private string _tP = String.Empty;
        private string _tR = String.Empty;
        private string _tBP = String.Empty;
        private string _diagnosis = String.Empty;
        private string _treatment = String.Empty;
        private string _doctorId;
        private string _operId;
        private DateTime _operTime;
        private string _patID;
        private string _mzRegId;
        private string _locationId;
        private string _specialistId;
        private string _familyHistoryOther = String.Empty;
        private string _usDrugCase;
        private string _abortion;
        private string _menarche;
        private string _physicalCheck;
        private string _wine = String.Empty;
        private string _uterus = String.Empty;
        private string _cervical = String.Empty;
        private bool _rubella;
        private bool _cardiopathy;
        private bool _theFlu;
        private bool _chickenPox;
        private bool _hPV;
        private bool _hypertension;
        private bool _asthma;
        private bool _diabetes;
        private bool _thyroidDisease;
        private bool _thromboticDiseases;
        private bool _marriageStatus;
        private string _bMI = "0";

        public AdEmr()
        {
        }

        /// <summary>
        /// 婚育史
        /// </summary>
        public string Abortion
        {
            get { return _abortion; }
            set
            {
                _abortion = value;
            }
        }


        /// <summary>  
        /// 主诉  
        /// </summary>  
        public string Complaint
        {
            get { return this._complaint; }
            set { this._complaint = value; }
        }

        /// <summary>  
        /// 现病史  
        /// </summary>  
        public string PresentHistory
        {
            get { return this._presentHistory; }
            set { this._presentHistory = value; }
        }

        /// <summary>  
        /// 外科手术史  
        /// </summary>  
        public string SurgeryHistory
        {
            get { return this._surgeryHistory; }
            set { this._surgeryHistory = value; }
        }

        /// <summary>  
        /// 内科疾病史  
        /// </summary>  
        public string MedicalHistory
        {
            get { return this._medicalHistory; }
            set { this._medicalHistory = value; }
        }

        /// <summary>  
        /// 传染病史  
        /// </summary>  
        public string InfectionHistory
        {
            get { return this._infectionHistory; }
            set { this._infectionHistory = value; }
        }

        /// <summary>  
        /// 免疫接种史  
        /// </summary>  
        public string ImmunizationHistory
        {
            get { return this._immunizationHistory; }
            set { this._immunizationHistory = value; }
        }

        /// <summary>  
        ///   既往史
        /// </summary>  
        public string OtherHistory
        {
            get { return this._otherHistory; }
            set { this._otherHistory = value; }
        }

        /// <summary>  
        /// 过敏史  
        /// </summary>  
        public string AllErgy
        {
            get { return this._allErgy; }
            set { this._allErgy = value; }
        }



        /// <summary>  
        /// T  
        /// </summary>  
        public string TT
        {
            get { return this._tT; }
            set { this._tT = value; }
        }

        /// <summary>  
        /// P  
        /// </summary>  
        public string TP
        {
            get { return this._tP; }
            set { this._tP = value; }
        }

        /// <summary>  
        /// R  
        /// </summary>  
        public string TR
        {
            get { return this._tR; }
            set { this._tR = value; }
        }

        /// <summary>  
        /// BP  
        /// </summary>  
        public string TBP
        {
            get { return this._tBP; }
            set { this._tBP = value; }
        }


        /// <summary>  
        ///   诊断
        /// </summary>  
        public string Diagnosis
        {
            get { return this._diagnosis; }
            set { this._diagnosis = value; }
        }

        /// <summary>  
        /// 治疗建议  
        /// </summary>  
        public string Treatment
        {
            get { return this._treatment; }
            set { this._treatment = value; }
        }

        /// <summary>  
        ///   医生id
        /// </summary>  
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        /// <summary>  
        ///  操作人
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        ///   操作时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 病人id
        /// </summary>  
        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }

        /// <summary>  
        /// 就诊id
        /// </summary>  
        public string MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }

        /// <summary>  
        /// 门诊机构id
        /// </summary>  
        public string LocationId
        {
            get { return this._locationId; }
            set { this._locationId = value; }
        }

        /// <summary>  
        ///   其他家族病史
        /// </summary>  
        public string FamilyHistoryOther

        {
            get { return this._familyHistoryOther; }
            set { this._familyHistoryOther = value; }
        }


        /// <summary>
        /// 使用抗生素与其他药物的情况
        /// </summary>
        public string UsDrugCase
        {
            get
            {
                return _usDrugCase;
            }

            set
            {
                _usDrugCase = value;
            }
        }
        /// <summary>
        /// 个人史
        /// </summary>
        public string Menarche
        {
            get
            {
                return _menarche;
            }

            set
            {
                _menarche = value;
            }
        }
        /// <summary>
        /// 体格检查
        /// </summary>
        public string PhysicalCheck
        {
            get
            {
                return _physicalCheck;
            }

            set
            {
                _physicalCheck = value;
            }
        }

        /// <summary>  
        /// 酒  
        /// </summary>  
        public string Wine
        {
            get { return this._wine; }
            set { this._wine = value; }
        }

        /// <summary>  
        ///   子宫
        /// </summary>  
        public string Uterus
        {
            get { return this._uterus; }
            set { this._uterus = value; }
        }

        /// <summary>  
        /// 宫颈  
        /// </summary>  
        public string Cervical
        {
            get { return this._cervical; }
            set { this._cervical = value; }
        }

        /// <summary>
        /// 心脏病
        /// </summary>
        public bool Cardiopathy
        {
            get { return this._cardiopathy; }
            set { this._cardiopathy = value; }
        }

        /// <summary>
        /// 流感
        /// </summary>
        public bool TheFlu
        {
            get { return this._theFlu; }
            set { this._theFlu = value; }
        }

        /// <summary>
        /// 水痘
        /// </summary>
        public bool ChickenPox
        {
            get { return this._chickenPox; }
            set { this._chickenPox = value; }
        }

        /// <summary>
        /// 风疹
        /// </summary>
        public bool Rubella
        {
            get { return this._rubella; }
            set { this._rubella = value; }
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
        /// 高血压
        /// </summary>
        public bool Hypertension
        {
            get { return this._hypertension; }
            set { this._hypertension = value; }
        }

        /// <summary>
        /// 哮喘
        /// </summary>
        public bool Asthma
        {
            get { return this._asthma; }
            set { this._asthma = value; }
        }

        /// <summary>
        /// 糖尿病
        /// </summary>
        public bool Diabetes
        {
            get { return this._diabetes; }
            set { this._diabetes = value; }
        }

        /// <summary>
        /// 甲状腺疾病
        /// </summary>
        public bool ThyroidDisease
        {
            get { return this._thyroidDisease; }
            set { this._thyroidDisease = value; }
        }

        /// <summary>
        /// 血栓性疾病
        /// </summary>
        public bool ThromboticDiseases
        {
            get { return this._thromboticDiseases; }
            set { this._thromboticDiseases = value; }
        }

        /// <summary>  
        /// 婚姻情况  
        /// </summary>  
        public bool MarriageStatus
        {
            get { return this._marriageStatus; }
            set { this._marriageStatus = value; }
        }

        /// <summary>  
        /// BMI  
        /// </summary>  
        public string BMI
        {
            get { return this._bMI; }
            set { this._bMI = value; }
        }
        /// <summary>  
        /// 云端专家ID
        /// </summary>  
        public string SpecialistId
        {
            get { return this._specialistId; }
            set { this._specialistId = value; }
        }

        

        #region 爱宝贝
        private string _wHR = String.Empty;
        private int _waist;
        private int _abdominal;
        private DateTime _menarcheTime;
        private string _throughDay = String.Empty;
        private bool _isDysmenorrhea;
        private bool _isDyspareunia;
        private bool _isSeparation;
        private bool _isContraception;
        private string _contraceptionWay = String.Empty;
        private string _sexUalFrequency = String.Empty;
        private string _g = "0";
        private string _p = "0";
        private string _miscarriage = "0";
        private string _inDuced = "0";
        private string _naturalBirth = "0";
        private string _cesareanSection = "0";
        private string _curettAge = String.Empty;
        private string _ecTopicPregnancy = "0";
        private string _isChildBirthCp = "0";
        private string _biocheMicalpregnancy = "0";
        private string _smoke = String.Empty;
        private string _pet = String.Empty;
        private string _cardIopulMonary = "/";
        private string _thyroid = "/";
        private string _liveRandKidney = "/";
        private string _breasts = "/";
        private string _hair = "/";
        private string _vulva = "已婚式,未见明显异常";
        private string _vagina = "畅,未及明显包块";
        private string _attachment = "未及明显包块及压痛";
        private string _leucorrHeaAnalysis = String.Empty;
        private string _uS = String.Empty;
        private string _intervalTime = String.Empty;

        /// <summary>  
        /// WHR  
        /// </summary>  
        public string WHR
        {
            get { return this._wHR; }
            set { this._wHR = value; }
        }

        /// <summary>  
        /// 腰围  
        /// </summary>  
        public int Waist
        {
            get { return this._waist; }
            set { this._waist = value; }
        }

        /// <summary>  
        /// 腹围  
        /// </summary>  
        public int Abdominal
        {
            get { return this._abdominal; }
            set { this._abdominal = value; }
        }

        /// <summary>  
        /// 初潮日期 
        /// </summary>  
        public DateTime MenarcheTime
        {
            get { return this._menarcheTime == DateTime.MinValue ? DateTime.Now : this._menarcheTime; }
            set { this._menarcheTime = value; }
        }


        /// <summary>  
        /// 间隔时间  
        /// </summary>  
        public string IntervalTime
        {
            get { return this._intervalTime; }
            set { this._intervalTime = value; }
        }

        /// <summary>  
        /// 行经天数  
        /// </summary>  
        public string ThroughDay
        {
            get { return this._throughDay; }
            set { this._throughDay = value; }
        }

        /// <summary>  
        /// 是否痛经  
        /// </summary>  
        public bool IsDysmenorrhea
        {
            get { return this._isDysmenorrhea; }
            set { this._isDysmenorrhea = value; }
        }

        /// <summary>  
        /// 是否性交痛  
        /// </summary>  
        public bool IsDyspareunia
        {
            get { return this._isDyspareunia; }
            set { this._isDyspareunia = value; }
        }


        /// <summary>  
        /// 是否分居  
        /// </summary>  
        public bool IsSeparation
        {
            get { return this._isSeparation; }
            set { this._isSeparation = value; }
        }

        /// <summary>  
        /// 是否避孕  
        /// </summary>  
        public bool IsContraception
        {
            get { return this._isContraception; }
            set { this._isContraception = value; }
        }

        /// <summary>  
        /// 避孕方式  
        /// </summary>  
        public string ContraceptionWay
        {
            get { return this._contraceptionWay; }
            set { this._contraceptionWay = value; }
        }

        /// <summary>  
        /// 性生活频次  
        /// </summary>  
        public string SexUalFrequency
        {
            get { return this._sexUalFrequency; }
            set { this._sexUalFrequency = value; }
        }

        /// <summary>  
        /// G(怀孕次数)
        /// </summary>  
        public string G
        {
            get { return this._g; }
            set { this._g = value; }
        }

        /// <summary>  
        /// P(生育次数)
        /// </summary>  
        public string P
        {
            get { return this._p; }
            set { this._p = value; }
        }


        /// <summary>  
        /// 自然流产  
        /// </summary>  
        public string Miscarriage
        {
            get { return this._miscarriage; }
            set { this._miscarriage = value; }
        }

        /// <summary>  
        /// 引产  
        /// </summary>  
        public string InDuced
        {
            get { return this._inDuced; }
            set { this._inDuced = value; }
        }

        /// <summary>  
        /// 顺产  
        /// </summary>  
        public string NaturalBirth
        {
            get { return this._naturalBirth; }
            set { this._naturalBirth = value; }
        }

        /// <summary>  
        /// 剖宫产  
        /// </summary>  
        public string CesareanSection
        {
            get { return this._cesareanSection; }
            set { this._cesareanSection = value; }
        }

        /// <summary>  
        /// 刮宫  
        /// </summary>  
        public string CurettAge
        {
            get { return this._curettAge; }
            set { this._curettAge = value; }
        }

        /// <summary>  
        /// 异位妊娠  
        /// </summary>  
        public string EcTopicPregnancy
        {
            get { return this._ecTopicPregnancy; }
            set { this._ecTopicPregnancy = value; }
        }

        /// <summary>  
        /// 分娩并发症  
        /// </summary>  
        public string IsChildBirthCp
        {
            get { return this._isChildBirthCp; }
            set { this._isChildBirthCp = value; }
        }

        /// <summary>  
        /// 生化妊娠  
        /// </summary>  
        public string BiocheMicalpregnancy
        {
            get { return this._biocheMicalpregnancy; }
            set { this._biocheMicalpregnancy = value; }
        }
        /// <summary>  
        /// 烟  
        /// </summary>  
        public string Smoke
        {
            get { return this._smoke; }
            set { this._smoke = value; }
        }


        /// <summary>  
        /// 喂养宠物  
        /// </summary>  
        public string Pet
        {
            get { return this._pet; }
            set { this._pet = value; }
        }

        /// <summary>  
        /// 心肺  
        /// </summary>  
        public string CardIopulMonary
        {
            get { return this._cardIopulMonary; }
            set { this._cardIopulMonary = value; }
        }

        /// <summary>  
        /// 甲状腺  
        /// </summary>  
        public string Thyroid
        {
            get { return this._thyroid; }
            set { this._thyroid = value; }
        }

        /// <summary>  
        /// 肝肾  
        /// </summary>  
        public string LiveRandKidney
        {
            get { return this._liveRandKidney; }
            set { this._liveRandKidney = value; }
        }

        /// <summary>  
        /// 双乳  
        /// </summary>  
        public string Breasts
        {
            get { return this._breasts; }
            set { this._breasts = value; }
        }

        /// <summary>  
        /// 毛发  
        /// </summary>  
        public string Hair
        {
            get { return this._hair; }
            set { this._hair = value; }
        }

        /// <summary>  
        ///   外阴
        /// </summary>  
        public string Vulva
        {
            get { return this._vulva; }
            set { this._vulva = value; }
        }

        /// <summary>  
        ///   阴道
        /// </summary>  
        public string Vagina
        {
            get { return this._vagina; }
            set { this._vagina = value; }
        }

        /// <summary>  
        ///   附件
        /// </summary>  
        public string Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        /// <summary>  
        /// 白带分析  
        /// </summary>  
        public string LeucorrHeaAnalysis
        {
            get { return this._leucorrHeaAnalysis; }
            set { this._leucorrHeaAnalysis = value; }
        }

        /// <summary>  
        /// 妇科彩超  
        /// </summary>  
        public string US
        {
            get { return this._uS; }
            set { this._uS = value; }
        }
        #endregion

    }
}

