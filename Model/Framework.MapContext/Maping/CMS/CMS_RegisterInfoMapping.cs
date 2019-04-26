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
    public class CMS_RegisterInfoMapping: ClassMap<CMS_RegisterInfo>
    {
        /// <summary>
        /// 
        /// </summary>
        public CMS_RegisterInfoMapping()
        {
            this.TableName("CMS_REGISTERINFO").Schema("orm");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.OrderId).ColumnName("ORDERID");
            this.Column(p => p.UserId).ColumnName("USERID");
            this.Column(p => p.RegTime).ColumnName("REGTIME");
            this.Column(p => p.TimeSpan).ColumnName("TIMESPAN");
            this.Column(p => p.DeptId).ColumnName("DEPTID");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.OrderTime).ColumnName("ORDERTIME");
            this.Column(p => p.Totalfee).ColumnName("TOTALFEE");
            this.Column(p => p.UserCode).ColumnName("USERCODE");
            this.Column(p => p.ShiftId).ColumnName("SHIFTID");
            this.Column(p => p.StateCode).ColumnName("STATECODE");
            this.Column(p => p.Remarks).ColumnName("REMARKS");
            this.Column(p => p.RefundTime).ColumnName("REFUNDTIME");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
