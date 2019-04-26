using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 转诊医院科室表
    /// </summary>
    public partial class BSRefHospitalMapping : ClassMap<BSRefHospital>
    {
        /// <summary>
        /// 
        /// </summary>
        public BSRefHospitalMapping()
        {
            this.TableName("BSREFHOSPITAL").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HospitalMc).ColumnName("HOSPITALMC");
            this.Column(p => p.DepartmentMc).ColumnName("DEPARTMENTMC");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
