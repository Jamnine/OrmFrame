using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface ISqlHelper : IDisposable
    {
        Hashtable Parameters { set; get; }
        void AddParameter(string paramName, object val);
        

        void AddOutParameter(string paramName, int type);
        
        /// <summary>
        /// 得到连接对象
        /// </summary>
        DbConnection Connection { get; }

        /// <summary>
        /// 执行更新
        /// </summary>
        /// <returns></returns>
        int ExecuteNonQuery(string sql, dynamic namedParameters = null);

        /// <summary>
        /// 执行查询并返回DataReader
        /// </summary>
        /// <returns></returns>
        DbDataReader ExecuteReader(string sql, dynamic namedParameters = null);

        /// <summary>
        /// 执行查询并返回DataTable
        /// </summary>
        /// <returns></returns>
        DataTable ExecuteDataTable(string sql, dynamic namedParameters = null);
    }
}
