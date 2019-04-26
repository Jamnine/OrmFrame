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
    public class CMS_BsSchInfoMapping:ClassMap<CMS_BsSchInfo>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_BsSchInfoMapping()
        {
            this.TableName("CMS_BSSCHINFO").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.ShiftId).ColumnName("SHIFTID");
            this.Column(p => p.ShiftType).ColumnName("SHIFTTYPE");
            this.Column(p => p.SchDate).ColumnName("SCHDATE");
            this.Column(p => p.SchRegTypeId).ColumnName("SCHREGTYPEID");
            this.Column(p => p.SchFee).ColumnName("SCHFEE");
            this.Column(p => p.SchRegfee).ColumnName("SCHREGFEE");
            this.Column(p => p.SchTreatfee).ColumnName("SCHTREATFEE");
            this.Column(p => p.SchBegintime).ColumnName("SCHBEGINTIME");
            this.Column(p => p.SchEndtime).ColumnName("SCHENDTIME");
            this.Column(p => p.SchRegMax).ColumnName("SCHREGMAX");
            this.Column(p => p.SchLimited).ColumnName("SCHLIMITED");
            this.Column(p => p.SchSegmented).ColumnName("SCHSEGMENTED");
            this.Column(p => p.LocationId).ColumnName("LOCATIONID");
            this.Column(p => p.Available).ColumnName("AVAILABLE");
            this.Column(p => p.SchRegCount).ColumnName("SCHREGCOUNT");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
