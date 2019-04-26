using System;
using System.Linq;

namespace Orm.Framework.Services
{
    public partial class MapContainer
    {
        /// <summary>
        /// 取映射的类型。
        /// </summary>
        /// <param name="MapKey">映射键。</param>
        /// <param name="InterfaceName">接口名</param>
        /// <returns></returns>
        public static TypeMap GetTypeMap(string MapKey)
        {
            RegisterTypeMap();

            TypeMap typeMap = null;

            var MapQuery = MapList.Where(ww =>ww.MapConfigKey!=null && ww.MapConfigKey == MapKey);
           
            typeMap = MapQuery.FirstOrDefault();

            return typeMap;
        }


        public static object GetInstance(string MapKey)
        {
            RegisterTypeMap();

            //验证类型对应是否存在
            object reInstance = null;
            TypeMap typeMap = GetTypeMap(MapKey);

            if (typeMap == null)
            {
                throw new Exception("不存在对类型 " + MapKey + " 的映射");
            }

        
            Type mapedType = Type.GetType(typeMap.MapToType, true, true);
            if (mapedType == null)
            {
                throw new Exception("找不到类型：" + typeMap.MapToType);
            }

            reInstance = Activator.CreateInstance(mapedType);

            return reInstance;
        }

    }
}
