using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    public class BsBedFloorMapping : ClassMap<BsBedFloor>
    {
        public BsBedFloorMapping()
        {
            this.TableName("BSBEDFLOOR").Schema("orm");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.PrintName).ColumnName("PRINTNAME");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.Nurse).ColumnName("NURSE");

            this.Column(p => p.NurseStaff).ColumnName("NURSESTAFF");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
