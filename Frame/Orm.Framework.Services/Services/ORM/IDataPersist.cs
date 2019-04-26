using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 持久化数据接口。
    /// </summary>
    public interface IDataPersist
    {
        /// <summary>
        /// 返回查询对象
        /// </summary>
        /// <typeparam name="T">己映射的类型</typeparam>
        /// <returns>可查接口</returns>
        IQueryable<T> GetQueryable<T>() where T : class,new();

        /// <summary>
        /// 添加一个实体，要求存在实体类型到数据库表的映射。
        /// </summary>
        /// <param name="entity">要添加的实体</param>
        void Add(object entity);

        /// <summary>
        /// 修改与参数有相同键的实体，要求存在实体类型到数据库表的映射。
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <returns>是否修改成功</returns>
        bool Update(object entity);

        /// <summary>
        /// 按条件修改实体对象的部分字段
        /// </summary>
        /// <typeparam name="T">己映射的类型</typeparam>
        /// <param name="update">要更样的列</param>
        /// <param name="where">条件表达式</param>
        /// <returns>受影响的记录数。</returns>
        int Update<T>(object update, Expression<Func<T, bool>> where)
            where T : class;

        /// <summary>
        /// 删除指定实体。
        /// </summary>
        /// <param name="entity">要删除的实体</param>
        /// <returns>是否能功</returns>
        bool Delete(object entity);

        /// <summary>
        /// 按条件删除
        /// </summary>
        /// <typeparam name="T">己映射的类型</typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        int Delete<T>(Expression<Func<T, bool>> where) where T : class;

        /// <summary>
        /// 工作单元。
        /// </summary>
        void WorkUnitAct(Action act, IsolationLevel isolationLevel = IsolationLevel.Unspecified);

        /// <summary>
        /// Sql帮助类。
        /// </summary>
        ISqlHelper SqlHelper { get; }

        /// <summary>
        /// 获取实体的映射成员
        /// </summary>
        /// <param name="entity">实体</param>
        ELinq.Mapping.IMemberMapping[] GetMappingMembers(object entity);

        /// <summary>
        /// 批量插入记录
        /// </summary>
        /// <param name="dt">要插入的数据</param>
        /// <param name="targetTable">数据库中的表</param>
        void BulkToDB(DataTable dt, string targetTable);

        ELinq.DbContext GetCurrentDBContext();
    }
}