using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class ToothCaseHistoryMapping : ClassMap<ToothCaseHistory>
    {
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public ToothCaseHistoryMapping()
        {
            this.TableName("TOOTHCASEHISTORY").Schema("orm");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.MzRegId).ColumnName("MZREGID");
            this.Column(p =>p.PatId).ColumnName("PATID");
            this.Column(p => p.ToothType).ColumnName("TOOTHTYPE");
            this.Column(p => p.ToothPosition).ColumnName("TOOTHPOSITION");
            this.Column(p => p.MainInform).ColumnName("MAININFORM");
            this.Column(p => p.SickHist).ColumnName("SICKHIST");
            this.Column(p => p.CheckCT).ColumnName("CHECKCT");
            this.Column(p => p.CheckCTXRay).ColumnName("CHECKCTXRAY");
            this.Column(p => p.CheckCTNo).ColumnName("CHECKCTNO");
            this.Column(p => p.Diagnosis).ColumnName("DIAGNOSIS");
            this.Column(p => p.TreatmentPlan).ColumnName("TREATMENTPLAN");
            this.Column(p =>p.OperTime).ColumnName("OPERTIME");
            this.Column(p =>p.OperId).ColumnName("OPERID");
            this.Column(p => p.TreatmentProcess).ColumnName("TREATMENTPROCESS");
            this.Column(p => p.AdviceNotice).ColumnName("ADVICENOTICE");
            this.Column(p => p.IsClearTooths).ColumnName("ISCLEARTOOTHS"); 

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
