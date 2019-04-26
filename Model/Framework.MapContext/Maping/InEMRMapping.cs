using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext.Maping
{
    public partial class InEMRMapping : ClassMap<InEMR>
    {
        public InEMRMapping()
        {
            this.TableName("INEMR").Schema("orm");

            this.Column(p => p.RecNo).ColumnName("RECNO");

            this.Column(p => p.OperTime).ColumnName("OPERTIME");

            this.Column(p => p.ModifyOperTime).ColumnName("MODIFYOPERTIME");

            this.Column(p => p.Content).ColumnName("CONTENT");

            this.Column(p => p.XMLFile).ColumnName("XMLFILE");

            this.Column(p => p.IsAuth).ColumnName("ISAUTH");

            this.Column(p => p.AuthOperTime).ColumnName("AUTHOPERTIME");

            this.Column(p => p.XMLContent).ColumnName("XMLCONTENT");

            this.Column(p => p.IsRealease).ColumnName("ISREALEASE");

            this.Column(p => p.RealeaseTime).ColumnName("REALEASETIME");

            this.Column(p => p.IsPrint).ColumnName("ISPRINT");

            this.Column(p => p.PrintTime).ColumnName("PRINTTIME");

            this.Column(p => p.IsClosed).ColumnName("ISCLOSED");

            this.Column(p => p.ClosedTime).ColumnName("CLOSEDTIME");

            this.Column(p => p.IsCheck).ColumnName("ISCHECK");

            this.Column(p => p.IsDelete).ColumnName("ISDELETE");

            this.Column(p => p.OperTime2).ColumnName("OPERTIME2");

            this.Column(p => p.NodeOrderBy).ColumnName("NODEORDERBY");

            this.Column(p => p.DeptName).ColumnName("DEPTNAME");

            this.Column(p => p.BedName).ColumnName("BEDNAME");

            this.Column(p => p.EmrTypeName).ColumnName("EMRTYPENAME");

            this.Column(p => p.SecretLevel).ColumnName("SECRETLEVEL");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HospId).ColumnName("HOSPID");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.CatalogId).ColumnName("CATALOGID");

            this.Column(p => p.OperID).ColumnName("OPERID");

            this.Column(p => p.ModifyOperID).ColumnName("MODIFYOPERID");

            this.Column(p => p.AuthOperId).ColumnName("AUTHOPERID");

            this.Column(p => p.RealeaseOperId).ColumnName("REALEASEOPERID");

            this.Column(p => p.PrintOperId).ColumnName("PRINTOPERID");

            this.Column(p => p.ClosedOperId).ColumnName("CLOSEDOPERID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
