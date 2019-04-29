using ELinq;
using Oracle.DataAccess.Client;
using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
namespace Orm
{
    internal class CommPersist : IDataPersist
    {
        private BaseDbContext _dbContext;
        internal static Dictionary<string, string> connectionDic = new Dictionary<string, string>();
        public string DbContextName
        {
            get;
            set;
        }
        public ISqlHelper SqlHelper
        {
            get
            {
                return new SqlHelperProxy(this._dbContext.DbHelper);
            }
        }
        public CommPersist(BaseDbContext pDbContext, string pDbContextName)
        {
            this._dbContext = pDbContext;
            this.DbContextName = pDbContextName;
        }
        public IQueryable<T> GetQueryable<T>() where T : class, new()
        {
            return this._dbContext.Set<T>();
        }
        public void Add(object entity)
        {
            this._dbContext.Set(entity.GetType()).Insert(entity);
        }
        public bool Update(object entity)
        {
            return this._dbContext.Set(entity.GetType()).Update(entity) == 1;
        }
        public int Update<T>(object update, Expression<Func<T, bool>> where) where T : class
        {
            return this._dbContext.Set<T>().Update(update, where);
        }
        public bool Delete(object entity)
        {
            System.Data.Common.DbCommand dbCommand = this._dbContext.Connection.CreateCommand();


            return this._dbContext.Set(entity.GetType()).Delete(entity) == 1;

        }
        public int Delete<T>(Expression<Func<T, bool>> where) where T : class
        {
            return this._dbContext.Set<T>().Delete(where);
        }
        public void WorkUnitAct(Action act, IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            this._dbContext.UsingTransaction(act, isolationLevel);
        }

        /// <summary>
        /// 获取实体的映射成员
        /// </summary>
        /// <param name="entity">实体</param>
        public ELinq.Mapping.IMemberMapping[] GetMappingMembers(object entity)
        {
            ELinq.Mapping.IMemberMapping[] mappingMembers = this._dbContext.DbConfiguration.GetClass(entity.GetType()).Members;
            return mappingMembers;
        }

        /// <summary>
        /// 批量插入记录
        /// </summary>
        /// <param name="dt">要插入的数据</param>
        /// <param name="targetTable">数据库中的表</param>
        public void BulkToDB(DataTable dt, string targetTable)
        {
            string connOrcleString = connectionDic[DbContextName];
            OracleConnection conn = new OracleConnection(connOrcleString);
            OracleBulkCopy bulkCopy = new OracleBulkCopy(connOrcleString, OracleBulkCopyOptions.UseInternalTransaction);   //用其它源的数据有效批量加载Oracle表中
            bulkCopy.BulkCopyTimeout = 260;
            bulkCopy.DestinationTableName = targetTable;    //服务器上目标表的名称
            bulkCopy.BatchSize = dt.Rows.Count;   //每一批次中的行数
                                                  //自定义的datatable和数据库的字段进行对应
            foreach (DataColumn column in dt.Columns)
            {
                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
            }
            try
            {
                conn.Open();
                if (dt != null && dt.Rows.Count != 0)

                    bulkCopy.WriteToServer(dt);  //将提供的数据源中的所有行复制到目标表中
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                if (bulkCopy != null)
                    bulkCopy.Close();
            }
        }

        public DbContext GetCurrentDBContext()
        {
            throw new NotImplementedException();
        }
    }
}
