

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库回填发票明细表 - 实体类
	/// </summary>
	public partial class HuVoucherDtlMapping: ClassMap<HuVoucherDtl>
	{   
		/// <summary>
		/// 仓库药库回填发票明细表 - 实体类
		/// </summary>
		public HuVoucherDtlMapping()
		{
			this.TableName("HUVOUCHERDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VoucherId).ColumnName("VOUCHERID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.HasPay).ColumnName("HASPAY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

