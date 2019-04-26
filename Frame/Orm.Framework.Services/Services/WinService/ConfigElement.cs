using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 服务配置项集合
    /// </summary>
    public class SvcConfigElementCollection : ConfigurationElementCollection
    {
        internal new SvcConfigElement this[string name]
        {
            get { return this.Cast<SvcConfigElement>().FirstOrDefault(element => element.Name.Equals(name)); }
        }

        public SvcConfigElement this[int index]
        {
            get
            {
                return (SvcConfigElement)BaseGet(index);
            }
        }

        public void Add(SvcConfigElement settings)
        {
            if (settings == null)
            {
                throw new System.ArgumentNullException("settings");
            }
            base.BaseAdd(settings);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SvcConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SvcConfigElement)element).Name;
        }
    }

    /// <summary>
    /// 服务配置项
    /// </summary>
    public class SvcConfigElement : ConfigurationElement
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SvcConfigElement()
        {
        }

        /// <summary>
        /// 服务名
        /// </summary>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return (String)this["name"]; }
            set { this["name"] = value; }
        }

        /// <summary>
        /// 服务类型， 必须实现IService接口
        /// </summary>
        [ConfigurationProperty("type")]
        public string Type
        {
            get { return (string)this["type"]; }
            set { this["type"] = value; }
        }
    }
}
