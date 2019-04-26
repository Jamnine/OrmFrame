

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库其他入库明细表 - 实体类
	/// </summary>
	public partial class HuOtherInDtlMapping: ClassMap<HuOtherInDtl>
	{   
		/// <summary>
		/// 仓库药库其他入库明细表 - 实体类
		/// </summary>
		public HuOtherInDtlMapping()
		{
			this.TableName("HUOTHERINDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.InBatchNo).ColumnName("INBATCHNO");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.PNo).ColumnName("PNO");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.StoreDate).ColumnName("STOREDATE");
			  
			this.Column(p =>p.ProduceDate).ColumnName("PRODUCEDATE");
			  
			this.Column(p =>p.LimitDate).ColumnName("LIMITDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

