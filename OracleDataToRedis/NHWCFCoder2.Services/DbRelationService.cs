using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Services
{
    public class DbRelationService
    {
        private static DbRelationService _instance = new DbRelationService();
        private IDbRelationDao relationDao;
        private DbRelationService()
        {
            string daoPath = DataBaseHelper.GetDaoPath(DataBaseHelper.CurrentDbType);
            relationDao = (IDbRelationDao)Assembly.Load(daoPath).CreateInstance(daoPath + ".DbRelationDao");
        }

        /// <summary>
        /// 获得单件模式对象
        /// </summary>
        public static DbRelationService Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 设置对应表与主表关系
        /// </summary>
        /// <param name="table">表</param>
        /// <returns>关系集合</returns>
        public DbTable SetParentRelations(DbTable table, IList<DbTable> allTables)
        {
            IList<DbRelation> relations = relationDao.GetParentRelations(table.Name);
            table.ParentRelations.Clear();
            foreach (DbRelation rlt in relations)
            {
                rlt.ChildTable = table;
                foreach (DbTable dt in allTables)
                {
                    if (dt.Name == rlt.ParentTableName)
                    {
                        rlt.ParentTable = dt;
                        rlt.ParentTable.ChildRelations.Add(rlt);
                        table.ParentRelations.Add(rlt);
                        break;
                    }
                }                
            }
            return table;
        }

        /// <summary>
        /// 获取对应关系的自增标识
        /// </summary>
        /// <param name="dt"></param>
        public void SetRelationIncrementalValue(DbTable dt)
        {
            foreach (DbRelation rl in dt.ParentRelations)
            {
                int i = 1;
                foreach (DbRelation r in dt.ParentRelations)
                {
                    if (r.ParentTable.Name == rl.ParentTable.Name)
                    {
                        r.IncrementalValue = i;
                        i++;
                    }
                }
            }

            foreach (DbRelation rl in dt.ChildRelations)
            {
                int i = 1;
                foreach (DbRelation r in dt.ChildRelations)
                {
                    if (r.ChildTable.Name == rl.ChildTable.Name)
                    {
                        r.IncrementalValue = i;
                        i++;
                    }
                }
            }
        }
    }
}
