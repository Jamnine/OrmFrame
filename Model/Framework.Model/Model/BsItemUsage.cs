

using System;
namespace Orm.Model
{
    /// <summary>
    /// 项目对应用法 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsItemUsage : BaseModel
    {



        private string _itemId;  //项目

        private string _usageId;  //用法

        private int _iconIndex;  //图标类型

        private int _HospitalID;

        private int _hisType;

        private DateTime _insertTime;

        public BsItemUsage() { }

        /// <summary>
        /// 项目
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// 图标类型
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }


        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }
    }
}


