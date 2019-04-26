using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 商城类别
    /// </summary>
    [Serializable]
    public partial class BsBusinessCityType : BaseModel
    {
        public BsBusinessCityType()
        {

        }
        private string _businessCityName;

        /// <summary>
        /// 商城类别名称
        /// </summary>
        [Collumn(HeaderName = "商城类别名称", RelatedTableType = null)]
        public string BusinessCityName
        {
            get { return this._businessCityName; }
            set { this._businessCityName = value; }
        }
    }
}
