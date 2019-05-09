using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Dao.MsSql2005
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
            string sql = "SELECT com.column_id AS column_id, tbl.name AS table_name, com.name AS column_name, usrt.name AS data_type,"
                + " com.max_length AS data_length, com.is_nullable AS nullable, pt.VALUE AS comments"
                + " FROM   sys.tables tbl"
                + "        INNER JOIN sys.all_columns as com ON tbl.object_id = com.object_id"
                + "        LEFT JOIN sys.extended_properties pt ON com.object_id = pt.major_id AND com.column_id = pt.minor_id"
                + "        LEFT OUTER JOIN sys.types AS usrt ON usrt.user_type_id = com.user_type_id"
                + " WHERE  tbl.name = '" + tableName + "'";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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
                dc.Nullable = ((bool)dr["nullable"]);
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
            string sql = "SELECT com.name AS column_name,usrt.name AS data_type,com.max_length AS data_length,com.is_nullable AS nullable,"
                                + " com.column_id AS column_id,pt.VALUE AS comments"
                                + " FROM   sys.tables tbl"
                                + "        INNER JOIN sys.indexes idx  ON idx.object_id = tbl.object_id"
                                + "        INNER JOIN sys.index_columns idc ON idc.object_id = idx.object_id and idc.index_id = idx.index_id"
                                + "        INNER JOIN sys.all_columns com ON com.object_id = idc.object_id AND com.column_id = idc.column_id "
                                + "        LEFT JOIN sys.extended_properties pt ON com.object_id = pt.major_id AND com.column_id = pt.minor_id"
                                + "        LEFT JOIN sys.types AS usrt ON usrt.user_type_id = com.user_type_id"
                                + " WHERE  idx.name = '" + indexName + "' and tbl.name = '" + tableName + "'";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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
            string sql = "SELECT col.NAME AS column_name"
                       + " FROM sys.foreign_keys fk"
                       + " INNER JOIN sys.foreign_key_columns fk_cl ON fk.object_id = fk_cl.constraint_object_id"
                       + " INNER JOIN sys.all_columns col ON col.object_id = fk_cl.referenced_object_id AND col.column_id = fk_cl.constraint_column_id"
                       + " WHERE fk.NAME = '" + parentConstraintName + "'"
                       + " AND fk_cl.referenced_object_id = object_id('" + tableName + "')";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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
            string sql = "SELECT col.NAME AS column_name"
                       + " FROM sys.foreign_keys fk"
                       + " INNER JOIN sys.foreign_key_columns fk_cl ON fk.object_id = fk_cl.constraint_object_id"
                       + " INNER JOIN sys.all_columns col ON col.object_id = fk_cl.parent_object_id AND col.column_id = fk_cl.parent_column_id"
                       + " WHERE fk.NAME = '" + childConstraintName + "'"
                       + " AND fk_cl.parent_object_id = object_id('" + tableName + "')";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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
