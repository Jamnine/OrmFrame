using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Dao.Interface
{
    public interface IDbColumnDao
    {
        /// <summary>
        /// 获取对应表的列
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>字段集合</returns>
        IList<DbColumn> GetColumns(string tableName);

        /// <summary>
        /// 获取对应索引的字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="indexName">索引名</param>
        /// <returns>对应字段名集合</returns>
        IList<string> GetIndexColumns(string indexName, string tableName);

        /// <summary>
        /// 获取对应表与主表的关联字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="parentConstraintName">数据库主表关联名称</param>
        /// <returns>对应字段名集合</returns>
        IList<string> GetParentRelationColumns(string parentConstraintName, string tableName);

        /// <summary>
        /// 获取对应表与从表的关联字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="childConstraintName">数据库从表表关联名称</param>
        /// <returns>对应字段名集合</returns>
        IList<string> GetChildRelationColumns(string childConstraintName, string tableName);
    }
}
