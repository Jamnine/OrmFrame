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
    public class DbTableDao : IDbTableDao
    {
        /// <summary>
        /// 获取所有的表信息
        /// </summary>
        /// <returns>表格对象集合</returns>
        public IList<DbTable> GetAllOfTables()
        {
            string sql = "SELECT tbl.name as table_name, 'use_table' as table_type, tbl.name as comments"
                + " FROM   sys.tables tbl";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "DbTables");
                conn.Close();
            }
            IList<DbTable> tables = new List<DbTable>();
            foreach (DataRow dr in ds.Tables["DbTables"].Rows)
            {
                DbTable table = new DbTable();
                table.Name = dr["table_name"].ToString();
                table.Comments = dr["comments"].ToString().Replace("\r", " ").Replace("\n", " ");
                tables.Add(table);
            }
            return tables;
        }
    }
}
