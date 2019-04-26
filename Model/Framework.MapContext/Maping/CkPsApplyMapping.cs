

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检检查申请表 - 实体类
	/// </summary>
	public partial class CkPsApplyMapping: ClassMap<CkPsApply>
	{   
		/// <summary>
		/// 体检检查申请表 - 实体类
		/// </summary>
		public CkPsApplyMapping()
		{
			this.TableName("CKPSAPPLY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.CheckBody).ColumnName("CHECKBODY");
			  
			this.Column(p =>p.XType).ColumnName("XTYPE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

