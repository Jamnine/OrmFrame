using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Services
{
    public class DbIndexService
    {
        private static DbIndexService _instance = new DbIndexService();
        private IDbIndexDao indexDao;
        private DbIndexService()
        {
            string daoPath = DataBaseHelper.GetDaoPath(DataBaseHelper.CurrentDbType);
            indexDao = (IDbIndexDao)Assembly.Load(daoPath).CreateInstance(daoPath + ".DbIndexDao");
        }

        /// <summary>
        /// 获得单件模式对象
        /// </summary>
        public static DbIndexService Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 获取对应表的索引
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>对应索引集合</returns>
        public DbTable SetIndexes(DbTable table)
        {
            IList<DbIndex> indexes = this.indexDao.GetIndexes(table.Name);
            foreach (DbIndex idx in indexes)
            {
                idx.Table = table;
            }
            table.Indexes = indexes;
            return table;
        }

        /// <summary>
        /// 获取对应表的主键
        /// </summary>
        /// <returns></returns>
        public DbIndex GetPrimaryKey(DbTable table)
        {
            foreach (DbIndex di in table.Indexes)
            {
                if (di.IsPrimaryKey == true)
                {
                    table.PrimaryKey = di;
                    return di;
                }
            }
            return null;
        }
    }
}
