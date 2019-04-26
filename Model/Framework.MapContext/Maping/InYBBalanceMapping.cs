

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院发票医保结算表 - 实体类
	/// </summary>
	public partial class InYBBalanceMapping: ClassMap<InYBBalance>
	{   
		/// <summary>
		/// 住院发票医保结算表 - 实体类
		/// </summary>
		public InYBBalanceMapping()
		{
			this.TableName("INYBBALANCE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvoNo).ColumnName("INVONO");
			  
			this.Column(p =>p.LsPayType).ColumnName("LSPAYTYPE");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.FromDate).ColumnName("FROMDATE");
			  
			this.Column(p =>p.ToDate).ColumnName("TODATE");
			  
			this.Column(p =>p.ChargeDays).ColumnName("CHARGEDAYS");
			  
			this.Column(p =>p.Beprice).ColumnName("BEPRICE");
			  
			this.Column(p =>p.TallyNo).ColumnName("TALLYNO");
			  
			this.Column(p =>p.FactGet).ColumnName("FACTGET");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.PaySelf).ColumnName("PAYSELF");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.Deposit).ColumnName("DEPOSIT");
			  
			this.Column(p =>p.Complement).ColumnName("COMPLEMENT");
			  
			this.Column(p =>p.Arrearage).ColumnName("ARREARAGE");
			  
			this.Column(p =>p.AddFee).ColumnName("ADDFEE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelMemo).ColumnName("CANCELMEMO");
			  
			this.Column(p =>p.InvoLastId).ColumnName("INVOLASTID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.SumFee).ColumnName("SUMFEE");
			  
			this.Column(p =>p.AmountInsurance).ColumnName("AMOUNTINSURANCE");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.InTime).ColumnName("INTIME");
			  
			this.Column(p =>p.OutTime).ColumnName("OUTTIME");
			  
			this.Column(p =>p.ReportContent).ColumnName("REPORTCONTENT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

