using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 检查步骤信息
    /// </summary>
    public class BsStepInfo : BaseModel
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
        private string _detail;
        /// <summary>
        /// 详细描述
        /// </summary>
        public string Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }

        private int _xmlId;
        /// <summary>
        /// 对应的疾病id
        /// </summary>
        public int XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }


    }
}
