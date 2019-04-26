using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext.Maping.CMS
{
    /// <summary>
    /// 
    /// </summary>
    public class CMS_DoctorAccountMapping : ClassMap<CMS_DoctorAccount>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_DoctorAccountMapping()
        {
            this.TableName("CMS_DOCTORACCOUNT").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Department).ColumnName("DEPARTMENT");
            this.Column(p => p.UserName).ColumnName("USERNAME");
            this.Column(p => p.Password).ColumnName("PASSWORD");
            this.Column(p => p.StateCode).ColumnName("STATECODE");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
