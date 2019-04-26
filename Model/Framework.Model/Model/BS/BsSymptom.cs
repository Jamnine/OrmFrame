using System;

namespace Orm.Model
{
    /// <summary>
    /// 症状
    /// </summary>
    [Serializable]

    public class BsSymptom : BaseModel
    {
        private string code;
        private string name;
        private bool isActive;
        private string operId;
        private DateTime operLastTime;
        private bool _isChecked;

        /// <summary>
        /// 编码
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null)]
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "名称", RelatedTableType = null)]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 是否有效
        /// </summary>
        [Collumn(HeaderName = "是否有效", RelatedTableType = null)]
        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }

        /// <summary>
        /// 操作人
        /// </summary>
        [Collumn(HeaderName = "操作人", RelatedTableType = null, IsShow = false)]
        public string OperId
        {
            get
            {
                return operId;
            }

            set
            {
                operId = value;
            }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Collumn(HeaderName = "操作时间", RelatedTableType = null, IsShow = false)]
        public DateTime OperLastTime
        {
            get
            {
                return operLastTime;
            }

            set
            {
                operLastTime = value;
            }
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        [Collumn(HeaderName = "是否选中", RelatedTableType = null, IsShow = false)]
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
            }
        }
    }
}
