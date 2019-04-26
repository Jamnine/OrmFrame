using System;

namespace Orm.Model
{
    [Serializable]
    /// <summary>
    /// 提成规则表
    /// </summary>
    public partial class BsRule : BaseModel
    {

        private int _diagnosisBasetArget;
        private decimal _diagnosisRoyalty;
        private int _diagnosisTndtArget;
        private string _docLevID;
        private int _drugfeeBasetArget;
        private decimal _drugfeeRoyalty;
        private int _drugfeeStandArget;
        private int _exdrugfeeBasetArget;
        private decimal _exdrugfeeRoyalty;
        private int _exdrugfeeStandtArget;
        private DateTime _insertTime;
        private bool _isActive;
        private string _remark;
        private int _royaltyLevel;
        private int _treatmentBasetArget;
        private decimal _treatmentRoyalty;
        private int _treatmentStandardtArget;
        private string _code;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsRule()
        {
        }
        /// <summary>
        /// 编码
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 诊金基础目标
        /// </summary>
        [Collumn(HeaderName = "诊金基础目标", RelatedTableType = null, Length = 6)]
        public int DiagnosisBasetarget
        {
            get { return _diagnosisBasetArget; }
            set { _diagnosisBasetArget = value; }
        }

        /// <summary>
        /// 诊金达标提成
        /// </summary>
        [Collumn(HeaderName = "诊金达标提成", RelatedTableType = null, Length = 6)]
        public decimal DiagnosisRoyalty 
        {
            get { return _diagnosisRoyalty; }
            set { _diagnosisRoyalty = value; }
        }

        /// <summary>
        /// 诊金达标目标
        /// </summary>
        [Collumn(HeaderName = "诊金达标目标", RelatedTableType = null, Length = 6)]
        public int DiagnosisTndtArget
        {
            get { return _diagnosisTndtArget; }
            set { _diagnosisTndtArget = value; }
        }

        /// <summary>
        /// 职称ID
        /// </summary>
        [Collumn(HeaderName = "职称", RelatedTableType = typeof(BsDocLevel))]
        public string DocLevID
        {
            get { return _docLevID; }
            set { _docLevID = value; }
        }

        /// <summary>
        /// 药费基础目标（集团内部）
        /// </summary>
        [Collumn(HeaderName = "集团产业药费目标", RelatedTableType = null, Length = 6)]
        public int DrugfeeBasetArget 
        {
            get { return _drugfeeBasetArget; }
            set { _drugfeeBasetArget = value; }
        }

        /// <summary>
        /// 药费达标提成（集团内部）
        /// </summary>
        [Collumn(HeaderName = "集团产业药费提成", RelatedTableType = null, Length = 6)]
        public decimal DrugfeeRoyalty
        {
            get { return _drugfeeRoyalty; }
            set { _drugfeeRoyalty = value; }
        }

        /// <summary>
        /// 药费达标目标（集团内部）
        /// </summary>
        [Collumn(HeaderName = "集团产业药费达标目标", RelatedTableType = null, Length = 6)]
        public int DrugfeeStandArget
        {
            get { return _drugfeeStandArget; }
            set { _drugfeeStandArget = value; }
        }

        /// <summary>
        /// 药费基础目标（集团外部）
        /// </summary>
        [Collumn(HeaderName = "合作产业药费目标", RelatedTableType = null, Length = 6)]
        public int ExdrugfeeBasetArget
        {
            get { return _exdrugfeeBasetArget; }
            set { _exdrugfeeBasetArget = value; }
        }

        /// <summary>
        /// 药费达标提成（集团外部）
        /// </summary>
        [Collumn(HeaderName = "合作产业提成", RelatedTableType = null, Length = 6)]
        public decimal ExdrugfeeRoyalty
        {
            get { return _exdrugfeeRoyalty; }
            set { _exdrugfeeRoyalty = value; }
        }

        /// <summary>
        /// 药费达标目标（集团外部）
        /// </summary>
        [Collumn(HeaderName = "合作产业达标目标", RelatedTableType = null, Length = 6)]
        public int ExdrugfeeStandtArget
        {
            get { return _exdrugfeeStandtArget; }
            set { _exdrugfeeStandtArget = value; }
        }

        /// <summary>
        /// 录入时间
        /// </summary>
        //[Collumn(HeaderName = "录入时间", RelatedTableType = null, Length = 6)]
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 说明
        /// </summary>
        [Collumn(HeaderName = "规则说明", RelatedTableType = null, Length = 6)]
        public string Remark 
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// 等级
        /// </summary>
        [Collumn(HeaderName = "规则等级", RelatedTableType = null, Length = 6)]
        public int RoyaltyLevel 
        {
            get { return _royaltyLevel; }
            set { _royaltyLevel = value; }
        }

        /// <summary>
        /// 治疗基础目标
        /// </summary>
        [Collumn(HeaderName = "治疗基础目标", RelatedTableType = null, Length = 6)]
        public int TreatmentBasetArget
        {
            get { return _treatmentBasetArget; }
            set { _treatmentBasetArget = value; }
        }

        /// <summary>
        /// 治疗达标提成
        /// </summary>
        [Collumn(HeaderName = "治疗达标提成", RelatedTableType = null, Length = 6)]
        public decimal TreatmentRoyalty
        {
            get { return _treatmentRoyalty; }
            set { _treatmentRoyalty = value; }
        }

        /// <summary>
        /// 治疗达标目标
        /// </summary>
        [Collumn(HeaderName = "治疗达标目标", RelatedTableType = null, Length = 6)]
        public int TreatmentStandardtArget
        {
            get { return _treatmentStandardtArget; }
            set { _treatmentStandardtArget = value; }
        }
    }
}



