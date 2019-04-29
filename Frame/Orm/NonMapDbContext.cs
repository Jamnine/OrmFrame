using ELinq;
namespace Orm
{
    internal class NonMapDbContext : BaseDbContext
    {
        public NonMapDbContext(string Provider, string ConnectString) : base(Provider, ConnectString)
        {
        }
        public override void RegisterMapping(DbConfiguration DbConfiguration)
        {
        }
    }
}
