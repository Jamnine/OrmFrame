namespace Orm.Framework.Services
{
    /// <summary>
    /// 当前环境配置
    /// </summary>
    public class Environments
    {
        /// <summary>
        /// 开发环境
        /// </summary>
        public static readonly string Development = "Development";

        /// <summary>
        /// 生产环境
        /// </summary>
        public static readonly string Production = "Production";

        /// <summary>
        /// 远程IIS服务地址。
        /// </summary>
        public static string IISServerUrl = string.Empty; 
    }
}
