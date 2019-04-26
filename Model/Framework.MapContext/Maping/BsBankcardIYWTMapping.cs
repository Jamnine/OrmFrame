using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    public class BsBankcardIYWTMapping : ClassMap<BsBankcardIYWT>
    {
        public BsBankcardIYWTMapping()
        {
            this.TableName("BSBANKCARDIYWT").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Login_id).ColumnName("LOGINID");
            this.Column(p => p.Bank).ColumnName("BANK");
            this.Column(p => p.Card).ColumnName("CARD");
            this.Column(p => p.CardType).ColumnName("CARDTYPE");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
