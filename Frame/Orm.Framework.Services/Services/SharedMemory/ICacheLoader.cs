using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services.SharedMemory
{
    public interface ICacheLoader
    {
        /// <summary>
        /// 数据加载方法，提供者只负责提供数据，由Server负责写入共享内存
        /// </summary>
        /// <returns></returns>
        Dictionary<string, object> Load();

        /// <summary>
        /// 刷新数据的方法
        /// </summary>
        /// <returns></returns>
        Dictionary<string, object> Refresh();

        bool Has(string key);

        object RefreshOne(string key);
    }

    /// <summary>
    /// 用来加载更新数据的类
    /// <remarks>Comparer类，用来更新缓存数据</remarks>
    /// </summary>
    public class IncrementData
    {
        private IRefreshComparer _comparer;
      
        public IncrementData(IRefreshComparer comparer)
        {
            _comparer = comparer;
        }

        public object Data
        {
            set;
            get;
        }
    }
    public interface IRefreshComparer : IComparer
    {
    }
}
