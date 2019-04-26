using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 项目对应病案首页的费用类别表 
    /// </summary>
    public partial class BsItemFirstPageMapping:ClassMap<BsItemFirstPage>
    {
        /// <summary>
        /// 项目对应病案首页的费用类别表 
        /// </summary>
        public BsItemFirstPageMapping ()
        {
            this.TableName("BsItemFirstPage").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.ItemId).ColumnName("ITEMID");
            this.Column(p => p.PsFeeId).ColumnName("PSFEEID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
