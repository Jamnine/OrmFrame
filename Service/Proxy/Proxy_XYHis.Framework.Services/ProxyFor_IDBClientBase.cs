using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Orm.Framework.Services;
using Orm.Model;

namespace Proxy_Orm.Framework.Services
{
    public class ProxyFor_IDBClientBase : WebBridgeEndpoint.ProxyBase, IDBClientBase
    {

        public void Add<T>(List<T> entityList, System.Boolean IsTrn) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entityList);
            ParamList.Add(IsTrn);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Add<T>", ParamList, TypeArgs, GetOneUrl());
        }

        //public System.Int32 Add<T>(T entity) where T : Orm.Model.BaseModel, new()
        //{
        //    List<Object> ParamList = new List<Object>();
        //    ParamList.Add(entity);
        //    var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
        //    return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Add<T>", ParamList, TypeArgs, GetOneUrl());
        //}

        public System.Int32 AddChild<T, TChild>(T entity, List<TChild> children, System.Boolean IsTrn) where T : Orm.Model.BaseModel, new() where TChild : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entity);
            ParamList.Add(children);
            ParamList.Add(IsTrn);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName, typeof(TChild).AssemblyQualifiedName };
            return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "AddChild<T,TChild>", ParamList, TypeArgs, GetOneUrl());
        }

        public void Commit(System.Action action)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(action);
            string[] TypeArgs = null;
            TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Commit", ParamList, TypeArgs, GetOneUrl());
        }

        public Orm.Framework.Services.IDataPersist DataRepository()
        {
            List<Object> ParamList = new List<Object>();
            string[] TypeArgs = null;
            return (Orm.Framework.Services.IDataPersist)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "DataRepository", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Boolean Delete<T>(List<T> Lstentity, System.Boolean IsTrn) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(Lstentity);
            ParamList.Add(IsTrn);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (System.Boolean)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Delete<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Int32 Delete<T>(System.String lambdaExpression, System.String[] ns) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(lambdaExpression);
            ParamList.Add(ns);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Delete<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Int32 DeleteModelByGuid<T>(string id) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(id);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "DeleteModelByGuid<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public T Get<T>(System.String where, System.Object[] arr) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (T)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Get<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetAllList<T>() where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetAllList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetAllList<T>(System.Int32 startIndex, System.Int32 stopIndex) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(startIndex);
            ParamList.Add(stopIndex);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetAllList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetAllList<T>(System.Int32 startIndex, System.Int32 stopIndex, System.String where, System.Object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(startIndex);
            ParamList.Add(stopIndex);
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetAllList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public T GetByLambda<T>(System.String lambdaExpression, System.String[] ns) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(lambdaExpression);
            ParamList.Add(ns);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (T)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetByLambda<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Collections.Generic.List<System.Object> GetDynamic<T>(System.String lambdaExpression, System.String selectExp, System.String[] ns) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(lambdaExpression);
            ParamList.Add(selectExp);
            ParamList.Add(ns);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (System.Collections.Generic.List<System.Object>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetDynamic<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetList<T>(System.String where, System.Object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetListByLambda<T>(System.String lambdaExpression, System.String[] ns) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(lambdaExpression);
            ParamList.Add(ns);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetListByLambda<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Int32 GetMaxField<T>(System.String exp, System.String[] ns) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(exp);
            ParamList.Add(ns);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetMaxField<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public T GetModelByGuid<T>(string id) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(id == null ? string.Empty : id);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (T)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetModelByGuid<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public System.DateTime GetServerTime()
        {
            List<Object> ParamList = new List<Object>();
            string[] TypeArgs = null;
            return (System.DateTime)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetServerTime", ParamList, TypeArgs, GetOneUrl());
        }

        public System.String NewId()
        {
            List<Object> ParamList = new List<Object>();
            string[] TypeArgs = null;
            return (System.String)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "NewId", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Boolean Save(System.Collections.Generic.IEnumerable<Orm.Model.BaseModel> Lstentity, System.Boolean IsTrn)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(Lstentity);
            ParamList.Add(IsTrn);
            string[] TypeArgs = null;
            return (System.Boolean)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Save", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Boolean Save(Orm.Model.BaseModel entity, System.Boolean IsTrn)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entity);
            ParamList.Add(IsTrn);
            string[] TypeArgs = null;
            return (System.Boolean)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Save", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Int32 SaveChild<T, TChild>(T parentObj, List<TChild> list, System.String relationKey, System.Boolean IsTrn)
            where T : Orm.Model.BaseModel, new()
            where TChild : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(parentObj);
            ParamList.Add(list);
            ParamList.Add(relationKey);
            ParamList.Add(IsTrn);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName, typeof(TChild).AssemblyQualifiedName };
            return (System.Int32)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "SaveChild<T,TChild>", ParamList, TypeArgs, GetOneUrl());
        }

        public void SetDbKey(System.String dbKey)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(dbKey);
            string[] TypeArgs = null;
            TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "SetDbKey", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Boolean Update(System.Object entity)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entity);
            string[] TypeArgs = null;
            return (System.Boolean)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Update", ParamList, TypeArgs, GetOneUrl());
        }

        public System.Boolean Update(IEnumerable<Orm.Model.BaseModel> Lstentity, System.Boolean IsTrn)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(Lstentity);
            ParamList.Add(IsTrn);
            string[] TypeArgs = null;
            return (System.Boolean)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Update", ParamList, TypeArgs, GetOneUrl());
        }


        public bool IsExist<T>(string where, params object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (bool)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "IsExist<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public string Add<T>(T entity) where T : Orm.Model.BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entity);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (string)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "Add<T>", ParamList, TypeArgs, GetOneUrl());
        }
        string IDBClientBase.SaveChild<T, TChild>(T parentObj, List<TChild> list, string relationKey, bool IsTrn)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(parentObj);
            ParamList.Add(list);
            ParamList.Add(relationKey);
            ParamList.Add(IsTrn);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName, typeof(TChild).AssemblyQualifiedName };
            return (string)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "SaveChild<T,TChild>", ParamList, TypeArgs, GetOneUrl());
        }

        public T GetModelByID<T>(int id) where T : BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(id);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (T)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetModelByID<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public int GetAllListCount<T>() where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (int)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetAllListCount<T>", ParamList, TypeArgs, GetOneUrl());
        }


        public List<T> GetListByEnum<T, T2>(List<T2> list, string getProperty, string Parameter) where T : BaseModel, new() where T2 : BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(list);
            ParamList.Add(getProperty);
            ParamList.Add(Parameter);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetListByEnum<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetPageList<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(startIndex);
            ParamList.Add(stopIndex);
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetPageList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public List<T> GetPageList<T>() where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (List<T>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetPageList<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public int GetPageListCount<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(startIndex);
            ParamList.Add(stopIndex);
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (int)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetPageListCount<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public int GetListCount<T>(string where, params object[] arr) where T : class, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(where);
            ParamList.Add(arr);
            var TypeArgs = new string[] { typeof(T).AssemblyQualifiedName };
            return (int)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "GetListCount<T>", ParamList, TypeArgs, GetOneUrl());
        }

        public DataTable ExecuteDataTable(string sql)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(sql);
            string[] TypeArgs = null;
            return (DataTable)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "ExecuteDataTable", ParamList, TypeArgs, GetOneUrl());
        }

        public int ExecuteNonQuery(string sql)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(sql);
            string[] TypeArgs = null;
            return (int)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "ExecuteNonQuery", ParamList, TypeArgs, GetOneUrl());
        }

        public DbDataReader ExecuteReader(string sql)
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(sql);
            string[] TypeArgs = null;
            return (DbDataReader)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "ExecuteReader", ParamList, TypeArgs, GetOneUrl());
        }

        public ELinq.DbContext GetCurrentDBContext()
        {
            return null;
        }

        public int GetSeq(string seqName)
        {
            throw new NotImplementedException();
        }

        public Tuple<bool, string, string> ChkBusicCacheTable<T>(string TableName = "")
        {
            throw new NotImplementedException();
        }

        public bool InsertOrUpdate<T>(T entity) where T : BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entity);
            string[] TypeArgs = null;
            return (bool)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "InsertOrUpdate", ParamList, TypeArgs, GetOneUrl());
        }

        public bool InsertOrUpdate<T>(IEnumerable<T> entities, bool IsTrn = false) where T : BaseModel, new()
        {
            List<Object> ParamList = new List<Object>();
            ParamList.Add(entities);
            ParamList.Add(IsTrn);
            string[] TypeArgs = null;
            return (bool)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.Framework.Services.IDBClientBase", "InsertOrUpdate", ParamList, TypeArgs, GetOneUrl());
        }
    }
}
