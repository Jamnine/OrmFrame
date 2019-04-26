using System;

namespace Orm.Model
{
    /// <summary>
    ///用法
    /// </summary>
    [Serializable]
    public partial class BsUsage : BaseModel
    {
       
        private string _code;
        private string _name;
        private string _printName;
        private string _wbCode;
        private string _pyCode;
        private int _lsUseArea;
        private int _lsPrnFormType;
        private bool _isPrintLabel;
        private bool _isPrintReject;
        private bool _isPrintDrug;
        private bool _isPrintAst;
        private bool _isPrintCure;
        private bool _isPrintNurse;
        private bool _isPrintExternal;
        private bool _isPrintPush;
        private bool _isPrintRejSkin;
        private bool _isPrintDietetic;
        private bool _isPrintBlood;
        private bool _isMzDrop;
        private bool _isMzReject;
        private bool _isMzCure;
        private int _orderBy;
        private bool _isActive;
        private bool _isPrintAtomization;
        private int _lsInOutType;
        private bool _isDrugTwoDay;  
        private bool _isSpecialUsage;
        private bool _isFORWestDrug;
        private DateTime _modiTime;
        private string _modiOperId;
        private int _HospitalID;//医院ID
        private bool _isChin; //是否中药用法
        private int _iconIndex;  //图标类型
        private string _rPTName;//绑定RPT
        private bool _isIvgtt;//是否静滴
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsUsage()
        {
        }
        /// <summary>
        /// 绑定RPT
        /// </summary>
        public string RPTName
        {
            get
            {
                return this._rPTName;
            }
            set
            {
                this._rPTName = value;
            }
        }
         
        /// <summary>
        /// 用法编号.
        /// </summary>
        [Collumn(HeaderName = "用法编号", RelatedTableType = null)]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// 用法.
        /// </summary>
        [Collumn(HeaderName = "用法", RelatedTableType = null)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// 打印/显示名.
        /// </summary>
        [Collumn(HeaderName = "打印/显示名", RelatedTableType = null)]
        public string PrintName
        {
            get
            {
                return this._printName;
            }
            set
            {
                this._printName = value;
            }
        }

        /// <summary>
        /// 五笔码.
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// 拼音码.
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// 适用范围：1-门诊；2-住院；3-共用.
        /// </summary>
        [Collumn(HeaderName = "适用范围", RelatedTableType = null)]
        public int LsUseArea
        {
            get
            {
                return this._lsUseArea;
            }
            set
            {
                this._lsUseArea = value;
            }
        }

        /// <summary>
        /// 药房分类单打印类别：1-口服药单；2-针剂汇总单.
        /// </summary>
        [Collumn(HeaderName = "药房分类单打印类别", RelatedTableType = null)]
        public int LsPrnFormType
        {
            get
            {
                return this._lsPrnFormType;
            }
            set
            {
                this._lsPrnFormType = value;
            }
        }

        /// <summary>
        /// 是否打印瓶签.
        /// </summary>
        [Collumn(HeaderName = "是否打印瓶签", RelatedTableType = null, IsShow = false)]
        public bool IsPrintLabel
        {
            get
            {
                return this._isPrintLabel;
            }
            set
            {
                this._isPrintLabel = value;
            }
        }

        /// <summary>
        /// 是否打印注射单.
        /// </summary>
        [Collumn(HeaderName = "是否打印注射单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintReject
        {
            get
            {
                return this._isPrintReject;
            }
            set
            {
                this._isPrintReject = value;
            }
        }

        /// <summary>
        /// 是否打印服药单.
        /// </summary>
        [Collumn(HeaderName = "是否打印服药单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintDrug
        {
            get
            {
                return this._isPrintDrug;
            }
            set
            {
                this._isPrintDrug = value;
            }
        }

        /// <summary>
        /// 是否打印AST单.
        /// </summary>
        [Collumn(HeaderName = "是否打印AST单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintAst
        {
            get
            {
                return this._isPrintAst;
            }
            set
            {
                this._isPrintAst = value;
            }
        }

        /// <summary>
        /// 是否打印治疗单.
        /// </summary>
        [Collumn(HeaderName = "是否打印治疗单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintCure
        {
            get
            {
                return this._isPrintCure;
            }
            set
            {
                this._isPrintCure = value;
            }
        }

        /// <summary>
        /// 是否打印护理单.
        /// </summary>
        [Collumn(HeaderName = "是否打印护理单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintNurse
        {
            get
            {
                return this._isPrintNurse;
            }
            set
            {
                this._isPrintNurse = value;
            }
        }

        /// <summary>
        /// 是否打印外用单.
        /// </summary>
        [Collumn(HeaderName = "是否打印外用单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintExternal
        {
            get
            {
                return this._isPrintExternal;
            }
            set
            {
                this._isPrintExternal = value;
            }
        }

        /// <summary>
        /// 是否打印静推单.
        /// </summary>
        [Collumn(HeaderName = "是否打印静推单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintPush
        {
            get
            {
                return this._isPrintPush;
            }
            set
            {
                this._isPrintPush = value;
            }
        }

        /// <summary>
        /// 是否打印皮下注射单.
        /// </summary>
        [Collumn(HeaderName = "是否打印皮下注射单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintRejSkin
        {
            get
            {
                return this._isPrintRejSkin;
            }
            set
            {
                this._isPrintRejSkin = value;
            }
        }

        /// <summary>
        /// 是否打印饮食单.
        /// </summary>
        [Collumn(HeaderName = "是否打印饮食单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintDietetic
        {
            get
            {
                return this._isPrintDietetic;
            }
            set
            {
                this._isPrintDietetic = value;
            }
        }

        /// <summary>
        /// 是否打印测血压单.
        /// </summary>
        [Collumn(HeaderName = "是否打印测血压单", RelatedTableType = null, IsShow = false)]
        public bool IsPrintBlood
        {
            get
            {
                return this._isPrintBlood;
            }
            set
            {
                this._isPrintBlood = value;
            }
        }

        /// <summary>
        /// 是否打印门诊输液单.
        /// </summary>
        [Collumn(HeaderName = "是否打印门诊输液单", RelatedTableType = null)]
        public bool IsMzDrop
        {
            get
            {
                return this._isMzDrop;
            }
            set
            {
                this._isMzDrop = value;
            }
        }

        /// <summary>
        /// 是否打印门诊注射单.
        /// </summary>
        [Collumn(HeaderName = "是否打印门诊注射单", RelatedTableType = null)]
        public bool IsMzReject
        {
            get
            {
                return this._isMzReject;
            }
            set
            {
                this._isMzReject = value;
            }
        }

        /// <summary>
        /// 是否打印门诊治疗单.
        /// </summary>
        [Collumn(HeaderName = "是否打印门诊治疗单", RelatedTableType = null, IsShow = false)]
        public bool IsMzCure
        {
            get
            {
                return this._isMzCure;
            }
            set
            {
                this._isMzCure = value;
            }
        }

        /// <summary>
        /// 显示顺序.
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
        public int OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy = value;
            }
        }

        /// <summary>
        /// 有效标志.
        /// </summary>
        [Collumn(HeaderName = "有效标志", RelatedTableType = null)]
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// 是否打印雾化
        /// </summary>       
        [Collumn(HeaderName = "是否打印雾化", RelatedTableType = null, IsShow = false)]
        public bool IsPrintAtomization
        {
            get
            {
                return this._isPrintAtomization;
            }
            set
            {
                this._isPrintAtomization = value;
            }
        }

        /// <summary>
        /// 病人类别用途:1-全部;2-门诊;3-住院.
        /// </summary>
        [Collumn(HeaderName = "病人类别用途", RelatedTableType = null)]
        public int LsInOutType
        {
            get
            {
                return this._lsInOutType;
            }
            set
            {
                this._lsInOutType = value;
            }
        }

        /// <summary>
        /// .是否双向药物
        /// </summary>
        [Collumn(HeaderName = "是否双向药物", RelatedTableType = null, IsShow = false)]
        public bool IsDrugTwoDay
        {
            get
            {
                return this._isDrugTwoDay;
            }
            set
            {
                this._isDrugTwoDay = value;
            }
        }

        

        /// <summary>
        /// F7西药专用.
        /// </summary>
        [Collumn(HeaderName = "西药专用", RelatedTableType = null, IsShow = false)]
        public bool ISFORWestDrug
        {
            get
            {
                return this._isFORWestDrug;
            }
            set
            {
                this._isFORWestDrug = value;
            }
        }

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }

        /// <summary>
        /// 最后修改人.
        /// </summary>
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }


        /// <summary>
        /// 是否静滴
        /// </summary>
        public bool ISIVGTT
        {
            get
            {
                return this._isIvgtt;
            }
            set
            {
                this._isIvgtt = value;
            }
        }
        /// <summary>
        /// 是否中药用法
        /// </summary>
        public bool IsChin
        {
            get
            {
                return this._isChin;
            }
            set
            {
                this._isChin = value;
            }
        }
        /// <summary>
        /// 图标类型
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }
        /// <summary>
        /// F6是否为特殊用法。
        /// </summary>
        [Collumn(HeaderName = "是否为特殊用法", RelatedTableType = null)]
        public bool IsSpecialUsage
        {
            get { return _isSpecialUsage; }
            set { _isSpecialUsage = value; }

        }


    }
}



