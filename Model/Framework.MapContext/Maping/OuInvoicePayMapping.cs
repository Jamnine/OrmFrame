

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊收费方式 - 实体类
	/// </summary>
	public partial class OuInvoicePayMapping: ClassMap<OuInvoicePay>
	{   
		/// <summary>
		/// 门诊收费方式 - 实体类
		/// </summary>
		public OuInvoicePayMapping()
		{
			this.TableName("OUINVOICEPAY").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.PaywayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.CancelPaywayId).ColumnName("CANCELPAYWAYID");
			  
			this.Column(p =>p.BankId).ColumnName("BANKID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.SheetNO).ColumnName("SHEETNO");
			  
			this.Column(p =>p.OrderNO).ColumnName("ORDERNO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

