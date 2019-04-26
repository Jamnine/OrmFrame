using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 应急考虑
    /// </summary>
    [Serializable]
    public class BsEmergency:BaseModel
    {
        private string _title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _detial;
        /// <summary>
        /// 详细
        /// </summary>
        public string Detial
        {
            get { return _detial; }
            set { _detial = value; }
        }

        private string _xmlId;
        /// <summary>
        /// 对应的评估xmlid
        /// </summary>
        public string XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }

        private int _orderBy;
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

    }
}
