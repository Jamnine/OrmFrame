using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Orm.Framework.Services;
namespace Orm
{
    public class PersistManeger
    {
        //以键值对形式保存数据库上下文的数据库访问方法集合CommPersist
        private static Dictionary<string, CommPersist> PersistDict = new Dictionary<string, CommPersist>();
        private static readonly object locker = new object();
        /// <summary>
        /// 通过数据库上下文名称获取数据库上下文,进而得到数据库访问方法集合IDataPersist
        /// </summary>
        public static IDataPersist GetDataPersist(string pDbContextName)
        {
            CommPersist commPersist = null;
            try
            {
                //键值对中已经存在的,直接获取
                commPersist = PersistManeger.PersistDict[pDbContextName];
            }
            catch
            {
            }
            if (commPersist == null)
            {
                DbProviderInfo theProveder = LocalConfig.GetProviderInfo(pDbContextName);
                BaseDbContext pDbContext;
                if (!string.IsNullOrWhiteSpace(theProveder.ContextAssembly))
                {
                    //theProveder.ContextAssembly为Orm.MapContext,也是在OrmConfig文件中有配置的
                    List<Type> source = (
                        from tt in Assembly.LoadFrom(Path.Combine(AppSettings.BinPath, theProveder.ContextAssembly)).GetTypes()
                        where tt.BaseType == typeof(BaseDbContext)
                        select tt).ToList<Type>();
                    if (string.IsNullOrWhiteSpace(theProveder.ContextType))
                    {
                        source = (
                            from tt in source
                            where tt.FullName == theProveder.ContextType
                            select tt).ToList<Type>();
                    }
                    /*
                     * 下面的代码通过反射执行RegisterMapContext类(此类继承了BaseDbContext)里面的构造函数
                     * 即执行了BaseDbContext里面的RegisterMapping方法，从而得到数据库上下文的实例
                     */
                    Type type = source.FirstOrDefault<Type>();
                    ConstructorInfo constructor = type.GetConstructor(new Type[]
                    {
                        typeof(string),
                        typeof(string)
                    });
                    pDbContext = (BaseDbContext)constructor.Invoke(new object[]
                    {
                        theProveder.ProviderName,
                        theProveder.ConnectionString
                    });
                }
                else
                {
                    pDbContext = new NonMapDbContext(theProveder.ProviderName, theProveder.ConnectionString);
                }
                commPersist = new CommPersist(pDbContext, pDbContextName);
                lock (PersistManeger.locker)
                {
                    PersistManeger.PersistDict[pDbContextName] = commPersist;
                    CommPersist.connectionDic[pDbContextName] = theProveder.ConnectionString;
                }
            }
            return commPersist;
        }
        public static IDataPersist GetDataPersist(DbProviderInfo pProviderInfo)
        {
            CommPersist commPersist = null;
            try
            {
                commPersist = PersistManeger.PersistDict[pProviderInfo.DbContextName];
            }
            catch
            {
            }
            if (commPersist == null)
            {
                BaseDbContext pDbContext;
                if (!string.IsNullOrWhiteSpace(pProviderInfo.ContextAssembly))
                {
                    List<Type> source = (
                        from tt in Assembly.LoadFrom(Path.Combine(AppSettings.BinPath, pProviderInfo.ContextAssembly)).GetTypes()
                        where tt.BaseType == typeof(BaseDbContext)
                        select tt).ToList<Type>();
                    if (string.IsNullOrWhiteSpace(pProviderInfo.ContextType))
                    {
                        source = (
                            from tt in source
                            where tt.FullName == pProviderInfo.ContextType
                            select tt).ToList<Type>();
                    }
                    Type type = source.FirstOrDefault<Type>();
                    ConstructorInfo constructor = type.GetConstructor(new Type[]
                    {
                        typeof(string),
                        typeof(string)
                    });
                    pDbContext = (BaseDbContext)constructor.Invoke(new object[]
                    {
                        pProviderInfo.ProviderName,
                        pProviderInfo.ConnectionString
                    });
                }
                else
                {
                    pDbContext = new NonMapDbContext(pProviderInfo.ProviderName, pProviderInfo.ConnectionString);
                }
                commPersist = new CommPersist(pDbContext, pProviderInfo.DbContextName);
                lock (PersistManeger.locker)
                {
                    PersistManeger.PersistDict[pProviderInfo.DbContextName] = commPersist;
                    CommPersist.connectionDic[pProviderInfo.DbContextName] = pProviderInfo.ConnectionString;
                }
            }
            return commPersist;
        }
    }
}
