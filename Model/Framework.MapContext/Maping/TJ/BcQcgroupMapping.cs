using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 标准样品
    /// </summary>  
    public partial class BcQcgroupMapping : ClassMap<BcQcgroup>
    {
        /// <summary>  
        /// 标准样品
        /// </summary>  
        public BcQcgroupMapping()
        {
            this.TableName("BcQcgroup").Schema("orm");
            this.Column(p => p.QcgroupName).ColumnName("QcgroupName");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
   
}
