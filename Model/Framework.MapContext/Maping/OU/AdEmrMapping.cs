using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///病历信息
    /// </summary> 
    public partial class AdEmrMapping : ClassMap<AdEmr>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public AdEmrMapping()
        {
            this.TableName("ADEMR").Schema("orm");
            this.Column(p => p.Abortion).ColumnName("Abortion");
            this.Column(p => p.Complaint).ColumnName("Complaint");
            this.Column(p => p.PresentHistory).ColumnName("PresentHistory");
            this.Column(p => p.SurgeryHistory).ColumnName("SurgeryHistory");
            this.Column(p => p.MedicalHistory).ColumnName("MedicalHistory");
            this.Column(p => p.InfectionHistory).ColumnName("InfectionHistory");
            this.Column(p => p.ImmunizationHistory).ColumnName("ImmunizationHistory");
            this.Column(p => p.OtherHistory).ColumnName("OtherHistory");
            this.Column(p => p.AllErgy).ColumnName("AllErgy");
            this.Column(p => p.TT).ColumnName("TT");
            this.Column(p => p.TP).ColumnName("TP");
            this.Column(p => p.TR).ColumnName("TR");
            this.Column(p => p.TBP).ColumnName("TBP");
            this.Column(p => p.Diagnosis).ColumnName("Diagnosis");
            this.Column(p => p.Treatment).ColumnName("Treatment");
            this.Column(p => p.DoctorId).ColumnName("DoctorId");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
            this.Column(p => p.FamilyHistoryOther).ColumnName("FamilyHistoryOther");
            this.Column(p => p.Menarche).ColumnName("Menarche");
            this.Column(p => p.PhysicalCheck).ColumnName("PhysicalCheck");
            this.Column(p => p.UsDrugCase).ColumnName("UsDrugCase");
            this.Column(p => p.SpecialistId).ColumnName("SpecialistID");

            #region 爱宝贝
            this.Column(p => p.WHR).ColumnName("WHR");
            this.Column(p => p.BMI).ColumnName("BMI");
            this.Column(p => p.Waist).ColumnName("Waist");
            this.Column(p => p.Abdominal).ColumnName("Abdominal");
            this.Column(p => p.MenarcheTime).ColumnName("MenarcheTime");
            this.Column(p => p.ThroughDay).ColumnName("ThroughDay");
            this.Column(p => p.IsDysmenorrhea).ColumnName("IsDysmenorrhea");
            this.Column(p => p.IsDyspareunia).ColumnName("IsDyspareunia");
            this.Column(p => p.MarriageStatus).ColumnName("MarriageStatus");
            this.Column(p => p.IsSeparation).ColumnName("IsSeparation");
            this.Column(p => p.IsContraception).ColumnName("IsContraception");
            this.Column(p => p.ContraceptionWay).ColumnName("ContraceptionWay");
            this.Column(p => p.SexUalFrequency).ColumnName("SexUalFrequency");
            this.Column(p => p.G).ColumnName("G");
            this.Column(p => p.P).ColumnName("P");
            this.Column(p => p.Abortion).ColumnName("Abortion");
            this.Column(p => p.Miscarriage).ColumnName("Miscarriage");
            this.Column(p => p.InDuced).ColumnName("InDuced");
            this.Column(p => p.NaturalBirth).ColumnName("NaturalBirth");
            this.Column(p => p.CesareanSection).ColumnName("CesareanSection");
            this.Column(p => p.CurettAge).ColumnName("CurettAge");
            this.Column(p => p.EcTopicPregnancy).ColumnName("EcTopicPregnancy");
            this.Column(p => p.IsChildBirthCp).ColumnName("IsChildBirthCp");
            this.Column(p => p.BiocheMicalpregnancy).ColumnName("BiocheMicalpregnancy");
            this.Column(p => p.Complaint).ColumnName("Complaint");
            this.Column(p => p.PresentHistory).ColumnName("PresentHistory");
            this.Column(p => p.SurgeryHistory).ColumnName("SurgeryHistory");
            this.Column(p => p.MedicalHistory).ColumnName("MedicalHistory");
            this.Column(p => p.InfectionHistory).ColumnName("InfectionHistory");
            this.Column(p => p.ImmunizationHistory).ColumnName("ImmunizationHistory");
            this.Column(p => p.OtherHistory).ColumnName("OtherHistory");
            this.Column(p => p.AllErgy).ColumnName("AllErgy");
            this.Column(p => p.Smoke).ColumnName("Smoke");
            this.Column(p => p.Wine).ColumnName("Wine");
            this.Column(p => p.Pet).ColumnName("Pet");
            this.Column(p => p.TT).ColumnName("TT");
            this.Column(p => p.TP).ColumnName("TP");
            this.Column(p => p.TR).ColumnName("TR");
            this.Column(p => p.TBP).ColumnName("TBP");
            this.Column(p => p.CardIopulMonary).ColumnName("CardIopulMonary");
            this.Column(p => p.Thyroid).ColumnName("Thyroid");
            this.Column(p => p.LiveRandKidney).ColumnName("LiveRandKidney");
            this.Column(p => p.Breasts).ColumnName("Breasts");
            this.Column(p => p.Hair).ColumnName("Hair");
            this.Column(p => p.Vulva).ColumnName("Vulva");
            this.Column(p => p.Cervical).ColumnName("Cervical");
            this.Column(p => p.Vagina).ColumnName("Vagina");
            this.Column(p => p.Uterus).ColumnName("Uterus");
            this.Column(p => p.Attachment).ColumnName("Attachment");
            this.Column(p => p.LeucorrHeaAnalysis).ColumnName("LeucorrHeaAnalysis");
            this.Column(p => p.US).ColumnName("US");
            this.Column(p => p.Diagnosis).ColumnName("Diagnosis");
            this.Column(p => p.Treatment).ColumnName("Treatment");
            this.Column(p => p.DoctorId).ColumnName("DoctorId");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.LocationId).ColumnName("HospitalId");
            this.Column(p => p.FamilyHistoryOther).ColumnName("FamilyHistoryOther");
            this.Column(p => p.IntervalTime).ColumnName("IntervalTime");
            this.Column(p => p.TheFlu).ColumnName("TheFlu");
            this.Column(p => p.ChickenPox).ColumnName("ChickenPox");
            this.Column(p => p.HPV).ColumnName("HPV");
            this.Column(p => p.Hypertension).ColumnName("Hypertension");
            this.Column(p => p.Asthma).ColumnName("Asthma");
            this.Column(p => p.Diabetes).ColumnName("Diabetes");
            this.Column(p => p.ThyroidDisease).ColumnName("ThyroidDisease");
            this.Column(p => p.ThromboticDiseases).ColumnName("ThromboticDiseases");
            this.Column(p => p.Cardiopathy).ColumnName("Cardiopathy");
            this.Column(p => p.Rubella).ColumnName("Rubella");
            this.Column(p => p.Menarche).ColumnName("Menarche"); 
            #endregion


             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}



