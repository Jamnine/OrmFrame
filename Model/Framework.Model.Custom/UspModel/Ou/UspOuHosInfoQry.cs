using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 挂号信息
    /// </summary>
    [Serializable]
    public class UspOuHosInfoQry : BaseModel
    {
        #region 预约挂号基本信息
        private int _adviserStatus = 0;
        /// <summary>
        /// 健康顾问状态: 1:已预约 2:已到达 3:已就诊 4:已收费 5:已发药 6:本次治疗已结束
        /// </summary>
        public int AdviserStatus
        {
            get { return this._adviserStatus; }
            set { this._adviserStatus = value; }
        }
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }
        /// <summary>
        /// 病人编号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WebUserCode { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString { get; set; }
        /// <summary>
        /// 病人类型
        /// </summary>
        public string PatTypeName { get; set; }
        public string BookingTel { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 就诊医生
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 就诊医生ID
        /// </summary>
        public string DoctorID { get; set; }
        /// <summary>
        /// 护士
        /// </summary>
        public string NurseName { get; set; }
        /// <summary>
        /// 前台接待ID
        /// </summary>
        public string ReceptionID { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        /// <summary>
        /// 前台接待Name
        /// </summary>
        public string ReceptionName { get; set; }
        /// <summary>
        /// 护士ID
        /// </summary>
        public string NurseID { get; set; }
        public string CnBookingPurse { get; set; }
        public string EmrID { get; set; }
        /// <summary>
        /// 是否初复诊
        /// </summary>
        public bool IsReturnVisit { get; set; }
        public int FollowStatus { get; set; }
        /// <summary>
        /// 病历编号
        /// </summary>
        public string RecordNumber { get; set; }

        /// <summary>
        /// 是否异常
        /// </summary>
        public bool IsAbnormal { get; set; }
        /// <summary>
        /// 病情记录
        /// </summary>
        public string Pathography
        {
            get;
            set;
        }
        /// <summary>
        /// 治疗建议ID
        /// </summary>
        public string TreatmentAdvise
        {
            get;
            set;
        }

        public string AdviserID { get; set; }
        /// <summary>
        /// 健康顾问
        /// </summary>
        public string AdviserName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 预约状态
        /// </summary>
        public string BookingStatus { get; set; }

        /// <summary>
        /// 时段
        /// </summary>
        public string TimeSpan { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 主诉
        /// </summary>
        public string Complaint
        {
            get;
            set;
        }
        /// <summary>
        /// 现病史
        /// </summary>
        public string PresentHistory
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
        /// 特殊病人
        /// </summary>
        public bool IsHideIllness { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect { get; set; }
        /// <summary>
        /// 挂号费
        /// </summary>
        public double RegistrationFee { get; set; }

        /// <summary>
        /// 挂号科室
        /// </summary>
        public string RegDept { get; set; }

        /// <summary>
        /// 就诊目的（编码，格式如1|2|3）
        /// </summary>
        public string BookingPurpose { get; set; }
        
        /// <summary>
        /// 是否注销
        /// </summary>
        public bool IsCancel { get; set; }

        /// <summary>
        /// 就诊医生
        /// </summary>
        public string FirstDoctorName { get; set; }

        /// <summary>
        /// 健康教育处方
        /// </summary>
        public string GoodRecipe
        {
            get ;
            set ;
        }

        /// <summary>
        /// 是否已经转诊
        /// </summary>
        public bool IsTransfer { get; set; }
        public string IsTransferStr { get; set; }

        /// <summary>
        /// 病历GUID
        /// </summary>
        public string OuClinicFirstGUID { get; set; }

        /// <summary>
        /// 医保流水号
        /// </summary>
        public string YbSeqNo { get; set; }

        /// <summary>
        /// 是否首诊
        /// </summary>
        public string IsFirstcheck { get; set; }

        /// <summary>
        /// 主诉（社区：主观资料）Complaint MainInform
        /// </summary>
        public string MainInform { get; set; }

        /// <summary>
        /// 预约挂号GUID
        /// </summary>
        public string OuHosInfoID { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string RegDeptName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkmanName { get; set; }

        /// <summary>
		/// 首诊医生，就是当天第一个看病的医生
		/// </summary>
        public string FirstDoctorId { get; set; }
        #endregion

        #region 病历信息
        /// <summary>
        /// 人工流产
        /// </summary>
        public string Abortion { get; set; }

        /// <summary>
		/// 过敏史
		/// </summary>
        public string AllErgy { get; set; }

        /// <summary>
		/// 治疗原则
		/// </summary>
        public string Analys { get; set; }

        /// <summary>
		/// 哮喘
		/// </summary>
        public bool Asthma { get; set; }

        /// <summary>
        /// 心脏病
        /// </summary>
        public bool Cardiopathy { get; set; }

        /// <summary>
		/// 心肺
		/// </summary>
		public string CardIopulMonary
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
		/// 糖尿病
		/// </summary>
		public bool Diabetes
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
        /// 诊断  
        /// </summary>  
        public string Diagnose { get; set; }

        /// <summary>
        /// 处理及建议
        /// </summary>
        public string Disposal
        {
            get;
            set;
        }
        public double ExamBP { get; set; }

        public double ExamBp
        {
            get;
            set;
        }

        public double ExamBp2
        {
            get;
            set;
        }
        public double ExamP { get; set; }

        /// <summary>
		/// 
		/// </summary>
		public double ExamR
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
        /// 体温
        /// </summary>
        public double ExamT
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
        /// 发病日期
        /// </summary>
        public string FirstDate
        {
            get;
            set;
        }

        public int HosPitalID
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClinicFirstOperName { get; set; }
        public DateTime ClinicFirstOperTime { get; set; }

        /// <summary>
		/// 水痘
		/// </summary>
		public bool ChickenPox
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
		/// 免疫接种史
		/// </summary>
		public string ImmunizationHistory
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
		/// 传染病史
		/// </summary>
		public string InfectionHistory
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
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

        public string PhysicalCheck
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
        /// 风疹
        /// </summary>
        public bool Rubella
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
        /// 云端专家ID
        /// </summary>
        public string SpecialistID
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
        /// 流感
        /// </summary>
        public bool TheFlu
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
        /// 舌象
        /// </summary>
        public string Tongue
        {
            get;
            set;
        }

        public string UsDrugCase
        {
            get;
            set;
        }
        public byte[] XMLCancer
        {
            get;
            set;
        }

        public byte[] XMLContagion
        {
            get;
            set;
        }
        public byte[] XMLSex
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

        public byte[] XMLTuberculosis
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
        /// 肝肾
        /// </summary>
        public string LiveRandKidney
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
        /// 门诊流水号
        /// </summary>
        public string MzRegId
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
		/// 苔象
		/// </summary>
		public string Moss
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
        #endregion
    }
}
