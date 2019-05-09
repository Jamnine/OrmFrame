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
    public class DbRelationDao : IDbRelationDao
    {
        /// <summary>
        /// 获取对应表与主表关系
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>关系集合</returns>
        public IList<DbRelation> GetParentRelations(string tableName)
        {
            string sql = "SELECT Object_name(fk.referenced_object_id) AS table_name,fk.name AS constraint_name,fk.name AS r_constraint_name,tbl.name AS comments"
                + " FROM   sys.tables AS tbl"
                + " INNER JOIN sys.foreign_keys AS fk ON fk.parent_object_id = tbl.object_id"
                + " WHERE  tbl.name = '" + tableName + "'";
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(DataBaseHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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
