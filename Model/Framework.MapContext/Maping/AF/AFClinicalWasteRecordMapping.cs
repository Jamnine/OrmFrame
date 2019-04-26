using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// AFClinicalWasteRecord.  Mapping  
    /// 医疗废物记录表
    /// </summary>  
    public partial class AFClinicalWasteRecordMapping : ClassMap<AFClinicalWasteRecord>
    {
        /// <summary>  
        /// Stru  医疗废物记录表
        /// </summary>  
        public AFClinicalWasteRecordMapping()
        {
            this.TableName("AFCLINICALWASTERECORD").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.RecordMonth).ColumnName("RECORDMONTH");
            this.Column(p => p.RecordDay).ColumnName("RECORDDAY");
            this.Column(p => p.InfectWeight).ColumnName("INFECTWEIGHT");
            this.Column(p => p.PathologicWeight).ColumnName("PATHOLOGICWEIGHT");
            this.Column(p => p.TraumaticWeight).ColumnName("TRAUMATICWEIGHT");
            this.Column(p => p.DrugsWeight).ColumnName("DRUGSWEIGHT");
            this.Column(p => p.ChemicalWeight).ColumnName("CHEMICALWEIGHT");
            this.Column(p => p.HandDate).ColumnName("HANDDATE");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.HandLocManID).ColumnName("HANDLOCMANID");
            this.Column(p => p.SpeciallyManID).ColumnName("SPECIALLYMANID");
            this.Column(p => p.InstitutionManID).ColumnName("INSTITUTIONMANID");
            this.Column(p => p.GoManID).ColumnName("GOMANID");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


