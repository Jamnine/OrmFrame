

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 系统参数 - 实体类
	/// </summary>
	public partial class GblSettingMapping: ClassMap<GblSetting>
	{   
		/// <summary>
		/// 系统参数 - 实体类
		/// </summary>
		public GblSettingMapping()
		{
			this.TableName("GBLSETTING").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.KeyNum).ColumnName("KEYNUM");
			  
			this.Column(p =>p.SetValue).ColumnName("SETVALUE");
			  
			this.Column(p =>p.Explain).ColumnName("EXPLAIN");
			  
			this.Column(p =>p.Piority).ColumnName("PIORITY");
			  
			this.Column(p =>p.Basetable).ColumnName("BASETABLE");
			  
			this.Column(p =>p.IsMutiselect).ColumnName("ISMUTISELECT");
			  
			this.Column(p =>p.SystemId).ColumnName("SYSTEMID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.Describtion).ColumnName("DESCRIBTION");
			  
			this.Column(p =>p.HospitalId).ColumnName("HOSPITALID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

