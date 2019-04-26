using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Orm.Framework.Services
{
    /// <summary>
    /// svcHost服务配置节
    /// </summary>
    public class SvcConfigSection : ConfigurationSection
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SvcConfigSection()
        {

        }

        /// <summary>
        /// 服务配置集合
        /// </summary>
        [ConfigurationProperty("ServiceConfig", DefaultValue = null)]
        public SvcConfigElementCollection ServiceConfigs
        {
            get
            {
                return (SvcConfigElementCollection)base["ServiceConfig"];
            }
        }
    }
}
