using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 科室核算费用分类 - mapping
    /// </summary>
    public partial class BsHsFeetyMapping: ClassMap<BsHsFeety>
    {
        /// <summary>
        /// 科室核算费用分类
        /// </summary>
        public BsHsFeetyMapping()
        {
            this.TableName("BsHsFeety").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.IsDrug).ColumnName("IsDrug");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

         

            this.Column(p => p.HospitalId).ColumnName("HospitalID");




            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
