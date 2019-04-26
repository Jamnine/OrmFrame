

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OpsChargeMapping: ClassMap<OpsCharge>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OpsChargeMapping()
		{
			this.TableName("OPSCHARGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.IsTally).ColumnName("ISTALLY");
			  
			this.Column(p =>p.Before).ColumnName("BEFORE");
			  
			this.Column(p =>p.Progress).ColumnName("PROGRESS");
			  
			this.Column(p =>p.After).ColumnName("AFTER");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

