using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Framework.Services.Utility;

namespace Orm.Client.Common
{
    public class ConfigFilesManager<T> where T : class
    {
        private static string _file;


        public static void SaveToBinary(string key, T obj)
        {
            _file = ConfigFileName.GetFileName(key);
            SerializeHelper<T> ser = new SerializeHelper<T>();
            ser.Serialize(true, _file, obj);
        }

        public static T GetFromBinary(string key)
        {
            _file = ConfigFileName.GetFileName(key);
            SerializeHelper<T> ser = new SerializeHelper<T>();
            return ser.Deserialize(true, _file);
        }
        public static void SaveToXml(string key, T obj)
        {
            _file = ConfigFileName.GetFileName(key);
            XmlHelper.ToXml(obj, _file, true);
        }
        public static T GetFromXml(string key)
        {
            _file = ConfigFileName.GetFileName(key);
            return XmlHelper.XmlToFromFile(_file, typeof(T)) as T;
        }
    }



    public class ConfigManager<T> where T : absConfigModel, new()
    {
        public static void SaveToList(string type, T info)
        {

            ConfigurationList<T> list;
            try
            {
                list = ConfigFilesManager<ConfigurationList<T>>.GetFromXml(type);
            }
            catch
            {
                list = new ConfigurationList<T>();
            }
            list.Add(info.Key, info);
            try
            {
                ConfigFilesManager<ConfigurationList<T>>.SaveToXml(type, list);
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        public static void SaveList(string type, ConfigurationList<T> list)
        {
            try
            {
                ConfigFilesManager<ConfigurationList<T>>.SaveToXml(type, list);
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 返回配置的List
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ConfigurationList<T> GetList(string type)
        {

            ConfigurationList<T> list;
            try
            {
                list = ConfigFilesManager<ConfigurationList<T>>.GetFromXml(type);
            }
            catch //(System.Exception ex)
            {
                list = null;
            }
            return list;
        }

        public static T GetInfo(string type, string key)
        {
            ConfigurationList<T> list = GetList(type);
            if (list == null) return default(T);
            return list[key];
        }
    }



    public class ConfigFileName
    {

        public static string LocaPat = string.Empty;

        public static string GetDefaultPath(string key)
        {
            string basePath;
            if (LocaPat == string.Empty) LocaPat = AppDomain.CurrentDomain.BaseDirectory;
            //if (!basePath.EndsWith("\\")) basePath = basePath + "\\";
            basePath = LocaPat;
            if (key.Contains('.'))
            {
                basePath += "\\ConfigFiles\\" + key.Substring(0, key.IndexOf(".")) + "\\";
            }else
                basePath += "\\ConfigFiles\\";

            if (!System.IO.Directory.Exists(basePath)) System.IO.Directory.CreateDirectory(basePath);

            return basePath;
        }
        public static string GetFileName(string key)
        {
            return GetDefaultPath(key) + key + ".config";
        }



    }
}
