using ELinq;
namespace Orm
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(string Provider, string ConnectString) : base(DbConfiguration.Configure(ConnectString, Provider))
        {
            this.RegisterMapping(base.DbConfiguration);
        }
        public abstract void RegisterMapping(DbConfiguration DbConfiguration);
    }
}