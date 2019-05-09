using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Dao.Interface
{
    public interface IDbRelationDao
    {
        /// <summary>
        /// 获取对应表与主表关系
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>关系集合</returns>
        IList<DbRelation> GetParentRelations(string tableName);
    }
}
