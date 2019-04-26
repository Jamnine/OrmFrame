using System;

namespace Orm.Model
{
    /// <summary>
    /// 导入药品记录表
    /// </summary>
    [Serializable]
    public class BsSelectedLocItemLog : BaseModel
    {
        private string _itemId;
        private string _itemCode;
        private string _locationId;

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// 门诊机构ID
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
    }
}
