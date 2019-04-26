using System;

namespace Orm.Model
{
    /// <summary>
    /// 体检项目接口 
    /// </summary>
    [Serializable]
    public class TjItemInterface : BaseModel
    {
        private string _tjItemCode;
        private string _plan;
        private string _itemInterface;
        private string _numberInterface;

        /// <summary>
        /// 体检项目编号
        /// </summary>
        public string TjItemCode
        {
            get
            {
                return _tjItemCode;
            }

            set
            {
                _tjItemCode = value;
            }
        }

        /// <summary>
        /// 计划
        /// </summary>
        public string Plan
        {
            get
            {
                return _plan;
            }

            set
            {
                _plan = value;
            }
        }

        /// <summary>
        /// 项目接口
        /// </summary>
        public string ItemInterface
        {
            get
            {
                return _itemInterface;
            }

            set
            {
                _itemInterface = value;
            }
        }

        /// <summary>
        /// 数字接口
        /// </summary>
        public string NumberInterface
        {
            get
            {
                return _numberInterface;
            }

            set
            {
                _numberInterface = value;
            }
        }
    }
}
