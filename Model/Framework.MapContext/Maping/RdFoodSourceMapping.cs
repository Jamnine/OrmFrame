

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 食源性疾病病例监测信息表 - 实体类
	/// </summary>
	public partial class RdFoodSourceMapping: ClassMap<RdFoodSource>
	{   
		/// <summary>
		/// 食源性疾病病例监测信息表 - 实体类
		/// </summary>
		public RdFoodSourceMapping()
		{
			this.TableName("RDFOODSOURCE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.ChkOperId).ColumnName("CHKOPERID");
			  
			this.Column(p =>p.ChkOperTime).ColumnName("CHKOPERTIME");
			  
			this.Column(p =>p.IsWrite).ColumnName("ISWRITE");
			  
			this.Column(p =>p.PrintStart).ColumnName("PRINTSTART");
			  
			this.Column(p =>p.Mobile).ColumnName("MOBILE");
			  
			this.Column(p =>p.IllDate).ColumnName("ILLDATE");
			  
			this.Column(p =>p.DiagDate).ColumnName("DIAGDATE");
			  
			this.Column(p =>p.DeadDate).ColumnName("DEADDATE");
			  
			this.Column(p =>p.WorkType).ColumnName("WORKTYPE");
			  
			this.Column(p =>p.LsZone).ColumnName("LSZONE");
			  
			this.Column(p =>p.Heart).ColumnName("HEART");
			  
			this.Column(p =>p.DigeStive).ColumnName("DIGESTIVE");
			  
			this.Column(p =>p.Breath).ColumnName("BREATH");
			  
			this.Column(p =>p.Blood).ColumnName("BLOOD");
			  
			this.Column(p =>p.Urinary).ColumnName("URINARY");
			  
			this.Column(p =>p.Nervous).ColumnName("NERVOUS");
			  
			this.Column(p =>p.Skin).ColumnName("SKIN");
			  
			this.Column(p =>p.Heartfr).ColumnName("HEARTFR");
			  
			this.Column(p =>p.HeartQt).ColumnName("HEARTQT");
			  
			this.Column(p =>p.DigeStiveFx).ColumnName("DIGESTIVEFX");
			  
			this.Column(p =>p.DigeStiveQt).ColumnName("DIGESTIVEQT");
			  
			this.Column(p =>p.DigeStivePxwqt).ColumnName("DIGESTIVEPXWQT");
			  
			this.Column(p =>p.BreathQt).ColumnName("BREATHQT");
			  
			this.Column(p =>p.BloodQt).ColumnName("BLOODQT");
			  
			this.Column(p =>p.UrinaryQt).ColumnName("URINARYQT");
			  
			this.Column(p =>p.NervousQt).ColumnName("NERVOUSQT");
			  
			this.Column(p =>p.SkinQt).ColumnName("SKINQT");
			  
			this.Column(p =>p.FirstDiag).ColumnName("FIRSTDIAG");
			  
			this.Column(p =>p.FirstDiagOther).ColumnName("FIRSTDIAGOTHER");
			  
			this.Column(p =>p.UseMedIndex).ColumnName("USEMEDINDEX");
			  
			this.Column(p =>p.KssName).ColumnName("KSSNAME");
			  
			this.Column(p =>p.OnceDiag).ColumnName("ONCEDIAG");
			  
			this.Column(p =>p.OnceDiagOther).ColumnName("ONCEDIAGOTHER");
			  
			this.Column(p =>p.EatCollectIndex).ColumnName("EATCOLLECTINDEX");
			  
			this.Column(p =>p.FoodName).ColumnName("FOODNAME");
			  
			this.Column(p =>p.FoodTYPE).ColumnName("FOODTYPE");
			  
			this.Column(p =>p.FoodMachingType).ColumnName("FOODMACHINGTYPE");
			  
			this.Column(p =>p.FoodBrand).ColumnName("FOODBRAND");
			  
			this.Column(p =>p.FoodCompany).ColumnName("FOODCOMPANY");
			  
			this.Column(p =>p.EatPlace).ColumnName("EATPLACE");
			  
			this.Column(p =>p.FoodEatPlaceType).ColumnName("FOODEATPLACETYPE");
			  
			this.Column(p =>p.ShopPlace).ColumnName("SHOPPLACE");
			  
			this.Column(p =>p.ShopPlaceType).ColumnName("SHOPPLACETYPE");
			  
			this.Column(p =>p.EatTime).ColumnName("EATTIME");
			  
			this.Column(p =>p.EatNumberOfPeople).ColumnName("EATNUMBEROFPEOPLE");
			  
			this.Column(p =>p.IsIllOthers).ColumnName("ISILLOTHERS");
			  
			this.Column(p =>p.SampleCode).ColumnName("SAMPLECODE");
			  
			this.Column(p =>p.SampleType).ColumnName("SAMPLETYPE");
			  
			this.Column(p =>p.SampleNumUnit).ColumnName("SAMPLENUMUNIT");
			  
			this.Column(p =>p.SampleTime).ColumnName("SAMPLETIME");
			  
			this.Column(p =>p.SampleMemo).ColumnName("SAMPLEMEMO");
			  
			this.Column(p =>p.HospitalName).ColumnName("HOSPITALNAME");
			  
			this.Column(p =>p.Preparer).ColumnName("PREPARER");
			  
			this.Column(p =>p.WriteTime).ColumnName("WRITETIME");
			  
			this.Column(p =>p.JName).ColumnName("JNAME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.CancelMemo).ColumnName("CANCELMEMO");
			  
			this.Column(p =>p.IllNameId).ColumnName("ILLNAMEID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

