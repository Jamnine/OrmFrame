using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services.SharedMemory
{
    public interface ICacheServer : ISharedMemoryCache
    {


        /// <summary>
        /// 初始加载
        /// </summary>
        void Load();

        /// <summary>
        /// 刷新加载
        /// </summary>
        void Refresh();

        /// <summary>
        /// 注册Loader
        /// </summary>
        void Register();

    }
}
