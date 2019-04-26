using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 仪器流水号
    /// </summary>  
    public partial class CKMachineSampleMapping : ClassMap<CKMachineSample>
    {
      
        public CKMachineSampleMapping()
        {
            this.TableName("CKMachineSample").Schema("orm");
            this.Column(p => p.TjitemId).ColumnName("TjitemId");
            this.Column(p => p.MachineID).ColumnName("MachineID");
            this.Column(p => p.MatchDate).ColumnName("MatchDate");
            this.Column(p => p.SampleNum).ColumnName("SampleNum");
            this.Column(p => p.SendStatus).ColumnName("SendStatus");
            this.Column(p => p.UserID).ColumnName("UserID");
            //this.Column(p => p.SpecimenCode).ColumnName("SpecimenCode");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.HosID).ColumnName("HosID");
            this.Column(p => p.QCReagentlot).ColumnName("QCReagentlot");
            this.Column(p => p.IsMatching).ColumnName("IsMatching");

            this.Column(p => p.LabId).ColumnName("LabId");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}
