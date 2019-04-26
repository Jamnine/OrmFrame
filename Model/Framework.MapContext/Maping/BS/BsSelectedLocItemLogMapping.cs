using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 导入药品记录表
    /// </summary>
    public class BsSelectedLocItemLogMapping : ClassMap<BsSelectedLocItemLog>
    {
        public BsSelectedLocItemLogMapping()
        {
            this.TableName("BsSelectedLocItemLog").Schema("orm");

            this.Column(p => p.ItemId).ColumnName("ItemId");
            this.Column(p => p.ItemCode).ColumnName("ItemCode");
            this.Column(p => p.LocationId).ColumnName("HospitalID");

            this.Column(p => p.GUID).ColumnName("GUID");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 

        }
        
    }
}
