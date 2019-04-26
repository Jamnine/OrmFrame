using System;
using System.IO;
using System.Configuration;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 全局基本配置项值
    /// </summary>
    public partial class AppSettings
    {
        /// <summary>
        /// 是否调试模式
        /// </summary>
        public static bool Debug
        {
            get
            {
                var debug = false;
                var config = ConfigurationManager.AppSettings["Orm.Framework.Debug"];
                if (config != null)
                {
                    debug = bool.Parse(config);
                }
                return debug;
            }
        }

        /// <summary>
        /// 是否调试模式
        /// </summary>
        public static bool IsClient
        {
            get
            {
                var debug = false;
                var config = ConfigurationManager.AppSettings["Orm.Framework.Client"];
                if (config != null)
                {
                    debug = bool.Parse(config);
                }
                return debug;
            }
        }

        /// <summary>
        /// 是否记录框架调试日志
        /// </summary>
        public static bool AppLogEnabled
        {
            get
            {
                bool _AppLogEnabled = false;
                if (ConfigurationManager.AppSettings["Orm.Framework.AppLogEnabled"] != null)
                {
                    _AppLogEnabled = bool.Parse(ConfigurationManager.AppSettings["Orm.Framework.AppLogEnabled"].ToString());
                }
                return _AppLogEnabled;
            }
        }

        /// <summary>
        /// 全局唯一的应用运行时名。
        /// </summary>
        public static string AppRuntimeName
        {
            get
            {
                return "Demo";
            }
            set { }
        }
  
        static string binPath;
        /// <summary>
        /// 配置文件夹路径。
        /// </summary>
        public static string BinPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(binPath))
                {
                    binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin");

                    if (!Directory.Exists(binPath))
                    {
                        binPath = AppDomain.CurrentDomain.BaseDirectory;
                    }
                }

                return binPath;
            }
        }

        /// <summary>
        /// 配置文件夹路径。
        /// </summary>
        public static string ConfigPath
        {
            get
            {
                string reString = Path.Combine(BinPath, @"config\");
                return reString;
            }
        }

        /// <summary>
        /// 配置文件夹路径。
        /// </summary>
        public static string ConfigFilesPath
        {
            get
            {
                string reString = Path.Combine(BinPath, @"configFiles\");
                return reString;
            }
        }

        /// <summary>
        /// 配置文件夹路径。
        /// </summary>
        public static string ConfigDB_Key
        {
            get
            {
                string configDb = string.Empty;
                if (ConfigurationManager.AppSettings["FRAMEWORK_DB_KEY"] != null)
                {
                    configDb = ConfigurationManager.AppSettings["FRAMEWORK_DB_KEY"].ToString();
                }
                return configDb;
            }
        }

        /// <summary>
        /// 自动更新DB配置。
        /// </summary>
        public static string ConfigUpdateDB_Key
        {
            get
            {
                string configDb = string.Empty;
                if (ConfigurationManager.AppSettings["FRAMEWORK_UPDATEDB_KEY"] != null)
                {
                    configDb = ConfigurationManager.AppSettings["FRAMEWORK_UPDATEDB_KEY"].ToString();
                }
                return configDb;
            }
        }

        /// <summary>
        /// 是否启动自动更新
        /// </summary>
        public static bool IsRunUpdate
        {
            get
            {
                bool update = false;
                if (ConfigurationManager.AppSettings["FRAMEWORK_RUNUPDATE"] != null)
                {
                    update = bool.Parse(ConfigurationManager.AppSettings["FRAMEWORK_RUNUPDATE"].ToString());
                }
                return update;
            }
        }

        /// <summary>
        /// 服务配置文件路径。
        /// </summary>
        public static string ServicesConfigPath
        {
            get
            {
                string reString = Path.Combine(ConfigPath, @"Orm.Framework.Services.config");
                return reString;
            }
        }

        /// <summary>
        /// ORM配置文件路径。
        /// </summary>
        public static string OrmConfigPath
        {
            get
            {
                string reString = Path.Combine(ConfigPath, @"Config.ORM.xml");
                return reString;
            }
        }

        /// <summary>
        /// 配置文件夹路径。
        /// </summary>
        public static string RedisDefaultKey
        {
            get
            {
                string redisDefaultKey = string.Empty;
                if (ConfigurationManager.AppSettings["Redis.DefaultKey"] != null)
                {
                    redisDefaultKey = ConfigurationManager.AppSettings["Redis.DefaultKey"].ToString();
                }
                return redisDefaultKey;
            }
        }

        /// <summary>
        /// 是否启用总店模式
        /// </summary>
        public static bool IsMainLocation
        {
            get
            {
                var debug = false;
                var config = ConfigurationManager.AppSettings["IsMainLocation"];
                if (config != null)
                {
                    debug = bool.Parse(config);
                }
                return debug;
            }
        }

        /// <summary>
        /// 是否启用Redis
        /// </summary>
        public static bool IsEnableRedis
        {
            get
            {
                var debug = false;
                var config = ConfigurationManager.AppSettings["IsEnableRedis"];
                if (config != null)
                {
                    debug = bool.Parse(config);
                }
                return debug;
            }
        }
    }
}
