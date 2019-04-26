

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史门诊费用明细 - 实体类
	/// </summary>
	public partial class HistOuInvoiceDtlMapping: ClassMap<HistOuInvoiceDtl>
	{   
		/// <summary>
		/// 历史门诊费用明细 - 实体类
		/// </summary>
		public HistOuInvoiceDtlMapping()
		{
			this.TableName("HISTOUINVOICEDTL").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.DiscDiag).ColumnName("DISCDIAG");
			  
			this.Column(p =>p.IsModiDisc).ColumnName("ISMODIDISC");
			  
			this.Column(p =>p.DiscSelf).ColumnName("DISCSELF");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.AmountSelf).ColumnName("AMOUNTSELF");
			  
			this.Column(p =>p.AmountTally).ColumnName("AMOUNTTALLY");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.LsPerform).ColumnName("LSPERFORM");
			  
			this.Column(p =>p.LimitGroupId).ColumnName("LIMITGROUPID");
			  
			this.Column(p =>p.LimitFee).ColumnName("LIMITFEE");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.FeeHsId).ColumnName("FEEHSID");
			  
			this.Column(p =>p.XDRpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.LsReportType).ColumnName("LSREPORTTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.RecipeItemId).ColumnName("RECIPEITEMID");
			  
			this.Column(p =>p.RecipeGroupId).ColumnName("RECIPEGROUPID");
			  
			this.Column(p =>p.DocLocID).ColumnName("DOCLOCID");
			  
			this.Column(p =>p.Usagememo).ColumnName("USAGEMEMO");
			  
			this.Column(p =>p.Usageid).ColumnName("USAGEID");
			  
			this.Column(p =>p.Formid).ColumnName("FORMID");
			  
			this.Column(p =>p.Frequencyid).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

