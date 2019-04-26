using System;

namespace Orm.Model
{
    /// <summary>
    ///查看更新版本信息
    /// </summary>
    [Serializable]
    public class ViewUpdateVersionInfo
    {
        /// <summary>
        /// 更新版本id
        /// </summary>
        public int UpVersionId { get; set; }
        /// <summary>
        /// 客户端id
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// 更新版本的数据库版本号
        /// </summary>
        public int UpVersionDbVersionNum { get; set; }
        /// <summary>
        /// 客户端编号
        /// </summary>
        public string  CustomerCode { get; set; }
        /// <summary>
        /// IIS文件路径
        /// </summary>
        public string IisFilePath { get; set; }
        /// <summary>
        /// IIS服务的IP地址
        /// </summary>
        public string IisServerLwIp { get; set; }
        /// <summary>
        /// 版本的IIS文件路径
        /// </summary>
        public string VersionIisFilePath { get; set; }
    }
}
