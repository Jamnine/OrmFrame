using System;
using System.Collections.Generic;
using System.Data;

namespace Orm.Framework.Model
{
    /// <summary>
    /// 文本缓存基类
    /// </summary>
    [Serializable]
    public class TextCacheEntity
    {
        public TextCacheEntity()
        {
            this.Fileds = new List<TextField>();
        }

        /// <summary>
        /// DatabaseCode
        /// </summary>
        public string DB
        {
            set;
            get;
        }

        /// <summary>
        /// 实体
        /// </summary>
        public string Entity
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
        /// 字段
        /// </summary>
        public List<TextField> Fileds
        {
            set;
            get;
        }
    }

    /// <summary>
    /// 缓存表基类
    /// </summary>
    [Serializable]
    public class TableCacheEntity
    {
        public TableCacheEntity()
        {
            this.Table = new DataTable();
        }

        /// <summary>
        /// DatabaseCode
        /// </summary>
        public string DB
        {
            set;
            get;
        }

        /// <summary>
        /// 实体
        /// </summary>
        public string Entity
        {
            set;
            get;
        }
        
        /// <summary>
        /// 表
        /// </summary>
        public DataTable Table
        {
            set;
            get;
        }
    }

    /// <summary>
    /// 文本字段
    /// </summary>
    [Serializable]
    public class TextField
    {
        /// <summary>
        /// 值字段值
        /// </summary>
        public string VF
        {
            set;
            get;
        }

        /// <summary>
        /// 文本字段值
        /// </summary>
        public string TF
        {
            set;
            get;
        }
    }
}
