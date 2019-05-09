using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Dao.Oracle9
{
    public class DbColumnDao : IDbColumnDao
    {
        /// <summary>
        /// 获取对应表的列
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>字段集合</returns>
        public IList<DbColumn> GetColumns(string tableName)
        {
            string sql = "SELECT col.column_id, col.table_name, col.column_name, col.data_type, col.data_length, col.nullable, com.comments"
                 + "   FROM user_tab_columns col, user_col_comments com"
                 + "  WHERE col.table_name = '" + tableName + "'"
                 + "    AND com.table_name(+) = '" + tableName + "'"
                 + "    AND com.column_name(+) = col.column_name"
                 + "  ORDER BY col.column_id";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "DbColumns");
                conn.Close();
            }
            IList<DbColumn> columns = new List<DbColumn>();
            foreach (DataRow dr in ds.Tables["DbColumns"].Rows)
            {
                DbColumn dc = new DbColumn();
                dc.Id = dr["column_id"].ToString();
                dc.Name = dr["column_name"].ToString();
                dc.DataType = dr["data_type"].ToString();
                try
                {
                    dc.Length = int.Parse(dr["data_length"].ToString());
                }
                catch { }
                dc.Comments = dr["comments"].ToString().Replace("\r", " ").Replace("\n", " ");
                dc.Nullable = (dr["nullable"].ToString().ToUpper() == "Y");
                columns.Add(dc);
            }
            return columns;
        }

        /// <summary>
        /// 获取对应索引的字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="indexName">索引名</param>
        /// <returns>对应字段名集合</returns>
        public IList<string> GetIndexColumns(string indexName, string tableName)
        {
            string sql = "SELECT icm.column_name"
                       + "  FROM user_ind_columns icm"
                       + " WHERE icm.index_name = '" + indexName + "'"
                       + "   AND icm.table_name = '" + tableName + "'";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "DbColumns");
                conn.Close();
            }
            IList<string> colomnNames = new List<string>();
            foreach (DataRow dr in ds.Tables["DbColumns"].Rows)
            {
                colomnNames.Add(dr["column_name"].ToString());
            }
            return colomnNames;
        }

        /// <summary>
        /// 获取对应表与主表的关联字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="parentConstraintName">数据库主表关联名称</param>
        /// <returns>对应字段名集合</returns>
        public IList<string> GetParentRelationColumns(string parentConstraintName, string tableName)
        {
            string sql = "SELECT cc.column_name"
                       + "  FROM user_cons_columns cc"
                       + " WHERE cc.table_name = '" + tableName + "'"
                       + "   AND cc.constraint_name = '" + parentConstraintName + "'";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "DbColumns");
                conn.Close();
            }
            IList<string> colomnNames = new List<string>();
            foreach (DataRow dr in ds.Tables["DbColumns"].Rows)
            {
                colomnNames.Add(dr["column_name"].ToString());
            }
            return colomnNames;
        }

        /// <summary>
        /// 获取对应表与从表的关联字段名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="childConstraintName">数据库从表表关联名称</param>
        /// <returns>对应字段名集合</returns>
        public IList<string> GetChildRelationColumns(string childConstraintName, string tableName)
        {
            string sql = "SELECT cc.column_name"
                       + "  FROM user_cons_columns cc"
                       + " WHERE cc.table_name = '" + tableName + "'"
                       + "   AND cc.constraint_name = '" + childConstraintName + "'";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "DbColumns");
                conn.Close();
            }
            IList<string> colomnNames = new List<string>();
            foreach (DataRow dr in ds.Tables["DbColumns"].Rows)
            {
                colomnNames.Add(dr["column_name"].ToString());
            }
            return colomnNames;
        }
    }
}
