

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库进出库日志 - 实体类
	/// </summary>
	public partial class HuStoreLogMapping: ClassMap<HuStoreLog>
	{   
		/// <summary>
		/// 仓库药库进出库日志 - 实体类
		/// </summary>
		public HuStoreLogMapping()
		{
			this.TableName("HUSTORELOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HappenTime).ColumnName("HAPPENTIME");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.InBatchId).ColumnName("INBATCHID");
			  
			this.Column(p =>p.BeforeStockNum).ColumnName("BEFORESTOCKNUM");
			  
			this.Column(p =>p.HappenNum).ColumnName("HAPPENNUM");
			  
			this.Column(p =>p.AfterStockNum).ColumnName("AFTERSTOCKNUM");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.LsActType).ColumnName("LSACTTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.BeforeStockNumSum).ColumnName("BEFORESTOCKNUMSUM");
			  
			this.Column(p =>p.AfterStockNumSum).ColumnName("AFTERSTOCKNUMSUM");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.BarCode).ColumnName("BARCODE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");

            

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

