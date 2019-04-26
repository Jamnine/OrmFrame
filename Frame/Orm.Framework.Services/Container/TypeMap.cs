using System;
using System.Collections.Generic;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 映射类。
    /// </summary>
    [Serializable]
    public class TypeMap : IEquatable<TypeMap>
    {
        /// <summary>
        /// 映射的标识。
        /// </summary>
        public string MapConfigKey { get; set; }

        /// <summary>
        /// 被映射的类型全名,服务接口类型。
        /// </summary>
        public string InterfaceName { get; set; }

        /// <summary>
        /// 映射目标类或目标类的创建器的限定名。
        /// 要求该类型拥有无参构造函数。
        /// </summary>
        public string MapToType { get; set; }

        /// <summary>
        /// 创建方法。可以是目标类的构造函数或创建器中的创建方法。
        /// 形如.p1.p2.f1。
        /// </summary>
        public string CreaterMethod { get; set; }

        /// <summary>
        /// 生命周期。
        /// </summary>
        public LifeTime LifeTimeCode { get; set; }

        /// <summary>
        /// WebApi的服务地址列表。
        /// </summary>
        public List<String> WebApiUrlList { get; set; }

        /// <summary>
        /// 构造函数。
        /// </summary>
        public TypeMap()
        {
            LifeTimeCode = LifeTime.Transient;
            WebApiUrlList = new List<string>();
        }

        public bool Equals(TypeMap other)
        {
            bool retB = (other.MapConfigKey == this.MapConfigKey && other.InterfaceName == this.InterfaceName);
            return retB;
        }
    }

    /// <summary>
    /// 定义受容器管理的服务对象的生命周期
    /// </summary>
    [Serializable]
    public enum LifeTime
    {
        /// <summary>
        /// 单例,只新建一次。
        /// </summary>
        Singleton = 1,

        /// <summary>
        /// 瞬时，每次调用都new
        /// </summary>
        Transient = 2
    }
}
