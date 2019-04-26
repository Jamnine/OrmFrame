using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class RdInfectiousNewMapping : ClassMap<RdInfectiousNew>
    {
        public RdInfectiousNewMapping()
        {
            this.TableName("RDINFECTIOUSNEW").Schema("orm");
            this.Column(p => p.AfpId).ColumnName("AFPID");
            this.Column(p => p.AgeType).ColumnName("AGETYPE");
            this.Column(p => p.ApplyId).ColumnName("APPLYID");
            this.Column(p => p.Areas).ColumnName("AREAS");
            this.Column(p => p.AttackDate).ColumnName("ATTACKDATE");
            this.Column(p => p.Authopt ).ColumnName("AUTHOPT");
            this.Column(p => p.BirthDate ).ColumnName("BIRTHDATE");
            this.Column(p => p.CancelOperId ).ColumnName("CANCELOPERID");
            this.Column(p => p.CancelOperTime ).ColumnName("CANCELOPERTIME");
            this.Column(p => p.CardNo ).ColumnName("CARDNO");
            this.Column(p => p.CardType ).ColumnName("CARDTYPE");
            this.Column(p => p.ChkOperId ).ColumnName("CHKOPERID");
            this.Column(p => p.ChkOperTime ).ColumnName("CHKOPERTIME");
            this.Column(p => p.City ).ColumnName("CITY");
            this.Column(p => p.CklisproId ).ColumnName("CKLISPROID");
            this.Column(p => p.Code ).ColumnName("CODE");
            this.Column(p => p.Company ).ColumnName("COMPANY");
            this.Column(p => p.ContractPhone ).ColumnName("CONTRACTPHONE");
            this.Column(p => p.Countryside ).ColumnName("COUNTRYSIDE");
            this.Column(p => p.County ).ColumnName("COUNTY");
            this.Column(p => p.DeathDate ).ColumnName("DEATHDATE");
            this.Column(p => p.DoorNo ).ColumnName("DOORNO");
            this.Column(p => p.Firstdiseases ).ColumnName("FIRSTDISEASES");
            this.Column(p => p.HospId ).ColumnName("HOSPID");
            this.Column(p => p.IllnameId ).ColumnName("ILLNAMEID");
            this.Column(p => p.IllnessType1 ).ColumnName("ILLNESSTYPE1");
            this.Column(p => p.IllnessType2 ).ColumnName("ILLNESSTYPE2");
            this.Column(p => p.InhosmzillDate ).ColumnName("INHOSMZILLDATE");
            this.Column(p => p.Isactive ).ColumnName("ISACTIVE");
            this.Column(p => p.Isauthed ).ColumnName("ISAUTHED");
            this.Column(p => p.IsbackWrite ).ColumnName("ISBACKWRITE");
            this.Column(p => p.IsWrite ).ColumnName("ISWRITE");
            this.Column(p => p.LocId).ColumnName("LOCID");
            this.Column(p => p.Mobile).ColumnName("MOBILE");
            this.Column(p => p.MzregId).ColumnName("MZREGID");
            this.Column(p => p.Note).ColumnName("NOTE");

            this.Column(p => p.OccupationType).ColumnName("OCCUPATIONTYPE");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.ParentName).ColumnName("PARENTNAME");
            this.Column(p => p.PatId).ColumnName("PATID");
            this.Column(p => p.PrnumberStart).ColumnName("PRNUMBERSTART");
            this.Column(p => p.Province).ColumnName("PROVINCE");
            this.Column(p => p.PspacsproId).ColumnName("PSPACSPROID");
            this.Column(p => p.Qillness).ColumnName("QILLNESS");
            this.Column(p => p.ReciOperId).ColumnName("RECIOPERID");
            this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");
            this.Column(p => p.RemindingOperTime).ColumnName("REMINDINGOPERTIME");
            this.Column(p => p.Reporting).ColumnName("REPORTING");
            this.Column(p => p.RevisedName).ColumnName("REVISEDNAME");
            this.Column(p => p.RowStatus).ColumnName("ROWSTATUS");
            this.Column(p => p.SeconddiSeases).ColumnName("SECONDDISEASES");
            this.Column(p => p.Statutory).ColumnName("STATUTORY");
            this.Column(p => p.Strage).ColumnName("STRAGE");
            this.Column(p => p.ThirddiSeases).ColumnName("THIRDDISEASES");
            this.Column(p => p.Village).ColumnName("VILLAGE");
            this.Column(p => p.WithDrawal).ColumnName("WITHDRAWAL"); 

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
        	
    }
}
