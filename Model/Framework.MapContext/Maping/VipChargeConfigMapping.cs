

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipChargeConfigMapping: ClassMap<VipChargeConfig>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public VipChargeConfigMapping()
		{
			this.TableName("VIPCHARGECONFIG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Viplevelid).ColumnName("VIPLEVELID");
			  
			this.Column(p =>p.Balance).ColumnName("BALANCE");
			  
			this.Column(p =>p.Givingintegral1).ColumnName("GIVINGINTEGRAL1");
			  
			this.Column(p =>p.Givingintegral2).ColumnName("GIVINGINTEGRAL2");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

