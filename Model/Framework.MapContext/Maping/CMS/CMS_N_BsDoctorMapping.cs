using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Model.CMS;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_N_BsDoctorMapping:ClassMap<CMS_N_BsDoctor>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_N_BsDoctorMapping()
        {
            this.TableName("CMS_N_BSDOCTOR").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.DoctorName).ColumnName("DOCTORNAME");
            this.Column(p => p.DeptId).ColumnName("DEPTID");
            this.Column(p => p.Title).ColumnName("TITLE");
            this.Column(p => p.Gender).ColumnName("GENDER");
            this.Column(p => p.Decsription).ColumnName("DECSRIPTION");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
