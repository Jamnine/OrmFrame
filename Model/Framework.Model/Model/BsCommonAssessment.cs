using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 常见评估表
    /// </summary>
    [Serializable]
    public partial class BsCommonAssessment : BaseModel
    {
        private string _name;
        /// <summary>
        /// 评估名字
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _orderby;
        /// <summary>
        /// 排序
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

        private string _assessmentId;
        /// <summary>
        /// 对应评估id
        /// </summary>
        public string AssessmentId
        {
            get { return _assessmentId; }
            set { _assessmentId = value; }
        }

        private int _clickCount;
        /// <summary>
        /// 点击次数
        /// </summary>
        public int ClickCount
        {
            get { return _clickCount; }
            set { _clickCount = value; }
        }

    }
}
