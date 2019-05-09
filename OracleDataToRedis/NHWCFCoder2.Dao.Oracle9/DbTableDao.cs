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
    public class DbTableDao : IDbTableDao
    {
        /// <summary>
        /// 获取所有的表信息
        /// </summary>
        /// <returns>表格对象集合</returns>
        public IList<DbTable> GetAllOfTables()
        {
            string sql = "SELECT t.table_name, c.table_type, c.comments"
               + " FROM user_tables t, user_tab_comments c"
               + " WHERE t.table_name NOT LIKE 'BIN$%'"
               + "   AND c.table_name = t.table_name"
               + "   AND c.table_type = 'TABLE'"
               + " ORDER BY t.table_name";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
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
