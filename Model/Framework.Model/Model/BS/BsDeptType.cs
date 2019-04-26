using System;

namespace Orm.Model
{
    /// <summary>
    ///科室类别表
    /// </summary>
    [Serializable]
    public partial class BsDeptType : BaseModel
    {
        private string _code;
        private string _name;
        private string _pyCode;
        private string _wbCode;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsDeptType()
        {
        }



        /// <summary>
        /// 编码.
        /// </summary>
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
        /// 名称.
        /// </summary>
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
        /// 拼音码.
        /// </summary>
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
        /// 图标.
        /// </summary>
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

    }
}



