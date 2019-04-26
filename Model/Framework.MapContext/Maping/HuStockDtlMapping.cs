

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库入库单明细 - 实体类
	/// </summary>
	public partial class HuStockDtlMapping: ClassMap<HuStockDtl>
	{   
		/// <summary>
		/// 仓库药库入库单明细 - 实体类
		/// </summary>
		public HuStockDtlMapping()
		{
			this.TableName("HUSTOCKDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.InBatchNo).ColumnName("INBATCHNO");
			  
			this.Column(p =>p.PNo).ColumnName("PNO");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.ProduceDate).ColumnName("PRODUCEDATE");
			  
			this.Column(p =>p.LimitDate).ColumnName("LIMITDATE");
			  
			this.Column(p =>p.IsBid).ColumnName("ISBID");
			  
			this.Column(p =>p.VoucherNo).ColumnName("VOUCHERNO");
			  
			this.Column(p =>p.ProAreaId).ColumnName("PROAREAID");
			  
			this.Column(p =>p.ManuId).ColumnName("MANUID");
			  
			this.Column(p =>p.PassNo).ColumnName("PASSNO");
			  
			this.Column(p =>p.PriceHighLine).ColumnName("PRICEHIGHLINE");
			  
			this.Column(p =>p.QcMemo).ColumnName("QCMEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.BarCode).ColumnName("BARCODE");
            


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

