using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping
{
   public class BsGroupSub2Mapping:ClassMap<BsGroupSub2>
    {
        /// <summary>
		/// 项目三级级分组 - 实体类
		/// </summary>
		public BsGroupSub2Mapping()
        {
            this.TableName("BSGROUPSUB2").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.SubId).ColumnName("SUBID");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");




            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
