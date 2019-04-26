

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药房退药申请明细 - 实体类
	/// </summary>
	public partial class RmApplbackDtlMapping: ClassMap<RmApplbackDtl>
	{   
		/// <summary>
		/// 药房退药申请明细 - 实体类
		/// </summary>
		public RmApplbackDtlMapping()
		{
			this.TableName("RMAPPLBACKDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.InBatchId).ColumnName("INBATCHID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.BeforeStockNum).ColumnName("BEFORESTOCKNUM");
			  
			this.Column(p =>p.AfterStockNum).ColumnName("AFTERSTOCKNUM");
			  
			this.Column(p =>p.CkDtlID).ColumnName("CKDTLID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

