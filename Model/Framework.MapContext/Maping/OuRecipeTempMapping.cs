

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊处方发药申请表 - 实体类
	/// </summary>
	public partial class OuRecipeTempMapping: ClassMap<OuRecipeTemp>
	{   
		/// <summary>
		/// 门诊处方发药申请表 - 实体类
		/// </summary>
		public OuRecipeTempMapping()
		{
			this.TableName("OURECIPETEMP").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.MzRegNo).ColumnName("MZREGNO");
			  
			this.Column(p =>p.RegTime).ColumnName("REGTIME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.Age).ColumnName("AGE");
			  
			this.Column(p =>p.BabyMonth).ColumnName("BABYMONTH");
			  
			this.Column(p =>p.AddressHome).ColumnName("ADDRESSHOME");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
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
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.ContactPhone).ColumnName("CONTACTPHONE");
			  
			this.Column(p =>p.PyCode1).ColumnName("PYCODE1");
			  
			this.Column(p =>p.WbCode1).ColumnName("WBCODE1");
			  
			this.Column(p =>p.PyCode2).ColumnName("PYCODE2");
			  
			this.Column(p =>p.WbCode2).ColumnName("WBCODE2");
			  
			this.Column(p =>p.PyCode3).ColumnName("PYCODE3");
			  
			this.Column(p =>p.WbCode3).ColumnName("WBCODE3");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.LocationName).ColumnName("LOCATIONNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.IsIssue).ColumnName("ISISSUE");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.RoomWindowName).ColumnName("ROOMWINDOWNAME");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LsReportType).ColumnName("LSREPORTTYPE");
			  
			this.Column(p =>p.DosageOperId).ColumnName("DOSAGEOPERID");
			  
			this.Column(p =>p.DosageTime).ColumnName("DOSAGETIME");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.InvoNo).ColumnName("INVONO");
			  
			this.Column(p =>p.IsOuAddInvo).ColumnName("ISOUADDINVO");
			  
			this.Column(p =>p.IsPrinted).ColumnName("ISPRINTED");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.IsDosage).ColumnName("ISDOSAGE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.ListNo).ColumnName("LISTNO");
			  
			this.Column(p =>p.IsMachineComfirm).ColumnName("ISMACHINECOMFIRM");
			  
			this.Column(p =>p.PatTypeName).ColumnName("PATTYPENAME");
			  
			this.Column(p =>p.IsDosaged).ColumnName("ISDOSAGED");
			  
			this.Column(p =>p.OuChargeDate).ColumnName("OUCHARGEDATE");

            this.Column(p => p.IssueOperId).ColumnName("ISSUEOPERID");

            this.Column(p => p.IssueTime).ColumnName("ISSUETIME");

            this.Column(p => p.FayaoID).ColumnName("FAYAOID");
            

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

