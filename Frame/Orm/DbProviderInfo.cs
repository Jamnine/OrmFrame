using System;
namespace Orm
{
    [Serializable]
    public class DbProviderInfo : IEquatable<DbProviderInfo>
    {
        public string DbContextName
        {
            get;
            set;
        }
        public string ConnectionString
        {
            get;
            set;
        }
        public string ProviderName
        {
            get;
            set;
        }
        public int CommandTimeout
        {
            get;
            set;
        }
        public string ContextType
        {
            get;
            set;
        }
        public string ContextAssembly
        {
            get;
            set;
        }
        public bool Equals(DbProviderInfo other)
        {
            return this.DbContextName == other.DbContextName;
        }
    }
}
