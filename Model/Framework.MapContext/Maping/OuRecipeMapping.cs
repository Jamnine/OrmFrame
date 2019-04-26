

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊处方 - 实体类
	/// </summary>
	public partial class OuRecipeMapping: ClassMap<OuRecipe>
	{   
		/// <summary>
		/// 门诊处方 - 实体类
		/// </summary>
		public OuRecipeMapping()
		{
			this.TableName("OURECIPE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			  
			this.Column(p =>p.RecipeNum).ColumnName("RECIPENUM");
			  
			this.Column(p =>p.RecipeTime).ColumnName("RECIPETIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.HowMany).ColumnName("HOWMANY");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsPend).ColumnName("ISPEND");
			  
			this.Column(p =>p.IsExecuted).ColumnName("ISEXECUTED");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.IsDosage).ColumnName("ISDOSAGE");
			  
			this.Column(p =>p.DosageOperId).ColumnName("DOSAGEOPERID");
			  
			this.Column(p =>p.DosageTime).ColumnName("DOSAGETIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.LsCookSelf).ColumnName("LSCOOKSELF");
			  
			this.Column(p =>p.IsPrinted).ColumnName("ISPRINTED");
			  
			this.Column(p =>p.IsPutDrug).ColumnName("ISPUTDRUG");
			  
			this.Column(p =>p.TempStr).ColumnName("TEMPSTR");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.OuChargeDate).ColumnName("OUCHARGEDATE");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");

            this.Column(p => p.DeptAddress).ColumnName("DEPTADDRESS");

            this.Column(p => p.DeptName).ColumnName("DEPTNAME");

            this.Column(p => p.DeptNo).ColumnName("DEPTNO");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

