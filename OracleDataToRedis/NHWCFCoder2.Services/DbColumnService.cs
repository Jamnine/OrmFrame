using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Dao.Interface;

namespace OracleDataToRedis.Services
{
    public class DbColumnService
    {

        private static DbColumnService _instance = new DbColumnService();
        private IDbColumnDao columnDao;
        private DbColumnService()
        {
            string daoPath = DataBaseHelper.GetDaoPath(DataBaseHelper.CurrentDbType);
            columnDao = (IDbColumnDao)Assembly.Load(daoPath).CreateInstance(daoPath + ".DbColumnDao");
        }

        /// <summary>
        /// 获得单件模式对象
        /// </summary>
        public static DbColumnService Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 设置表的列信息
        /// </summary>
        /// <param name="table">表名</param>
        /// <returns>对应表</returns>
        public DbTable SetColumns(DbTable table)
        {
            IList<DbColumn> columns = this.columnDao.GetColumns(table.Name);
            foreach (DbColumn dc in columns)
            {
                dc.Table = table;
                dc.IsGenerateField = !(dc.TitleCaseName == "DataVersion" || dc.TitleCaseName == "DataCreateTime" || dc.TitleCaseName == "DataUpdateTime");
            }
            table.Columns = columns;
            return table;
        }

        /// <summary>
        /// 设置索引的列信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DbIndex SetIndexColumns(DbIndex index)
        {
            IList<string> columns = this.columnDao.GetIndexColumns(index.Name, index.Table.Name);
            index.Columns.Clear();
            foreach (string colname in columns)
            {
                foreach (DbColumn dc in index.Table.Columns)
                {
                    if (colname == dc.Name)
                    {
                        if (dc.IsPrimaryKey == false)
                            dc.IsPrimaryKey = index.IsPrimaryKey;
                        index.Columns.Add(dc);
                        break;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// 设置主表关系的列信息
        /// </summary>
        /// <param name="relation">主表关系</param>
        /// <returns>关系对象</returns>
        public DbRelation SetParentRelationColumns(DbRelation relation)
        {
            IList<string> columns = this.columnDao.GetParentRelationColumns(relation.ParentConstraintName, relation.ParentTable.Name);
            relation.ParentColumns.Clear();
            foreach (string colname in columns)
            {
                foreach (DbColumn dc in relation.ParentTable.Columns)
                {
                    if (colname == dc.Name)
                    {
                        relation.ParentColumns.Add(dc);
                        break;
                    }
                }
            }
            return relation;
        }


        /// <summary>
        /// 设置从表关系的列信息
        /// </summary>
        /// <param name="relation">从表关系</param>
        /// <returns>关系对象</returns>
        public DbRelation SetChildRelationColumns(DbRelation relation)
        {
            IList<string> columns = this.columnDao.GetChildRelationColumns(relation.ChildConstraintName, relation.ChildTable.Name);
            relation.ChildColumns.Clear();
            foreach (string colname in columns)
            {
                foreach (DbColumn dc in relation.ChildTable.Columns)
                {
                    if (colname == dc.Name)
                    {
                        dc.IsForeignKey = true;
                        dc.IsGenerateField = dc.IsPrimaryKey;
                        relation.ChildColumns.Add(dc);
                        break;
                    }
                }
            }
            return relation;
        }
    }
}
