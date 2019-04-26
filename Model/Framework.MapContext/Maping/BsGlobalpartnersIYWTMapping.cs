using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext
{
    public class BsGlobalpartnersIYWTMapping : ClassMap<BsGlobalpartnersIYWT>
    {
        /// <summary>
        /// 医务通登录 - 实体类
        /// </summary>
        public BsGlobalpartnersIYWTMapping()
        {
            this.TableName("BSGLOBALPARTNERSIYWT").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Partner_sn).ColumnName("PARTNER_SN");
            this.Column(p => p.Partner).ColumnName("PARTNER");
            this.Column(p => p.LAT).ColumnName("LAT");
            this.Column(p => p.LNG).ColumnName("LNG");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
