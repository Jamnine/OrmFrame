

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人基本档案 - 实体类
	/// </summary>
	public partial class OuHealthCheckBaseMapping: ClassMap<OuHealthCheckBase>
	{   
		/// <summary>
		/// 行心云:病人基本档案 - 实体类
		/// </summary>
		public OuHealthCheckBaseMapping()
		{
			this.TableName("OUHEALTHCHECKBASE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperLastDate).ColumnName("OPERLASTDATE");
			  
			this.Column(p =>p.SymptomIds).ColumnName("SYMPTOMIDS");
			  
			this.Column(p =>p.Temperature).ColumnName("TEMPERATURE");
			  
			this.Column(p =>p.PulseRate).ColumnName("PULSERATE");
			  
			this.Column(p =>p.RespiratoryRate).ColumnName("RESPIRATORYRATE");
			  
			this.Column(p =>p.Waist).ColumnName("WAIST");
			  
			this.Column(p =>p.BloodPressureLeft).ColumnName("BLOODPRESSURELEFT");
			  
			this.Column(p =>p.BloodPressureReght).ColumnName("BLOODPRESSUREREGHT");
			  
			this.Column(p =>p.BloodPressureLeft2).ColumnName("BLOODPRESSURELEFT2");
			  
			this.Column(p =>p.BloodPressureReght2).ColumnName("BLOODPRESSUREREGHT2");
			  
			this.Column(p =>p.Weight).ColumnName("WEIGHT");
			  
			this.Column(p =>p.Height).ColumnName("HEIGHT");
			  
			this.Column(p =>p.Bmi).ColumnName("BMI");
			  
			this.Column(p =>p.StatusAssessment).ColumnName("STATUSASSESSMENT");
			  
			this.Column(p =>p.SelfCare).ColumnName("SELFCARE");
			  
			this.Column(p =>p.Cognition).ColumnName("COGNITION");
			  
			this.Column(p =>p.CognitionScore).ColumnName("COGNITIONSCORE");
			  
			this.Column(p =>p.Emotion).ColumnName("EMOTION");
			  
			this.Column(p =>p.EmotionScore).ColumnName("EMOTIONSCORE");
			  
			this.Column(p =>p.SportsRate).ColumnName("SPORTSRATE");
			  
			this.Column(p =>p.SportsTime).ColumnName("SPORTSTIME");
			  
			this.Column(p =>p.SportsCountYers).ColumnName("SPORTSCOUNTYERS");
			  
			this.Column(p =>p.SportsType).ColumnName("SPORTSTYPE");
			  
			this.Column(p =>p.DietType).ColumnName("DIETTYPE");
			  
			this.Column(p =>p.SmokeStatus).ColumnName("SMOKESTATUS");
			  
			this.Column(p =>p.SmokeCount).ColumnName("SMOKECOUNT");
			  
			this.Column(p =>p.SmokeAge).ColumnName("SMOKEAGE");
			  
			this.Column(p =>p.NoSmokeAge).ColumnName("NOSMOKEAGE");
			  
			this.Column(p =>p.AlcoholRate).ColumnName("ALCOHOLRATE");
			  
			this.Column(p =>p.AlcoholCount).ColumnName("ALCOHOLCOUNT");
			  
			this.Column(p =>p.IsNoAlcohol).ColumnName("ISNOALCOHOL");
			  
			this.Column(p =>p.NoAlcoholAge).ColumnName("NOALCOHOLAGE");
			  
			this.Column(p =>p.StartNoAlcoholAge).ColumnName("STARTNOALCOHOLAGE");
			  
			this.Column(p =>p.IsLatelyDrunk).ColumnName("ISLATELYDRUNK");
			  
			this.Column(p =>p.AlcoholType).ColumnName("ALCOHOLTYPE");
			  
			this.Column(p =>p.IsOccupationalHarm).ColumnName("ISOCCUPATIONALHARM");
			  
			this.Column(p =>p.WorkDate).ColumnName("WORKDATE");
			  
			this.Column(p =>p.DustAnswer).ColumnName("DUSTANSWER");
			  
			this.Column(p =>p.RadiationAnswer).ColumnName("RADIATIONANSWER");
			  
			this.Column(p =>p.PhysicsAnswer).ColumnName("PHYSICSANSWER");
			  
			this.Column(p =>p.TasteMatterAnswer).ColumnName("TASTEMATTERANSWER");
			  
			this.Column(p =>p.OtherAnswer).ColumnName("OTHERANSWER");
			  
			this.Column(p =>p.SymptomNames).ColumnName("SYMPTOMNAMES");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

