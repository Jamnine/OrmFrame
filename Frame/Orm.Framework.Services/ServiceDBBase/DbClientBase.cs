using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using Orm.Framework.Services;
using Orm.Framework.Services.ServiceDBBase;
using Orm.Log4Library;
using Orm.Model;
using Orm.Redis;

namespace Orm.Framework.Services
{
    public partial class DBClientBase : IDBClientBase
    {
        protected IDataPersist _db = null;
        protected string _dbKey = string.Empty;

        public static Assembly _assembly = Assembly.Load(@"Orm.Model");
        public static Type[] _classTableTypes = _assembly.GetTypes();
        //  public RefreshBaseModelCaches refreshBaseModelCaches = new RefreshBaseModelCaches();

        protected ISysParamService _SysParam;
        public ISysParamService SysParam
        {
            get
            {
                if (_SysParam == null)
                    _SysParam = new SysParamService();
                return _SysParam;
            }
        }

        public DBClientBase(string dbKey)
        {
            if (string.IsNullOrWhiteSpace(dbKey))
            {
                _dbKey = AppSettings.ConfigDB_Key;
            }
            else
            {
                _dbKey = dbKey;
            }
        }
        public DBClientBase()
        {
            _dbKey = AppSettings.ConfigDB_Key;
        }
        public void SetDbKey(string dbKey)
        {
            _dbKey = dbKey;
            _db = null;
        }
        public IDataPersist DataRepository()
        {

            if (_db == null)
            {
                _db = ServiceTaker.GetService<IDataPersist>(_dbKey);
            }
            return _db;
        }

        #region 查询一张表的某一列最大值，在服务器完成

        public int GetMaxField<T>(string exp, params string[] ns) where T : BaseModel, new()
        {
            Expression<Func<T, int>> lamb = LambdaParser.Parse<Func<T, int>>(exp, ns);
            var _dal = DataRepository().GetQueryable<T>().Max(lamb);
            return _dal;
        }

        #endregion

        #region 检查业务表是否加入缓存
        /// <summary>
        /// 检查业务表是否加入缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TableName"></param>
        /// <returns>RedisType:Hash,Sets,CacheType:Sing:一条数据，List:多个数据,</returns>
        public Tuple<bool, string, string> ChkBusicCacheTable<T>(string TableName = "")
        {
            try
            {
                string SrvUrl = ConfigurationManager.AppSettings["ServiceAddress"].Replace("/Handler.api", "/");
                //string PathSrv = ConfigurationManager.AppSettings["ServiceAddress"];// HttpContext.Current.Server.MapPath("~/");
                string PathFile = string.Format("{0}{1}", SrvUrl, "BusicTable.Cache.xml");
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(PathFile);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(PathFile);
                XmlNode node = xmlDoc.DocumentElement;
                XmlNode appNote = node.SelectSingleNode("table");
                XmlNodeList appNoteList = appNote.ChildNodes;
                if (appNoteList != null)
                {
                    foreach (XmlNode tmpNote in appNoteList)
                    {
                        string ls_Key = tmpNote.Attributes["Table"].Value;
                        bool ls_UseStatus = Convert.ToBoolean(tmpNote.Attributes["UseStatus"].Value);
                        string ls_RedisType = tmpNote.Attributes["RedisType"].Value;
                        string ls_CacheType = tmpNote.Attributes["CacheType"].Value;
                        if (string.IsNullOrWhiteSpace(TableName))
                        {
                            var TypeArg = typeof(T).GenericTypeArguments;
                            TableName = TypeArg.Count() <= 0 ? typeof(T).Name : TypeArg[0].Name;
                        }
                        if (ls_Key.ToUpper().Equals(TableName.ToUpper()) && ls_UseStatus)
                            return new Tuple<bool, string, string>(true, ls_RedisType, ls_CacheType);
                    }
                }
            }
            catch (Exception er) { }
            return new Tuple<bool, string, string>(false, string.Empty, string.Empty);
        }
        #endregion

        #region 根据传入字段，查询一张表的数据，在服务器里完成查询
        /// <summary>
        /// 根据传入字段，在服务器里查询出来，并返回List（object）类型
        /// </summary>
        /// <typeparam name="T">对应一个数据实体</typeparam>
        /// <param name="lambdaExpression">Where条件，可为空</param>
        /// <param name="selectExp">要查询的字段</param>
        /// <param name="ns">model的命名空间</param>
        /// <returns></returns>
        public List<object> GetDynamic<T>(string lambdaExpression, string selectExp, params string[] ns) where T : BaseModel, new()
        {
            IQueryable query;
            if (!string.IsNullOrEmpty(lambdaExpression))
            {
                Expression<Func<T, bool>> lamb = LambdaParser.Parse<Func<T, bool>>(lambdaExpression, ns);
                query = DataRepository().GetQueryable<T>().Where(lamb).Select(selectExp);
            }
            else
            {
                query = DataRepository().GetQueryable<T>().Select(selectExp);
            }

            var em = query.GetEnumerator();
            List<object> lstResult = new List<object>();
            while (em.MoveNext())
            {
                lstResult.Add(em.Current);
            }

            return lstResult;
        }
        #endregion

        #region 查询单个

        /// <summary>
        /// 传入查询字段条件，查询,例：Get<BsUser>("Code = @0 or Code=@1", "251","999999");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="arr">条件的值</param>
        /// <returns></returns>
        public T Get<T>(string where, params object[] arr) where T : BaseModel, new()
        {
            string modelTypeStr = typeof(T).Name;
            IQueryable<T> models;
            //var IsExist = IsExist<BsRedisTable>("TableName=@0", modelTypeStr);
            //if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
            //{//如果是基础数据，从本地redis中获取数据
            //    try
            //    {   //构建pattern
            //        string pattern = GetPattern<T>(where, modelTypeStr, arr);
            //        if (pattern != "")
            //        {//pattern如果为空，将从数据库中查询
            //            List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
            //            if (list != null && list.Count() > 0)
            //            {
            //                return list[0];
            //            }
            //            else
            //            {
            //                models = DataRepository().GetQueryable<T>().Where(where, arr);
            //                if (models != null && models.Count() > 0)
            //                {
            //                    return models.ElementAt(0);
            //                }
            //                else
            //                {
            //                    return null;
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {//如果出现异常，将从数据库中查询
            //        LogHelper.ErrorLog(ex.ToString());
            //    }
            //}
            models = DataRepository().GetQueryable<T>().Where(where, arr);
            if (models != null && models.Count() > 0)
            {
                return models.ElementAt(0);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 传入查询Lambda表达式的字符串,例：GetByLambda &lt;BsUser&gt;("t=>t.Code==\"251\" || t.Code==\"999999\"", "Orm.Model");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="lambdaExpression">查询Lambda表达式的字符串</param>
        /// <param name="ns">用到的命名空间</param>
        /// <returns></returns>
        public T GetByLambda<T>(string lambdaExpression, params string[] ns) where T : Orm.Model.BaseModel, new()
        {
            Expression<Func<T, bool>> lamb = LambdaParser.Parse<Func<T, bool>>(lambdaExpression, ns);
            var models = DataRepository().GetQueryable<T>().Where(lamb);

            if (models != null && models.Count() > 0)
            {
                return models.ElementAt(0);
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 查询多个


        /// <summary>
        /// 传入查询字段条件，查询,例：GetList &lt;BsUser&gt;("Code = @0 or Code=@1", "251","999999");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="arr">条件的值</param>
        /// <returns></returns>
        public List<T> GetList<T>(string where, params object[] arr) where T : class, new()
        {
            string modelTypeStr = typeof(T).Name;
            IQueryable<T> models;
            //var IsExist = IsExist<BsRedisTable>("TableName=@0", modelTypeStr);
            //if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
            //{//如果是基础数据，从本地redis中获取数据
            //    try
            //    {   //构建pattern
            //        string pattern = GetPattern<T>(where, modelTypeStr, arr);
            //        if (pattern != "")
            //        {//pattern如果为空，将从数据库中查询
            //            List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
            //            if (list.Count>0)
            //                return list;
            //        }
            //    }
            //    catch (Exception ex)
            //    {//如果出现异常，将从数据库中查询
            //        LogHelper.ErrorLog(ex.ToString());
            //    }
            //}
            models = DataRepository().GetQueryable<T>().Where(where, arr);
            if (models != null && models.Count() > 0) return models.ToList();
            else
            {
                return new List<T>();
            }
        }
        /// <summary>
        /// 传入查询Lambda表达式的字符串,例：GetByLambda("t=>t.Code==\"251\" || t.Code==\"999999\"", "Orm.Model");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="lambdaExpression">查询Lambda表达式的字符串</param>
        /// <param name="ns">用到的命名空间</param>
        /// <returns></returns>
        public List<T> GetListByLambda<T>(string lambdaExpression, params string[] ns) where T : BaseModel, new()
        {
            Expression<Func<T, bool>> lamb = LambdaParser.Parse<Func<T, bool>>(lambdaExpression, ns);
            var models = DataRepository().GetQueryable<T>().Where(lamb);
            if (models != null && models.Count() > 0)
            {
                return models.ToList();
            }
            else
            {
                return new List<T>();
            }
        }
        /// <summary>
        /// 返回整表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetAllList<T>() where T : class, new() 
        {
            string modelTypeStr = typeof(T).Name;
            var IsExist = IsExist<BsRedisTable>("TableName=@0", modelTypeStr);
            if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL") || IsExist)
            {//如果是基础数据，从本地redis中获取数据
                List<T> list = RedisReadExHelper.RetrieveSet<T>(modelTypeStr);
                if (list.Count > 0)
                    return list;
            }
            try
            {
                var _dal = DataRepository().GetQueryable<T>();
                if (_dal != null)
                {
                    List<T> list = _dal.ToList();
                    return list;
                }
                else
                    return new List<T>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 返回整表数据(供DB数据导入到redis时使用)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetAllListUseInDataImport<T>() where T : class, new()
        {
            try
            {
                var _dal = DataRepository().GetQueryable<T>();
                if (_dal != null)
                {
                    List<T> list = _dal.ToList();
                    return list;
                }
                else
                    return new List<T>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 返回整表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetAllList<T>(int startIndex, int stopIndex) where T : class, new()
        {
            return this.GetAllList<T>(startIndex, stopIndex, string.Empty);
        }

        /// <summary>
        /// 返回整表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetAllList<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new()
        {
            IQueryable<T> _dal = null;
            if (string.IsNullOrEmpty(where))
                _dal = DataRepository().GetQueryable<T>().SkipT<T>(startIndex).TakeT<T>(stopIndex).OrderBy<T>("name");
            else
                _dal = DataRepository().GetQueryable<T>().Where(where, arr).SkipT<T>(startIndex).TakeT<T>(stopIndex).OrderBy<T>("name");
            if (_dal != null)
                return _dal.ToList();
            else
                return new List<T>();
        }
        #endregion

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public string Add<T>(T entity) where T : BaseModel, new()
        {
            entity.SetStringValue();
            if(entity.GetType().Name != "BsDoctor")
            entity.GUID = Guid.NewGuid().ToString("N");
            this.DataRepository().Add(entity);
            //TransformToInsertSQL(entity);
            string TableName = entity.GetType().Name;
            string modelTypeStr = entity.GetType().ToString().ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
            {
                AddEntityToRedis(entity);
                return entity.GUID;
            }
            return entity.GUID;
        }

        /// <summary>
        /// 新增实体_电白中医院网站
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public int Add_GetID<T>(T entity) where T : BaseModel, new()
        {
            entity.SetStringValue();
            entity.GUID = Guid.NewGuid().ToString("N");
            this.DataRepository().Add(entity);
            //TransformToInsertSQL(entity);
            string TableName = entity.GetType().Name;
            string modelTypeStr = entity.GetType().ToString().ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
            {
                AddEntityToRedis(entity);
                return entity.ID;
            }
            return entity.ID;
        }


        /// <summary>
        /// 新增实体_HuLi
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        public string Add_HuLi<T>(T entity) where T : Basics, new()
        {
            entity.SetStringValue();
            entity.GUID = Guid.NewGuid().ToString("N");
            this.DataRepository().Add(entity);
            //TransformToInsertSQL(entity);
            string TableName = entity.GetType().Name;
            string modelTypeStr = entity.GetType().ToString().ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);

            if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
            {
                AddEntityToRedis(entity);
                return entity.GUID;
            }
            return entity.GUID;
        }

        internal string TransformToInsertSQL<T>(T entity) where T : BaseModel, new()
        {
            string insertSQL = InsertSQL(entity);
            AppLogger.Log("insertSQL：" + insertSQL);
            return insertSQL;
        }

        public T GetModelByID<T>(int id) where T : BaseModel, new()
        {
            var model = this.DataRepository().GetQueryable<T>().FirstOrDefault(t => t.ID == id);
            return model == null ? new T() : model;
        }

        public T GetModelByGuid<T>(string guid) where T : BaseModel, new()
        {
            object model = this.DataRepository().GetQueryable<T>().FirstOrDefault(t => t.GUID == guid);
            return (T)model == null ? new T() : (T)model;
        }

        public T GetModeRedisByGuid<T>(string guid) where T : BaseModel, new()
        {
            object model;
            string modelTypeStr = typeof(T).Name;
            if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL"))
            {
                List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, guid, 10000);
                return list.Count == 0 ? GetModelByGuid<T>(guid) : list[0];
            }
            else
            {
                return GetModelByGuid<T>(guid);
            }

        }

        /// <summary>
        /// 根据ID删除表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteModelByGuid<T>(string guid) where T : BaseModel, new()
        {
            //string deleteSQL = DeleteModelByGuidSQL(typeof(T).Name, guid);
            //AppLogger.Log("DeleteModelByGuidSQL：" + deleteSQL);
            var entity = GetModelByGuid<T>(guid);
            int k = this.DataRepository().Delete<T>(t => t.GUID.ToString() == guid);
            string TableName = typeof(T).Name;
            string modelTypeStr = TableName.ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);

            if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist )
            {
                //if (k > 0)
                //{
                try
                {
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = typeof(T).Name,
                    //    EntityGuid = guid,
                    //    MessageBody = JsonConvert.SerializeObject(entity),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.RemoveEntryFromHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                    RedisWriteExHelper.SetRemove(typeof(T).Name, JsonConvert.SerializeObject(entity));
                    ////更新BaseModel.Caches
                    //Type classType = _classTableTypes.Where(t => t.Name == entity.GetType().Name).First();
                    //MethodInfo deleteEntityToCache = typeof(RefreshBaseModelCaches).GetMethod("DeleteEntityToCache").MakeGenericMethod(classType);
                    //deleteEntityToCache.Invoke(refreshBaseModelCaches, new object[] { guid });
                }
                catch (Exception ex)
                {
                    Log4Library.LogHelper.ErrorLog(ex.ToString());
                    throw (ex);
                }
                //}
                return k;
            }
            return k;
        }

        /// <summary>
        /// 传入删除Lambda表达式的字符串,例：Delete&lt;BsUser&gt;("t=>t.GUID==19496", "Orm.Model");
        /// </summary>
        /// <typeparam name="T">泛型，对应的实体</typeparam>
        /// <param name="lambdaExpression">删除Lambda表达式的字符串</param>
        /// <param name="ns">用到的命名空间</param>
        /// <returns></returns>
        public int Delete<T>(string lambdaExpression, params string[] ns) where T : BaseModel, new()
        {
            Expression<Func<T, bool>> lamb = LambdaParser.Parse<Func<T, bool>>(lambdaExpression, ns);
            string TableName = typeof(T).Name;
            string modelTypeStr = TableName.ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL") || IsExist)
            {
                    DeleteRedis<T>(lamb);
            }
            int k = DataRepository().Delete<T>(lamb);
            return k;
        }


        /// <summary>
        /// 返回LIST
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        private List<T> GetList<T>(Expression<Func<T, bool>> exp) where T : class, new()
        {
            IQueryable<T> _dal = DataRepository().GetQueryable<T>();
            return _dal.Where(exp).ToList();
        }


        /// <summary>
        /// 新增表集合数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityList"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        public void Add<T>(List<T> entityList, bool IsTrn = false) where T : BaseModel, new()
        {
            string TableName = typeof(T).Name;
            string modelTypeStr = TableName.ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            string ls_GuID = string.Empty;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    for (int i = 0; i < entityList.Count; i++)
                    {
                        ls_GuID = entityList[i].GUID;
                        this.DataRepository().Add(entityList[i]);
                        //TransformToInsertSQL(entityList[i]);
                    }
                };
                Commit(action);
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
                {
                    AddListToRedis(entityList);
                    return;
                }
            }
            else
            {
                for (int i = 0; i < entityList.Count; i++)
                {
                    ls_GuID = entityList[i].GUID;
                    this.DataRepository().Add(entityList[i]);
                    //TransformToInsertSQL(entityList[i]);
                    if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
                    {
                        AddEntityToRedis<T>(entityList[i]);
                    }
                }
            }
        }

        /// <summary>
        /// 保存父子表，如果已经存在就修改,返回主表的ID
        /// </summary>
        /// <typeparam name="ModelChild">子表类型</typeparam>
        /// <param name="parentObj">父对象</param>
        /// <param name="list">子表</param>
        /// <param name="relationKey">子表的关系键</param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        public string SaveChild<T, TChild>(T parentObj, List<TChild> list, string relationKey, bool IsTrn = false) where T : BaseModel, new() where TChild : BaseModel, new()
        {
            string TableName=  typeof(T).Name;
            string modelTypeStr = TableName.ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            string returns = null;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = SaveChildList(parentObj, list, relationKey);
                };
                Commit(action);
                //if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
                //{
                //    AddEntityToRedis(parentObj);
                //    AddListToRedis(list);
                //    return returns;
                //}
            }
            else
            {
                returns = SaveChildList(parentObj, list, relationKey);
            }
            return returns;
        }

        #region 删除

        /// <summary>
        /// 在事务在删除集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Lstentity"></param>
        /// <param name="IsTrn"></param>
        /// <returns></returns>
        public bool Delete<T>(List<T> Lstentity, bool IsTrn = false) where T : Orm.Model.BaseModel, new()
        {
            string TableName = typeof(T).Name;
            string modelTypeStr = TableName.ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);
            bool returns = false;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = DeleteList(Lstentity);
                };
                Commit(action);
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
                {
                    DeleteRedis<T>(Lstentity);
                    return returns;
                }
            }
            else
            {
                returns = DeleteList(Lstentity);
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")||IsExist)
                {
                    DeleteRedis<T>(Lstentity);
                    return returns;
                }
            }
            return returns;
        }

        public bool Delete<T>(T t, bool IsTrn = false) where T : BaseModel, new()
        {
            string modelTypeStr = typeof(T).Name.ToUpper();
            bool returns = false;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = DataRepository().Delete(t);
                };
                Commit(action);
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL"))
                {
                    DeleteRedis<T>(t);
                    return returns;
                }
            }
            else
            {
                returns = DataRepository().Delete(t);
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL"))
                {
                    DeleteRedis<T>(t);
                    return returns;
                }
            }
            return returns;
        }
        #endregion


        /// <summary>
        /// 修改实体类
        /// </summary>
        /// <param name="entity">短信模板类</param>
        /// <returns></returns>
        public bool Update(object entity)
        {
            //TransformToUpdateSQL(entity);
            bool k = DataRepository().Update(entity);
            string TableName = entity.GetType().Name;
            string modelTypeStr = entity.GetType().ToString().ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);

            if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
            {
                if (k)
                    UpdateRedis(entity);
            }
            return k;
        }

        private void UpdateRedis(object entity)
        {
            try
            {
                string entityGuid = entity.GetType().GetProperty("GUID").GetValue(entity).ToString();
                //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                //{
                //    MessageKey = entity.GetType().Name,
                //    EntityGuid = entityGuid,
                //    MessageBody = JsonConvert.SerializeObject(entity),
                //    OperTime = DateTime.Now,
                //    OperType = (int)OperTypeEnum.UpdateEntryInHash
                //};
                //RabbitMQTasks.MQTask(rabbitMQMessage);
                RedisWriteExHelper.SetUpdate(entity.GetType().Name, entityGuid, JsonConvert.SerializeObject(entity));
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }

        internal string TransformToUpdateSQL(object entity)
        {
            string updateSQL = UpdateEntitySQL(entity);
            AppLogger.Log("TransformToUpdateSQL:" + updateSQL);
            return updateSQL;
        }

        public bool Update(IEnumerable<BaseModel> Lstentity, bool IsTrn = false)
        {
            bool returns = false;
            string TableName = Lstentity.First().GetType().Name;
            string modelTypeStr = Lstentity.First().GetType().ToString().ToUpper();
            var IsExist = IsExist<BsRedisTable>("TableName=@0", TableName);

            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = UpdateList(Lstentity);
                };
                Commit(action);
                if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
                    UpdateRedis(Lstentity);
            }
            else
            {
                returns = UpdateList(Lstentity);
                if (modelTypeStr.Contains(".BS") || modelTypeStr.Contains(".GBL") || IsExist)
                    UpdateRedis(Lstentity);
            }
            return returns;
        }

        private void UpdateRedis(IEnumerable<BaseModel> Lstentity)
        {
            try
            {
                foreach (BaseModel entity in Lstentity)
                {
                    string entityGuid = entity.GetType().GetProperty("GUID").GetValue(entity).ToString();
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = entity.GetType().Name,
                    //    EntityGuid = entityGuid,
                    //    MessageBody = JsonConvert.SerializeObject(entity),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.UpdateEntryInHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                    RedisWriteExHelper.SetUpdate(entity.GetType().Name, entityGuid, JsonConvert.SerializeObject(entity));
                }
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }

        public string NewId()
        {
            return Guid.NewGuid().ToString();
        }

        public void Commit(Action action)
        {
            try
            {
                DataRepository().WorkUnitAct(action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetServerTime()
        {
            return System.DateTime.Now;
        }
        /// <summary>
        /// 保存一个集合
        /// </summary>
        /// <param name="Lstentity"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        public bool Save(IEnumerable<BaseModel> Lstentity, bool IsTrn = false)
        {
            bool returns = false;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = SaveList(Lstentity);
                };
                Commit(action);
            }
            else
            {
                returns = SaveList(Lstentity);
            }
            return returns;
        }
        public bool Save(BaseModel entity, bool IsTrn = false)
        {
            bool returns = false;
            if (IsTrn == true)
            {
                Action action = delegate ()
                {
                    returns = SaveList(entity);
                };
                Commit(action);
            }
            else
            {
                returns = SaveList(entity);
            }
            return returns;
        }
        private bool SaveList(BaseModel entity)
        {
            if (string.IsNullOrWhiteSpace(entity.GUID))
            {
                Add(entity);
            }
            else
            {
                if (entity.IsModify)
                {
                    Update(entity);
                }
            }
            return true;
        }

        private bool SaveList(IEnumerable<BaseModel> Lstentity)
        {
            for (int i = 0; i < Lstentity.Count(); i++)
            {
                var obj = Lstentity.ElementAt(i);

                if (string.IsNullOrWhiteSpace(obj.GUID))
                {
                    Add(obj);
                    //TransformToInsertSQL(obj);
                }
                else
                {
                    if (obj.IsModify)
                    {
                        Update(obj);
                        //TransformToUpdateSQL(obj);
                    }
                }
            }
            return true;
        }

        private void SaveRedis(IEnumerable<BaseModel> Lstentity)
        {
            foreach (BaseModel entity in Lstentity)
            {
                //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                //{
                //    MessageKey = entity.GetType().Name,
                //    EntityGuid = entity.GetType().GetProperty("GUID").GetValue(entity).ToString(),
                //    MessageBody = JsonConvert.SerializeObject(entity),
                //    OperTime = DateTime.Now,
                //    OperType = (int)OperTypeEnum.SetEntryInHash
                //};
                //RabbitMQTasks.MQTask(rabbitMQMessage);
                RedisWriteExHelper.SetAdd(entity.GetType().Name, entity.GetType().GetProperty("GUID").GetValue(entity).ToString(), JsonConvert.SerializeObject(entity));
            }
        }

        private string SaveChildList<T, TChild>(T parentObj, List<TChild> list, string relationKey) where T : BaseModel, new() where TChild : BaseModel, new()
        {
            if (string.IsNullOrWhiteSpace(parentObj.GUID))
            {
                parentObj.GUID = Guid.NewGuid().ToString("N");
                this.Add(parentObj);
                //TransformToInsertSQL(parentObj);
            }
            else
            {
                this.Update(parentObj);
                //TransformToUpdateSQL(parentObj);
            }
            string parentGuid = parentObj.GUID;
            string childGuid = null;
            if (string.IsNullOrWhiteSpace(parentGuid)) throw (new Exception("新增或更新父表失败"));
            foreach (TChild info in list)
            {
                info.GetType().GetProperty(relationKey).SetValue(info, parentGuid, null);
                if (string.IsNullOrWhiteSpace(info.GUID))
                {
                    info.GUID = Guid.NewGuid().ToString("N");
                    this.Add(info);
                    //this.DataRepository().Add(info);
                    childGuid = info.GUID;
                    if (string.IsNullOrWhiteSpace(childGuid)) throw (new Exception("新增子表失败"));
                    //TransformToInsertSQL(info);
                }
                if (!string.IsNullOrWhiteSpace(info.GUID))
                {
                    var t = this.Update(info);
                    if (Convert.ToInt32(t) < -1)
                    {
                        throw (new Exception("更新子表失败"));
                    }
                    //TransformToUpdateSQL(info);
                }
            }
            return parentGuid;
        }

        private bool DeleteList<T>(List<T> Lstentity) where T : BaseModel, new()
        {
            for (int i = 0; i < Lstentity.Count(); i++)
            {
                var obj = Lstentity.ElementAt(i);
                DataRepository().Delete(obj);
                //string deleteSQL = DeleteEntitySQL(obj);
                //AppLogger.Log(deleteSQL);
            }
            return true;
        }

        private bool UpdateList(IEnumerable<BaseModel> Lstentity)
        {
            for (int i = 0; i < Lstentity.Count(); i++)
            {
                var obj = Lstentity.ElementAt(i);
                DataRepository().Update(obj);
                //TransformToUpdateSQL(obj);
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsExist<T>(string where, params object[] arr) where T : class, new()
        {
            IQueryable<T> models;
            models = DataRepository().GetQueryable<T>().Where(where, arr);
            if (models != null && models.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetAllListCount<T>() where T : class, new()
        {
            try
            {
                var _dal = DataRepository().GetQueryable<T>();
                if (_dal != null)
                    return _dal.ToList().Count();
                else
                    return new List<T>().Count();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        public List<T> GetPageList<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new()
        {
            IQueryable<T> _dal = null;
            if (string.IsNullOrEmpty(where))
                _dal = DataRepository().GetQueryable<T>().SkipT<T>(startIndex).TakeT<T>(stopIndex).OrderBy<T>("guid");
            else
                _dal = DataRepository().GetQueryable<T>().Where(where, arr).SkipT<T>(startIndex).TakeT<T>(stopIndex).OrderBy<T>("guid");
            return _dal.ToList();
        }

        /// <summary>
        /// 根据Web组需求 
        /// 初始化获取分页数据
        /// </summary>
        public List<T> GetPageList<T>() where T : class, new()
        {
            IQueryable<T> _dal = null;
            _dal = DataRepository().GetQueryable<T>().SkipT<T>(0).TakeT<T>(14).OrderBy<T>("guid");
            if (_dal != null)
                return _dal.ToList();
            else
                return new List<T>();
        }

        public int GetPageListCount<T>(int startIndex, int stopIndex, string where, params object[] arr) where T : class, new()
        {
            IQueryable<T> queryable = null;
            if (string.IsNullOrEmpty(where))
                queryable = DataRepository().GetQueryable<T>().SkipT<T>(startIndex).TakeT<T>(stopIndex);
            else
                queryable = DataRepository().GetQueryable<T>().Where(where, arr).SkipT<T>(startIndex).TakeT<T>(stopIndex);
            return queryable.Count();
        }

        public int GetListCount<T>(string where, params object[] arr) where T : class, new()
        {
            return DataRepository().GetQueryable<T>().Where(where, arr).Count();
        }

        public DataTable ExecuteDataTable(string sql)
        {
            return DataRepository().SqlHelper.ExecuteDataTable(sql);
        }

        public int ExecuteNonQuery(string sql)
        {
            return DataRepository().SqlHelper.ExecuteNonQuery(sql);
        }

        public DbDataReader ExecuteReader(string sql)
        {
            return DataRepository().SqlHelper.ExecuteReader(sql);
        }

        public ELinq.DbContext GetCurrentDBContext()
        {
            return DataRepository().GetCurrentDBContext();
        }

        public int GetSeq(string seqName)
        {
            string sql = "select " + seqName + ".nextval id from dual";
            DataTable dt = this.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 数据库新增记录后新增redis相关记录
        /// </summary>
        /// <typeparam name="T">表的泛型</typeparam>
        /// <param name="entityList">要新增的记录</param>
        private void AddEntityToRedis<T>(T entity) where T : BaseModel, new()
        {
            try
            {
                #region 通过Rabbit MQ队列往Redis插入数据
                //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                //{
                //    MessageKey = entity.GetType().Name,
                //    EntityGuid = entity.GUID,
                //    MessageBody = JsonConvert.SerializeObject(entity),
                //    OperTime = DateTime.Now,
                //    OperType = (int)OperTypeEnum.SetEntryInHash
                //};
                //RabbitMQTasks.MQTask(rabbitMQMessage);
                #endregion
                bool succ = RedisWriteExHelper.SetAdd(entity.GetType().Name, entity.GUID, JsonConvert.SerializeObject(entity));
                //ConnectionMultiplexer.Connect("Localhost:6379,password=123456"))
                //using (var redis = ConnectionMultiplexer.Connect("Localhost"))
                //{
                //    //写入
                //    var db = redis.GetDatabase();
                //    db.StringSet("key", "123456");
                //    //设置过期日期
                //    //if (date != null)
                //    //{
                //    //    DateTime time = DateTime.Now.AddSeconds(20);
                //    //    db.KeyExpire("key", time);
                //    //}
                //    var result = db.StringGet("key");
                //}
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }
        
        

        /// <summary>
        /// 数据库新增记录后新增redis相关记录
        /// </summary>
        /// <typeparam name="T">表的泛型</typeparam>
        /// <param name="entityList">要新增的记录集合</param>
        private void AddListToRedis<T>(List<T> entityList) where T : BaseModel, new()
        {
            try
            {
                for (int i = 0; i < entityList.Count; i++)
                {
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = entityList[i].GetType().Name,
                    //    EntityGuid = entityList[i].GUID,
                    //    MessageBody = JsonConvert.SerializeObject(entityList[i]),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.SetEntryInHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                    RedisWriteExHelper.SetAdd(entityList[i].GetType().Name, entityList[i].GUID, JsonConvert.SerializeObject(entityList[i]));
                }
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }

        /// <summary>
        /// 删除数据库之后删除redis中相关记录
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lamb"></param>
        internal void DeleteRedis<T>(Expression<Func<T, bool>> lamb) where T : BaseModel, new()
        {
            try
            {
                List<T> list = GetList<T>(lamb);
                foreach (T t in list)
                {
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = t.GetType().Name,
                    //    EntityGuid = t.GUID,
                    //    MessageBody = JsonConvert.SerializeObject(t),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.RemoveEntryFromHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                    RedisWriteExHelper.SetRemove(t.GetType().Name, t.GUID);
                }
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }
        /// <summary>
        /// 删除数据库之后删除redis中相关记录
        /// </summary>
        /// <typeparam name="T">表泛型</typeparam>
        /// <param name="Lstentity">要删除的记录集合</param>
        private void DeleteRedis<T>(List<T> Lstentity) where T : Orm.Model.BaseModel, new()
        {
            try
            {
                foreach (T t in Lstentity)
                {
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = t.GetType().Name,
                    //    EntityGuid = t.GUID,
                    //    MessageBody = JsonConvert.SerializeObject(t),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.RemoveEntryFromHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                    RedisWriteExHelper.SetRemove(t.GetType().Name, t.GUID);
                }
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }
        /// <summary>
        /// 删除数据库之后删除redis中相关记录
        /// </summary>
        /// <typeparam name="T">表泛型</typeparam>
        /// <param name="Lstentity">要删除的记录</param>
        private void DeleteRedis<T>(object entity) where T : Orm.Model.BaseModel, new()
        {
            try
            {
                string entityGuid = entity.GetType().GetProperty("GUID").GetValue(entity).ToString();
                //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                //{
                //    MessageKey = typeof(T).Name,
                //    EntityGuid = entityGuid,
                //    MessageBody = JsonConvert.SerializeObject(entity),
                //    OperTime = DateTime.Now,
                //    OperType = (int)OperTypeEnum.RemoveEntryFromHash
                //};
                //RabbitMQTasks.MQTask(rabbitMQMessage);
                RedisWriteExHelper.SetRemove(typeof(T).Name, entityGuid);
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }
        /// <summary>
        /// 根据传入的list对象 关联返回要查询的t表集合
        /// </summary>
        /// <typeparam name="T">表t 根据条件查询要返回的表<peparam>
        /// <typeparam name="T2">t2 传入的表对象<peparam>
        /// <param name="list">t2 传入的表集合</param>
        /// <param name="getProperty">（父集合）关联属性名称</param>
        ///  /// <param name="getProperty">查询条件属性名称</param>
        /// <returns></returns>
        public List<T> GetTableListByIDs<T, T2>(List<T2> list, string getProperty, string Parameter = "GUID") where T : BaseModel, new() where T2 : BaseModel, new()
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                string modelTypeStr = typeof(T).Name;

                if (!list.Any())
                    return new List<T>();

                foreach (var item in list)
                {
                    var NewValue = item.GetType().GetProperty(getProperty).GetValue(item, null);
                    if (NewValue != null)
                    {
                        stringBuilder.Append("\'" + NewValue.ToString() + "\'" + ",");
                    }
                }
                if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL"))
                {//如果是基础数据，从本地redis中获取数据
                    List<T> lstT = RedisReadExHelper.RetrieveSet<T>(modelTypeStr);
                    if (list.Any())
                    {
                        List<T> lstRedisT = new List<T>();
                        foreach (T item in lstT)
                        {
                            var NewValue = item.GetType().GetProperty(Parameter).GetValue(item, null);
                            if (NewValue != null && stringBuilder.ToString().Contains(NewValue.ToString()))
                            {
                                lstRedisT.Add(item);
                            }
                        }
                        return lstRedisT;
                    }
                }

                stringBuilder.Length = stringBuilder.Length - 1;
                var helper = DataRepository().SqlHelper;//非单列模式  每次给予的对象不唯一
                string sql = string.Format(@"select * from {0} where {1} in ({2})", modelTypeStr, Parameter, stringBuilder);
                return helper.ExecuteDataTable(sql, helper.Parameters).TableToList<T>();
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }

        }
        #region InsertOrUpdate
        public bool InsertOrUpdate<T>(T entity) where T : BaseModel, new()
        {
            bool k = false;
            if (string.IsNullOrEmpty(entity.GUID)) //新增
            {
                var GUID = Add<T>(entity);
                if (!string.IsNullOrEmpty(GUID))
                    k = true;
            }
            else //修改
            {
                k = Update(entity);
            }
            return k;
        }

        public bool InsertOrUpdate<T>(IEnumerable<T> entities, bool IsTrn = false) where T : BaseModel, new()
        {
            bool isNoSave = false;
            isNoSave = Save(entities, IsTrn);
            return isNoSave;
        }

        public List<T> GetListByEnum<T, T2>(List<T2> list, string getProperty, string Parameter)
            where T : BaseModel, new()
            where T2 : BaseModel, new()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                var NewValue = item.GetType().GetProperty(getProperty).GetValue(item, null);
                if (NewValue != null)
                {
                    stringBuilder.Append("\'" + NewValue.ToString() + "\'" + ",");
                }
            }
            stringBuilder.Length = stringBuilder.Length - 1;
            string modelTypeStr = typeof(T).Name;
            var helper = DataRepository().SqlHelper;//非单列模式  每次给予的对象不唯一
            string sql = string.Format(@"select * from {0} where {1} in ({2})", modelTypeStr, Parameter, stringBuilder);
            return helper.ExecuteDataTable(sql, helper.Parameters).TableToList<T>();
        }

        

        #endregion
    }
}
