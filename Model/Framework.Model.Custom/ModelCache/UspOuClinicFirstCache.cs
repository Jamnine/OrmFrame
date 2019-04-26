using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspOuClinicFirstCache
        :BaseModel
    {
        
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId
        {
            get;
            set;
        }

        /// <summary>
        /// 主诉（社区：主观资料）Complaint MainInform
        /// </summary>
        public string MainInform
        {
            get;
            set;
        }

        /// <summary>
        /// 现病史（社区：问题评估）PresentHistory SickHist
        /// </summary>
        public string SickHist
        {
            get;
            set;
        }

        /// <summary>
        /// 体温
        /// </summary>
        public double ExamT
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double ExamP
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double ExamR
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double ExamBp
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double ExamBp2
        {
            get;
            set;
        }

        /// <summary>
        /// 体格检查
        /// </summary>
        public string CheckUp
        {
            get;
            set;
        }

        /// <summary>
        /// 辅助检查
        /// </summary>
        public string CheckCT
        {
            get;
            set;
        }

        /// <summary>
        /// 处理及建议
        /// </summary>
        public string Disposal
        {
            get;
            set;
        }

        /// <summary>
        /// 望诊印象
        /// </summary>
        public string Impression
        {
            get;
            set;
        }

        /// <summary>
        /// 治疗原则
        /// </summary>
        public string Analys
        {
            get;
            set;
        }

        /// <summary>
        /// 其他
        /// </summary>
        public string Others
        {
            get;
            set;
        }

        /// <summary>
        /// 舌象
        /// </summary>
        public string Tongue
        {
            get;
            set;
        }

        /// <summary>
        /// 脉象
        /// </summary>
        public string Pulse
        {
            get;
            set;
        }

        /// <summary>
        /// 苔象
        /// </summary>
        public string Moss
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] XMLCancer
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] XMLSex
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] XMLTuberculosis
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] XMLContagion
        {
            get;
            set;
        }

        /// <summary>
        /// 血糖
        /// </summary>
        public double ExamSugar
        {
            get;
            set;
        }

        /// <summary>
        /// 发病日期
        /// </summary>
        public string FirstDate
        {
            get;
            set;
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get;
            set;
        }

        /// <summary>
        /// 血栓性疾病
        /// </summary>
        public bool ThromboticDiseases
        {
            get;
            set;
        }

        /// <summary>
        /// 行经天数
        /// </summary>
        public string ThroughDay
        {
            get;
            set;
        }

        /// <summary>
        /// 诊断
        /// </summary>
        public string Diagnosis
        {
            get;
            set;
        }

        /// <summary>
        /// 过敏史
        /// </summary>
        public string AllErgy
        {
            get;
            set;
        }

        /// <summary>
        /// 避孕方式
        /// </summary>
        public string ContraceptionWay
        {
            get;
            set;
        }

        /// <summary>
        /// 酒
        /// </summary>
        public string Wine
        {
            get;
            set;
        }

        /// <summary>
        /// 间隔时间
        /// </summary>
        public string IntervalTime
        {
            get;
            set;
        }

        /// <summary>
        /// 阴道
        /// </summary>
        public string Vagina
        {
            get;
            set;
        }

        /// <summary>
        /// 附件
        /// </summary>
        public string Attachment
        {
            get;
            set;
        }

        /// <summary>
        /// 顺产
        /// </summary>
        public string NaturalBirth
        {
            get;
            set;
        }

        /// <summary>
        /// 风疹
        /// </summary>
        public bool Rubella
        {
            get;
            set;
        }

        /// <summary>
        /// 高血压
        /// </summary>
        public bool Hypertension
        {
            get;
            set;
        }

        /// <summary>
        /// 使用其他药物情况
        /// </summary>
        public string UsDrugCase
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PhysicalCheck
        {
            get;
            set;
        }

        /// <summary>
        /// 云端专家ID
        /// </summary>
        public string SpecialistID
        {
            get;
            set;
        }

        /// <summary>
        /// 人工流产
        /// </summary>
        public string Abortion
        {
            get;
            set;
        }

        /// <summary>
        /// 传染病史
        /// </summary>
        public string InfectionHistory
        {
            get;
            set;
        }

        /// <summary>
        /// 免疫接种史
        /// </summary>
        public string ImmunizationHistory
        {
            get;
            set;
        }

        /// <summary>
        /// 其他家族病史
        /// </summary>
        public string FamilyHistoryOther
        {
            get;
            set;
        }

        /// <summary>
        /// 其他病史
        /// </summary>
        public string OtherHistory
        {
            get;
            set;
        }

        /// <summary>
        /// 内科疾病史
        /// </summary>
        public string MedicalHistory
        {
            get;
            set;
        }

        /// <summary>
        /// 分娩并发症
        /// </summary>
        public string IsChildBirthCp
        {
            get;
            set;
        }

        /// <summary>
        /// 创建人
        /// </summary>
        public string OperId
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 初潮时间
        /// </summary>
        public DateTime MenarcheTime
        {
            get;
            set;
        }

        /// <summary>
        /// 初潮
        /// </summary>
        public string Menarche
        {
            get;
            set;
        }

        /// <summary>
        /// 刮宫
        /// </summary>
        public string CurettAge
        {
            get;
            set;
        }

        /// <summary>
        /// 剖宫产
        /// </summary>
        public string CesareanSection
        {
            get;
            set;
        }

        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorID
        {
            get;
            set;
        }

        /// <summary>
        /// 双乳
        /// </summary>
        public string Breasts
        {
            get;
            set;
        }

        /// <summary>
        /// 哮喘
        /// </summary>
        public bool Asthma
        {
            get;
            set;
        }

        /// <summary>
        /// 喂养宠物
        /// </summary>
        public string Pet
        {
            get;
            set;
        }

        /// <summary>
        /// 外科手术史
        /// </summary>
        public string SurgeryHistory
        {
            get;
            set;
        }

        /// <summary>
        /// 外阴
        /// </summary>
        public string Vulva
        {
            get;
            set;
        }

        /// <summary>
        /// 妇科彩超
        /// </summary>
        public string Us
        {
            get;
            set;
        }

        /// <summary>
        /// 婚姻情况
        /// </summary>
        public bool MarriageStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 子宫
        /// </summary>
        public string Uterus
        {
            get;
            set;
        }

        /// <summary>
        /// 客人id
        /// </summary>
        public string PatID
        {
            get;
            set;
        }

        /// <summary>
        /// 宫颈
        /// </summary>
        public string Cervical
        {
            get;
            set;
        }

        /// <summary>
        /// 异位妊娠
        /// </summary>
        public string EcTopicPregnancy
        {
            get;
            set;
        }

        /// <summary>
        /// 引产
        /// </summary>
        public string InDuced
        {
            get;
            set;
        }

        /// <summary>
        /// 心肺
        /// </summary>
        public string CardIopulMonary
        {
            get;
            set;
        }

        /// <summary>
        /// 心脏病
        /// </summary>
        public bool Cardiopathy
        {
            get;
            set;
        }

        /// <summary>
        /// 性生活频次
        /// </summary>
        public string SexUalFrequency
        {
            get;
            set;
        }

        /// <summary>
        /// 是否分居
        /// </summary>
        public bool IsSeparation
        {
            get;
            set;
        }

        /// <summary>
        /// 是否性交痛
        /// </summary>
        public bool IsDyspareunia
        {
            get;
            set;
        }

        /// <summary>
        /// 是否痛经
        /// </summary>
        public bool IsDysmenorrhea
        {
            get;
            set;
        }

        /// <summary>
        /// 是否避孕
        /// </summary>
        public bool IsContraception
        {
            get;
            set;
        }

        /// <summary>
        /// 毛发
        /// </summary>
        public string Hair
        {
            get;
            set;
        }

        /// <summary>
        /// 水痘
        /// </summary>
        public bool ChickenPox
        {
            get;
            set;
        }

        /// <summary>
        /// 治疗建议
        /// </summary>
        public string Treatment
        {
            get;
            set;
        }

        /// <summary>
        /// 流感
        /// </summary>
        public bool TheFlu
        {
            get;
            set;
        }

        /// <summary>
        /// 烟
        /// </summary>
        public string Smoke
        {
            get;
            set;
        }

        /// <summary>
        /// 生化妊娠
        /// </summary>
        public string BiocheMicalpregnancy
        {
            get;
            set;
        }

        /// <summary>
        /// 甲状腺
        /// </summary>
        public string Thyroid
        {
            get;
            set;
        }

        /// <summary>
        /// 甲状腺疾病
        /// </summary>
        public bool ThyroidDisease
        {
            get;
            set;
        }

        /// <summary>
        /// 白带分析
        /// </summary>
        public string LeucorrHeaAnalysis
        {
            get;
            set;
        }

        /// <summary>
        /// 糖尿病
        /// </summary>
        public bool Diabetes
        {
            get;
            set;
        }

        /// <summary>
        /// 肝肾
        /// </summary>
        public string LiveRandKidney
        {
            get;
            set;
        }

        /// <summary>
        /// 腰围
        /// </summary>
        public int Waist
        {
            get;
            set;
        }

        /// <summary>
        /// 腹围
        /// </summary>
        public int Abdominal
        {
            get;
            set;
        }

        /// <summary>
        /// 自然流产
        /// </summary>
        public string Miscarriage
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int HosPitalID
        {
            get;
            set;
        }

        /// <summary>
        /// HPV
        /// </summary>
        public bool HPV
        {
            get;
            set;
        }


        /// <summary>  
        /// BMI  
        /// </summary>  
        public string BMI
        {
            get;
            set;
        }
        /// <summary>
        /// 科室ID
        /// </summary>
        public string LocationId { get; set; }
    }
}
