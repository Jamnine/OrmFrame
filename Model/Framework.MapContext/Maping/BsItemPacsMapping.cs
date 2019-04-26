using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 影像项目 - 实体类
    /// </summary>
    public partial class BsItemPacsMapping:ClassMap<BsItemPacs>
    {
        /// <summary>
        /// 影像项目 - 实体类
        /// </summary>
        public BsItemPacsMapping ()
        {
            this.TableName("BsItemPacs").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");           
              
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.XType).ColumnName("XType");
            this.Column(p => p.Equipment).ColumnName("EQUIPMENT");
            this.Column(p => p.CheckBody).ColumnName("CHECKBODY");

            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ItemId).ColumnName("ITEMID");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");



            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
