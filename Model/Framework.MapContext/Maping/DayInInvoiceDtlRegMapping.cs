

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayInInvoiceDtlRegMapping: ClassMap<DayInInvoiceDtlReg>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayInInvoiceDtlRegMapping()
		{
			this.TableName("DAYININVOICEDTLREG").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsPay).ColumnName("ISPAY");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.ExecOperId).ColumnName("EXECOPERID");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.ExecDoctorId).ColumnName("EXECDOCTORID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

