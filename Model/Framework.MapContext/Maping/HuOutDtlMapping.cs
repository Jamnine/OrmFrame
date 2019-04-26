﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库出库单明细 - 实体类
	/// </summary>
	public partial class HuOutDtlMapping: ClassMap<HuOutDtl>
	{   
		/// <summary>
		/// 仓库药库出库单明细 - 实体类
		/// </summary>
		public HuOutDtlMapping()
		{
			this.TableName("HUOUTDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.InBatchId).ColumnName("INBATCHID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.OutPrice).ColumnName("OUTPRICE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IsStockNum).ColumnName("ISSTOCKNUM");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

