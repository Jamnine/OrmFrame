using System;
using System.Collections.Generic; 
using System.Linq.Expressions; 

namespace Orm.Framework.Services
{
    public interface IDBLambdaBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        int Delete<T>(Expression<Func<T, bool>> exp, bool IsTrn = false) where T : Orm.Model.BaseModel, new();
        T Get<T>(Func<T, bool> exp) where T : Orm.Model.BaseModel, new();

        bool IsExist<T>(Expression<Func<T, bool>> exp) where T : Orm.Model.BaseModel, new();

        /// <summary>
        /// Update<Model.BsUser>(new { name = "测试" }, m => m.Name == "scott");
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update<T>(object update, Expression<Func<T, bool>> where) where T : Orm.Model.BaseModel, new();

        List<T> GetList<T>(Expression<Func<T, bool>> exp) where T : class, new();
    }
}
