using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 免责声明表
    /// </summary>
    public partial class BsDisclaimerMapping : ClassMap<BsDisclaimer>
    {        
        /// <summary>
        /// 免责声明表
        /// </summary>
        public BsDisclaimerMapping()
        {
            this.TableName("BsDisclaimer").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Detail).ColumnName("Detail");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


