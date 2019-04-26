using System;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 查询条件字段对象
    /// </summary>
    public class WhereField
    {
        public string Entity { set; get; }
        public string Field { set; get; }
        /// <summary>
        /// 比较运算符
        /// </summary>
        public WhereType Oper { get; set; }

        /// <summary>
        /// 函数模板
        /// </summary>
        public string Func { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        public string Value { get; set; }

    }
    /// <summary>
    /// 返回字段对象
    /// </summary>
    public class QueryField
    {
        public QueryField()
        {
            Opt = new QueryOptions();
        }

        public string Entity { set; get; }

        public string Field { set; get; }

        public QueryOptions Opt { set; get; }
    }
    [Serializable]
    public class QueryOptions
    {
        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        public int Option { set; get; }

        /// <summary>
        /// 函数模板
        /// <example>
        /// Sum({0},Left({0},5), (A-B)/C
        /// </example>
        /// </summary>
        public string Func { get; set; }

        /// <summary>
        /// 排序,从1开始
        /// </summary>
        public int Order { set; get; }


        /// <summary>
        /// 分组顺序,从1开始
        /// </summary>
        public int GroupByOrder { set; get; }
    }


    public enum FileldOption
    {
        None = 0,
        /// <summary>
        /// 是否排序列
        /// </summary>
        IsOrder = 1,
        /// <summary>
        /// 是否分组列
        /// </summary>
        IsGroupBy = 2,
        /// <summary>
        /// 是否计算 列
        /// </summary>
        IsCompute = 4,
        /// <summary>
        /// 是否反向排序
        /// </summary>
        IsDesc = 8,
        /// <summary>
        /// 是否文本
        /// </summary>
        IsText = 16
    }

    public enum DbFunctionType
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        Sum = 1,
        Avg = 2,
        Count = 3,

    }

    public class Relationship
    {
        public string Parent { set; get; }
        public string Child { set; get; }
        public RelationType Relation { set; get; }

        public bool OneToMany { set; get; }

        public string ParentKey { set; get; }
        public string ChildKey { set; get; }
    }

    public enum RelationType
    {
        Left = 0,
        Right = 1,
        Inner = 2,
        Full = 3
    }

    /// <summary>
    /// 查询条件类型
    /// </summary>
    public enum WhereType
    {
        /// <summary>
        /// 空
        /// </summary>
        None = 0,

        /// <summary>
        /// 等于
        /// </summary>
        Equal = 1,
        /// <summary>
        /// 不等于
        /// </summary>
        UnEqual = 2,
        /// <summary>
        /// 小于
        /// </summary>
        Less = 3,
        /// <summary>
        /// 小于等于
        /// </summary>
        LessOrEqual = 4,
        /// <summary>
        /// 大于
        /// </summary>
        More = 5,
        /// <summary>
        /// 大于等于
        /// </summary>
        MoreOrEqual = 6,
        /// <summary>
        /// 左Like
        /// </summary>
        LeftLike = 7,
        /// <summary>
        /// 右Like
        /// </summary>
        RightLike = 8,
        /// <summary>
        /// 全Like
        /// </summary>
        Like = 9,

        /// <summary>
        /// 包含
        /// </summary>
        In = 10,

        /// <summary>
        /// 不包含
        /// </summary>
        NotIn = 11,


    }


}
