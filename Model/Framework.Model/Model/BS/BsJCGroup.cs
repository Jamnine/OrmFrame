using System;

namespace Orm.Model
{
    /// <summary>
    /// 检查附加收费分组表
    /// </summary>
    [Serializable]
    public partial class BsJCGroup : BaseModel
    {
        private string _code;
        private string _name;
        private int _iconIndex;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;

        /// <summary>
        /// 检查附加收费分组.
        /// </summary>
        public BsJCGroup()
        {
        }

        /// <summary>
        /// 检查附加收费分组ID.
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
        /// 检查附加收费分组.
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
        /// 图标索引
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



