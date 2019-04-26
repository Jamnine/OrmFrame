using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 商城类别Mapping
    /// </summary>
    public partial class BsBusinessCityTypeMapping : ClassMap<BsBusinessCityType>
    {
        public BsBusinessCityTypeMapping()
        {

            this.Column(p => p.GUID).ColumnName("GUID");        
            this.TableName("BSBUSINESSCITYTYPE").Schema("orm");
            this.Column(p => p.BusinessCityName).ColumnName("BUSINESSCITYNAME");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}
