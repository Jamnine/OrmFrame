using StackExchange.Redis;
using System;
using System.Configuration;

namespace Ninth.RedisHelper
{
    //public static partial class RedisHelper
    public partial class RedisWriteHelper
    {
        private static readonly string ConnectString = ConfigurationManager.ConnectionStrings["RedisWriteConnection"].ToString();
        private static Lazy<ConnectionMultiplexer> _lazyConnection;
        private static readonly Object MultiplexerLock = new Object();
        private static readonly IDatabase Cache;

        static RedisWriteHelper()//his:0,yun:1,share2
        {
            var conn = CreateManager.Value;
            Cache = conn.GetDatabase(); //获取实例
        }

        private static Lazy<ConnectionMultiplexer> GetManager(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = GetDefaultConnectionString();
            }

            return new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connectionString));
        }

        private static Lazy<ConnectionMultiplexer> CreateManager
        {
            get
            {
                if (_lazyConnection == null)
                {
                    lock (MultiplexerLock)
                    {
                        if (_lazyConnection != null)
                        {
                            return _lazyConnection;
                        }

                        _lazyConnection = GetManager();
                        return _lazyConnection;
                    }
                }

                return _lazyConnection;
            }
        }

        public static string GetDefaultConnectionString()
        {
            return ConnectString;
        }
    }
}