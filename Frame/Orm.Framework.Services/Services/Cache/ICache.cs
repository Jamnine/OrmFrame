namespace Orm.Framework.Services
{
    /// <summary>
    /// 缓存服务接口
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// 从缓存中删除一个对象
        /// </summary>
        /// <param name="key">缓存键值</param>
        /// <returns>返回操作是否成功</returns>
        bool Delete(string key);

        /// <summary>
        /// 判断是否存在指定键的记录
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>如果存在则返回true</returns>
        bool Exists(string key);

        /// <summary>
        /// 从缓存服务中获取一个对象
        /// </summary>
        /// <param name="key">缓存键值</param>
        /// <returns>返回从缓存中得到的对象</returns>
        object Get(string key);

        /// <summary>
        /// 从缓存服务中获取一个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存键值</param>
        /// <returns>返回从缓存中得到的对象</returns>
        T Get<T>(string key) where T : class;

        /// <summary>
        /// 设置一个缓存项,并指定有效期,操作成功则返回true。如果指定的键存在则更新其对应的值，
        /// 如果不存在则新建一个缓存项。
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="minute">缓存时间（以分钟为单位）</param>
        /// <returns></returns>
        bool Set(string key, object value, int minute = 24);

        /// <summary>
        /// 索引函数
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        object this[string key] { get; set; }
    }
}
