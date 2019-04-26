

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 交款报表专用 - 实体类
	/// </summary>
	public partial class RtrjkReportMapping: ClassMap<RtrjkReport>
	{   
		/// <summary>
		/// 交款报表专用 - 实体类
		/// </summary>
		public RtrjkReportMapping()
		{
			this.TableName("RTRJKREPORT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Operid).ColumnName("OPERID");
			  
			this.Column(p =>p.Opertime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.Iscancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.begintime).ColumnName("BEGINTIME");
			  
			this.Column(p =>p.Endtime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.LsOutIn).ColumnName("LSOUTIN");
			  
			this.Column(p =>p.Bills).ColumnName("BILLS");
			  
			this.Column(p =>p.billcancel).ColumnName("BILLCANCEL");
			  
			this.Column(p =>p.AmountSum).ColumnName("AMOUNTSUM");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountCancel).ColumnName("AMOUNTCANCEL");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.AmountYF).ColumnName("AMOUNTYF");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

