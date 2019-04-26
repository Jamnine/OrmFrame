using System.Collections.Generic;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 通用配置服务接口
    /// </summary>
    public interface IConfiger
    {
        /// <summary>
        /// 根据键值从配置中取出一项配置。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string Get(string key);

        /// <summary>
        /// 根据键值从配置中取出一项配置。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key) where T : class, new();

        /// <summary>
        /// 根据配置类型名从配置中取出一组配置。
        /// </summary>
        /// <typeparam name="T">配置类型参数</typeparam>
        /// <param name="owner">配置类所有者。</param>
        /// <returns></returns>
        List<T> GetMulti<T>(string owner) where T : class, new();

        /// <summary>
        /// 根据本配置名取一项配置，存在多项是返回第一项。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="configName"></param>
        /// <returns></returns>
        T GetFirst<T>(string configName) where T : class, new();
    }
}
