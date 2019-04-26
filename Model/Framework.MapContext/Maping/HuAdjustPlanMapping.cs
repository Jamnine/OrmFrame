

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药库调价计划 - 实体类
	/// </summary>
	public partial class HuAdjustPlanMapping: ClassMap<HuAdjustPlan>
	{   
		/// <summary>
		/// 药库调价计划 - 实体类
		/// </summary>
		public HuAdjustPlanMapping()
		{
			this.TableName("HUADJUSTPLAN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.NotifyDate).ColumnName("NOTIFYDATE");
			  
			this.Column(p =>p.DispUnit).ColumnName("DISPUNIT");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsExcute).ColumnName("ISEXCUTE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IsAdjust).ColumnName("ISADJUST");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

