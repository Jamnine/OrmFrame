

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库药品库存表 - 实体类
	/// </summary>
	public partial class HuStoresMapping: ClassMap<HuStores>
	{   
		/// <summary>
		/// 仓库药库药品库存表 - 实体类
		/// </summary>
		public HuStoresMapping()
		{
			this.TableName("HUSTORES").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InBatchNo).ColumnName("INBATCHNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.PNo).ColumnName("PNO");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.StockNum).ColumnName("STOCKNUM");
			  
			this.Column(p =>p.InstoreNum).ColumnName("INSTORENUM");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.StoreDate).ColumnName("STOREDATE");
			  
			this.Column(p =>p.ProduceDate).ColumnName("PRODUCEDATE");
			  
			this.Column(p =>p.LimitDate).ColumnName("LIMITDATE");
			  
			this.Column(p =>p.IsBalance).ColumnName("ISBALANCE");
			  
			this.Column(p =>p.IsNewin).ColumnName("ISNEWIN");
			  
			this.Column(p =>p.IsBid).ColumnName("ISBID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.BarCode).ColumnName("BARCODE");
			  
			this.Column(p =>p.ProareaId).ColumnName("PROAREAID");
			  
			this.Column(p =>p.ManuId).ColumnName("MANUID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

