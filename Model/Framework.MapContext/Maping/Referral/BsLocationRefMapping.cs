using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XYHis.Model;

namespace XYHis.MapContext
{
    /// <summary>
    ///门诊机构
    /// </summary>
    public partial class BsLocationRefMapping : ClassMap<BsLocationRef>
    {
        /// <summary>
        ///门诊机构
        /// </summary>
        public BsLocationRefMapping()
        {
            this.TableName("BSLOCATION").Schema("orm");


            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.IsInOut).ColumnName("LSINOUT");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.Area).ColumnName("AREA");
            this.Column(p => p.ModiTime).ColumnName("MODITIME");
            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");
            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");
            this.Column(p => p.IsForWomen).ColumnName("IsForWomen");
            this.Column(p => p.PhoneCode).ColumnName("PhoneCode");
            this.Column(p => p.MedicIneratio).ColumnName("MedicIneratio");

            this.Column(p => p.SpeciAlityId).ColumnName("SpeciAlityId");
            this.Column(p => p.BedSum).ColumnName("BedSum");
            this.Column(p => p.BasysCode).ColumnName("BasysCode");
            this.Column(p => p.Director).ColumnName("Director");
            this.Column(p => p.DeptTypeID).ColumnName("DeptTypeID");
            this.Column(p => p.Iscostapp).ColumnName("Iscostapp");
            this.Column(p => p.AppLevel).ColumnName("AppLevel");
            this.Column(p => p.OuRoomId).ColumnName("OuRoomId");
            this.Column(p => p.InRoomId).ColumnName("InRoomId");
            this.Column(p => p.IsPriceSub).ColumnName("IsPriceSub");
            this.Column(p => p.IsClinical).ColumnName("IsClinical");
            this.Column(p => p.IsChinLocation).ColumnName("IsChinLocation");
            this.Column(p => p.IsRegLocation).ColumnName("IsRegLocation");
            this.Column(p => p.IsAllLocation).ColumnName("IsAllLocation");




            this.Id(T => T.GUID).DbGenerated();
            this.SequenceId(t => t.GUID).SequenceName("BSLOCATION_ID_SEQ");
            this.Ignore(p => p.IsModify);
        }
    }
}