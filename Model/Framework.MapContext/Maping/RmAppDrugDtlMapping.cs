

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药房领药申请明细 - 实体类
	/// </summary>
	public partial class RmAppDrugDtlMapping: ClassMap<RmAppDrugDtl>
	{   
		/// <summary>
		/// 药房领药申请明细 - 实体类
		/// </summary>
		public RmAppDrugDtlMapping()
		{
			this.TableName("RMAPPDRUGDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.HuStockNum).ColumnName("HUSTOCKNUM");
			  
			this.Column(p =>p.UnitKc).ColumnName("UNITKC");
			  
			this.Column(p =>p.Pno).ColumnName("PNO");
			  
			this.Column(p =>p.LimitDate).ColumnName("LIMITDATE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

