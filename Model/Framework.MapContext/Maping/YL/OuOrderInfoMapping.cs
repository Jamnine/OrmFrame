using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    public class OuOrderInfoMapping : ClassMap<OuOrderInfo>
    {
        public OuOrderInfoMapping()
        {
            this.TableName("OuOrderInfo").Schema("orm");
            this.Column(p => p.BillNo).ColumnName("BillNo");
            this.Column(p => p.PatId).ColumnName("PatId");
            this.Column(p => p.ItemId).ColumnName("ItemId");
            this.Column(p => p.OrderStart).ColumnName("OrderStart");
            this.Column(p => p.OrderLive).ColumnName("OrderLive");
            this.Column(p => p.PayWay).ColumnName("PayWay");
            this.Column(p => p.PayStart).ColumnName("PayStart");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.ProvinceId).ColumnName("ProvinceId");
            this.Column(p => p.RegionId).ColumnName("RegionId");
            this.Column(p => p.AreaId).ColumnName("AreaId");
            this.Column(p => p.Address).ColumnName("Address");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.ServiceTime).ColumnName("ServiceTime");
            this.Column(p => p.DateRemarks).ColumnName("DateRemarks");
            this.Column(p => p.OrderType).ColumnName("ORDERTYPE");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
