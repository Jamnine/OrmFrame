using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  版本信息
    /// </summary> 
    public partial class BsVersionMapping : ClassMap<BsVersion>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsVersionMapping()
        {
            this.TableName("BSVERSION").Schema("orm");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.AnnualFee).ColumnName("AnnualFee");
            this.Column(p => p.CurrentVersionNum).ColumnName("CurrentVersionNum");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


