

using System;
namespace Orm.Model
{
    /// <summary>
    /// 项目对应频率 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsItemFrequency : BaseModel
    {
        private string _itemId;  //项目

        private string _frequencyId;  //频率

        private int _iconIndex;  //图标类型

        private int _HospitalID;

        private int _hisType;

        private DateTime _insertTime;

        public BsItemFrequency() { }

        /// <summary>
        /// 项目
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        /// <summary>
        /// 频率
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
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


