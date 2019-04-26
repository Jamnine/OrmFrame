using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Orm.Framework.Services;
namespace Orm
{
    public class LocalConfig
    {
        private static List<DbProviderInfo> providerInfoList = new List<DbProviderInfo>();
        public static DbProviderInfo GetProviderInfo(string DbContextName)
        {
            if (LocalConfig.providerInfoList == null || LocalConfig.providerInfoList.Count < 1)
            {
                LocalConfig.GetProviderFromFile();
            }
            DbProviderInfo dbProviderInfo = (
                from ww in LocalConfig.providerInfoList
                where ww.DbContextName == DbContextName
                select ww).FirstOrDefault<DbProviderInfo>();
            if (dbProviderInfo == null)
            {
                IConfiger service = ServiceTaker.GetService<IConfiger>(new object[0]);
                dbProviderInfo = service.GetFirst<DbProviderInfo>(DbContextName);
                LocalConfig.providerInfoList.Remove(dbProviderInfo);
                LocalConfig.providerInfoList.Add(dbProviderInfo);
            }
            return dbProviderInfo;
        }
        private static void GetProviderFromFile()
        {
            using (FileStream fileStream = File.OpenRead(AppSettings.OrmConfigPath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DbProviderInfo>));
                object obj = xmlSerializer.Deserialize(fileStream);
                LocalConfig.providerInfoList = (obj as List<DbProviderInfo>);
            }
        }
    }
}
