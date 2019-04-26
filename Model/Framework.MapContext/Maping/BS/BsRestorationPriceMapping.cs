using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm;
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    public class BsRestorationPriceMapping: ClassMap<BsRestorationPrice>
    {
        public BsRestorationPriceMapping()
        {
            this.TableName("BSRESTORATIONPRICE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.RestorationId).ColumnName("RESTORATIONID");
            this.Column(p => p.FactoryId).ColumnName("FACTORYID");
            this.Column(p=>p.Price).ColumnName("PRICE");

            this.Column(p => p.RestorationName).ColumnName("RESTORATIONNAME");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
