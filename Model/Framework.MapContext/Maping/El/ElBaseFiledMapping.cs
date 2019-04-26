using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping.El
{
    /// <summary>
    /// 
    /// </summary>
    public class ElBaseFiledMapping : ClassMap<ElBaseFiled>
    {
        /// <summary>
        /// 
        /// </summary>
        public ElBaseFiledMapping()
        {
            this.TableName("ELBASEFILED").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.ErrorTips).ColumnName("ERRORTIPS");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalID).ColumnName("HospitalID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IsEncrypt).ColumnName("ISENCRYPT");
            this.Column(p => p.IsHasChild).ColumnName("ISHASCHILD");
            this.Column(p => p.IsLog).ColumnName("ISLOG");
            this.Column(p => p.IsMustWrite).ColumnName("ISMUSTWRITE");
            this.Column(p => p.Lengh).ColumnName("LENGH");
            this.Column(p => p.LsdataType).ColumnName("LSDATATYPE");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.NameType).ColumnName("NAMETYPE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.TagOrder).ColumnName("TAGORDER");
            this.Column(p => p.TagType).ColumnName("TAGTYPE");
            this.Column(p => p.ToolTips).ColumnName("TOOLTIPS");
            this.Column(p => p.EditMask).ColumnName("EDITMASK");
            this.Column(p => p.BaseTableId).ColumnName("BASETABLEID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
