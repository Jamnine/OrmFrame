

using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
	/// <summary>
	/// 药库调价 - 实体类
	/// </summary>
	public partial class HuAdjustMapping: ClassMap<Model.HuAdjust>
	{   
		/// <summary>
		/// 药库调价 - 实体类
		/// </summary>
		public HuAdjustMapping()
		{
			this.TableName("HUADJUST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.NotifyDate).ColumnName("NOTIFYDATE");
			  
			this.Column(p =>p.DispUnit).ColumnName("DISPUNIT");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

