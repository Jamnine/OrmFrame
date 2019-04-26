using System;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 服务容器
    /// </summary>
    public class ServiceTaker
    {
        #region 通用服务获取方法。
        /// <summary>
        /// 取任意已经提供的服务,如果存在多个，则返回第一个。
        /// </summary>
        /// <typeparam name="T">服务类型</typeparam>
        /// <param name="Params">获取服务的参数</param>
        /// <returns></returns>
        public static T GetService<T>(params object[] Params) where T : class
        {
            return MapContainer.GetInstance("", typeof(T).FullName, Params) as T;
        }


        /// <summary>
        /// 按给定的key取任意已经提供的服务。
        /// </summary>
        /// <typeparam name="T">服务类型</typeparam>
        /// <param name="MapKey">服务标识</param>
        /// <param name="Params">获取服务的参数</param>
        /// <returns></returns>
        public static T GetServiceByKey<T>(string MapKey, params object[] Params) where T : class
        {
            return MapContainer.GetInstance(MapKey, typeof(T).FullName, Params) as T;
        }

        public static object GetServiceByKey<T>(string MapKey)
        {
            return MapContainer.GetInstance(MapKey);
        }

        /// <summary>
        /// 取任意已经提供的服务,如果存在多个，则返回第一个。
        /// </summary>
        /// <param name="typeName">服务类型名</param>
        /// <param name="Params">获取服务的参数</param>
        /// <returns></returns>
        public static object GetService(string typeName, params object[] Params)
        {
            return MapContainer.GetInstance(typeName, "", Params);
        }

        /// <summary>
        /// 按给定的key取任意已经提供的服务。
        /// </summary>
        /// <param name="typeName">服务类型名</param>
        /// <param name="MapKey">服务标识</param>
        /// <param name="Params">获取服务的参数</param>
        /// <returns></returns>
        public static object GetServiceByKey(string MapKey, string typeName, params object[] Params)
        {
            return MapContainer.GetInstance(MapKey, typeName, Params);
        }

        /// <summary>
        /// 取任意已经提供的Web服务。客户端使用
        /// </summary>
        /// <typeparam name="T">服务类型。</typeparam>
        /// <param name="MapKey">服务标识。</param>
        /// <returns></returns>
        public static T GetRemoteService<T>(string MapKey = "") where T : class
        {
            if (AppSettings.Debug )
            {
                return GetService<T>(MapKey);
            }
            var theMaped = MapContainer.GetTypeMap(MapKey, typeof(T).FullName);
            if (theMaped == null)
            {
                throw new Exception(typeof(T).FullName + " 没有在配置文件中注册映射。");
            }
            var Manager = GetService<IRemoteProxyManager>();
            T proxy = Manager.GetApiProxy<T>(theMaped);
            return proxy;
        }

        /// <summary>
        /// 取任意已经提供的Web服务。客户端使用
        /// </summary>
        /// <typeparam name="T">服务类型。</typeparam>
        /// <param name="MapKey">服务标识。</param>
        /// <returns></returns>
        public static T GetRemoteServiceInLocal<T>(string MapKey = "") where T : class
        {
            return GetService<T>(MapKey);
        }
        #endregion

        #region 额外的专用服务获取方法，便于用户体验。

        /// <summary>
        /// 从服务容器获取缓存服务接口
        /// </summary>
        /// <returns></returns>
        public static ICache GetCache()
        {
            return GetService<ICache>();
        }

        /// <summary>
        /// 取主键生成器。
        /// </summary>
        /// <returns></returns>
        public static IKeyCreater GetKeyCreater()
        {
            return GetService<IKeyCreater>();
        }

        /// <summary>
        /// 从服务容器获取配置服务接口
        /// </summary>
        /// <returns></returns>
        public static IConfiger GetConfiger()
        {
            return GetService<IConfiger>();
        }

        /// <summary>
        /// 从服务容器或者日志服务接口
        /// </summary>
        /// <returns></returns>
        public static ILogger GetLogger()
        {
            return GetService<ILogger>();
        }

        /// <summary>
        /// 获取分布式文件系统客户端接口
        /// </summary>
        /// <returns></returns>
        public static IDfsClinet GetDfsClient()
        {
            return GetService<IDfsClinet>();
        }

        /// <summary>
        /// 获取认证服务接口
        /// </summary>
        /// <returns></returns>
        public static IAuthenticator GetAuthenticator()
        {
            return GetService<IAuthenticator>();
        }

        /// <summary>
        /// 获取权限服务接口
        /// </summary>
        /// <returns></returns>
        public static IPermission GetPermission()
        {
            return GetService<IPermission>();
        }

        /// <summary>
        /// 获取Excel读取器接口
        /// </summary>
        /// <returns></returns>
        public static IExcelReader GetExcelReader()
        {
            return GetService<IExcelReader>();
        }

        /// <summary>
        /// 获取模板引擎接口
        /// </summary>
        /// <returns></returns>
        public static ITempletEngine GetTempletEngine()
        {
            return GetService<ITempletEngine>();
        }

        /// <summary>
        /// 获取字典服务接口
        /// </summary>
        /// <returns></returns>
        public static IDictService GetDictService()
        {
            return GetService<IDictService>();
        }

        /// <summary>
        /// 获取用户服务接口
        /// </summary>
        /// <returns></returns>
        public static IUserService GetUserService()
        {
            return GetService<IUserService>();
        }

        /// <summary>
        /// 获取消息服务
        /// </summary>
        /// <returns></returns>
        public static IMQService GetMQService()
        {
            return GetService<IMQService>();
        }

        /// <summary>
        /// 获取分布式锁服务
        /// </summary>
        /// <returns></returns>
        public static ILockService GetLockService()
        {
            return GetService<ILockService>();
        }

        /// <summary>
        /// 获取对象池接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static IObjectPool<T> GetObjectPool<T>(IPoolableObjectFactory<T> factory) where T : class
        {
            return new DefaultPool<T>(factory);
        }

        #endregion
    }
}
