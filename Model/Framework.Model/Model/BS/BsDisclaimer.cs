using System;

namespace Orm.Model
{
    /// <summary>
    /// 免责声明
    /// </summary> 
    [Serializable]
     public partial class BsDisclaimer : BaseModel
    {
        byte[] _detail;
        /// <summary>
        /// 免责声明详细
        /// </summary>
        public byte[] Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }
    }
}



