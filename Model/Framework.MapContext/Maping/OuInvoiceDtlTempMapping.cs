

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊收费发票明细临时表 - 实体类
	/// </summary>
	public partial class OuInvoiceDtlTempMapping: ClassMap<OuInvoiceDtlTemp>
	{   
		/// <summary>
		/// 门诊收费发票明细临时表 - 实体类
		/// </summary>
		public OuInvoiceDtlTempMapping()
		{
			this.TableName("OUINVOICEDTLTEMP").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.AmountInsurance).ColumnName("AMOUNTINSURANCE");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.AmountSelf).ColumnName("AMOUNTSELF");
			  
			this.Column(p =>p.AmountTally).ColumnName("AMOUNTTALLY");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.DiscDiag).ColumnName("DISCDIAG");
			  
			this.Column(p =>p.DiscSelf).ColumnName("DISCSELF");
			  
			this.Column(p =>p.DocLevId).ColumnName("DOCLEVID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.FeeHsId).ColumnName("FEEHSID");
			  
			this.Column(p =>p.FeeHsMzName).ColumnName("FEEHSMZNAME");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.FeeName).ColumnName("FEENAME");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.InvMzItemName).ColumnName("INVMZITEMNAME");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.InvoTime).ColumnName("INVOTIME");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.IsDoctorInput).ColumnName("ISDOCTORINPUT");
			  
			this.Column(p =>p.IsIssue).ColumnName("ISISSUE");
			  
			this.Column(p =>p.IsModiDisc).ColumnName("ISMODIDISC");
			  
			this.Column(p =>p.IsOtherFee).ColumnName("ISOTHERFEE");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.IsToBack).ColumnName("ISTOBACK");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.LimitFee).ColumnName("LIMITFEE");
			  
			this.Column(p =>p.LimitGroupId).ColumnName("LIMITGROUPID");
			  
			this.Column(p =>p.LimitTotalMz).ColumnName("LIMITTOTALMZ");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.LocationName).ColumnName("LOCATIONNAME");
			  
			this.Column(p =>p.LsAdviceType).ColumnName("LSADVICETYPE");
			  
			this.Column(p =>p.LsGfType).ColumnName("LSGFTYPE");
			  
			this.Column(p =>p.LsGroupType).ColumnName("LSGROUPTYPE");
			  
			this.Column(p =>p.LsPerform).ColumnName("LSPERFORM");
			  
			this.Column(p =>p.LsReportType).ColumnName("LSREPORTTYPE");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			  
			this.Column(p =>p.LsRpType).ColumnName("LSRPTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PrepareTime).ColumnName("PREPARETIME");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.RecipeGroupId).ColumnName("RECIPEGROUPID");
			  
			this.Column(p =>p.RecipeGroupIds).ColumnName("RECIPEGROUPIDS");
			  
			this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.RecipeItemId).ColumnName("RECIPEITEMID");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.TypeGFXEId).ColumnName("TYPEGFXEID");
			  
			this.Column(p =>p.UnitDiagName).ColumnName("UNITDIAGNAME");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.XDRpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.Mzregid).ColumnName("MZREGID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Usagememo).ColumnName("USAGEMEMO");
			  
			this.Column(p =>p.Usageid).ColumnName("USAGEID");
			  
			this.Column(p =>p.Formid).ColumnName("FORMID");
			  
			this.Column(p =>p.Frequencyid).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.DiscountAoumt).ColumnName("DISCOUNTAOUMT");
			  
			this.Column(p =>p.ChildPrice).ColumnName("CHILDPRICE");
			  
			this.Column(p =>p.DiscountPrice).ColumnName("DISCOUNTPRICE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

