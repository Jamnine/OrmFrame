

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊病人病历 - 实体类
	/// </summary>
	public partial class OuClinicFirstMapping: ClassMap<OuClinicFirst>
	{   
		/// <summary>
		/// 门诊病人病历 - 实体类
		/// </summary>
		public OuClinicFirstMapping()
		{
			this.TableName("OUCLINICFIRST").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.MainInform).ColumnName("MAININFORM");
			  
			this.Column(p =>p.SickHist).ColumnName("SICKHIST");
			  
			this.Column(p =>p.ExamT).ColumnName("EXAMT");
			  
			this.Column(p =>p.ExamP).ColumnName("EXAMP");
			  
			this.Column(p =>p.ExamR).ColumnName("EXAMR");
			  
			this.Column(p =>p.ExamBp).ColumnName("EXAMBP");
			  
			this.Column(p =>p.ExamBp2).ColumnName("EXAMBP2");
			  
			this.Column(p =>p.CheckUp).ColumnName("CHECKUP");
			  
			this.Column(p =>p.CheckCT).ColumnName("CHECKCT");
			  
			this.Column(p =>p.Disposal).ColumnName("DISPOSAL");
			  
			this.Column(p =>p.Impression).ColumnName("IMPRESSION");
			  
			this.Column(p =>p.Analys).ColumnName("ANALYS");
			  
			this.Column(p =>p.Others).ColumnName("OTHERS");
			  
			this.Column(p =>p.Tongue).ColumnName("TONGUE");
			  
			this.Column(p =>p.Pulse).ColumnName("PULSE");
			  
			this.Column(p =>p.Moss).ColumnName("MOSS");
			  
			this.Column(p =>p.XMLCancer).ColumnName("XMLCANCER");
			  
			this.Column(p =>p.XMLSex).ColumnName("XMLSEX");
			  
			this.Column(p =>p.XMLTuberculosis).ColumnName("XMLTUBERCULOSIS");
			  
			this.Column(p =>p.XMLContagion).ColumnName("XMLCONTAGION");
			  
			this.Column(p =>p.ExamSugar).ColumnName("EXAMSUGAR");
			  
			this.Column(p =>p.FirstDate).ColumnName("FIRSTDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.ThromboticDiseases).ColumnName("THROMBOTICDISEASES");
			  
			this.Column(p =>p.ThroughDay).ColumnName("THROUGHDAY");
			  
			this.Column(p =>p.Diagnosis).ColumnName("DIAGNOSIS");
			  
			this.Column(p =>p.AllErgy).ColumnName("ALLERGY");
			  
			this.Column(p =>p.ContraceptionWay).ColumnName("CONTRACEPTIONWAY");
			  
			this.Column(p =>p.Wine).ColumnName("WINE");
			  
			this.Column(p =>p.IntervalTime).ColumnName("INTERVALTIME");
			  
			this.Column(p =>p.Vagina).ColumnName("VAGINA");
			  
			this.Column(p =>p.Attachment).ColumnName("ATTACHMENT");
			  
			this.Column(p =>p.NaturalBirth).ColumnName("NATURALBIRTH");
			  
			this.Column(p =>p.Rubella).ColumnName("RUBELLA");
			  
			this.Column(p =>p.Hypertension).ColumnName("HYPERTENSION");
			  
			this.Column(p =>p.UsDrugCase).ColumnName("USDRUGCASE");
			  
			this.Column(p =>p.PhysicalCheck).ColumnName("PHYSICALCHECK");
			  
			this.Column(p =>p.SpecialistID).ColumnName("SPECIALISTID");
			  
			this.Column(p =>p.Abortion).ColumnName("ABORTION");
			  
			this.Column(p =>p.InfectionHistory).ColumnName("INFECTIONHISTORY");
			  
			this.Column(p =>p.ImmunizationHistory).ColumnName("IMMUNIZATIONHISTORY");
			  
			this.Column(p =>p.FamilyHistoryOther).ColumnName("FAMILYHISTORYOTHER");
			  
			this.Column(p =>p.OtherHistory).ColumnName("OTHERHISTORY");
			  
			this.Column(p =>p.MedicalHistory).ColumnName("MEDICALHISTORY");
			  
			this.Column(p =>p.IsChildBirthCp).ColumnName("ISCHILDBIRTHCP");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.MenarcheTime).ColumnName("MENARCHETIME");
			  
			this.Column(p =>p.Menarche).ColumnName("MENARCHE");
			  
			this.Column(p =>p.CurettAge).ColumnName("CURETTAGE");
			  
			this.Column(p =>p.CesareanSection).ColumnName("CESAREANSECTION");
			  
			this.Column(p =>p.DoctorID).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Breasts).ColumnName("BREASTS");
			  
			this.Column(p =>p.Asthma).ColumnName("ASTHMA");
			  
			this.Column(p =>p.Pet).ColumnName("PET");
			  
			this.Column(p =>p.SurgeryHistory).ColumnName("SURGERYHISTORY");
			  
			this.Column(p =>p.Vulva).ColumnName("VULVA");
			  
			this.Column(p =>p.Us).ColumnName("US");
			  
			this.Column(p =>p.MarriageStatus).ColumnName("MARRIAGESTATUS");
			  
			this.Column(p =>p.Uterus).ColumnName("UTERUS");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.Cervical).ColumnName("CERVICAL");
			  
			this.Column(p =>p.EcTopicPregnancy).ColumnName("ECTOPICPREGNANCY");
			  
			this.Column(p =>p.InDuced).ColumnName("INDUCED");
			  
			this.Column(p =>p.CardIopulMonary).ColumnName("CARDIOPULMONARY");
			  
			this.Column(p =>p.Cardiopathy).ColumnName("CARDIOPATHY");
			  
			this.Column(p =>p.SexUalFrequency).ColumnName("SEXUALFREQUENCY");
			  
			this.Column(p =>p.IsSeparation).ColumnName("ISSEPARATION");
			  
			this.Column(p =>p.IsDyspareunia).ColumnName("ISDYSPAREUNIA");
			  
			this.Column(p =>p.IsDysmenorrhea).ColumnName("ISDYSMENORRHEA");
			  
			this.Column(p =>p.IsContraception).ColumnName("ISCONTRACEPTION");
			  
			this.Column(p =>p.Hair).ColumnName("HAIR");
			  
			this.Column(p =>p.ChickenPox).ColumnName("CHICKENPOX");
			  
			this.Column(p =>p.Treatment).ColumnName("TREATMENT");
			  
			this.Column(p =>p.TheFlu).ColumnName("THEFLU");
			  
			this.Column(p =>p.Smoke).ColumnName("SMOKE");
			  
			this.Column(p =>p.BiocheMicalpregnancy).ColumnName("BIOCHEMICALPREGNANCY");
			  
			this.Column(p =>p.Thyroid).ColumnName("THYROID");
			  
			this.Column(p =>p.ThyroidDisease).ColumnName("THYROIDDISEASE");
			  
			this.Column(p =>p.LeucorrHeaAnalysis).ColumnName("LEUCORRHEAANALYSIS");
			  
			this.Column(p =>p.Diabetes).ColumnName("DIABETES");
			  
			this.Column(p =>p.LiveRandKidney).ColumnName("LIVERANDKIDNEY");
			  
			this.Column(p =>p.Waist).ColumnName("WAIST");
			  
			this.Column(p =>p.Abdominal).ColumnName("ABDOMINAL");
			  
			this.Column(p =>p.Miscarriage).ColumnName("MISCARRIAGE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

