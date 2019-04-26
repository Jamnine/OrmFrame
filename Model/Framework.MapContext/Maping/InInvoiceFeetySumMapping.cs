

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院发票对应基础分类 - 实体类
	/// </summary>
	public partial class InInvoiceFeetySumMapping: ClassMap<InInvoiceFeetySum>
	{   
		/// <summary>
		/// 住院发票对应基础分类 - 实体类
		/// </summary>
		public InInvoiceFeetySumMapping()
		{
			this.TableName("ININVOICEFEETYSUM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.AmountSelf).ColumnName("AMOUNTSELF");
			  
			this.Column(p =>p.AmountTally).ColumnName("AMOUNTTALLY");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.MzAmount).ColumnName("MZAMOUNT");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.AddFee).ColumnName("ADDFEE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

