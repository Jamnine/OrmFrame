using System;
using System.Collections.Generic;
using System.Text;

namespace OracleDataToRedis.Utils
{
    public class DataBaseHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            set;
            get;
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public static DataBaseType CurrentDbType
        {
            set;
            get;
        }

        /// <summary>
        /// 获取数据库操作对象路径
        /// </summary>
        /// <param name="dbType">数据库种类</param>
        /// <returns>对象路径</returns>
        public static string GetDaoPath(DataBaseType dbType)
        {
            switch (dbType)
            {
                case DataBaseType.Oracle9:
                    return "OracleDataToRedis.Dao.Oracle9";
                case DataBaseType.SqlServer2005:
                case DataBaseType.SqlServer2008:
                    return "OracleDataToRedis.Dao.MsSql2005";
                default:
                    return "OracleDataToRedis.Dao.Oracle9";
            }
        }
    }
}
