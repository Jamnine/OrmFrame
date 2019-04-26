using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///
    /// </summary>
    public partial class BsLockMapping : ClassMap<BsLock>
    {
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public BsLockMapping()
        {
            this.TableName("BSLOCK").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.OuhosinfoId).ColumnName("OuhosinfoId");
            this.Column(p => p.Version).ColumnName("Version");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


