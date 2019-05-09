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
    public class DbIndexDao : IDbIndexDao
    {
        /// <summary>
        /// 获取对应表的索引
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>对应索引集合</returns>
        public IList<DbIndex> GetIndexes(string tableName)
        {
            string sql = "SELECT idx.name as index_name, tbl.name as table_name, idx.is_unique, idx.is_primary_key"
                + " FROM   sys.tables tbl"
                + "        INNER JOIN sys.indexes idx ON tbl.object_id = idx.object_id and idx.index_id > 0"
                + " WHERE  tbl.name = '" + tableName + "'";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "DbIndexs");
                conn.Close();
            }
            IList<DbIndex> indexes = new List<DbIndex>();
            foreach (DataRow dr in ds.Tables["DbIndexs"].Rows)
            {
                DbIndex di = new DbIndex();
                di.Name = dr["index_name"].ToString();
                di.IsUnique = (dr["is_unique"].ToString().ToLower() == "true");
                di.IsPrimaryKey = (dr["is_primary_key"].ToString().ToLower() == "true"); 
                di.ConstraintType = (di.IsPrimaryKey == true) ? "P" : "";
                indexes.Add(di);
            }

            return indexes;
        }
    }
}
