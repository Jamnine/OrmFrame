using System;

namespace Orm.Framework.Model
{
    /// <summary>
    /// 单据基本类
    /// </summary>
    public partial class BillNoEntity : Orm.Model.BaseModel
    {
        private string _billNoCode;
        private string _billNoName;
        private int _billNoType;
        private int _rreq;
        private string _rule;
        private int _isRnd;
        private bool _isContinuation;
        private int _lastNum;
        private DateTime? _lastModifyTime;
        private string _moduleCode;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BillNoEntity()
        {
        }

        /// <summary>
        /// 获取或设置ID.
        /// </summary>
        public string BillNoCode
        {
            get
            {
                return this._billNoCode;
            }
            set
            {
                this._billNoCode = value;
            }
        }

        /// <summary>
        /// 获取或设置数据源ID.
        /// </summary>
        public string BillNoName
        {
            get
            {
                return this._billNoName;
            }
            set
            {
                this._billNoName = value;
            }
        }

        /// <summary>
        /// 获取或设置类型 0=字符 1=整数.
        /// </summary>
        public int BillNoType
        {
            get
            {
                return this._billNoType;
            }
            set
            {
                this._billNoType = value;
            }
        }

        /// <summary>
        /// 获取或设置频率 0=按天 1=按小时 2=按分钟.
        /// </summary>
        public int Rreq
        {
            get
            {
                return this._rreq;
            }
            set
            {
                this._rreq = value;
            }
        }

        /// <summary>
        /// 获取或设置规则.
        /// </summary>
        public string Rule
        {
            get
            {
                return this._rule;
            }
            set
            {
                this._rule = value;
            }
        }

        /// <summary>
        /// 获取或设置是否随机 0=无 1=随机 2=顺序.
        /// </summary>
        public int IsRnd
        {
            get
            {
                return this._isRnd;
            }
            set
            {
                this._isRnd = value;
            }
        }

        /// <summary>
        /// 获取或设置是否全局连号.
        /// </summary>
        public bool IsContinuation
        {
            get
            {
                return this._isContinuation;
            }
            set
            {
                this._isContinuation = value;
            }
        }

        /// <summary>
        /// 获取或设置最后号码.
        /// </summary>
        public int LastNum
        {
            get
            {
                return this._lastNum;
            }
            set
            {
                this._lastNum = value;
            }
        }

        /// <summary>
        /// 获取或设置最后修改时间.
        /// </summary>
        public DateTime? LastModifyTime
        {
            get
            {
                return this._lastModifyTime;
            }
            set
            {
                this._lastModifyTime = value;
            }
        }

        /// <summary>
        /// 获取或设置项目编码.
        /// </summary>
        public string ModuleCode
        {
            get
            {
                return this._moduleCode;
            }
            set
            {
                this._moduleCode = value;
            }
        }
    }
}