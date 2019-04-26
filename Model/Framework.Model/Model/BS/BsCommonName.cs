using System;

namespace Orm.Model
{
    /// <summary>
    ///BP通用名表
    /// </summary>
    [Serializable]
    public partial class BsCommonName : BaseModel
    {
        /// <summary>
        ///BP通用名表
        /// </summary>
        public BsCommonName()
        {
        }

        string _commonName;
        /// <summary>
        /// 通用名
        /// </summary>
        public string CommonName
        {
            get
            {
                return _commonName;
            }
            set
            {
                _commonName = value;
            }
        }
    }
}



