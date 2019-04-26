using System.Collections.Generic;
using System.Data;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 通用查询接口
    /// </summary>
    public interface ICommonQuery
    {
        /// <summary>
        /// 根据条件返回泛型实体
        /// </summary>
        T Get<T>(QueryArgs query);

        /// <summary>
        /// 根据条件返回泛型实体列表
        /// </summary>
        List<T> GetList<T>(QueryArgs query, out int totalRecords);

        /// <summary>
        /// 根据条件返回DataTable
        /// </summary>
        DataTable GetDataTable(QueryArgs query, out int totalRecords);

    }
}
