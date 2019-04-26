using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface IJsonSerializer
    {
        /// <summary>
        /// 将对象序列化为Json字符串。
        /// </summary>
        /// <param name="data">要序列化的对象。</param>
        /// <returns>返回的字符串。</returns>
        string Serialize(object data);

        /// <summary>
        /// 将Json字符串反序列化为对象。
        /// </summary>
        /// <param name="json">要反序列化的字符串</param>
        /// <param name="targetType">目标对象的类型</param>
        /// <returns>反序列化的结果。</returns>
        object Deserialize(string json, Type targetType);

        /// <summary>
        /// 将Json字符串反序列化为对象。
        /// </summary>
        /// <typeparam name="T">目标对象的类型</typeparam>
        /// <param name="json">要反序列化的字符串</param>
        /// <returns>反序列化的结果。</returns>
        T Deserialize<T>(string json);
    }
}
