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
    public class CMS_PcUserMapping: ClassMap<CMS_PcUser>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_PcUserMapping()
        {
            this.TableName("CMS_PCUSER").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.UserName).ColumnName("USERNAME");
            this.Column(p => p.PassWord).ColumnName("PASSWORD");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.Mobile).ColumnName("MOBILE");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Sex).ColumnName("SEX");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
