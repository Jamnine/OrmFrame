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
    public class DbIndexDao : IDbIndexDao
    {
        /// <summary>
        /// 获取对应表的索引
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>对应索引集合</returns>
        public IList<DbIndex> GetIndexes(string tableName)
        {
            string sql = "SELECT idx.index_name, idx.table_name, idx.uniqueness, cons.constraint_type"
                + "    FROM user_indexes idx"
                + "    LEFT JOIN sys.all_constraints cons ON idx.index_name = cons.index_name"
                + "   WHERE idx.table_name = '" + tableName + "'"
                + "   ORDER BY index_name";

            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "DbIndexs");
                conn.Close();
            }
            IList<DbIndex> indexes = new List<DbIndex>();
            foreach (DataRow dr in ds.Tables["DbIndexs"].Rows)
            {
                DbIndex di = new DbIndex();
                di.Name = dr["index_name"].ToString();
                di.IsUnique = (dr["uniqueness"].ToString().ToUpper() == "UNIQUE");
                di.ConstraintType = dr["constraint_type"].ToString();
                di.IsPrimaryKey = (di.ConstraintType.ToUpper() == "P");
                indexes.Add(di);
            }

            return indexes;
        }
    }
}
