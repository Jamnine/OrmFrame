using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    /// <summary>
    /// 护理系统管理员信息
    /// </summary>
    public class AdminMapping:ClassMap<Admin>
    {
        /// <summary>
        /// 
        /// </summary>
        public AdminMapping()
        {
            this.TableName("Admin").Schema("orm");
            this.Column(p => p.Address).ColumnName("ADDRESS");
            this.Column(p => p.CloseTime).ColumnName("CLOSETIME");
            this.Column(p => p.CreateTime).ColumnName("CREATETIME");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.LastTime).ColumnName("LASTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OrganizationId).ColumnName("ORGANIZATIONID");
            this.Column(p => p.Password).ColumnName("PASSWORD");
            this.Column(p => p.Phone).ColumnName("PHONE");
            this.Column(p => p.PIC).ColumnName("PIC");
            this.Column(p => p.Qualifications).ColumnName("QUALIFICATIONS");
            this.Column(p => p.RoleId).ColumnName("ROLEID");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Type).ColumnName("TYPE");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
