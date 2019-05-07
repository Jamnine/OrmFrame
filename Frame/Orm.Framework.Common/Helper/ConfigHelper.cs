using System;
using System.Configuration;

namespace Orm.Framework.Common
{
    public static class ConfigHelper
    {
        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public static void SetSettings(string key, string value)
        {
            Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(System.Web.HttpContext.Current.Request.ApplicationPath);
            AppSettingsSection appseting = (AppSettingsSection)config.GetSection("appSettings");
            appseting.Settings[key].Value = value; //修改设置
            config.Save();
        }

        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public static void AddSettings(string key, string value)
        {
            Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(System.Web.HttpContext.Current.Request.ApplicationPath);
            AppSettingsSection appseting = (AppSettingsSection)config.GetSection("appSettings");
            appseting.Settings.Add(key, value);//增加设置
            config.Save();
        }

        public static string GetSettings(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value == null ? String.Empty : value;
        }

        public static int GetSettingsInt(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value == null ? 0 : int.Parse(value);
        }
    }
}