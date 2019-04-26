

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 发血申请单 - 实体类
	/// </summary>
	public partial class CkBldApplyMapping: ClassMap<CkBldApply>
	{   
		/// <summary>
		/// 发血申请单 - 实体类
		/// </summary>
		public CkBldApplyMapping()
		{
			this.TableName("CKBLDAPPLY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecNo).ColumnName("RECNO");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.PatBloodGroup).ColumnName("PATBLOODGROUP");
			  
			this.Column(p =>p.PatRHD).ColumnName("PATRHD");
			  
			this.Column(p =>p.Illness).ColumnName("ILLNESS");
			  
			this.Column(p =>p.Purpose).ColumnName("PURPOSE");
			  
			this.Column(p =>p.HstyBlood).ColumnName("HSTYBLOOD");
			  
			this.Column(p =>p.HstyReact).ColumnName("HSTYREACT");
			  
			this.Column(p =>p.HstyTest).ColumnName("HSTYTEST");
			  
			this.Column(p =>p.HstyPregnancy).ColumnName("HSTYPREGNANCY");
			  
			this.Column(p =>p.HstyBirth).ColumnName("HSTYBIRTH");
			  
			this.Column(p =>p.TestResult).ColumnName("TESTRESULT");
			  
			this.Column(p =>p.BloodTypeId).ColumnName("BLOODTYPEID");
			  
			this.Column(p =>p.Vollume).ColumnName("VOLLUME");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.PreOps).ColumnName("PREOPS");
			  
			this.Column(p =>p.SpecHandle).ColumnName("SPECHANDLE");
			  
			this.Column(p =>p.BloodGroup).ColumnName("BLOODGROUP");
			  
			this.Column(p =>p.Replace).ColumnName("REPLACE");
			  
			this.Column(p =>p.LabNum).ColumnName("LABNUM");
			  
			this.Column(p =>p.IsAgree).ColumnName("ISAGREE");
			  
			this.Column(p =>p.BloodBreeds).ColumnName("BLOODBREEDS");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.PatPhdBlood).ColumnName("PATPHDBLOOD");
			  
			this.Column(p =>p.PhdBlood).ColumnName("PHDBLOOD");
			  
			this.Column(p =>p.IsMed).ColumnName("ISMED");
			  
			this.Column(p =>p.BloodBreedsSec).ColumnName("BLOODBREEDSSEC");
			  
			this.Column(p =>p.IsSelection).ColumnName("ISSELECTION");
			  
			this.Column(p =>p.VollumeUse).ColumnName("VOLLUMEUSE");
			  
			this.Column(p =>p.VollumeUseTwo).ColumnName("VOLLUMEUSETWO");
			  
			this.Column(p =>p.UnitTwo).ColumnName("UNITTWO");
			  
			this.Column(p =>p.VollumeTwo).ColumnName("VOLLUMETWO");
			  
			this.Column(p =>p.Plt).ColumnName("PLT");
			  
			this.Column(p =>p.HBsAg).ColumnName("HBSAG");
			  
			this.Column(p =>p.AntiHCV).ColumnName("ANTIHCV");
			  
			this.Column(p =>p.AntiAIV).ColumnName("ANTIAIV");
			  
			this.Column(p =>p.Syphilis).ColumnName("SYPHILIS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

