

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊发票费用发票分类 - 实体类
	/// </summary>
	public partial class OuInvoiceInvItemSumMapping: ClassMap<OuInvoiceInvItemSum>
	{   
		/// <summary>
		/// 门诊发票费用发票分类 - 实体类
		/// </summary>
		public OuInvoiceInvItemSumMapping()
		{
			this.TableName("OUINVOICEINVITEMSUM").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.AmountSelf).ColumnName("AMOUNTSELF");
			  
			this.Column(p =>p.AmountTally).ColumnName("AMOUNTTALLY");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

