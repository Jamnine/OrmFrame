using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 服务细表
    /// </summary>
    public partial class OuServiceDtlMapping : ClassMap<OuServiceDtl>
    {
        public OuServiceDtlMapping()
        {
            this.TableName("OuServiceDtl").Schema("orm");

            this.Column(p => p.BsItemId).ColumnName("ITEMID");
            this.Column(p => p.OuServiceId).ColumnName("OUSERVICEID");
            this.Column(p => p.OuHosInfoId).ColumnName("MZREGID");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);  
        }
    }
}
