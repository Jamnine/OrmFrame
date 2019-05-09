using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Dao.Interface
{
    public interface IDbIndexDao
    {
        /// <summary>
        /// 获取对应表的索引
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>对应索引集合</returns>
        IList<DbIndex> GetIndexes(string tableName);
    }
}
