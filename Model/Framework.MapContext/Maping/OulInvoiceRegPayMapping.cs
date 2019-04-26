

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊挂号支付方式表 - 实体类
	/// </summary>
	public partial class OulInvoiceRegPayMapping: ClassMap<OulInvoiceRegPay>
	{   
		/// <summary>
		/// 门诊挂号支付方式表 - 实体类
		/// </summary>
		public OulInvoiceRegPayMapping()
		{
			this.TableName("OULINVOICEREGPAY").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.CancelPayWayId).ColumnName("CANCELPAYWAYID");
			  
			this.Column(p =>p.BankId).ColumnName("BANKID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

