using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Services
{
    public class DbTableService
    {
        private static DbTableService _instance = new DbTableService();
        private IDbTableDao tableDao;
        private DbTableService()
        {
            string daoPath = DataBaseHelper.GetDaoPath(DataBaseHelper.CurrentDbType);
            tableDao = (IDbTableDao)Assembly.Load(daoPath).CreateInstance(daoPath + ".DbTableDao");
        }

        /// <summary>
        /// 获得单件模式对象
        /// </summary>
        public static DbTableService Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 获取所有的表信息
        /// </summary>
        /// <returns>表格对象集合</returns>
        public IList<DbTable> GetAllOfTables()
        {
            return tableDao.GetAllOfTables();
        }
    }
}
