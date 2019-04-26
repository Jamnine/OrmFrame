

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病人类别一级分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsTallyGroup:BaseModel
	{   
		 
        private string _code;
        private string _name;
        private bool _isGf;
        private bool _isYb;
        private string _ybHospNo;
        private string _pyCode;
        private string _wbCode;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex; 
        private DateTime _modiTime;
        private string _modiOperId;
        private int _HospitalID;//医院ID 

        private string _zyClassName;  //住院的医保接口对应代码的ClassName
		
		private string _mzClassName;  //门诊医保接口对应代码的ClassName
		
		private int _lsinout;  //1.门诊2.住院3.全部


        /// <summary>
        /// 1.门诊2.住院3.全部
        /// </summary>
        public int Lsinout
        {
            get { return _lsinout; }
            set { _lsinout = value; }
        }
         
        /// <summary>
        /// 住院的医保接口对应代码的ClassName.
        /// </summary>

        public string ZyClassName
        {
            get
            {
                return this._zyClassName;
            }
            set
            {
                this._zyClassName = value;
            }
        }

        /// <summary>
        /// 门诊医保接口对应代码的ClassName.
        /// </summary>

        public string MzClassName
        {
            get
            {
                return this._mzClassName;
            }
            set
            {
                this._mzClassName = value;
            }
        }
         
        /// <summary>
        /// 编码.
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
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
        /// 公医类别.
        /// </summary>
        [Collumn(HeaderName = "公医类别", RelatedTableType = null, Length = 50)]
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
        /// 公费标志.
        /// </summary>
        [Collumn(HeaderName = "公费标志", RelatedTableType = null)]
        public bool IsGf
        {
            get
            {
                return this._isGf;
            }
            set
            {
                this._isGf = value;
            }
        }

        /// <summary>
        /// 医保标志.
        /// </summary>
        [Collumn(HeaderName = "医保标志", RelatedTableType = null)]
        public bool IsYb
        {
            get
            {
                return this._isYb;
            }
            set
            {
                this._isYb = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        [Collumn(HeaderName = "YbHospNo", RelatedTableType = null, IsShow = false)]
        public string YbHospNo
        {
            get
            {
                return this._ybHospNo;
            }
            set
            {
                this._ybHospNo = value;
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
        /// 图标索引
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

  

    }  
}           


