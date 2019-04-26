using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 评估小结
    /// </summary>
    [Serializable]
    public class BsSummary :BaseModel
    {
        private string _xmlId;
        /// <summary>
        /// 对应评估id
        /// </summary>
        public string XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }
        private string _summary;
        /// <summary>
        /// 小结
        /// </summary>
        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }   
    }
}
