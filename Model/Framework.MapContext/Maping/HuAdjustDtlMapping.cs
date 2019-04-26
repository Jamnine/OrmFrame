

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药库调价明细表 - 实体类
	/// </summary>
	public partial class HuAdjustDtlMapping: ClassMap<HuAdjustDtl>
	{   
		/// <summary>
		/// 药库调价明细表 - 实体类
		/// </summary>
		public HuAdjustDtlMapping()
		{
			this.TableName("HUADJUSTDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InBatchId).ColumnName("INBATCHID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.NewPrice).ColumnName("NEWPRICE");
			  
			this.Column(p =>p.OldPrice).ColumnName("OLDPRICE");
			  
			this.Column(p =>p.ProfLoss).ColumnName("PROFLOSS");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

