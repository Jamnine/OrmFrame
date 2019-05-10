using ELinq;
using Orm.Framework.Services;
using System;
using System.Collections;
using System.Data;

namespace Orm
{
    public class SqlHelperProxy : ISqlHelper
    {
        IDbHelper dbHelper;


        public SqlHelperProxy(IDbHelper pDbHelper)
        {
            dbHelper = pDbHelper;
            Parameters = new Hashtable();
        }


        public System.Data.Common.DbConnection Connection
        {
            get { return dbHelper.Connection; }
        }

        public int ExecuteNonQuery(string sql, dynamic namedParameters = null)
        {
            try
            {
                return dbHelper.ExecuteNonQuery(sql, namedParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public System.Data.Common.DbDataReader ExecuteReader(string sql, dynamic namedParameters = null)
        {
            return dbHelper.ExecuteReader(sql, namedParameters);
        }

        public System.Data.DataTable ExecuteDataTable(string sql, dynamic namedParameters = null)
        {
            return dbHelper.ExecuteDataTable(sql, namedParameters);
        }

        public System.Data.DataSet ExecuteDataSet(string sql, dynamic namedParameters = null)
        {
            return dbHelper.ExecuteDataSet(sql, namedParameters);
        }

        public object ExecuteScalar(string sql, dynamic namedParameters = null)
        {
            return dbHelper.ExecuteScalar(sql, namedParameters);
        }

        public void Dispose()
        {
            dbHelper.Dispose();
        }

        public void AddOutParameter(string paramName, System.Data.DbType type)
        {
            dynamic parameter = new Orm.Framework.Services.DbParameter();
            parameter.DbType = type;
            parameter.Direction = ParameterDirection.Output;
            Parameters.Add(paramName, parameter);
        }

        public void AddOutParameter(string paramName, int type)
        {
            dynamic parameter = new Orm.Framework.Services.DbParameter();
            parameter.OracleDbType = type;
            parameter.Direction = ParameterDirection.Output;
            Parameters.Add(paramName, parameter);
        }

        public void AddParameter(string paramName, object val)
        {
            dynamic parameter = new Orm.Framework.Services.DbParameter();
            parameter.Value = val;
            Parameters.Add(paramName, parameter);
        }


        public Hashtable Parameters
        {
            set;
            get;
        }


        public object GetParameterValue(string paramName)
        {
            if (dbHelper.OutParameters == null
                || !dbHelper.OutParameters.ContainsKey(paramName)
                )
            {
                return null;
            }

            return dbHelper.OutParameters[paramName];
        }





    }
}
