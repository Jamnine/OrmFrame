using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
	/// 体检小结 - 实体拓展类
	/// </summary>
    public partial  class CkSummary :BaseModel
    {
        private string _itemID;
        /// <summary>
        /// 项目id
        /// </summary>
        public string ItemID
        {
            get { return this._itemID; }
            set { this._itemID = value; }
        }
        private string _tjLocationName;
        /// <summary>
        /// 科室名称
        /// </summary>
        public string TjLocationName
        {
            get { return _tjLocationName; }
            set { _tjLocationName = value; }
        }
        private string _doctorName;
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }
        
    }
}
