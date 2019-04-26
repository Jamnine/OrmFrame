using System;

namespace Orm.Model
{
    /// <summary>
    /// 还原恢复体信息
    /// </summary>
    [Serializable]
    public partial class BsRestorationPrice : BaseModel
    {
        
        private string _restorationId;
        private string _factoryId;
        private double  _price;
        private string _restorationName;
        private int _hisType;
        private DateTime _insertTime;

        /// <summary>
        /// 还原恢复体信息.
        /// </summary>
        public BsRestorationPrice(){ }

        
        /// <summary>
        /// 修复体ID
        /// </summary>
        public string RestorationId
        {
            get
            {
                return this._restorationId;
            }
            set
            {
                this._restorationId = value;
            }
        }
        /// <summary>
        /// 加工厂ID
        /// </summary>
        public string FactoryId
        {
            get
            {
                return this._factoryId;
            }
            set
            {
                this._factoryId = value;
            }
        }
        /// <summary>
        /// 修复体价格
        /// </summary>
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }

        /// <summary>
        /// 修复体名字
        /// </summary>
        public string RestorationName   
        {
            get
            {
                return this._restorationName;
            }
            set
            {
                this._restorationName = value;
            }
        }

 

        /// <summary>
        /// 产品类型
        /// </summary>
        public int HisType
        {
            get
            {
                return _hisType;
            }

            set
            {
                _hisType = value;
            }
        }

        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }
    }
}
