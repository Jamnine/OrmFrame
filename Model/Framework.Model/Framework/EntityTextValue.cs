using System;

namespace Orm.Framework.Model
{
    /// <summary>
    /// Text和字段关系
    /// </summary>
    [Serializable]
    public class EntityTextField
    {
        public EntityTextField()
        {
            IsDict = false;
        }

        /// <summary>
        /// 实体名称
        /// </summary>
        public string EntityName
        {
            set;
            get;
        }

        /// <summary>
        /// 字段值
        /// </summary>
        public string ValueField
        {
            set;
            get;
        }

        /// <summary>
        /// 主键字段值
        /// </summary>
        public string PrimaryValueField
        {
            set;
            get;
        }

        /// <summary>
        /// 文本字段
        /// </summary>
        public string TextField
        {
            set;
            get;
        }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsDict
        {
            set;
            get;
        }
    }
}
