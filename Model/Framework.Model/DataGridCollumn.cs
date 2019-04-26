using System;

namespace Orm.Model
{
    /// <summary>
    /// Model属性的表格列属性，方便反射获得
    /// </summary>
    public class CollumnAttribute:Attribute
    {
        /// <summary>
        /// 列名称
        /// </summary>
        public string HeaderName { get; set; }

        /// <summary>
        /// 关联表
        /// </summary>
        public Type RelatedTableType { get; set; }

        /// <summary>
        /// 关联字段
        /// </summary>
        public string RelatedDisplayName { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        public string Where { get; set; }

        /// <summary>
        /// 条件参数
        /// </summary>
        public object[] WhereArgs { get; set; }

        private bool _isReadOnly = false;
        /// <summary>
        /// 是否只读
        /// </summary>
        public bool IsReadOnly { get { return _isReadOnly; } set { _isReadOnly = value; } }

        private bool _isShow = true;
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool IsShow { get { return _isShow; } set { _isShow = value; } }

        /// <summary>
        /// 类型说明 键值用:分割，项与项用|分割， 比如 1:在职|2:离职
        /// </summary>
        public string LstType { get; set; }

        /// <summary>
        /// 属性长度
        /// </summary>
        public int Length { get; set; }
    }
}
