using System;

namespace Orm.Model
{
    /// <summary>
    ///剂型类别表
    /// </summary>
    [Serializable]
    public partial class BsDrugForm : BaseModel
    {
        private string _code;
        private string _name;
        private bool _isReject;
        private bool _isSave;
        private string _wbCode;
        private string _pyCode;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex;
        private long _iSONETotality;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;
        private bool _isPecial;
        private bool _isTOForm;
        private bool _isNotAutoBackDrug;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsDrugForm()
        {
        }

        /// <summary>
        /// 剂型ID.
        /// </summary>
        [Collumn(HeaderName = "编号", RelatedTableType = null)]
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
        /// 剂型.
        /// </summary>
        [Collumn(HeaderName = "剂型", RelatedTableType = null)]
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
        /// 是否注射剂.
        /// </summary>
        [Collumn(HeaderName = "是否注射剂", RelatedTableType = null)]
        public bool IsReject
        {
            get
            {
                return this._isReject;
            }
            set
            {
                this._isReject = value;
            }
        }

        /// <summary>
        /// 是否节省用药.
        /// </summary>
        [Collumn(HeaderName = "是否节省用药", RelatedTableType = null)]
        public bool IsSave
        {
            get
            {
                return this._isSave;
            }
            set
            {
                this._isSave = value;
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
        /// .图标
        /// </summary>
        [Collumn(HeaderName = "图标", IsShow = false, RelatedTableType = null)]
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex = value;
            }
        }

        /// <summary>
        /// F4是否自动收费1次.
        /// </summary>
        [Collumn(HeaderName = "是否自动收费", RelatedTableType = null)]
        public long ISONETotality
        {
            get
            {
                return this._iSONETotality;
            }
            set
            {
                this._iSONETotality = value;
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
        /// 医保码.
        /// </summary>
        [Collumn(HeaderName = "医保码", RelatedTableType = null)]
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode = value;
            }
        }

        /// <summary>
        /// 上报码.
        /// </summary>
        [Collumn(HeaderName = "上报码", RelatedTableType = null)]
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode = value;
            }
        }
        public bool IsPecial
        {
            get { return _isPecial; }
            set { _isPecial = value; }
        }
        /// <summary>
        /// 是否口服
        /// </summary>	
        public bool IsTOForm
        {
            get { return _isTOForm; }
            set { _isTOForm = value; }
        }

        public bool IsNotAutoBackDrug
        {
            get { return _isNotAutoBackDrug; }
            set { _isNotAutoBackDrug = value; }
        }
    }
}



