using System.Collections.Generic;

namespace Orm.Framework.Services
{

    ///<summary>
    /// 
    ///</summary>
    public class QueryArgs
    {
        /// <summary>
        /// Ado数据查询参数
        /// </summary>
        public QueryArgs()
        {
            QueryFields = new List<QueryField>();
            WhereFields = new List<WhereField>();
            Relations = new List<Relationship>();
            PageSize = 20;

            this.ModelAssembly = "Orm.Model.dll";
            this.NameSpace = "Orm.Model";

        }

        /// <summary>
        /// 实体对象程序集
        ///<example>"Orm.Framework.Model.dll"</example>
        /// </summary>
        public string ModelAssembly { get; set; }

        /// <summary>
        /// 实体对象带命名空间
        ///<example>"Orm.Framework.Model"</example>
        /// </summary>
        public string NameSpace { get; set; }
        /// <summary>
        /// 每页行数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 页数
        /// <remarks>从0开始编号</remarks>
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 结果字段列表
        /// <remarks>不支持一个字段返回两次</remarks>
        /// <example>json代码：
        ///  [
        ///       { entity:"purorderEntity",filed:"purorderCode",alias:"code",func:null}, billdate:null,employee:{alias:"buyer"},  //采购单主表，返回三个字段
        ///        {  entity:"purordersub",filed:"productCode"alias:"",func:0}, qty:{alias:"",func:1}    //采购单子表，返回两个字段
        ///   ]
        ///   </example>
        /// </summary>
        public List<QueryField> QueryFields { get; set; }
        /// <summary>
        /// 条件字段列表
        /// <example>json代码
        ///   [
        ///                       {entity:"purorder",field:"purorderCode",oper:0,value:'PO2014050812'},
        ///                       {entity:"purorder",field:"billdate",oper:1,value:'2014-04-10',func:{func:8,func:'substring({0},0,8)}},
        ///                       {entity:"purorder",field:"howlong",oper:1,value:'2014-04-10',func:{func:1,func:'PoEndTime-PoStartTime'}}
        ///                       ],  //采购单主表，返回两个字段。第二个字段使用了函数
        ///        entity:"purordersub",field:"",oper:"",value:""},{}]    //采购单子表，返回两个字段
        ///   ]
        /// </example>
        /// </summary>
        public List<WhereField> WhereFields { get; set; }

        /// <summary>
        ///  对象关系
        ///  <example>json代码
        ///   [
        ///     {parent:"purorder",child:"purordersub",relation:1，parentKey:"purordercode",childKey:"purordercode"},  //采购单主表，外键表，采购单 子表，关系，一对多
        ///     {parent: "purordersub",child:"productinfo",relation:0，parentKey:"productcode",childKey:"productcode"}  //采购单子表，外键表:商品信息，关系一对一
        ///   ]，
        ///   只有一个表
        ///   [parent:"purorder"]
        /// </example>
        /// </summary>
        public List<Relationship> Relations { get; set; }

    }

    ///<summary>
    /// 结果集
    ///</summary>
    public class QueryResult
    {
        /// <summary>
        /// 总数据行数
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        public object Data { get; set; }
    }

    /// <summary>
    /// 泛型结果集
    /// </summary>
    /// <typeparam name="TResult">类型参数</typeparam>
    public class QueryResult<TResult>
    {
        /// <summary>
        /// 总数据行数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        public IEnumerable<TResult> Data { get; set; }
    }
}
