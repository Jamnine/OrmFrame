using Orm.Log4Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 类型映射容器。
    /// </summary>
    public partial class MapContainer
    {
        public static IRegisterDbTypeMap Register { set; get; }

        private static List<TypeMap> _mapList;
        /// <summary>
        /// 映射列表。
        /// </summary>
        private static List<TypeMap> MapList
        {
            set
            {
                lock (mapLoker)
                {
                    _mapList = value;
                }
            }
            get
            {
                lock (mapLoker)
                {
                    if (_mapList == null)
                    {
                        _mapList = new List<TypeMap>();
                    }

                    return _mapList;
                }
            }
        }

        /// <summary>
        /// 单例字典。
        /// </summary>
        private static Dictionary<string, object> SingleObjDict;

        /// <summary>
        /// MapList并发锁。
        /// </summary>
        private static readonly object mapLoker = new object();

        static MapContainer()
        {
            SingleObjDict = new Dictionary<string, object>();
        }

        /// <summary>
        /// 取映射的类型。
        /// </summary>
        /// <param name="MapKey">映射键。</param>
        /// <param name="InterfaceName">接口名</param>
        /// <returns></returns>
        public static TypeMap GetTypeMap(string MapKey, string InterfaceName)
        {
            RegisterTypeMap();

            TypeMap typeMap = null;
            if (IsRegistered(InterfaceName))
            {
                lock (mapLoker)
                {
                    var MapQuery = MapList.Where(ww => ww.InterfaceName == InterfaceName);
                    if (!string.IsNullOrWhiteSpace(MapKey))
                    {
                        MapQuery.Where(ww => ww.MapConfigKey == MapKey);
                    }
                    typeMap = MapQuery.FirstOrDefault();
                }
            }

            return typeMap;
        }

        /// <summary>
        /// 取映射的实例。
        /// </summary>
        /// <param name="InterfaceName">服务接口名</param>
        /// <param name="MapKey">映射的标识。</param>
        /// <param name="Params">构建参数。</param>
        /// <returns>目标实例。</returns>
        public static object GetInstance(string MapKey, string InterfaceName, params object[] Params)
        {
            RegisterTypeMap();

            try
            {

                //验证类型对应是否存在
                object reInstance = null;
                TypeMap typeMap = GetTypeMap(MapKey, InterfaceName);

                if (typeMap == null)
                {
                    throw new Exception("不存在对类型 " + InterfaceName + " 的映射");
                }

                //验证目标单例实例，存在即直接使用。
                if (typeMap.LifeTimeCode == LifeTime.Singleton && SingleObjDict.ContainsKey(InterfaceName))
                {
                    return SingleObjDict[InterfaceName];
                }

                Type mapedType = Type.GetType(typeMap.MapToType, true, true);
                if (mapedType == null)
                {
                    throw new Exception("找不到类型：" + typeMap.MapToType);
                }

                reInstance = Activator.CreateInstance(mapedType);

                if (!string.IsNullOrWhiteSpace(typeMap.CreaterMethod))
                {
                    string[] routes = typeMap.CreaterMethod.Split('.');
                    try
                    {
                        reInstance = RunCreaterMethod(reInstance, routes, Params);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                //缓存单例实例
                if (typeMap.LifeTimeCode == LifeTime.Singleton)
                {
                    SingleObjDict[InterfaceName] = reInstance;
                }

                return reInstance;
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 将类型映射注释到上下文。
        /// </summary>
        private static void RegisterTypeMap()
        {
            lock (mapLoker)
            {
                if (MapList != null && MapList.Count > 0)
                {
                    return;
                }
            }
            RegisterTypeMapFromConfigFile();
        }

        /// <summary>
        /// 从文件注册类型映射。
        /// </summary>
        private static void RegisterTypeMapFromConfigFile()
        {
            lock (mapLoker)
            {
                if (MapList != null && MapList.Count > 0)
                {
                    return;
                }
            }
            if (!Directory.Exists(AppSettings.ConfigPath))
            {
                return;
            }


            var files = Directory.GetFiles(AppSettings.ConfigPath, "*.config");

            for (int i = 0; i < files.Length; i++)
            {
                var list = new List<TypeMap>();
                try
                {
                    var fileStream = File.OpenRead(files[i]);
                    XmlSerializer ser = new XmlSerializer(typeof(List<TypeMap>));
                    var vv = ser.Deserialize(fileStream);
                    list = vv as List<TypeMap>;
                    if (list == null)
                    {
                        continue;
                    }

                    foreach (var aMap in list)
                    {

                        lock (mapLoker)
                        {
                            MapList.Remove(aMap);
                            MapList.Add(aMap);
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 从数据库注册类型映射。
        /// </summary>
        private static void RegisterTypeMapFromConfigDB(List<TypeMap> maps)
        {
            if (Register != null)
            {
                Register.RegisterTypeMapFromConfigDB(maps);
            }
        }

        /// <summary>
        /// 重新注册类型映射。
        /// </summary>
        private static void Refresh()
        {
            MapList = new List<TypeMap>();
            RegisterTypeMap();
        }

        /// <summary>
        /// 判断类型映射是否已经注册。
        /// </summary>
        /// <param name="InterfaceName"></param>
        /// <returns></returns>
        private static bool IsRegistered(string InterfaceName)
        {

            lock (mapLoker)
            {
                if (MapList == null)
                {
                    return false;
                }
            }
            lock (mapLoker)
            {
                var map = MapList.Where(ww => ww != null && ww.InterfaceName == InterfaceName);
                if (map == null)
                {
                    return false;
                }

                return map.Count() > 0;
            }
        }

        /// <summary>
        /// 运行创建方法。
        /// </summary>
        /// <param name="Parameter">运行创建方法的对象。</param>
        /// <param name="Routes">创建方法的路由。</param>
        /// <param name="Params">创建方法的参数。</param>
        /// <returns>创建的结果。</returns>
        private static object RunCreaterMethod(object Parameter, string[] Routes, params object[] Params)
        {
            try
            {
                object Obj = Parameter;
                object reObj = null;
                for (int i = 0; i < Routes.Length; i++)
                {
                    if (Obj == null)
                    {
                        break;
                    }

                    string strRoute = Routes[i];
                    if (i == Routes.Length - 1)
                    {
                        List<Type> typeList = new List<Type>();
                        foreach (object param in Params)
                        {
                            typeList.Add(param.GetType());
                        }

                        MethodInfo method = Obj.GetType().GetMethod(strRoute, typeList.ToArray());
                        reObj = method.Invoke(Obj, Params);
                    }
                    else
                    {
                        if (Obj.GetType().GetProperty(strRoute) != null)
                        {
                            Obj = Obj.GetType().GetProperty(strRoute).GetValue(Obj, null);
                            continue;
                        }
                        if (Obj.GetType().GetField(strRoute) != null)
                        {
                            Obj = Obj.GetType().GetField(strRoute).GetValue(Obj);
                            continue;
                        }
                    }

                    Obj = null;
                    break;
                }

                return reObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
