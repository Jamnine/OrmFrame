using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// Api代理对象管理，所有Api均约为单例模式。这是一个本地接口。
    /// </summary>
    public interface IRemoteProxyManager
    {
        /// <summary>
        /// 取Api代理对象。
        /// </summary>
        /// <typeparam name="T">Api接口。</typeparam>
        /// <param name="theTypeMap">Api映射配置。</param>
        /// <returns></returns>
        T GetApiProxy<T>(TypeMap theTypeMap);
    }
}
