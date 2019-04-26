

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库盘点明细 - 实体类
	/// </summary>
	public partial class HuCheckDtlMapping: ClassMap<HuCheckDtl>
	{   
		/// <summary>
		/// 仓库药库盘点明细 - 实体类
		/// </summary>
		public HuCheckDtlMapping()
		{
			this.TableName("HUCHECKDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.InBatchId).ColumnName("INBATCHID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.BalanceNum).ColumnName("BALANCENUM");
			  
			this.Column(p =>p.StcokNum).ColumnName("STCOKNUM");
			  
			this.Column(p =>p.InstoreNum).ColumnName("INSTORENUM");
			  
			this.Column(p =>p.CheckNum).ColumnName("CHECKNUM");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.Compare).ColumnName("COMPARE");
			  
			this.Column(p =>p.IsBalance).ColumnName("ISBALANCE");
			  
			this.Column(p =>p.IsAdjust).ColumnName("ISADJUST");
			  
			this.Column(p =>p.BuyIn).ColumnName("BUYIN");
			  
			this.Column(p =>p.BackIn).ColumnName("BACKIN");
			  
			this.Column(p =>p.OtherIn).ColumnName("OTHERIN");
			  
			this.Column(p =>p.DeptOut).ColumnName("DEPTOUT");
			  
			this.Column(p =>p.SaleOut).ColumnName("SALEOUT");
			  
			this.Column(p =>p.BackOut).ColumnName("BACKOUT");
			  
			this.Column(p =>p.LoseOut).ColumnName("LOSEOUT");
			  
			this.Column(p =>p.AdjustAmouUp).ColumnName("ADJUSTAMOUUP");
			  
			this.Column(p =>p.AdjustAmouDn).ColumnName("ADJUSTAMOUDN");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

