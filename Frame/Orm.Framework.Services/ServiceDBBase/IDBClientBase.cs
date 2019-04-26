using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Orm.Model;

namespace Orm.Framework.Services
{
    public interface IDBClientBase
    {
        /// <summary>
        /// 新增表集合数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityList"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        void Add<T>(List<T> entityList, bool IsTrn = false) where T : BaseModel, new();

        /// <summary>
        /// 新增实体类
        /// </summary>
        /// <typeparam name="T">实体类类型</typeparam>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        string Add<T>(T entity) where T : BaseModel, new();

        void Commit(Action action);
        IDataPersist DataRepository();

        /// <summary>
        /// 删除表集合数据
        /// </summary>
        /// <param name="Lstentity"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        bool Delete<T>(List<T> Lstentity, bool IsTrn = false) where T : BaseModel, new();

        int DeleteModelByGuid<T>(string guid) where T : BaseModel, new();

        T Get<T>(string where, params object[] arr) where T : BaseModel, new();
        List<T> GetAllList<T>() where T : class, new();
        List<T> GetAllList<T>(int startIndex, int stopIndex) where T : class, new();

        List<T> GetAllList<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new();

        List<T> GetListByEnum<T, T2>(List<T2> list, string getProperty, string Parameter) where T : BaseModel, new() where T2 : BaseModel, new();

        int GetAllListCount<T>() where T : class, new();

        List<T> GetPageList<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new();

        List<T> GetPageList<T>() where T : class, new();

        int GetPageListCount<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new();

        T GetByLambda<T>(string lambdaExpression, params string[] ns) where T : BaseModel, new();
        List<object> GetDynamic<T>(string lambdaExpression, string selectExp, params string[] ns) where T : BaseModel, new();

        List<T> GetList<T>(string where, params object[] arr) where T : class, new();
        List<T> GetListByLambda<T>(string lambdaExpression, params string[] ns) where T : BaseModel, new();



        int GetMaxField<T>(string exp, params string[] ns) where T : BaseModel, new();
        T GetModelByGuid<T>(string guid) where T : Orm.Model.BaseModel, new();
        T GetModelByID<T>(int id) where T : Orm.Model.BaseModel, new();
        DateTime GetServerTime();

        string NewId();
        /// <summary>
        /// 保存一个集合
        /// </summary>
        /// <param name="Lstentity"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        bool Save(IEnumerable<Orm.Model.BaseModel> Lstentity, bool IsTrn = false);

        bool Save(Orm.Model.BaseModel entity, bool IsTrn = false);

        /// <summary>
        /// 保存父子表，如果已经存在就修改,返回主表的ID
        /// </summary>
        /// <typeparam name="T">父表类型</typeparam>
        /// <typeparam name="TChild">子表类型</typeparam>
        /// <param name="parentObj">父对象</param>
        /// <param name="list">子表</param>
        /// <param name="relationKey">子表的关系键</param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        string SaveChild<T, TChild>(T parentObj, List<TChild> list, string relationKey, bool IsTrn = false) where T : BaseModel, new() where TChild : BaseModel, new();
        void SetDbKey(string dbKey);

        int Delete<T>(string lambdaExpression, params string[] ns) where T : BaseModel, new();


        /// <summary>
        /// 修改实体类
        /// </summary>
        /// <param name="entity">短信模板类</param>
        /// <returns></returns>
        bool Update(object entity);

        /// <summary>
        /// 更新集合数据,true函数体内加事务，false或不传外部加事务
        /// </summary>
        /// <param name="Lstentity"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        bool Update(IEnumerable<Orm.Model.BaseModel> Lstentity, bool IsTrn = false);

        bool IsExist<T>(string where, params object[] arr) where T : class, new();

        int GetListCount<T>(string where, params object[] arr) where T : class, new();

        DataTable ExecuteDataTable(string sql);

        int ExecuteNonQuery(string sql);

        DbDataReader ExecuteReader(string sql);

        int GetSeq(string seqName);

        ELinq.DbContext GetCurrentDBContext();
        /// <summary>
        /// 检查业务表是否加入缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TableName"></param>
        /// <returns>RedisType:Hash,Sets,CacheType:Sing:一条数据，List:多个数据,</returns>
        Tuple<bool, string, string> ChkBusicCacheTable<T>(string TableName = "");

        bool InsertOrUpdate<T>(T entity) where T : BaseModel, new();

        bool InsertOrUpdate<T>(IEnumerable<T> entities, bool IsTrn = false) where T : BaseModel, new();
    }
}
