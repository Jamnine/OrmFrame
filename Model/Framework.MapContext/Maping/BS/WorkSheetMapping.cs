using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///
    /// </summary>
    public partial class WorkSheetMapping: ClassMap<WorkSheet>
    {        
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public WorkSheetMapping()
        {
            this.TableName("WORKSHEET").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.ToothPosition).ColumnName("TOOTHPOSITION");
            this.Column(p => p.ProcessingFactory).ColumnName("PROCESSINGFACTORY");
            this.Column(p => p.SalesMan).ColumnName("SALESMAN");
            this.Column(p => p.OrderType).ColumnName("ORDERTYPE");
            this.Column(p => p.Restoration).ColumnName("RESTORATION");
            this.Column(p => p.Colorimetric).ColumnName("COLORIMETRIC");
            this.Column(p => p.Amount).ColumnName("AMOUNT");
            this.Column(p => p.RepairType).ColumnName("REPAIRTYPE");
            this.Column(p => p.BillNo).ColumnName("BILLNO");
            this.Column(p => p.DoctorId).ColumnName("DOCTORID");
            this.Column(p => p.PriceIn).ColumnName("PRICEIN");
            this.Column(p => p.SendTime).ColumnName("SENDTIME");
            this.Column(p => p.EmergencyType).ColumnName("EMERGENCYTYPE");
            this.Column(p => p.FinishTime).ColumnName("FINISHTIME");
            this.Column(p => p.TryoutTime).ColumnName("TRYOUTTIME");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.Attachment).ColumnName("ATTACHMENT");
            this.Column(p => p.PatId).ColumnName("PatId");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");
            this.Column(p => p.ModiOperTime).ColumnName("ModiOperTime");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.WorkTypeId).ColumnName("WORKTYPEID");
            this.Column(p => p.NoDoTime).ColumnName("NODOTIME");
            this.Column(p => p.DoneTime).ColumnName("DONETIME");
            this.Column(p => p.GetOutime).ColumnName("GETOUTIME");
            this.Column(p => p.WearTime).ColumnName("WEARTIME");
            this.Column(p => p.TakeOutime).ColumnName("TAKEOUTIME");
            this.Column(p => p.ReturnTime).ColumnName("RETURNTIME");
            this.Column(p => p.Totality).ColumnName("TOTALITY");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


