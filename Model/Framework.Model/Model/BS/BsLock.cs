using System;

namespace Orm.Model
{
    [Serializable]
    /// <summary>
    ///
    /// </summary>
    public partial class BsLock : BaseModel
    {
        string _ouhosinfoId;
        int _version;
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsLock()
        {
        }
        /// <summary>
        /// 门诊id
        /// </summary>
        public string OuhosinfoId
        {
            get { return _ouhosinfoId; }
            set { _ouhosinfoId = value; }
        }
        /// <summary>
        /// 版本 每次保存+1
        /// </summary>
        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }
    }
}



