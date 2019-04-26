using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// 诊断表
    /// </summary>
    [Serializable]
    public partial class BsDiagnose : BaseModel
    {
        string _diagnose;
        string _history;
        string _examine;
        bool _isCommon;
        int _orderby;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsDiagnose()
        {
            mainList = new List<BsDiagnoseDtl>();
            otherList = new List<BsDiagnoseDtl>();
        }

        /// <summary>
        /// 首要检查
        /// </summary>
        public List<BsDiagnoseDtl> mainList { get; set; }

        /// <summary>
        /// 其他检查
        /// </summary>
        public List<BsDiagnoseDtl> otherList { get; set; }

        /// <summary>
        /// 排序依据
        /// </summary>
        public int OrderBy
        {
            get
            {
                return _orderby;
            }
            set
            {
                _orderby = value;
            }
        }

        /// <summary>
        /// 常见：true/罕见：false
        /// </summary>
        public bool IsCommon
        {
            get
            {
                return _isCommon;
            }
            set
            {
                _isCommon = value;
            }
        }

        /// <summary>
        /// 检查
        /// </summary>
        public string Examine
        {
            get
            {
                return _examine;
            }
            set
            {
                _examine = value;
            }
        }

        /// <summary>
        /// 病史
        /// </summary>
        public string History
        {
            get
            {
                return _history;
            }
            set
            {
                _history = value;
            }
        }

        /// <summary>
        /// 假设诊断
        /// </summary>
        public string Diagnose
        {
            get
            {
                return _diagnose;
            }
            set
            {
                _diagnose = value;
            }
        }
        private string _xmlId;

        public string XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }

    }
}



