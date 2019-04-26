

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊诊断模板 - 实体类
	/// </summary>
	public partial class TmpOuEmrMapping: ClassMap<TmpOuEmr>
	{   
		/// <summary>
		/// 门诊诊断模板 - 实体类
		/// </summary>
		public TmpOuEmrMapping()
		{
			this.TableName("TMPOUEMR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.GroupMain).ColumnName("GROUPMAIN");
			  
			this.Column(p =>p.GroupSub).ColumnName("GROUPSUB");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
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
			  
			this.Column(p =>p.ExamSugar).ColumnName("EXAMSUGAR");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.UsDrugCase).ColumnName("USDRUGCASE");
			  
			this.Column(p =>p.Menarche).ColumnName("MENARCHE");
			  
			this.Column(p =>p.FamilyHistoryOther).ColumnName("FAMILYHISTORYOTHER");
			  
			this.Column(p =>p.Treatment).ColumnName("TREATMENT");
			  
			this.Column(p =>p.Diagnosis).ColumnName("DIAGNOSIS");
			  
			this.Column(p =>p.AllErgy).ColumnName("ALLERGY");
			  
			this.Column(p =>p.OtherHistory).ColumnName("OTHERHISTORY");
			  
			this.Column(p =>p.Presenthistory).ColumnName("PRESENTHISTORY");
			  
			this.Column(p =>p.Abortion).ColumnName("ABORTION");
			  
			this.Column(p =>p.ToothCasecontID).ColumnName("TOOTHCASECONTID");
			  
			this.Column(p =>p.PhysicalCheck).ColumnName("PHYSICALCHECK");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

