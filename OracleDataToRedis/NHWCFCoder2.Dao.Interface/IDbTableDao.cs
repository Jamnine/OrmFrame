using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Dao.Interface
{
    public interface IDbTableDao
    {
        /// <summary>
        /// 获取所有的表信息
        /// </summary>
        /// <returns>表格对象集合</returns>
        IList<DbTable> GetAllOfTables();
    }
}
