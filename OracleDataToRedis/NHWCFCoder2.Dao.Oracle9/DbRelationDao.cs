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
    public class DbRelationDao : IDbRelationDao
    {
        /// <summary>
        /// 获取对应表与主表关系
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>关系集合</returns>
        public IList<DbRelation> GetParentRelations(string tableName)
        {
            string sql = "SELECT   c2.table_name, c1.constraint_name, c1.r_constraint_name, c1.status"
                       + "     FROM user_constraints c1, user_constraints c2"
                       + "    WHERE c1.table_name = '" + tableName + "'"
                       + "      AND c1.constraint_type = 'R'"
                       + "      AND c2.constraint_name = c1.r_constraint_name"
                       + "      AND c2.constraint_type IN ('P', 'U')"
                       + " ORDER BY c2.table_name, c1.constraint_name";
            DataSet ds = new DataSet();
            using (OracleConnection conn = new OracleConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "ParentRelations");
                conn.Close();
            }
            IList<DbRelation> relations = new List<DbRelation>();
            foreach (DataRow dr in ds.Tables["ParentRelations"].Rows)
            {
                DbRelation rlt = new DbRelation();
                rlt.ChildConstraintName = dr["constraint_name"].ToString();
                rlt.ParentConstraintName = dr["r_constraint_name"].ToString();
                rlt.ParentTableName = dr["table_name"].ToString();
                relations.Add(rlt);
            }
            return relations;
        }

    }
}
