using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 体检信息
    /// </summary>
    [Serializable]
    public class UspTjRecord
    {
        private OuHosInfo _currentOuHosInfo;
        /// <summary>
        /// 当前挂号信息
        /// </summary>
        public OuHosInfo CurrentOuHosInfo
        {
            get { return _currentOuHosInfo; }
            set { _currentOuHosInfo = value; }
        }

        private List<CkSummary> _lstTjSummary = new List<CkSummary>();
        /// <summary>
        /// 科室小结
        /// </summary>
        public List<CkSummary> LstTjSummary
        {
            get { return _lstTjSummary; }
            set { _lstTjSummary = value; }
        }

    }
}
