

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayOuInvoicePayChkMapping: ClassMap<DayOuInvoicePayChk>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayOuInvoicePayChkMapping()
		{
			this.TableName("DAYOUINVOICEPAYCHK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.PaywayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.BankId).ColumnName("BANKID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

