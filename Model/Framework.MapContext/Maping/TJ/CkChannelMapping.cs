using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 标本 
    /// </summary>  
    public partial class CkChannelMapping : ClassMap<CkChannel>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public CkChannelMapping()
        {
            this.TableName("CkChannel").Schema("orm");
            this.Column(p => p.CKMId).ColumnName("CKMId");
            this.Column(p => p.CkitemCode).ColumnName("CkitemCode");
            this.Column(p => p.ItemInterface).ColumnName("ItemInterface");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}
