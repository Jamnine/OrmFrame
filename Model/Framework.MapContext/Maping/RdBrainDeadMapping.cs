using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.MapContext
{
    public class RdBrainDeadMapping : ClassMap<RdBrainDead>
    {
        public RdBrainDeadMapping()
        {
            this.TableName("RDBRAINDEAD").Schema("orm"); 
            this.Column(p => p.GUID).ColumnName("GUID"); 
            this.Column(p => p.Code).ColumnName("CODE"); 
            this.Column(p => p.DeadCause).ColumnName("DEADCAUSE"); 
            this.Column(p => p.DeadDate).ColumnName("DEADDATE"); 
            this.Column(p => p.DeadICD).ColumnName("DEADICD"); 
            this.Column(p => p.DiagDate).ColumnName("DIAGDATE"); 
            this.Column(p => p.ElseIllness).ColumnName("ELSEILLNESS"); 
            this.Column(p => p.ElseIllnessICD).ColumnName("ELSEILLNESSICD"); 
            this.Column(p => p.F1).ColumnName("F1"); 
            this.Column(p => p.F2).ColumnName("F2");
            this.Column(p => p.F3).ColumnName("F3");
            this.Column(p => p.F4).ColumnName("F4");
            this.Column(p => p.FormerlyIllness).ColumnName("FORMERLYILLNESS");
            this.Column(p => p.ICDId).ColumnName("ICDID");
            this.Column(p => p.IllDate).ColumnName("ILLDATE");
            this.Column(p => p.IllId).ColumnName("ILLID");
            this.Column(p => p.IllTimes).ColumnName("ILLTIMES");
            this.Column(p => p.ImmediacyDead).ColumnName("IMMEDIACYDEAD");
            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");
            this.Column(p => p.LocId).ColumnName("LOCID");
            this.Column(p => p.LsCardType).ColumnName("LSCARDTYPE");
            this.Column(p => p.LsCensus).ColumnName("LSCENSUS");
            this.Column(p => p.LsIllBase).ColumnName("LSILLBASE");
            this.Column(p => p.LsIllType).ColumnName("LSILLTYPE");
            this.Column(p => p.LsLastTime).ColumnName("LSLASTTIME");
            this.Column(p => p.MzRegId).ColumnName("MZREGID");
            this.Column(p => p.OperID).ColumnName("OPERID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.PatId).ColumnName("PATID");
            this.Column(p => p.ReciOperId).ColumnName("RECIOPERID");
            this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");
            this.Column(p => p.ReportDate).ColumnName("REPORTDATE");
            this.Column(p => p.ReportUnit).ColumnName("REPORTUNIT");
            this.Column(p => p.RowStatus).ColumnName("ROWSTATUS");
            this.Column(p => p.YDiagDate).ColumnName("YDIAGDATE");
            this.Column(p => p.RedisConditionValus).ColumnName("REDISCONDITIONVALUS");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }
    }
}
