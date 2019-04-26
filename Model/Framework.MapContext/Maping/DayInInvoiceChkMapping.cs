

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayInInvoiceChkMapping: ClassMap<DayInInvoiceChk>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayInInvoiceChkMapping()
		{
			this.TableName("DAYININVOICECHK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.Beprice).ColumnName("BEPRICE");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.AddFee).ColumnName("ADDFEE");
			  
			this.Column(p =>p.Deposit).ColumnName("DEPOSIT");
			  
			this.Column(p =>p.Complement).ColumnName("COMPLEMENT");
			  
			this.Column(p =>p.InvoS).ColumnName("INVOS");
			  
			this.Column(p =>p.Rc).ColumnName("RC");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

