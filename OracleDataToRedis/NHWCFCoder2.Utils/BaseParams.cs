using System.Data;
using System.Text;
using System.IO;
namespace OracleDataToRedis.Utils
{
    public class BaseParams
    {
        #region 需要设置的基本参数
        /// <summary>
        /// 公司名称
        /// </summary>
        public static string CompanyName
        {
            set;
            get;
        }

        /// <summary>
        /// 作者
        /// </summary>
        public static string Author
        {
            set;
            get;
        }

        /// <summary>
        /// 解决方案名称
        /// </summary>
        public static string SolutionName
        {
            set;
            get;
        }

        /// <summary>
        /// 解决方案保存路径
        /// </summary>
        public static string SolutionPath
        {
            set;
            get;
        }

        /// <summary>
        /// 表前缀分割符
        /// </summary>
        public static string TablePrefixSpilt
        {
            set;
            get;
        }

        /// <summary>
        /// 表前缀
        /// </summary>
        public static string TablePrefix
        {
            set;
            get;
        }

        /// <summary>
        /// 是否在子表中创建父表属性
        /// </summary>
        public static bool IsGenerateParentProperty
        {
            set;
            get;
        }

        /// <summary>
        /// WCF服务端口
        /// </summary>
        public static int WcfServicePort
        {
            set;
            get;
        }
        #endregion

        private static string _external_binNo;
        private static string _controlsNo;
        private static string _domainNo;
        private static string _persistenceNo;
        private static string _runNo;
        private static string _servicesNo;
        private static string _usercontrolsNo;
        private static string _wcfclientNo;
        private static string _wcfmodelsNo;
        private static string _wcfservicesNo;
        private static string _winfromsNo;
        private static string _utilityNo;

        #region 只读的组合型参数
        /// <summary>
        /// 创建时间
        /// </summary>
        public static string CreateTime
        {
            get { return System.DateTime.Now.ToShortDateString(); }
        }

        /// <summary>
        /// 项目解决方案命名空间
        /// </summary>
        public static string SolutionNameSpace
        {
            get { return CompanyName + "." + SolutionName; }
        }

        #region External_bin方案组件集合项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string External_binNameSpace
        {
            get { return "External_bin"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string External_binPath
        {
            get { return Path.Combine(SolutionPath, "External_bin"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string External_binNo
        {
            get { return BaseParams._external_binNo; }
        }
        #endregion

        #region Controls自定义控件项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string ControlsNameSpace
        {
            get { return CompanyName + ".Controls"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string ControlsPath
        {
            get { return Path.Combine(SolutionPath, CompanyName + ".Controls"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string ControlsNo
        {
            get { return BaseParams._controlsNo; }
        }
        #endregion

        #region Domain系统对象项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string DomainNameSpace
        {
            get { return SolutionNameSpace + ".Domain"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string DomainPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".Domain"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string DomainNo
        {
            get { return BaseParams._domainNo; }
        }
        #endregion

        #region Persistence持久化项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string PersistenceNameSpace
        {
            get { return SolutionNameSpace + ".Persistence"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string PersistencePath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".Persistence"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string PersistenceNo
        {
            get { return BaseParams._persistenceNo; }
        }
        #endregion

        #region Run系统启动项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string RunNameSpace
        {
            get { return SolutionNameSpace + ".Run"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string RunPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".Run"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string RunNo
        {
            get { return BaseParams._runNo; }
        }

        #endregion

        #region Services对象业务服务项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string ServicesNameSpace
        {
            get { return SolutionNameSpace + ".Services"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string ServicesPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".Services"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string ServicesNo
        {
            get { return BaseParams._servicesNo; }
        }

        #endregion

        #region UserControls用户控件项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string UserControlsNameSpace
        {
            get { return SolutionNameSpace + ".UserControls"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string UserControlsPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".UserControls"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string UserControlsNo
        {
            get { return BaseParams._usercontrolsNo; }
        }

        #endregion

        #region WcfClient服务客户端项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string WcfClientNameSpace
        {
            get { return SolutionNameSpace + ".WcfClient"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string WcfClientPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".WcfClient"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string WcfClientNo
        {
            get { return BaseParams._wcfclientNo; }
        }

        #endregion

        #region WcfModels服务端项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string WcfModelsNameSpace
        {
            get { return SolutionNameSpace + ".WcfModels"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string WcfModelsPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".WcfModels"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string WcfModelsNo
        {
            get { return BaseParams._wcfmodelsNo; }
        }

        #endregion

        #region WcfServices服务端项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string WcfServicesNameSpace
        {
            get { return SolutionNameSpace + ".WcfServices"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string WcfServicesPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".WcfServices"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string WcfServicesNo
        {
            get { return BaseParams._wcfservicesNo; }
        }

        #endregion

        #region WinFroms用户界面项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string WinFromsNameSpace
        {
            get { return SolutionNameSpace + ".WinFroms"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string WinFromsPath
        {
            get { return Path.Combine(SolutionPath, SolutionNameSpace + ".WinFroms"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string WinFromsNo
        {
            get { return BaseParams._winfromsNo; }
        }

        #endregion

        #region Utility工具集合项目
        /// <summary>
        /// 命名空间
        /// </summary>
        public static string UtilityNameSpace
        {
            get { return CompanyName + ".Utility"; }
        }

        /// <summary>
        /// 保存路径
        /// </summary>
        public static string UtilityPath
        {
            get { return Path.Combine(SolutionPath, CompanyName + ".Utility"); }
        }

        /// <summary>
        /// 项目号码
        /// </summary>
        public static string UtilityNo
        {
            get { return BaseParams._utilityNo; }
        }

        #endregion
        #endregion

        public static void CreateProjectNo()
        {
            _external_binNo = System.Guid.NewGuid().ToString();
            _controlsNo = System.Guid.NewGuid().ToString();
            _domainNo = System.Guid.NewGuid().ToString();
            _persistenceNo = System.Guid.NewGuid().ToString();
            _runNo = System.Guid.NewGuid().ToString();
            _servicesNo = System.Guid.NewGuid().ToString();
            _usercontrolsNo = System.Guid.NewGuid().ToString();
            _wcfclientNo = System.Guid.NewGuid().ToString();
            _wcfmodelsNo = System.Guid.NewGuid().ToString();
            _wcfservicesNo = System.Guid.NewGuid().ToString();
            _winfromsNo = System.Guid.NewGuid().ToString();
            _utilityNo = System.Guid.NewGuid().ToString();
        }
    }
}
